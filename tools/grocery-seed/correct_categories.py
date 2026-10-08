"""Split combined sample categories via the existing API without replacing stock."""
import argparse
import json
import sys
from pathlib import Path
from concurrent.futures import ThreadPoolExecutor
from seed_groceries import Seeder, CATEGORIES, PRODUCTS

LEGACY_CODES = {"rice": "GRAINS"}
FIELDS = ("name", "baseUnitId", "description", "isActive", "sku", "barcode",
          "imageUrl", "categoryId", "reorderPointBase", "reorderQuantityBase")

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--base-url", required=True)
    parser.add_argument("--session", required=True)
    parser.add_argument("--state", default=".tmp/grocery-category-correction.json")
    args = parser.parse_args()
    seed = Seeder(args)
    seed.preflight()
    original = json.loads(Path(".tmp/grocery-seed-state.json").read_text(encoding="utf-8"))
    for index, shop in enumerate(original["summary"], 1):
        shop_id = shop["id"]
        seed.token = seed.request("POST", "/api/Account/switch-shop", {"shopId": shop_id})["token"]
        Path(args.session).write_text(json.dumps({"token": seed.token}), encoding="utf-8")
        categories = [c for c in seed.request("GET", "/api/Category?pageSize=100")["items"] if c["shopId"] == shop_id]
        products = [p for p in seed.request("GET", "/api/Product?pageSize=100")["items"] if p["shopId"] == shop_id]
        if len(products) != 20:
            raise RuntimeError("Unexpected product set; refusing to modify this shop.")
        if shop_id not in seed.state.setdefault("backup", {}):
            seed.state["backup"][shop_id] = {"categories": categories, "products": products}
            seed.save()
        category_ids = {}
        for code, name in CATEGORIES:
            old_code = LEGACY_CODES.get(code, code.upper())
            category = next((c for c in categories if c["code"] in (code.upper(), old_code)), None)
            payload = {"name": name, "code": code.upper(), "description": "Single grocery product group", "isActive": True}
            if category:
                result = seed.write(f"{index}:category:{code}", "PUT", "/api/Category/" + category["id"], payload)
            else:
                result = seed.write(f"{index}:category:{code}", "POST", "/api/Category", payload)
            category_ids[code] = result["id"]
        definitions = {f"AFG-{index:02}-{item[0]}": item[2] for item in PRODUCTS}
        def update(product):
            if product["sku"] not in definitions:
                raise RuntimeError("Unexpected product SKU.")
            payload = {field: product.get(field) for field in FIELDS}
            payload["categoryId"] = category_ids[definitions[product["sku"]]]
            # Refresh the stored CategoryName as well as the foreign key.
            seed.write(f"{index}:product:{product['id']}", "PUT", "/api/Product/" + product["id"], payload)
        with ThreadPoolExecutor(max_workers=4) as executor:
            list(executor.map(update, products))
        final = [c for c in seed.request("GET", "/api/Category?pageSize=100")["items"] if c["shopId"] == shop_id]
        if len(final) != 12:
            raise RuntimeError("Unexpected category count after correction.")
        print(f"Shop {index}/5 complete: 12 single-group categories; 20 products reassigned.", flush=True)
    seed.state["completed"] = True
    seed.save()
    print("Category correction complete. Product units, prices and inventory were preserved.", flush=True)

if __name__ == "__main__":
    sys.stdout.reconfigure(encoding="utf-8")
    sys.stderr.reconfigure(encoding="utf-8")
    main()
