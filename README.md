# 📦 Sistema de Estoque e Vendas

### ASP.NET MVC 5 | .NET Framework 4.5.2 | C# | Entity Framework 5 | SQL Server

O **Sistema de Estoque e Vendas** é uma aplicação web desenvolvida em C# utilizando ASP.NET MVC, voltada ao gerenciamento de produtos e fornecedores, com persistência de dados em SQL Server.

O projeto representa uma etapa da minha trajetória no desenvolvimento de software, com foco na aplicação de conceitos de programação orientada a objetos, organização de código, acesso a dados e construção de aplicações web no ecossistema Microsoft.

---

## 🛠️ Tecnologias utilizadas

| Tecnologia | Versão / utilização |
|---|---|
| C# | Linguagem de programação |
| .NET Framework | **4.5.2** |
| ASP.NET MVC | **5.2.3** |
| Entity Framework | **5.0.0** |
| SQL Server | Banco de dados relacional |
| Razor | Construção das interfaces MVC |
| Bootstrap | 3.0.0 |
| jQuery | 1.10.2 |
| Visual Studio | Ambiente de desenvolvimento |
| Git / GitHub | Versionamento de código |

**Nota:** esta aplicação utiliza o .NET Framework clássico, não ASP.NET Core. As versões foram identificadas nos arquivos de configuração do projeto original.

---

## 🏗️ Arquitetura e organização

O sistema foi estruturado utilizando o padrão **MVC (Model-View-Controller)**, com uma camada adicional de acesso a dados.

### Model

Contém as classes que representam os dados da aplicação, incluindo produtos, fornecedores, clientes, pedidos e usuários.

Também utiliza classes de metadados para definição de validações.

### View

Responsável pela apresentação das interfaces ao usuário, utilizando Razor, HTML, CSS, Bootstrap e JavaScript.

### Controller

Recebe as requisições, coordena os fluxos de navegação e utiliza as classes de acesso a dados para executar operações.

### DAO — Data Access Object

Concentra as operações de persistência, separando as consultas e alterações no banco de dados dos controllers.

### Entity Framework

O mapeamento do banco utiliza um modelo EDMX, característico da abordagem **Database First**, com geração de entidades e contexto a partir do modelo de dados.

---

## 📦 Funcionalidades implementadas

### Gerenciamento de produtos

- Cadastro de produtos.
- Listagem de produtos registrados.
- Consulta de produto por identificador.
- Edição de informações.
- Exclusão de produtos.
- Associação de produtos a fornecedores.
- Validação de campos obrigatórios.

As informações do produto incluem nome, quantidade, quantidade por caixa, valor e fornecedor associado.

### Gerenciamento de fornecedores

- Cadastro de fornecedores.
- Listagem de fornecedores.
- Consulta por identificador.
- Atualização de informações.
- Exclusão de registros.
- Validação de dados cadastrais.

O cadastro contempla informações como nome, endereço, telefone, e-mail e documento.

### Módulos estruturados

O projeto também contém entidades e controllers relacionados a:

- Clientes.
- Pedidos.
- Usuários.

Esses módulos fazem parte da estrutura original, mas os controllers publicados apresentam apenas ações básicas de navegação, sem fluxos completos de gerenciamento.

---

## ✅ Validação de dados

O projeto utiliza **Data Annotations** em classes de modelo, permitindo definir regras como obrigatoriedade de campos, limites de caracteres e validação de formato de e-mail.

Nos formulários de cadastro e edição, os controllers utilizam `ModelState.IsValid` para verificar as validações antes de persistir alterações.

Algumas operações POST também utilizam `ValidateAntiForgeryToken` para proteção contra falsificação de requisições.

---

## 📂 Estrutura do projeto

```text
SistemaEstoqueVendas/
├── App_Start/
│   └── RouteConfig.cs
├── Controllers/
│   ├── ClienteController.cs
│   ├── FornecedorController.cs
│   ├── HomeController.cs
│   ├── PedidoController.cs
│   ├── ProdutoController.cs
│   └── UsuarioController.cs
├── DAO/
│   ├── ClienteDAO.cs
│   ├── FornecedorDAO.cs
│   ├── PedidoDAO.cs
│   ├── ProdutoDAO.cs
│   └── UsuarioDAO.cs
├── Models/
│   ├── ModeloDeDados.edmx
│   ├── Produto.cs
│   ├── Fornecedor.cs
│   ├── Cliente.cs
│   ├── Pedido.cs
│   └── Usuario.cs
├── Views/
├── Content/
├── scripts/
├── Web.config
├── packages.config
└── SistemaEstoqueVendas.csproj
```

---

## ⚙️ Como executar

### Pré-requisitos

- Windows.
- Visual Studio com suporte a projetos ASP.NET MVC do .NET Framework clássico.
- .NET Framework 4.5.2 Developer Pack ou ferramentas de compilação compatíveis.
- SQL Server.
- Acesso à estrutura de banco de dados esperada pelo modelo EDMX.

### 1. Clonar o repositório

```bash
git clone https://github.com/JulianoFerreiraSilva/SistemaEstoqueVendas.git
```

### 2. Abrir a solução

Abra `SistemaEstoqueVendas.sln` no Visual Studio.

### 3. Restaurar as dependências

Restaure os pacotes NuGet definidos no arquivo `packages.config`, incluindo ASP.NET MVC e Entity Framework.

### 4. Configurar o banco de dados

Configure a conexão `EstoqueVendaDataBase` no arquivo `Web.config`, utilizando uma instância SQL Server e um banco compatível com o modelo da aplicação.

Não utilize credenciais reais em arquivos destinados à publicação.

Como o projeto utiliza Entity Framework Database First, a configuração do banco deve ser compatível com as entidades e relacionamentos definidos no EDMX.

### 5. Executar a aplicação

Compile a solução e execute-a pelo Visual Studio com IIS Express ou outro ambiente ASP.NET compatível.

**Observação:** por se tratar de uma aplicação legada, a execução pode exigir restauração de dependências e adaptação da configuração de banco de dados. Não há garantia de funcionamento imediato em ambientes modernos.

---

## 📚 Conceitos aplicados

O projeto demonstra conhecimentos relacionados a:

- Programação orientada a objetos.
- Desenvolvimento web com ASP.NET MVC.
- Separação de responsabilidades.
- Acesso a dados com DAO.
- Persistência com Entity Framework.
- Mapeamento relacional com Database First.
- Operações CRUD.
- Validações de formulários.
- Integração com SQL Server.
- Versionamento com Git.

---

## 📌 Contexto e evolução

Este repositório representa uma aplicação desenvolvida utilizando tecnologias do ecossistema .NET Framework clássico.

Sua manutenção como parte do portfólio permite demonstrar experiência com projetos MVC tradicionais e acompanhar a evolução técnica para abordagens mais modernas de desenvolvimento backend.

A experiência adquirida com ASP.NET MVC, Entity Framework e SQL Server contribuiu para o aprofundamento posterior em ASP.NET Core, APIs REST e arquiteturas organizadas em camadas.

### Projeto relacionado

**[Finance Core — API REST em .NET 8](https://github.com/JulianoFerreiraSilva/ApiFinanceCore)**

Projeto de controle financeiro desenvolvido com tecnologias mais recentes, incluindo ASP.NET Core 8, PostgreSQL, CQRS e autenticação JWT.

Os dois repositórios representam diferentes momentos de aprendizado e aplicação de tecnologias do ecossistema .NET.

---

## 👨‍💻 Autor

**Juliano Ferreira da Silva**

Desenvolvedor C# / .NET

GitHub: [JulianoFerreiraSilva](https://github.com/JulianoFerreiraSilva)

---

**Sistema de Estoque e Vendas — Projeto de portfólio desenvolvido com ASP.NET MVC 5 e .NET Framework 4.5.2.**
