@ECHO OFF

dotnet publish -r linux-bionic-x64
rem -p:DisableUnsupportedError=true -p:PublishAotUsingRuntimePack=true
