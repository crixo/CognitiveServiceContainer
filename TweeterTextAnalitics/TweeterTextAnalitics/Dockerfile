FROM microsoft/dotnet:2.2-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY TweeterTextAnalitics/TweeterTextAnalitics.csproj TweeterTextAnalitics/appsettings.json TweeterTextAnalitics/
RUN dotnet restore TweeterTextAnalitics/TweeterTextAnalitics.csproj
COPY . .
WORKDIR /src/TweeterTextAnalitics
RUN dotnet build TweeterTextAnalitics.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TweeterTextAnalitics.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TweeterTextAnalitics.dll"]
