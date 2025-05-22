FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["MottFinder.csproj", "./"]
RUN dotnet restore "MottFinder.csproj"
COPY . .
RUN dotnet publish "MottFinder.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:5169
ENTRYPOINT ["dotnet", "MottFinder.dll"]