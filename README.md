# MarkfyAPI - .NET

## Membros do Grupo

- Kayque Lima - RM550782
- Bruno de Paula - RM552226
- Edward Lima - RM98626
- Gabriel França - RM551905

## Arquitetura da API

Este projeto é um micro serviço desenvolvido em .NET, utilizando o padrão de design MVC (Model-View-Controller).

Principais componentes da arquitetura:

1. *Model (M)*: Responsável por representar a lógica de negócios e os dados da aplicação. No contexto desta API, o model define as entidades que serão usadas para estruturar e manipular os dados provenientes de fontes como banco de dados ou outros serviços.
2. *View (V)*: No caso de uma API, o “View” é frequentemente substituído pela camada de respostas da API (geralmente no formato JSON). Esta camada é responsável por retornar dados ao cliente que consome a API, como resultado das operações realizadas nas rotas.
3. *Controller (C)*: O controller atua como intermediário entre as camadas de Model e View. Ele recebe as requisições dos clientes (clientes HTTP, como navegadores ou outras APIs), processa-as de acordo com a lógica de negócios (definida no Model) e retorna a resposta correspondente.

### Fluxo de Requisição na API:

1. Cliente faz uma requisição HTTP (GET, POST, PUT, DELETE) para a API.
2. Controller manipula a requisição, chamando a lógica necessária e acessando os dados via Model.
3. Camada de serviços processa e retorna os dados ou a resposta apropriada ao Controller.
4. Controller retorna a resposta formatada (geralmente em JSON) para o cliente.

## Tecnologias Utilizadas

- *ASP.NET Core* para a criação da API.
- *Entity Framework Core* para manipulação e persistência de dados.
- *Oracle DataBase* Armazenar os dados. 
- *Swagger* para documentação interativa e testes das rotas da API.

## Instruções para Rodar o Projeto Localmente

### Requisitos

- .NET SDK instalado (versão mínima: 6.0)
- Visual Studio (opcional)
- CLI do .NET

### Executando o projeto com Visual Studio

1. Clone o repositório em sua máquina local:

    bash
    git clone https://github.com/usuario/projeto-api.git
    

2. Abra o projeto no Visual Studio: Vá até o diretório do projeto clonado e abra o arquivo .sln (Solution).
3. Restaure as dependências: O Visual Studio irá automaticamente restaurar as dependências do projeto assim que o mesmo for aberto.
4. Configure a string de conexão: No arquivo appsettings.json, configure a string de conexão com o seu banco de dados, caso o projeto utilize um.
5. Executar o projeto: No Visual Studio, selecione o projeto e clique em Run ou pressione F5. A API será executada e você poderá acessá-la através do https://localhost:<porta>/swagger para testar as rotas via Swagger.

### Executando o projeto sem Visual Studio (via CLI)

1. Clone o repositório em sua máquina local:

    bash
    git clone https://github.com/usuario/projeto-api.git
    

2. Navegue até o diretório do projeto:

    bash
    cd projeto-api
    

3. Restaurar dependências:

    bash
    dotnet restore
    

4. Executar o projeto:

    bash
    dotnet run
    

5. Acessar a API: Após a execução, a API estará disponível em https://localhost:7012/swagger/index.html, onde você poderá testar suas rotas via Swagger.


## Notas

- Certifique-se de que o banco de dados está corretamente configurado, se necessário.
- Para testes locais, utilize o Swagger que estará disponível via /swagger/index.html na URL local.
