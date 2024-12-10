@ECHO OFF

dotnet publish -r linux-bionic-x86 
rem -p:DisableUnsupportedError=true -p:PublishAotUsingRuntimePack=true
