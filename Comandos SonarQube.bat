dotnet "C:\sonar-scanner-msbuild-5.3.1.36242-netcoreapp2.0\SonarScanner.MSBuild.dll" begin /k:"T3_Calidad_N00038949" /d:sonar.login="b47aa4723a8017269c05823ba11334f05ee131c2" /d:sonar.host.url="https://sonar.lumenes.tk"
dotnet build 
dotnet sonarscanner end /d:sonar.login="b47aa4723a8017269c05823ba11334f05ee131c2"