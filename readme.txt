
#download VSCode
https://code.visualstudio.com/download

#donwload netcore sdk
https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-3.1.410-windows-x64-installer

#download docker
https://docs.docker.com/desktop/windows/install/

#donwload insominia
https://insomnia.rest/download


#Extensao recomendadas
ms-dotnettools.csharp
dotnet-test-explorer

#verificar versao do netcore instalada (o retorno do comando deve listar a versão 3.1)
dotnet --list-sdks

#Abrir Terminal do VSCode
ctrl + '


#[na pasta raiz do projeto] criar projeto console app
mkdir NetcoreV3.SonarQ.Apps
cd ./NetcoreV3.SonarQ.Apps
dotnet new classlib -f netcoreapp3.1

#[na pasta raiz do projeto] criar projeto web
mkdir NetcoreV3.SonarQ.Api
cd ./NetcoreV3.SonarQ.Api
dotnet new web -f netcoreapp3.1

#[na pasta raiz do projeto] criar projeto test
mkdir NetcoreV3.SonarQ.Tests
cd ./NetcoreV3.SonarQ.Tests
dotnet new mstest -f netcoreapp3.1

#[na pasta raiz do projeto] adiciona referencia do projeto apps no projeto de tests
dotnet add .\NetcoreV3.SonarQ.Api.csproj reference ..\NetcoreV3.SonarQ.Apps\NetcoreV3.SonarQ.Apps.csproj
dotnet add .\NetcoreV3.SonarQ.Tests.csproj reference ..\NetcoreV3.SonarQ.Apps\NetcoreV3.SonarQ.Apps.csproj

#[na pasta raiz do projeto] add arquivos solucao
dotnet sln .\NetcoreV3.SonarQ.sln add .\NetcoreV3.SonarQ.Apps\NetcoreV3.SonarQ.Apps.csproj
dotnet sln .\NetcoreV3.SonarQ.sln add .\NetcoreV3.SonarQ.Api\NetcoreV3.SonarQ.Api.csproj
dotnet sln .\NetcoreV3.SonarQ.sln add .\NetcoreV3.SonarQ.Tests\NetcoreV3.SonarQ.Tests.csproj


# baixar imagem docker
docker pull sonarqube
docker run --name engsof_sonarq -d -p 9000:9000 sonarqube

# adicionar o scanner para o netcore de forma global
dotnet tool install --global dotnet-sonarscanner

# apos rodar o conainter do sonar abrir o endereço http://localhost:9000
Login: admin
Password: admin

#Crie nova senha : admin123
#Crie um projeto, na tela do projeto selecione o opção Manual
#Informe um nome para o projeto, ex: engsoft-analisesonar
#Informe nome para o token, ex: engsoft-analisesonar-token
#Copie e guarde esse codigo

#ad74dec81eec1b8ffe8af8e65045581d041be495

# exemplo execução scanner sonar
dotnet sonarscanner begin /k:"project-key" /d:sonar.login="<token>"
dotnet build <path to solution.sln>
dotnet sonarscanner end /d:sonar.login="<token>"

####
dotnet sonarscanner begin /k:"engsoft-analisesonar" /d:sonar.login="a901b9af9f47b3286fa457e66f73b412c54a757c" /d:sonar.host.url="http://localhost:9000" /d:sonar.cs.opencover.reportsPaths="./NetcoreV3.SonarQ.Tests/coverage_result/coverage.opencover.xml"
dotnet build
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput="./coverage_result/"
dotnet sonarscanner end /d:sonar.login="a901b9af9f47b3286fa457e66f73b412c54a757c"

