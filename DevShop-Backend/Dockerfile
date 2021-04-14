FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
COPY *.sln .
COPY devshops.Api/*.csproj ./devshops.Api/
COPY devshops.Core/*.csproj ./devshops.Core/
COPY devshops.Domain/*.csproj ./devshops.Domain/
COPY devshops.Infrastructure/*.csproj ./devshops.Infrastructure/

RUN dotnet restore

COPY devshops.Api/. ./devshops.Api/
COPY devshops.Core/. ./devshops.Core/
COPY devshops.Domain/. ./devshops.Domain/
COPY devshops.Infrastructure/. ./devshops.Infrastructure/

WORKDIR /app/devshops.Api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0.0-alpine3.12
RUN apk add --no-cache icu-libs
RUN apk update && apk add bash
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

WORKDIR /app
COPY ./wait-for-it.sh /wait-for-it.sh
RUN chmod +x /wait-for-it.sh
COPY --from=build app/devshops.Api/out .
ENTRYPOINT [ "dotnet", "devshops.Api.dll" ]