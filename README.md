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

---

## ❓ Perguntas e Respostas do Processo Seletivo

### 📍 A solução deve ser disponibilizada em Cloud ou On-premise?

Considero a **Cloud** a melhor solução. Com ela, temos uma ótima flexibilidade de acesso à aplicação e evitamos todas as complicações com permissões e acessos remotos que teríamos em uma rede local. A principal vantagem do ambiente on-premise seria a segurança de uma rede fechada e o controle direto da base de dados, mas, no meu ponto de vista, em todos os demais aspectos a Cloud ainda leva vantagem.

---

### 👥 Considerando a participação de 4 pessoas técnicas para o desenvolvimento dessa solução, qual ferramenta acredita ser apropriada para o controle de tarefas da equipe? A ferramenta é ágil?

A ferramenta que eu consideraria mais apropriada seria o **Jira**, devido à sua maturidade e à praticidade no uso de metodologias ágeis, como Kanban e Scrum. O Jira também possui integração com repositórios Git via *Jira Automation* e com outras ferramentas como o **Confluence**, facilitando a documentação do projeto.  
Como alternativa, sugeriria o **Trello**, por motivos semelhantes, apesar de suas limitações em projetos mais robustos.

---

### 🧑‍💼 Você se sente capaz de liderar esta equipe? Por quê?

Sim, tenho boas experiências atuando como desenvolvedor no ambiente fabril, acostumado a cumprir prazos, trabalhar com metas e manter contato direto com clientes. Me considero uma pessoa com boas habilidades de comunicação e com facilidade para interagir com a equipe. Seria uma experiência nova para mim, mas com certeza eu daria o meu melhor para atender às expectativas!

---

### 💡 Se pudesse sugerir uma melhoria, mudança ou oportunidade, o que seria?

Considerando o desafio entregue, acredito que haveria muitas melhorias a serem feitas caso a aplicação fosse destinada a um ambiente real. A começar pela ausência de um banco de dados persistente, já que foi utilizado o **InMemory** apenas para fins de teste. Além disso, seria necessária a implementação completa dos processos de CRUD e outras funcionalidades importantes para que a aplicação pudesse ser considerada um produto escalável e pronto para produção.

---

### 🎯 Acha válido esse desafio para o processo que está participando?

Acho o teste válido e interessante, principalmente por avaliar as noções técnicas do candidato, seus conhecimentos de lógica de programação e arquitetura de software. O desafio também deixa espaço para a criatividade e expertise do desenvolvedor, permitindo que ele entregue uma solução simples, porém bem estruturada, alinhada com o proposto.



