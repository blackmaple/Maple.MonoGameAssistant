@ECHO OFF
dotnet publish -r linux-bionic-arm64 
rem -p:DisableUnsupportedError=true -p:PublishAotUsingRuntimePack=true
