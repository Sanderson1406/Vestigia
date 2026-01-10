# Vestigia API

API backend do projeto **Vestigia**, desenvolvida em **ASP.NET Core**, seguindo boas práticas de organização, escalabilidade e documentação automática com **Swagger**.

---

## Visão Geral

A **Vestigia API** é responsável por fornecer serviços REST para o gerenciamento das funcionalidades do sistema Vestigia, atuando como camada central de negócio e integração com o frontend.

O projeto está estruturado visando:
- Clareza de responsabilidades
- Facilidade de manutenção
- Evolução futura para Clean Architecture

---

## Tecnologias Utilizadas

- **.NET 9**
- **ASP.NET Core Web API**
- **Swagger / OpenAPI (Swashbuckle)**
- **C#**
- **HTTP/REST**
- **JSON**

---

## Estrutura do Projeto

Vestigia
│
├── src
│ └── Vestigia.API
│ ├── Controllers
│ ├── Properties
│ │ └── launchSettings.json
│ ├── Program.cs
│ └── Vestigia.API.csproj
│
├── README.md
└── Vestigia.sln

A estrutura será expandida futuramente para camadas como **Application**, **Domain** e **Infrastructure**, seguindo os princípios de **Clean Architecture** e **DDD**.

---

## Como Executar o Projeto

### Pré-requisitos

- **.NET SDK 9.0 ou superior**
- Visual Studio 2022, VS Code ou outro editor compatível


### Executando localmente

1. Clone o repositório:
```bash
git clone <url-do-repositorio>
```

2. Acesse a pasta da API:
```bash
cd src/Vestigia.API
```

3. Execute o projeto:
```bash
dotnet run
```

---

## Documentação da API (Swagger)

Após executar o projeto, acesse no navegador:

```bash
https://localhost:<porta>/swagger
```
---

## Padrões e Boas Práticas

- Arquitetura RESTful
- Separação de responsabilidades
- Código preparado para escalabilidade
- Documentação automática de endpoints
- Base para aplicação de Clean Architecture e DDD

--- 

## Próximos Passos Planejados

- Estruturação completa em Clean Architecture
- Criação da camada Domain
- Implementação da camada Application
- Persistência de dados com Entity Framework Core
- Autenticação e autorização
- Versionamento da API

---

## Autor

Sanderson de Oliveira Machado
Estudante de Ciência da Computação
Desenvolvedor Backend (.NET / Go)