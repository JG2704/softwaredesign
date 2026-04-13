#!/usr/bin/env bash
set -euo pipefail

echo "Bootstrapping DUA backend skeleton..."
dotnet restore backend/src/DUA.API/DUA.API.csproj
