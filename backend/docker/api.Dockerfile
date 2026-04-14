FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview AS runtime
WORKDIR /app
EXPOSE 8080
ENTRYPOINT ["dotnet", "DUA.API.dll"]
