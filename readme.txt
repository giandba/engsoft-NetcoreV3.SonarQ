#donwload netcore sdk
https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-3.1.410-windows-x64-installer

#Extensao
ms-dotnettools.csharp
dotnet-test-explorer

#verificar versao instalada
dotnet --list-sdks

#Abrir Terminal
ctrl + '


#criar projeto console app
mkdir NetcoreV3.SonarQ.Apps
cd ./NetcoreV3.SonarQ.ConsoleApp
dotnet new console -f netcoreapp3.1

#criar projeto web
mkdir NetcoreV3.SonarQ.Api
cd ./NetcoreV3.SonarQ.Api
dotnet new web -f netcoreapp3.1

#criar projeto test
mkdir NetcoreV3.SonarQ.Tests
cd ./NetcoreV3.SonarQ.Tests
dotnet new mstest -f netcoreapp3.1

#adiciona referencia do projeto apps no projeto de tests
dotnet add .\NetcoreV3.SonarQ.Api.csproj reference ..\NetcoreV3.SonarQ.Apps\NetcoreV3.SonarQ.Apps.csproj
dotnet add .\NetcoreV3.SonarQ.Tests.csproj reference ..\NetcoreV3.SonarQ.Apps\NetcoreV3.SonarQ.Apps.csproj

#navega para raiz do projeto
cd ..

#add arquivos solucao
dotnet sln .\NetcoreV3.SonarQ.sln add .\NetcoreV3.SonarQ.Apps\NetcoreV3.SonarQ.Apps.csproj
dotnet sln .\NetcoreV3.SonarQ.sln add .\NetcoreV3.SonarQ.Api\NetcoreV3.SonarQ.Api.csproj
dotnet sln .\NetcoreV3.SonarQ.sln add .\NetcoreV3.SonarQ.Tests\NetcoreV3.SonarQ.Tests.csproj


https://docs.sonarqube.org/latest/analysis/scan/sonarscanner-for-msbuild/
##https://medium.com/@thiagoloureiro/an%C3%A1lise-de-c%C3%B3digo-com-sonarqube-docker-net-core-aad17147486a

#compose container
docker-compose -f ./docker-compose.yml -p container_sonarq up

#http://localhost:9000
Login: admin
Password: bitnami

####
dotnet tool install --global dotnet-sonarscanner

dotnet sonarscanner begin /k:"project-key" /d:sonar.login="<token>"
dotnet build <path to solution.sln>
dotnet sonarscanner end /d:sonar.login="<token>"

####


dotnet tool install --global dotnet-sonarscanner

dotnet sonarscanner begin /k:"engsoft-qualidadecodigo-v1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="654ad2cf9887e4a8dbf30f139a8c6416e6ee305e" /d:sonar.cs.opencover.reportsPaths="./NetcoreV3.SonarQ.Tests/coverage_result/coverage.opencover.xml"
dotnet build
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput="./coverage_result/"
dotnet sonarscanner end /d:sonar.login="654ad2cf9887e4a8dbf30f139a8c6416e6ee305e"
