FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DotnetApi/DotnetApi.csproj", "DotnetApi/"]
RUN dotnet restore "DotnetApi/DotnetApi.csproj"
COPY . .
WORKDIR "/src/DotnetApi"
RUN dotnet build "DotnetApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotnetApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetApi.exe"]
