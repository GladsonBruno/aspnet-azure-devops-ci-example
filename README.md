[![Build Status](https://gladsonbruno16.visualstudio.com/Portfolio_DevOps/_apis/build/status/AspNet-AzureDevOps-CI-Example?repoName=GladsonBruno%2Faspnet-azure-devops-ci-example&branchName=master)](https://gladsonbruno16.visualstudio.com/Portfolio_DevOps/_build/latest?definitionId=10&repoName=GladsonBruno%2Faspnet-azure-devops-ci-example&branchName=master)

# Visão Geral
Projeto de exemplo criado apenas para fins de exemplificação de automação DevOps com Azure DevOps.

Estará contemplado:

* Scan SonarCloud - OK
* Teste unitário - OK
* Code Coverage - OK
* Build de container - OK
* Teste de container - OK
* Pipeline templatizada - OK

Link do projeto template utilizado referenciado neste projeto: [azure-template-pipelines](https://github.com/GladsonBruno/azure-template-pipelines)

## Execução Local
Execute o seguinte comando para execução local:
```
dotnet restore
dotnet run --project aspnet-demo-api
```

## Execução em container
Existe a possibilidade de executar o projeto no Visual Studio através do Dockerfile contido em [**aspnet-demo-api/Dockerfile**](./aspnet-demo-api//Dockerfile).

Também existe outro Dockerfile destinado ao CI que se encontra na pasta raiz do repositório, o mesmo espera que o projeto já tenha sido compilado previamente ( ponto este que difere do Dockerfile contido em [**aspnet-demo-api/Dockerfile**](./aspnet-demo-api//Dockerfile)).

Para utilizar o segundo Dockerfile manualmente execute os seguintes comandos para realizar o build do container final da aplicação:
```
dotnet restore
dotnet build "aspnet-demo-api/aspnet-demo-api.csproj" -c Release -o ./app/build
dotnet publish "aspnet-demo-api/aspnet-demo-api.csproj" -c Release -o ./app/publish /p:UseAppHost=false
docker build -t aspnet-demo-api:latest .
docker run --rm -it -p 8080:8080 aspnet-demo-api:latest
```

## Execução em produção
Para executar em produção execute os seguintes comandos:
```
dotnet restore
dotnet build "aspnet-demo-api/aspnet-demo-api.csproj" -c Release -o ./app/build
dotnet publish "aspnet-demo-api/aspnet-demo-api.csproj" -c Release -o ./app/publish /p:UseAppHost=false
dotnet ./app/publish/aspnet-demo-api.dll
```