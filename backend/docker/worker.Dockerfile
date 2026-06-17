FROM mcr.microsoft.com/dotnet/runtime:10.0-preview AS runtime
WORKDIR /app
ENTRYPOINT ["dotnet", "DUA.Workers.dll"]
