FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
ADD ./ /app
ENV ASPNETCORE_URLS=http://*:${PORT}
ENV ASPNETCORE_ENVIRONMENT=Production
WORKDIR /app
ENTRYPOINT [ "dotnet", "NativoApi.dll"]