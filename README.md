# API de Gestão de Biblioteca 📚

![Status](https://img.shields.io/badge/status-conclu%C3%ADdo-green)
![.NET](https://img.shields.io/badge/.NET-9.0-blueviolet)
![Docker](https://img.shields.io/badge/Docker-blue)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-darkblue)

API RESTful desenvolvida em C# com .NET 9 para gerenciar o catálogo de livros de uma biblioteca. O projeto foi totalmente containerizado com Docker, garantindo um ambiente de desenvolvimento e produção consistente e isolado.

Este projeto foi construído como parte de um estudo de desenvolvimento back-end, focando em boas práticas de API RESTful, interação com banco de dados usando Entity Framework Core e a criação de um ambiente de desenvolvimento moderno com Docker.

---

## ✨ Features

- ✅ **CRUD Completo** para a entidade de Livros.
- ✅ **Listagem** de todos os livros cadastrados.
- ✅ **Busca** de um livro específico pelo seu ID.
- ✅ **Criação** de um novo livro.
- ✅ **Atualização** completa de um livro existente.
- ✅ **Remoção** de um livro do catálogo.

---

## 🚀 Tecnologias Utilizadas

- **C# & .NET 9:** Plataforma e linguagem para a construção da API.
- **Entity Framework Core:** ORM para comunicação com o banco de dados de forma produtiva.
- **PostgreSQL:** Banco de dados relacional para armazenamento dos dados.
- **Docker & Docker Compose:** Para a containerização da aplicação e do banco de dados.

---

## ⚙️ Como Executar o Projeto

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina:
- [.NET 9 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/9.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

### Passo a Passo

1. Clone este repositório:
   ```bash
   git clone https://github.com/kauansantanaa/Gestao-de-Biblioteca
   ```

2. Navegue até a pasta raiz do projeto:
   ```bash
   cd nome-da-pasta-do-projeto
   ```

3. Suba os containers com Docker Compose. O comando `--build` garante que a imagem da API será construída:
   ```bash
   docker-compose up --build
   ```

4. A API estará disponível para ser consumida no endereço: `http://localhost:8080`

---

## 📖 Endpoints da API

Abaixo estão todos os endpoints disponíveis na aplicação.

| Verbo HTTP | Rota                  | Descrição                           | Corpo (Body) de Exemplo (para POST e PUT)                                                  |
|------------|-----------------------|---------------------------------------|--------------------------------------------------------------------------------------------|
| `GET`      | `/api/livros`         | Lista todos os livros.                | N/A                                                                                        |
| `GET`      | `/api/livros/{id}`    | Busca um livro específico pelo ID.    | N/A                                                                                        |
| `POST`     | `/api/livros`         | Cria um novo livro.                   | `{"titulo": "O Guia do Mochileiro das Galáxias", "autor": "Douglas Adams", "isbn": "978-8575422464", "anoPublicacao": 1979}` |
| `PUT`      | `/api/livros/{id}`    | Atualiza um livro existente.          | `{"id": "seu-guid-aqui", "titulo": "Novo Título", "autor": "...", "isbn": "...", "anoPublicacao": 2025}` |
| `DELETE`   | `/api/livros/{id}`    | Apaga um livro pelo ID.               | N/A                                                                                        |