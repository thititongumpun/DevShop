FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build

WORKDIR /src
COPY *.sln .
COPY DbUp/*.csproj ./DbUp/
COPY devshops.Api/*.csproj ./devshops.Api/
COPY devshops.Core/*.csproj ./devshops.Core/
COPY devshops.Domain/*.csproj ./devshops.Domain/
COPY devshops.Services/*.csproj ./devshops.Services/

RUN dotnet restore

COPY DbUp/. ./DbUp/
COPY devshops.Api/. ./devshops.Api/
COPY devshops.Core/. ./devshops.Core/
COPY devshops.Domain/. ./devshops.Domain/
COPY devshops.Services/. ./devshops.Services/

WORKDIR /src/devshops.Api
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0.0-alpine3.12
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "devshops.Api.dll" ]