FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
COPY *.sln .
COPY devshops.Api/*.csproj ./devshops.Api/
COPY devshops.Core/*.csproj ./devshops.Core/
COPY devshops.Domain/*.csproj ./devshops.Domain/

RUN dotnet restore


COPY devshops.Api/. ./devshops.Api/
COPY devshops.Core/. ./devshops.Core/
COPY devshops.Domain/. ./devshops.Domain/

WORKDIR /app/devshops.Api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0.0-alpine3.12
WORKDIR /app
COPY --from=build app/devshops.Api/out .
ENTRYPOINT [ "dotnet", "devshops.Api.dll" ]