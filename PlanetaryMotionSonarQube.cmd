@echo off

SET projectKeyName=PlanetaryMotion
SET projectSolutionFileName=PlanetaryMotion
SET projectSonarName=PlanetaryMotion

SET runner=C:\SonarQube\SonarRunner\MSBuild.SonarQube.Runner.exe
set fwPath=C:\projects\%projectKeyName%
set currentVersion="1.0"

"%runner%" begin /k:"%projectSolutionFileName%" /n:"%projectSonarName%" /v:"%currentVersion%" /d:sonar.verbose=true /d:sonar.host.url="http://104.196.209.111:9000/"

MSBuild.exe "%fwPath%"\%projectSolutionFileName%.sln /t:Rebuild

"%runner%" end