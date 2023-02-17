#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY ["aspnet-demo-api/aspnet-demo-api.csproj", "aspnet-demo-api/"]
RUN dotnet restore "aspnet-demo-api/aspnet-demo-api.csproj"
COPY . .
WORKDIR "/src/aspnet-demo-api"
RUN dotnet build "aspnet-demo-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "aspnet-demo-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY app/publish .
ENTRYPOINT ["dotnet", "aspnet-demo-api.dll"]