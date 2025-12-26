Reservoir Simulation & Telemetry System
A full-stack industrial monitoring application designed to visualize reservoir telemetry data. This project features a .NET 8 Web API backend with a layered architecture and a React + Three.js frontend for 3D spatial data representation.

🚀 Key Features
3D Spatial Visualization: Real-time rendering of reservoir sensors using React Three Fiber and Three.js.

Data-Driven Dashboards: High-performance analytics charts built with Recharts.

Layered Backend Architecture: Clean separation of concerns (API, Service, Data layers) following SOLID principles.

Real-time Analytics: Automated calculation of average pressures and system health status.

Responsive Design: Fully adaptive interface for monitoring from any device.

🛠️ Tech Stack
Frontend: React 18, TypeScript, Vite, React Three Fiber (Three.js), Recharts, Axios.

Backend: .NET 8 (C#), ASP.NET Core Web API.

Data Source: JSON-based persistence (designed for easy migration to SQL Server/PostgreSQL).

🏗️ Architecture
The system is divided into three main projects:

Reservoir.Api: Handles HTTP requests and CORS configuration.

Reservoir.Service: Contains the business logic and engineering calculations.

Reservoir.Data: Manages data access, repository patterns, and JSON deserialization.

🔧 Installation & Setup
Prerequisites
.NET 8 SDK

Node.js (v18+)

1. Backend Setup
Bash

# Navigate to the root directory
cd reservoir-simulation-api

# Restore and Build
dotnet build

# Run the API
dotnet run --project Reservoir.Api
The API will be available at: http://localhost:5085

2. Frontend Setup
Bash

# Navigate to the frontend folder
cd reservoir-visualizer-ui

# Install dependencies
npm install

# Run the development server
npm run dev
The UI will be available at: http://localhost:5173 (or check the terminal for the specific port).

📊 API Endpoints
GET /api/Reservoir/data - Returns all reservoir points and geological data.

GET /api/Reservoir/stats - Returns calculated pressure and temperature statistics.

📝 Future Roadmap
[ ] Implement SignalR for real-time websocket updates.

[ ] Add Entity Framework Core for SQL Server integration.

[ ] Expand 3D visualization with Heatmap shaders for pressure gradients.