FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AspNovelServer2/AspNovelServer2.csproj", "AspNovelServer2/"]
RUN dotnet restore "AspNovelServer2/AspNovelServer2.csproj"
COPY . .
WORKDIR "/src/AspNovelServer2"
RUN dotnet build "AspNovelServer2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNovelServer2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNovelServer2.dll"]
