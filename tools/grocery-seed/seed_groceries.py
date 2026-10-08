"""API-only Afghan grocery sample seeder. Python 3.12 standard library; no credentials in source."""
import argparse
import json
import os
from pathlib import Path
from datetime import datetime, timedelta, timezone
from urllib.request import Request, urlopen
from urllib.error import HTTPError
import uuid
import threading
import sys
from concurrent.futures import ThreadPoolExecutor

SHOP_PREFIX = "11111111-0000-0000-0000-"
SHOPS = [
    ("000000000001", "Main Store", "Mandawi bazaar, Kabul", "retailShop"),
    ("000000000002", "Branch Store", "Food wholesale market, Herat", "wholesaleShop"),
    ("000000000003", "Warehouse", "Mazar-e-Sharif, Balkh", "retailShop"),
    ("000000000004", "Wasil Shop", "Kabul, Afghanistan", "retailShop"),
    (None, "Kandahar Neighbourhood Grocery / فروشگاه محلی قندهار", "Kandahar city", "retailShop"),
]
UNITS = [
    ("kg", "Kilogram / کیلوگرام", "kg"), ("piece", "Piece / عدد", "pc"),
    ("sack", "Sack / بوری", "sack"), ("bag", "Bag / خریطه", "bag"),
    ("carton", "Carton / کارتن", "ctn"), ("tray", "Tray / شانه", "tray"),
]
CATEGORIES = [
    ("rice", "Rice / برنج"), ("flour", "Flour / آرد"), ("pulses", "Pulses / حبوبات"),
    ("oil", "Cooking oil / روغن خوراکی"), ("sugar", "Sugar / بوره"),
    ("tea", "Tea / چای"), ("spices", "Spices / ادویه"),
    ("dairy", "Dairy / لبنیات"), ("eggs", "Eggs / تخم مرغ"),
    ("packaged", "Packaged food / مواد غذایی بسته بندی"),
    ("beverages", "Beverages / نوشیدنی"), ("household", "Cleaning supplies / مواد پاک کاری"),
]
# code, name, category, base unit, packaging unit, base units per package, retail AFN/base, cost AFN/base, shelf days
PRODUCTS = [
    ("RICE", "Sela basmati rice / برنج سیله", "rice", "kg", "sack", 25, 130, 110, 365),
    ("FLOUR", "Wheat flour / آرد گندم", "flour", "kg", "sack", 50, 42, 35, 180),
    ("SUGAR", "White sugar / بوره سفید", "sugar", "kg", "sack", 50, 65, 55, 365),
    ("LENTIL", "Red lentils / دال سرخ", "pulses", "kg", "bag", 5, 110, 90, 365),
    ("CHICKPEA", "Chickpeas / نخود", "pulses", "kg", "bag", 5, 120, 100, 365),
    ("BEAN", "Red kidney beans / لوبیا سرخ", "pulses", "kg", "bag", 5, 130, 110, 365),
    ("OIL5", "Sunflower cooking oil 5 L / روغن ۵ لیتر", "oil", "piece", "carton", 4, 580, 500, 270),
    ("GTEA", "Green tea 250 g / چای سبز ۲۵۰ گرام", "tea", "piece", "carton", 24, 160, 135, 365),
    ("BTEA", "Black tea 500 g / چای سیاه ۵۰۰ گرام", "tea", "piece", "carton", 12, 260, 220, 365),
    ("SALT", "Iodized salt 1 kg / نمک یک کیلو", "spices", "piece", "carton", 20, 25, 18, 365),
    ("TURMERIC", "Turmeric powder 100 g / زردچوبه ۱۰۰ گرام", "spices", "piece", "carton", 24, 40, 30, 270),
    ("MILK", "UHT milk 1 L / شیر یک لیتر", "dairy", "piece", "carton", 12, 80, 65, 20),
    ("EGG", "Chicken egg / تخم مرغ", "eggs", "piece", "tray", 30, 10, 8, 14),
    ("YOGURT", "Plain yogurt 500 g / ماست ۵۰۰ گرام", "dairy", "piece", "carton", 12, 45, 35, 10),
    ("WATER", "Drinking water 1.5 L / آب آشامیدنی", "beverages", "piece", "carton", 12, 25, 18, 270),
    ("PASTA", "Macaroni 500 g / مکرونی ۵۰۰ گرام", "packaged", "piece", "carton", 20, 45, 35, 365),
    ("PASTE", "Tomato paste 800 g / رب بادنجان رومی", "packaged", "piece", "carton", 12, 110, 90, 365),
    ("BISCUIT", "Tea biscuits 200 g / بسکویت چای", "packaged", "piece", "carton", 24, 30, 22, 180),
    ("SOAP", "Laundry soap 200 g / صابون لباس", "household", "piece", "carton", 48, 35, 25, None),
    ("DETERGENT", "Washing powder 1 kg / پودر لباس شویی", "household", "piece", "carton", 12, 120, 95, None),
]
SUPPLIERS = [
    ("Mandawi Dry Goods Distribution / توزیع مواد خشک مندوی", "Grains, pulses, tea and spices; fictional sample supplier."),
    ("Afghan Packaged Foods Distribution / توزیع مواد بسته بندی", "Oil, packaged food, beverages and household goods; fictional sample supplier."),
    ("Local Dairy and Egg Supply / عرضه لبنیات و تخم", "Cold-chain dairy and fresh eggs; fictional sample supplier."),
]

def utc(value):
    return value.isoformat(timespec="seconds").replace("+00:00", "Z")

class Seeder:
    def __init__(self, args):
        self.args = args
        session = json.loads(Path(args.session).read_text(encoding="utf-8-sig"))
        self.token = session["token"]
        self.lock = threading.RLock()
        self.state_path = Path(args.state)
        self.state_path.parent.mkdir(parents=True, exist_ok=True)
        self.state = json.loads(self.state_path.read_text(encoding="utf-8")) if self.state_path.exists() else {
            "runId": str(uuid.uuid4()), "baseUrl": args.base_url, "recipeVersion": 2,
            "anchor": utc(datetime.now(timezone.utc)), "operations": {},
        }
        if self.state["baseUrl"] != args.base_url:
            raise RuntimeError("Journal belongs to another API.")
        self.anchor = datetime.fromisoformat(self.state["anchor"].replace("Z", "+00:00"))

    def request(self, method, path, payload=None):
        body = json.dumps(payload, ensure_ascii=False).encode("utf-8") if payload is not None else None
        req = Request(self.args.base_url.rstrip("/") + path, data=body, method=method,
                      headers={"Authorization": "Bearer " + self.token, "Content-Type": "application/json"})
        try:
            with urlopen(req, timeout=90) as response:
                content = response.read()
                return json.loads(content) if content else None
        except HTTPError as error:
            raise RuntimeError(f"{method} {path}: HTTP {error.code}: {error.read().decode('utf-8')}") from None

    def save(self):
        temp = self.state_path.with_suffix(".tmp")
        temp.write_text(json.dumps(self.state, ensure_ascii=False, indent=2), encoding="utf-8")
        os.replace(temp, self.state_path)

    def write(self, key, method, path, payload=None):
        with self.lock:
            previous = self.state["operations"].get(key)
            if previous:
                if previous["status"] == "done":
                    return previous["result"]
                # Do not blindly repeat a write that may have committed before a timeout.
                raise RuntimeError(f"Unresolved operation {key}; reconcile its API result before resuming.")
            self.state["operations"][key] = {"status": "pending", "method": method, "path": path, "payload": payload}
            self.save()
        try:
            result = self.request(method, path, payload)
        except RuntimeError as error:
            # Definite HTTP rejection can be corrected and resumed; transport failures stay pending.
            if "HTTP 4" in str(error):
                with self.lock:
                    del self.state["operations"][key]
                    self.save()
            raise
        with self.lock:
            self.state["operations"][key] = {"status": "done", "result": result}
            self.save()
        return result

    def preflight(self):
        user = self.request("GET", "/api/Account/me")
        shops = self.request("GET", "/api/Shop?pageSize=100")["items"]
        expected = {SHOP_PREFIX + item[0] for item in SHOPS if item[0]}
        if not expected.issubset({shop["id"] for shop in shops}):
            raise RuntimeError("Expected retained Azure shop IDs are absent; refusing to seed.")
        for path in ("Category", "UnitOfMeasure", "Product", "ProductUnit", "ProductPrice", "Supplier", "PurchaseOrder", "StockBatch"):
            self.request("GET", f"/api/{path}?pageSize=1")
        print(f"Preflight passed: user {user['userName']}; required API reads and retained shops verified.", flush=True)

    def seed(self):
        if self.state.get("recipeVersion", 1) != 2:
            raise RuntimeError("Old recipe journal: use correct_categories.py for existing data, or a fresh journal after reset.")
        self.preflight()
        for path in ("Category", "Product", "UnitOfMeasure", "Supplier", "PurchaseOrder", "StockBatch"):
            if not self.state["operations"] and self.request("GET", f"/api/{path}?pageSize=1")["totalCount"]:
                raise RuntimeError("Business data is not empty. Run the scoped reset first.")
        unit_ids = {}
        for key, name, symbol in UNITS:
            unit_ids[key] = self.write("unit:" + key, "POST", "/api/UnitOfMeasure",
                {"name": name, "symbol": symbol, "description": "Product-specific packaging conversion; prices are in AFN."})["id"]
        provinces = {}
        languages = self.request("GET", "/api/Language?pageSize=100")["items"]
        english = next(language for language in languages if language["code"] == "en")
        for city, district in [("Kabul", "Kabul city"), ("Herat", "Herat city"), ("Balkh", "Mazar-e-Sharif"), ("Kandahar", "Kandahar city")]:
            existing = self.request("GET", "/api/Province?pageSize=100")["items"]
            province = next((p for p in existing if p["name"] == city), None)
            if province is None:
                province = self.write("province:" + city, "POST", "/api/Province", {
                    "name": city, "translations": [{"languageId": english["id"],
                    "languageCode": "en", "isDefault": True, "name": city}]})
            provinces[city] = province["id"]
            districts = self.request("GET", "/api/District?pageSize=100")["items"]
            if not any(d["provinceId"] == province["id"] and d["name"] == district for d in districts):
                self.write("district:" + city, "POST", "/api/District", {"name": district, "provinceId": province["id"]})
        summary = []
        for index, (suffix, name, address, shop_type) in enumerate(SHOPS, 1):
            shop_id = SHOP_PREFIX + suffix if suffix else None
            shop = self.write(f"shop:{index}", "PUT" if shop_id else "POST",
                "/api/Shop" + ("/" + shop_id if shop_id else ""),
                {"name": name, "shopType": shop_type, "address": address, "isActive": True})
            shop_id = shop["id"]
            if shop["name"] != name:
                self.write(f"shop:{index}:preserved-name", "PUT", "/api/Shop/" + shop_id,
                    {"name": name, "shopType": shop_type, "address": address, "isActive": True})
            self.token = self.request("POST", "/api/Account/switch-shop", {"shopId": shop_id})["token"]
            Path(self.args.session).write_text(json.dumps({"token": self.token}), encoding="utf-8")
            print(f"Shop {index}/5: {name}", flush=True)
            categories = {}
            for code, cat_name in CATEGORIES:
                categories[code] = self.write(f"{index}:category:{code}", "POST", "/api/Category",
                    {"name": cat_name, "code": code.upper(), "description": "Afghan grocery assortment", "isActive": True})["id"]
            suppliers = []
            for number, (supplier_name, notes) in enumerate(SUPPLIERS):
                suppliers.append(self.write(f"{index}:supplier:{number}", "POST", "/api/Supplier",
                    {"name": supplier_name, "notes": notes})["id"])
            order_groups = [[], [], []]
            def build_product(item):
                code, product_name, category, base, pack, factor, sell, cost, shelf = item
                product_payload = {
                    "name": product_name, "baseUnitId": unit_ids[base], "categoryId": categories[category],
                    "sku": f"AFG-{index:02}-{code}", "description": "Illustrative grocery sample; all monetary amounts are AFN.",
                    "isActive": True, "reorderPointBase": factor * 2, "reorderQuantityBase": factor * 5,
                }
                product = self.write(f"{index}:product:{code}", "POST", "/api/Product", product_payload)
                if product.get("shopName") != name:
                    product = self.write(f"{index}:product-shop-label:{code}", "PUT",
                        "/api/Product/" + product["id"], product_payload)
                base_units = self.request("GET", f"/api/ProductUnit?productId={product['id']}&pageSize=100")["items"]
                base_unit = next(p for p in base_units if p["unitOfMeasureId"] == unit_ids[base] and p["baseUnitQuantity"] == 1)
                package = self.write(f"{index}:pack:{code}", "POST", "/api/ProductUnit", {
                    "productId": product["id"], "unitOfMeasureId": unit_ids[pack], "baseUnitQuantity": factor})
                for label, product_unit, price in [("base", base_unit, sell), ("pack", package, sell * factor)]:
                    self.write(f"{index}:price:{code}:{label}", "POST", "/api/ProductPrice", {
                        "productUnitId": product_unit["id"], "sellPrice": price,
                        "effectiveDate": utc(self.anchor - timedelta(days=30)), "endDate": None})
                group = 2 if category in ("dairy", "eggs") else (0 if category in ("rice", "flour", "pulses", "tea", "spices") else 1)
                return group, (product, package, cost, shelf, code)
            # Only independent products run together; each product's dependency chain remains sequential.
            with ThreadPoolExecutor(max_workers=4) as executor:
                for group, data in executor.map(build_product, PRODUCTS):
                    order_groups[group].append(data)
            for group, products in enumerate(order_groups):
                key = f"{index}:order:{group}"
                quantities = {p[0]["id"]: (1 if p[4] in ("YOGURT", "MILK") else 6 + index) for p in products}
                order = self.write(key, "POST", "/api/PurchaseOrder", {
                    "supplierId": suppliers[group], "referenceNumber": f"AFG-{index:02}-{group + 1:02}",
                    "orderedAtUtc": utc(self.anchor - timedelta(days=3)),
                    "idempotencyKey": self.state["runId"] + ":" + key,
                    "notes": "Opening grocery replenishment. Costs are AFN per base unit.",
                    "lines": [{"productId": p["id"], "productUnitId": pack["id"],
                               "quantityEntered": quantities[p["id"]], "unitCostBase": cost}
                              for p, pack, cost, shelf, code in products],
                })
                by_product = {p[0]["id"]: p for p in products}
                receipt_lines = []
                for line in order["lines"]:
                    product, pack, cost, shelf, code = by_product[line["productId"]]
                    receipt_lines.append({"purchaseOrderLineId": line["id"],
                        "quantityEntered": quantities[product["id"]],
                        "batchNumber": f"AFG-{index:02}-{code}-01",
                        "expirationDate": utc(self.anchor + timedelta(days=shelf)) if shelf else None})
                self.write(key + ":receipt", "POST", f"/api/PurchaseOrder/{order['id']}/receipts", {
                    "occurredAtUtc": utc(self.anchor - timedelta(days=2)),
                    "idempotencyKey": self.state["runId"] + ":" + key + ":receipt",
                    "lines": receipt_lines})
            batches = self.request("GET", "/api/StockBatch?pageSize=100")["items"]
            batches = [b for b in batches if b["shopId"] == shop_id]
            if len(batches) != len(PRODUCTS):
                raise RuntimeError(f"Expected 20 stock batches in shop {index}; got {len(batches)}.")
            count = self.write(f"{index}:count", "POST", "/api/inventory/stock-counts", {
                "stockBatchIds": [b["id"] for b in batches], "notes": "Opening physical count confirmed against received stock."})
            self.write(f"{index}:count:complete", "POST", f"/api/inventory/stock-counts/{count['id']}/complete", {
                "counts": [{"stockBatchId": line["stockBatchId"], "countedQuantityBase": line["expectedQuantityBase"]}
                           for line in count["lines"]],
                "idempotencyKey": self.state["runId"] + f":{index}:count:complete"})
            reconciliation = self.request("GET", "/api/inventory/reconciliation")
            if len(reconciliation) != len(PRODUCTS) or any(not row["isBalanced"] for row in reconciliation):
                raise RuntimeError(f"Stock reconciliation failed for shop {index}.")
            self.state.setdefault("reconciliation", {})[shop_id] = reconciliation
            self.save()
            summary.append({"id": shop_id, "name": name, "products": len(PRODUCTS), "batches": len(batches)})
            print(f"Completed shop {index}: 20 products, 40 units/prices, 3 received orders, 1 physical count.", flush=True)
        self.state["summary"] = summary
        self.state["completed"] = True
        self.save()
        print(json.dumps(summary, ensure_ascii=False, indent=2), flush=True)

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--base-url", required=True)
    parser.add_argument("--session", required=True, help="Private JSON login response containing token")
    parser.add_argument("--state", default=".tmp/grocery-seed-state.json")
    parser.add_argument("--preflight", action="store_true")
    args = parser.parse_args()
    seeder = Seeder(args)
    if args.preflight:
        seeder.preflight()
    else:
        seeder.seed()

if __name__ == "__main__":
    sys.stdout.reconfigure(encoding="utf-8")
    sys.stderr.reconfigure(encoding="utf-8")
    main()
