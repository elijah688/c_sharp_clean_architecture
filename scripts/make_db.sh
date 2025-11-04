#!/bin/bash
set -e

# -------------------------
# 1️⃣ Start PostgreSQL in Docker
# -------------------------
echo "Starting PostgreSQL container..."
docker-compose up -d
# Wait a few seconds for Postgres to start
echo "Waiting 5 seconds for Postgres..."
sleep 5

# -------------------------
# 2️⃣ Run EF Core migrations
# -------------------------
echo "Adding migration..."
dotnet tool run dotnet-ef migrations add InitialCreate \
	--project Infrastructure/Infrastructure.csproj \
	--startup-project Api/Api.csproj

echo "Applying migration to database..."
dotnet tool run dotnet-ef database update \
	--project Infrastructure/Infrastructure.csproj \
	--startup-project Api/Api.csproj

echo "✅ Database ready and Notes table created."
