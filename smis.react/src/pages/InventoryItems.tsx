export default function InventoryItems() {
  return (
    <div className="page">
      <div className="page-header">
        <h1 className="page-title">Inventory Items</h1>
        <button className="primary-button">New Item</button>
      </div>
      <div className="panel">
        <div className="panel-header">
          <h2>All Inventory Items</h2>
          <input className="search" placeholder="Search inventory items…" />
        </div>
        <div className="empty">Connect API to list inventory items.</div>
      </div>
    </div>
  )
}
