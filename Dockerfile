FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

COPY back-1-trimestre-2-daw.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish back-1-trimestre-2-daw.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app


COPY --from=build /app/publish ./

EXPOSE 80

ENTRYPOINT ["dotnet", "back-1-trimestre-2-daw.dll"]