@echo off

SET projectKeyName=PlanetaryMotion
SET projectSolutionFileName=PlanetaryMotion
SET projectSonarName=PlanetaryMotion

SET runner=D:\SonarQube\SonarRunner\bin\MSBuild.SonarQube.Runner.exe
set fwPath=C:\projects\PlanetaryMotion\%projectKeyName%
set currentVersion=1.0

"%runner%" begin /k:"%projectSolutionFileName%" /n:"%projectSonarName%" /v:"%currentVersion%"

MSBuild.exe "%fwPath%"\%projectSolutionFileName%.sln /t:Rebuild

"%runner%" end

