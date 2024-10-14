@ECHO OFF

dotnet publish -r linux-bionic-arm64 -p:DisableUnsupportedError=true -p:PublishAotUsingRuntimePack=true
