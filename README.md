# Blazor CRUD

Este é um projeto de teste utilizando **Blazor** com .NET 8, implementando as seguintes funcionalidades:

- Cadastro de usuários  
- Visualização da lista de usuários  
- Login simulado com dados em memória

A persistência de dados utiliza o provedor **InMemory** do Entity Framework Core, ideal para testes e debug.

> ⚠️ **Observação**: Este projeto foi desenvolvido para fins de participação em um processo seletivo da **Bemol Digital**. Os estilos, logotipos e elementos visuais da aplicação foram inspirados no site oficial da empresa e são propriedades intelectuais da mesma.

---

## 📦 Tecnologias e Bibliotecas Utilizadas

### 🔧 Plataforma e Frameworks

- **.NET 8.0**
  - Plataforma para desenvolvimento da aplicação.
- **Blazor (Server side)**
  - Framework para construir aplicações web usando C# e Razor.

### 💾 Acesso a Dados

- **Entity Framework Core**
  - ORM (Object-Relational Mapper) para manipulação de dados via classes C#.
- **Microsoft.EntityFrameworkCore.InMemory**
  - Provedor de banco de dados em memória, ideal para testes ou protótipos sem necessidade de um banco real.
- **Microsoft.EntityFrameworkCore.Tools**
  - Ferramentas para suporte a migrações e geração de código com o EF Core.
- **Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore**
  - Fornece suporte a páginas de erro detalhadas relacionadas a operações do Entity Framework.

### 🧩 Componentes de Interface

- **Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter**
  - Componente de tabela para exibição de dados, com integração nativa com o EF Core.

### ⚙️ Ferramentas de Desenvolvimento

- **Microsoft.VisualStudio.Web.CodeGeneration.Design**
  - Suporte a **scaffolding** para geração  código (ex: models, pages).

### 🌐 Front-end

- **LibMan (Library Manager)**
  - Gerenciador de bibliotecas JavaScript/CSS.

---

## 🚀 Executando o Projeto

1. Clone o repositório:

```bash
git clone https://github.com/LRaziel/blazor-crud.git
```

Entrar dentro da pasta do repositório
```bash
cd blazor-crud
```

2. Executar o projeto:
```bash
docker-compose up -d
```

O projeto será executado via ***docker-compose*** para mais praticidade. 
Para login inicial no projeto, usar usuario padrão definido no código:
Email: ***lucas@mecontratapf.com***
Senha: ***123***
