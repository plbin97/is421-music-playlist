FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["MusicList/MusicList.csproj", "MusicList/"]
RUN dotnet restore "MusicList/MusicList.csproj"
COPY . .
WORKDIR "/src/MusicList"
RUN dotnet build "MusicList.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MusicList.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MusicList.dll"]
