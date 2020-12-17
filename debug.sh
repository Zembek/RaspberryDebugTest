#!/bin/bash
git pull
dotnet build Raspberry.TestDebug/Raspberry.TestDebug/Raspberry.TestDebug.csproj -c Debug
dotnet Raspberry.TestDebug/Raspberry.TestDebug/bin/Debug/netcoreapp3.1/Raspberry.TestDebug.dl