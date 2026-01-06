export default function Categories() {
  return (
    <div className="page">
      <div className="page-header">
        <h1 className="page-title">Categories</h1>
        <button className="primary-button">New Category</button>
      </div>
      <div className="panel">
        <div className="panel-header">
          <h2>All Categories</h2>
          <input className="search" placeholder="Search categories…" />
        </div>
        <div className="empty">Connect API to list categories.</div>
      </div>
    </div>
  )
}
