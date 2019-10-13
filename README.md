# Exemplo: utilizando ADO para realizar consultas em uma tabela no SQL Server

O exemplo neste repositório demostra como utilizar classes do ADO para retornar dados de uma tabela do SQL Server.

## Explicando o código

Basicamente o exemplo consiste em apenas 2 classes, Database e Client.

A classe Client é utilizada no exemplo apenas para mapear os dados obtidos através da instrução SELECT.

A classe Database possui um método chamado ObterClientes. O método retorna uma lista de clientes, a classe List auxilia na criação de uma coleção de clients.

Obs: para testar esse exemplo é necessário configurar a string de conexão do SQL Server no config da aplicação (web.config em aplicações web ou app.config em aplicações console ou windows).

## Como consumir a classe

var db = new Database();

var dados = db.ObterClientes();

## Perfil no Linkedin

[Lucas Batista de Deus](https://www.linkedin.com/in/lucas-batista-8395a7186/)
