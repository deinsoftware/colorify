#!/bin/bash
token="$(cat sonar.txt)"
# https://docs.sonarqube.org/display/SONAR/Analysis+Parameters
dotnet sonarscanner begin /k:"dein:colorify" /n:"Colorify" /v:"2.2.1" /o:"dein" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="${token}" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*"
dotnet restore
dotnet build
dotnet test Colorify.Tests/Colorify.Tests.csproj
dotnet sonarscanner end /d:sonar.login="${token}"