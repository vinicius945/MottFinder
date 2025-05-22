🛠️ API para Gerenciamento de Armazém de Motos
API desenvolvida em ASP.NET Core para controlar o estoque e a localização precisa de motos em um armazém. Permite cadastrar, consultar, atualizar e remover informações sobre as motos, facilitando o gerenciamento e organização do espaço.

🚀 Tecnologias Utilizadas

ASP.NET Core

Entity Framework Core

Oracle / SQL Server

Swagger 

Este projeto é uma API RESTful desenvolvida com ASP.NET Core, que implementa operações básicas de CRUD para gerenciar recursos de forma simples e eficiente.

Funcionalidades
Criação, leitura, atualização e exclusão de dados

Validação e tratamento de erros

Integração com banco de dados relacional (ex: Oracle, SQL Server)

Documentação automática da API com Swagger

Padrões de projeto para código limpo e manutenível

🛠️ Endpoints principais
GET /motos → Lista todas as motos
GET /motos/{id} → Consulta moto por ID
POST /motos → Cadastra uma nova moto
PUT /motos/{id} → Atualiza informações de uma moto
DELETE /motos/{id} → Remove uma moto


📌 Entidades Principais
🛵 Moto (TB_MOTO)
ID_MOTO: int

NM_MODELO: string

DS_LOCALIZACAO: string

ST_MOTO: string (Pronto ou Quebrado)

🎥 Camera (TB_CAMERA)
ID_CAMERA: int

DS_POSICAO: string

ID_MOTO: FK para a moto

📍 GPS (TB_GPS)
ID_GPS: int

NR_LATITUDE: string

NR_LONGITUDE: string

ID_MOTO: FK para a moto

🔁 Endpoints da API
Verbo	Rota	Descrição
GET	/api/moto	Lista todas as motos
GET	/api/moto/{id}	Retorna uma moto por ID
POST	/api/moto	Cria uma nova moto
PUT	/api/moto/{id}	Atualiza os dados de uma moto
DELETE	/api/moto/{id}	Remove uma moto
GET	/api/camera	Lista todas as câmeras
GET	/api/camera/{id}	Retorna uma câmera por ID
POST	/api/camera	Cadastra uma nova câmera
PUT	/api/camera/{id}	Atualiza uma câmera
DELETE	/api/camera/{id}	Remove uma câmera
GET	/api/gps	Lista todos os registros de GPS
GET	/api/gps/{id}	Retorna um registro GPS por ID
POST	/api/gps	Cadastra uma nova coordenada GPS
PUT	/api/gps/{id}	Atualiza uma coordenada GPS
DELETE	/api/gps/{id}	Remove uma coordenada GPS
