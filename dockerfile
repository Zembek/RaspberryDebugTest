FROM mcr.microsoft.com/dotnet/runtime:3.1.10-buster-slim-arm32v7
COPY Raspberry.TestDebug/Raspberry.TestDebug/bin/Release/netcoreapp3.1/linux-arm/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "Raspberry.TestDebug.dll"]