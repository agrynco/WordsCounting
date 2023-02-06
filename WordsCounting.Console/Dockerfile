FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WordsCounting.Console/WordsCounting.Console.csproj", "WordsCounting.Console/"]
COPY ["WordsCounting/WordsCounting.csproj", "WordsCounting/"]
RUN dotnet restore "WordsCounting.Console/WordsCounting.Console.csproj"
COPY . .
WORKDIR "/src/WordsCounting.Console"
RUN dotnet build "WordsCounting.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WordsCounting.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WordsCounting.Console.dll"]
