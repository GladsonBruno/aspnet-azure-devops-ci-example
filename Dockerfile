#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /code
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

COPY ./app/publish .
ENTRYPOINT ["dotnet", "aspnet-demo-api.dll"]