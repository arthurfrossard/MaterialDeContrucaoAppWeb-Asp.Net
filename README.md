# Loja de Materiais de Construção - Aplicação Web

Este é um projeto de uma aplicação web para uma loja de materiais de construção, desenvolvido em C# utilizando ASP.NET Core, Entity Framework Core e Razor Pages. A aplicação permite aos usuários visualizar os produtos disponíveis para compra e, caso estejam logados, ter acesso completo ao CRUD (Create, Read, Update, Delete) dos produtos.

## Funcionalidades

- Visualização de produtos disponíveis na loja
- Autenticação de usuários para acesso exclusivo
- CRUD de produtos para usuários autenticados
- Gerenciamento eficiente do estoque da loja

## Tecnologias Utilizadas

- C# (linguagem de programação)
- ASP.NET Core (framework web)
- Entity Framework Core (ORM para interação com banco de dados)
- Razor Pages (tecnologia para criação de páginas web dinâmicas)
- HTML/CSS/JavaScript (tecnologias web para criação de interfaces interativas)

## Como Usar

1. Clone este repositório para sua máquina local.
2. Certifique-se de ter o SDK do .NET Core instalado em sua máquina.
3. Abra o projeto em seu ambiente de desenvolvimento preferido.
4. Configure a conexão com o banco de dados no arquivo `appsettings.json`.
5. No terminal, execute o comando `dotnet ef database update` para criar o banco de dados com as migrações fornecidas.
6. Execute a aplicação usando o comando `dotnet run`.
7. Acesse a aplicação em seu navegador através do endereço `http://localhost:5000`.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue para relatar problemas ou sugerir melhorias. Se deseja contribuir diretamente, por favor, abra um pull request com suas alterações.

## Licença

Este projeto está licenciado sob a [MIT License](https://opensource.org/licenses/MIT).
