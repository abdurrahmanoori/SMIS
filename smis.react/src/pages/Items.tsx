export default function Items() {
  return (
    <div className="page">
      <div className="page-header">
        <h1 className="page-title">Items</h1>
        <button className="primary-button">New Item</button>
      </div>
      <div className="panel">
        <div className="panel-header">
          <h2>All Items</h2>
          <input className="search" placeholder="Search items…" />
        </div>
        <div className="empty">Connect API to list items.</div>
      </div>
    </div>
  )
}
