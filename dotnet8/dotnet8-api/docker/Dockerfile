FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

ENV ASPNETCORE_HTTP_PORTS=80

WORKDIR /App
EXPOSE 80

COPY --from=build /App/out .
ENTRYPOINT ["dotnet", "dotnet8-api.dll"]