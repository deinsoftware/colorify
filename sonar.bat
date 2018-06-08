@echo off
set /p token=<sonar.txt
:: https://docs.sonarqube.org/display/SONAR/Analysis+Parameters
SonarQube.Scanner.MSBuild.exe begin /k:"dein:colorify" /n:"Colorify" /v:"1.0.5" /o:"dein" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="%token%" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*"
dotnet restore
dotnet build
dotnet test Colorify.Tests/Colorify.Tests.csproj
SonarQube.Scanner.MSBuild.exe end /d:sonar.login="%token%"