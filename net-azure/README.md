# Projeto Trilha .NET - Desafio Azure

Este projeto foi desenvolvido como parte da trilha de aprendizado .NET e Azure, utilizando uma API Web desenvolvida em C# para realizar operações de CRUD sobre dados de funcionários. O projeto faz uso de **SQL Server** como banco de dados, **Azure Table Storage** para o armazenamento de logs, e está hospedado no **Azure App Service** para facilitar o gerenciamento e a escalabilidade da aplicação.

## Tecnologias Utilizadas

- **.NET 6.0**: Framework para desenvolvimento da API.
- **Entity Framework Core**: Ferramenta ORM (Object-Relational Mapping) para realizar operações no banco de dados SQL Server.
- **Azure Table Storage**: Serviço de armazenamento não relacional para manter logs das operações realizadas.
- **Azure App Service**: Serviço de hospedagem da aplicação.
- **SQL Server**: Banco de dados utilizado para armazenar as informações dos funcionários.

## Funcionalidades

O projeto possui as seguintes funcionalidades:

1. **CRUD de Funcionários**: A aplicação permite criar, ler, atualizar e deletar dados de funcionários no banco de dados SQL Server.
2. **Logs em Azure Table Storage**: A cada operação (criação, atualização, remoção) realizada na base de dados, é criado um log no Azure Table Storage.
3. **Swagger**: Documentação interativa da API utilizando Swagger UI.
   
## Configurações Necessárias

### Conexões
Para que o projeto funcione corretamente, é necessário configurar as strings de conexão tanto para o banco de dados SQL Server quanto para o Azure Table Storage. Essas informações devem ser inseridas no arquivo `appsettings.json` da seguinte forma:

```json
{
  "ConnectionStrings": {
    "ConexaoPadrao": "Server=localhost\\sqlexpress;Database=MeuBanco;Trusted_Connection=True;",
    "SAConnectionString": "DefaultEndpointsProtocol=https;AccountName=seu_account_name;AccountKey=seu_account_key;TableEndpoint=seu_endpoint",
    "AzureTableName": "FuncionarioLog"
  }
}
```
