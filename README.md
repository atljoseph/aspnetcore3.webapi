This project is inactive (for meow).

# aspnetcore3.webapi
AspNetCore 3 - WebApi in Layers 

# Confused? Seek `Knowledge`!
Check the `knowledge` folder when in doubt. There are a bunch of notes in there from development in case you are confused or stuck on a build issue.

# Dependencies
Git
.NET (dotnet) Core 3 Preview 1 or later SDK
Sql Server - Already set up in your environment (See `knowledge` folder.s)

# Install Project
git clone https://github.com/atljoseph/aspnetcore3.webapi.git

# Restore Packages & Build
dotnet restore
dotnet build

# Initialize the Database
cd webapi.AuthDAL
dotnet ef --startup-project ../webapi.WebApi database update
(no seed data - yet! - Right now it just creates db and tables)

# Run the project
dotnet run --project webapi.WebApi
Visit http://localhost:5000/api/users in your browser.

# Goals Met
- Dotnet Core 3 dev on Mac
- Use Sql Server on Mac
- Design from ground up as N-Layer
- Use EntityFrameworkCore to Initialize Database

# Future Goals
- Use EntityFrameworkCore to Read / Write Entities to Db 
- Add Cors
- Add Token-based Authentication 
- Add Authorization
- Who knows ... !
- Integrate with josephgill.io
