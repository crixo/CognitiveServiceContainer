FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ARMWebApp/ARMWebApp.csproj ARMWebApp/
RUN dotnet restore ARMWebApp/ARMWebApp.csproj
COPY . .
WORKDIR /src/ARMWebApp
RUN dotnet build ARMWebApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ARMWebApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ARMWebApp.dll"]
