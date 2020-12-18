FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY Raspberry.TestDebug/Raspberry.TestDebug/bin/Release/netcoreapp3.1/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "Raspberry.TestDebug.dll"]