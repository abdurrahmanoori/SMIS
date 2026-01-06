import { Route, Routes, Navigate } from 'react-router-dom'
import './App.css'
import AppLayout from './components/AppLayout'
import Dashboard from './pages/Dashboard'
import Items from './pages/Items'
import InventoryItems from './pages/InventoryItems'
import Categories from './pages/Categories'
import Provinces from './pages/Provinces'
import Users from './pages/Users'
import NotFound from './pages/NotFound'

export default function App() {
  return (
    <AppLayout>
      <Routes>
        <Route path="/" element={<Dashboard />} />
        <Route path="/items" element={<Items />} />
        <Route path="/inventory-items" element={<InventoryItems />} />
        <Route path="/categories" element={<Categories />} />
        <Route path="/provinces" element={<Provinces />} />
        <Route path="/users" element={<Users />} />
        <Route path="/404" element={<NotFound />} />
        <Route path="*" element={<Navigate to="/404" replace />} />
      </Routes>
    </AppLayout>
  )
}
