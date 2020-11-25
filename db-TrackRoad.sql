CREATE DATABASE TrackRoad;
DROP DATABASE TrackRoad;

USE TrackRoad;

CREATE TABLE Usuarios (
	Id          INT             IDENTITY(1,1)   PRIMARY KEY,    -- Identificador do usuário
	[Login]     VARCHAR(30)     NOT NULL,                       -- Login do usuário
	[Password]  VARCHAR(10)     NOT NULL,                       -- Senha do usuário
	Email       VARCHAR(50)     NOT NULL,                       -- E-mail do usuário
	Tipo    	INT             NOT NULL                        -- Tipo de usuário
);

CREATE TABLE Clientes (
    Id          INT             IDENTITY(1,1)   PRIMARY KEY,    -- Identificador do cliente
	Nome        VARCHAR(50)     NOT NULL,                       -- Nome do cliente
	RazSoc      VARCHAR(50)     NOT NULL,						-- Razão social do cliente
	Cnpj        VARCHAR(14)     NOT NULL,                       -- CNPJ do cliente
	RamAtiv     VARCHAR(20)     NULL,							-- Ramo de atividade do cliente
	Endereco    VARCHAR(50)     NULL,                           -- Endereço do cliente
	Bairro      VARCHAR(25)     NULL,                           -- Bairro do cliente
	Numero      INT             NULL,                           -- Número do cliente
	Cidade      VARCHAR(30)     NULL,                           -- Cidade do cliente
	Estado      VARCHAR(2)      NULL,                           -- Estado do cliente
	Cep         INT             NULL                            -- CEP do cliente
);

CREATE TABLE Contratos	(   
	Id          INT             IDENTITY(1,1)   PRIMARY KEY,	-- Identificador do contrato
	Cliente     INT             NOT NULL,						-- Cliente ligado ao contrato (id do cliente)
	Emp     	VARCHAR(20)     NOT NULL,						-- Ramo de atividade do cliente
	Valor     	VARCHAR(10)     NOT NULL,						-- Valor do contrato acordado com o cliente
	Doc     	VARBINARY(max)  NOT NULL,						-- Imagem do contrato
	FOREIGN KEY (Cliente) REFERENCES Clientes(Id)
);

CREATE TABLE Combustiveis (
	Id          	INT             IDENTITY(1,1)   PRIMARY KEY,	-- Identificador do combustível
	Nome    	VARCHAR(10)     NOT NULL,						-- Tipo de combustível (Gasolina, Diesel, Álcool)
	Preco  		VARCHAR(5)      NULL							-- Preço por litro de combustível
);  

CREATE TABLE Motoristas	(   
	Id          INT             IDENTITY(1,1)   PRIMARY KEY,	-- Identificador do motorista
	Nome        VARCHAR(50)     NOT NULL,						-- Nome do usuário de rebite
	Cnh         INT             NOT NULL,						-- CNH do motorista
	TipVeic     VARCHAR(10)     NOT NULL,						-- Tipo de veículo que o motorista possui (carro, van, caminhão, perua)
	ModVeic     VARCHAR(20)     NULL,							-- Modelo do veículo
	MarcVeic    VARCHAR(15)     NULL,							-- Marca do veículo
	AnoFab      INT             NULL,							-- Ano de fabricação do veículo
	TipCom      INT             NOT NULL,						-- Tipo de combustível que o veículo utiliza (id do combustível)
	KmLitro     VARCHAR(5)      NOT NULL,						-- Definição da quilometragem que o veículo faz por litro de combustível
	FOREIGN KEY (TipCom) REFERENCES Combustiveis(id)
);

CREATE TABLE Viagens (
	Id          INT             IDENTITY(1,1)   PRIMARY KEY,	-- Identificador da viagem
	TotDist     FLOAT     		NULL,							-- Distancia total da viagem da origem até o destino
	Motorista   INT             NOT NULL,						-- Identificador do motorista responsável pela viagem (id do motorista)
	EndDest     VARCHAR(50)     NOT NULL,						-- Endereço do destino (nome da Rua, Avenida, etc.)
	NumDest     INT             NOT NULL,						-- Número do endereço do destino
	BaiDest     VARCHAR(25)     NOT NULL,						-- Bairro do destino
	CidDest     VARCHAR(50)     NOT NULL,						-- Cidade do destino
	EstDest     VARCHAR(2)      NOT NULL,						-- Estado do destino
	CepDest     VARCHAR(10)     NOT NULL,						-- CEP do destino
	FOREIGN KEY (Motorista) REFERENCES Motoristas(id)
);