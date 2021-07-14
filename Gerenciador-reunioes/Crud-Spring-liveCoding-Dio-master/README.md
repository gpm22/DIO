# Servidor do gerenciador de salas de reunioes

## Descrição

API com Spring Boot para gerenciar salas de reunião, utilizando o Spring Data para persistência de dados e o banco in-memory H2. 

## Stack utilizada:


 * Spring Web
 * Spring Data JPA
 * H2 Database
 * Java 8
 * Maven

## Endpoints criados na API

* Criar sala de reuniao
POST - /api/v1/rooms

* Listar todas as salas
GET - /api/v1/rooms

* Buscar uma sala pelo Id
GET - /api/v1/rooms/{id}

* Atualizar uma sala pelo Id
PUT - /api/v1/rooms/{id}

* Excluir uma sala pelo id
DELETE - /api/v1/rooms/{Id})



 
