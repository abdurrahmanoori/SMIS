import StatCard from '../components/StatCard'

export default function Dashboard() {
  return (
    <div className="page">
      <h1 className="page-title">Dashboard</h1>
      <div className="grid kpis">
        <StatCard title="Storage Locations" value={24} trend="+2 this week" icon={<span>🏢</span>} />
        <StatCard title="Items" value={1320} trend="+58 today" icon={<span>📦</span>} />
        <StatCard title="Inventory Count" value={482} trend="+17 this week" icon={<span>📋</span>} />
        <StatCard title="Pending Orders" value={39} trend="-5%" icon={<span>⏳</span>} />
      </div>

      <div className="panel">
        <div className="panel-header">
          <h2>Recent Inventory</h2>
          <button className="text-button">View all</button>
        </div>
        <div className="table">
          <div className="table-row head">
            <div>Item</div>
            <div>Location</div>
            <div>Date Added</div>
            <div>Status</div>
          </div>
          {[1,2,3,4,5].map(i => (
            <div className="table-row" key={i}>
              <div>Item {i}</div>
              <div>Warehouse A</div>
              <div>2025-09-0{i}</div>
              <div><span className="badge badge-green">In Stock</span></div>
            </div>
          ))}
        </div>
      </div>
    </div>
  )
}
