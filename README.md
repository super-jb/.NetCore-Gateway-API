# .NetCore-Gateway-API
Gateway API created using .NET Core and Ocelot (Gateway helper)

# Description
Imagine you're hosting multiple APIs for your clients. It can become quite challenging for them to keep up with all those APIs and versions of the APIs. That's where the concept of a Gateway (and Ocelot) comes in to play.  
Expose one API that connects to all your APIs

# Setup
* .NET Core v2.2 (https://dotnet.microsoft.com/download)
* Ocelot v13.5.2 (https://www.nuget.org/packages/Ocelot/)

# Running application
To fully test this, you'll want to have the 3 APIs running simultaneously.  
I open 3 instances of GitBash and, for each API, run: dotnet run

cd c/development/GatewayApi/src/GatewayApi (port 7000)  
dotnet run  
cd c/development/GatewayApi/src/CatalogApi (port 7001)  
dotnet run  
cd c/development/GatewayApi/src/OrdersApi (port 7002)  
dotnet run  

Open a browser, and 4 tabs  
* localhost:7001/api/currencies  
* localhost:7002/api/order  
* localhost:7000/catalog-api/currencies  
* localhost:7000/order-api/orders  

The GatewayApi project is configured to redirect all calls to port 7000 to the respective APIs  

# Unit Tests
Some basic Unit Tests setup for CatalogApi and OrdersApi