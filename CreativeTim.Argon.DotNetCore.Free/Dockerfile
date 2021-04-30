FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["GestionDeVehiculos/GestionDeVehiculos.csproj", "GestionDeVehiculos/"]
RUN dotnet restore "GestionDeVehiculos/GestionDeVehiculos.csproj"
COPY . .
WORKDIR "/src/GestionDeVehiculos"
RUN dotnet build "GestionDeVehiculos.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GestionDeVehiculos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GestionDeVehiculos.dll"]
