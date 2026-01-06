import { NavLink } from 'react-router-dom'

type SidebarProps = {
  collapsed?: boolean
  onNavigate?: () => void
}

export default function Sidebar({ collapsed, onNavigate }: SidebarProps) {
  return (
    <aside className={`sidebar ${collapsed ? 'collapsed' : ''}`}>
      <div className="sidebar-header">
        <div className="logo-circle">S</div>
        {!collapsed && <div className="sidebar-title">SMIS Admin</div>}
      </div>
      <nav className="nav">
        <NavLink to="/" end onClick={onNavigate} className={({ isActive }: { isActive: boolean }) => `nav-item ${isActive ? 'active' : ''}`}>
          <span className="nav-icon">🏠</span>
          <span className="nav-label">Dashboard</span>
        </NavLink>
  <NavLink to="/items" onClick={onNavigate} className={({ isActive }: { isActive: boolean }) => `nav-item ${isActive ? 'active' : ''}`}>
          <span className="nav-icon">📦</span>
          <span className="nav-label">Items</span>
        </NavLink>
  <NavLink to="/inventory-items" onClick={onNavigate} className={({ isActive }: { isActive: boolean }) => `nav-item ${isActive ? 'active' : ''}`}>
          <span className="nav-icon">📋</span>
          <span className="nav-label">Inventory Items</span>
        </NavLink>
  <NavLink to="/categories" onClick={onNavigate} className={({ isActive }: { isActive: boolean }) => `nav-item ${isActive ? 'active' : ''}`}>
          <span className="nav-icon">🏷️</span>
          <span className="nav-label">Categories</span>
        </NavLink>
  <NavLink to="/provinces" onClick={onNavigate} className={({ isActive }: { isActive: boolean }) => `nav-item ${isActive ? 'active' : ''}`}>
          <span className="nav-icon">🗺️</span>
          <span className="nav-label">Provinces</span>
        </NavLink>
  <NavLink to="/users" onClick={onNavigate} className={({ isActive }: { isActive: boolean }) => `nav-item ${isActive ? 'active' : ''}`}>
          <span className="nav-icon">👥</span>
          <span className="nav-label">Users</span>
        </NavLink>
      </nav>
    </aside>
  )
}
