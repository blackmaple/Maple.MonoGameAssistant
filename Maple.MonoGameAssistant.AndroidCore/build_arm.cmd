@ECHO OFF
dotnet publish -r linux-bionic-arm
rem -p:DisableUnsupportedError=true -p:PublishAotUsingRuntimePack=true
