#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MagicVilla_UserAuthAPI/MagicVilla_UserAuthAPI.csproj", "MagicVilla_UserAuthAPI/"]
RUN dotnet restore "MagicVilla_UserAuthAPI/MagicVilla_UserAuthAPI.csproj"
COPY . .
WORKDIR "/src/MagicVilla_UserAuthAPI"
RUN dotnet build "MagicVilla_UserAuthAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MagicVilla_UserAuthAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MagicVilla_UserAuthAPI.dll"]