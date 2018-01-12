#!/bin/bash

# https://docs.sonarqube.org/display/SONAR/Analysis+Parameters
mono ~/Applications/Sonar/Scanner/msbuild/SonarQube.Scanner.MSBuild.exe begin /k:"dein:colorify" /n:"Colorify" /v:"1.0.1" /o:"dein" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="34dadb57c7435b016b8ba12e48dc49f5d1eadee6" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*"
dotnet restore
dotnet build
dotnet test Colorify.Tests/Colorify.Tests.csproj
mono ~/Applications/Sonar/Scanner/msbuild/SonarQube.Scanner.MSBuild.exe end /d:sonar.login="34dadb57c7435b016b8ba12e48dc49f5d1eadee6"