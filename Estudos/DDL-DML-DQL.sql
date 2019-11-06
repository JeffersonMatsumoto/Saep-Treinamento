--DDL------------------------------------------------------------------------------------------------------------------------------------

CREATE DATABASE JeffThings
--DROP DATABASE JeffThings
--DROP TABLE JOGOS
--DROP TABLE PLATAFORMAS
--DROP TABLE JOGOS_PLATAFORMAS

USE JeffThings

--ALTER TABLE USUARIOS ADD NOME varchar(250) NOT NULL;
CREATE TABLE USUARIOS (
--IDENTITY [ (seed , increment) ] --PADRÃO/DEFAULT(1,)
--seed = É o valor usado para a primeira linha carregada na tabela.
--increment = É o valor de incremento adicionado ao valor de identidade da linha anterior que foi carregada. 
	ID INT IDENTITY(1000, 1) PRIMARY KEY
	, NOME VARCHAR(250) NOT NULL
	, EMAIL VARCHAR(250) NOT NULL UNIQUE
	, SENHA VARCHAR(250) NOT NULL 
)

CREATE TABLE TIPOS_JOGOS (
	ID TINYINT IDENTITY --TINYINT 0 ATÉ 255
	, NOME VARCHAR(50) NOT NULL
	PRIMARY KEY(ID)
)

CREATE TABLE PLATAFORMAS (
	ID TINYINT IDENTITY PRIMARY KEY
	, NOME VARCHAR(50) NOT NULL
)

CREATE TABLE JOGOS_PLATAFORMAS (
	ID INT IDENTITY PRIMARY KEY
	, ID_JOGO INT NOT NULL FOREIGN KEY REFERENCES JOGOS(ID)
	, ID_PLATAFORMA TINYINT NOT NULL FOREIGN KEY REFERENCES	PLATAFORMAS(ID)
)

CREATE TABLE JOGOS (
	ID INT IDENTITY(100,1) PRIMARY KEY
	, NOME VARCHAR(100) NOT NULL UNIQUE
	, DATA_LANCAMENTO DATE NOT NULL
	, DESCRICAO TEXT NOT NULL
	, PRECO SMALLMONEY NOT NULL
	-- 0 = FALSE / 1 = TRUE
	, COOP BIT NOT NULL DEFAULT (0) 
	, TIPOS_JOGOS_ID TINYINT NOT NULL FOREIGN KEY (TIPOS_JOGOS_ID) REFERENCES TIPOS_JOGOS(ID)
	--, PLATAFORMAS_ID TINYINT NOT NULL FOREIGN KEY (PLATAFORMAS_ID) REFERENCES PLATAFORMAS(ID)
)
--ALTER TABLE JOGOS DROP COLUMN PLATAFORMAS_ID

--DML------------------------------------------------------------------------------------------------------------------------------------

BULK INSERT USUARIOS
FROM 'C:\Planilhas\usuarios.csv'
WITH (
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2,
	CODEPAGE = 'acp'
)

INSERT INTO TIPOS_JOGOS VALUES 
('Aventura')
, ('Fps')
, ('Rpg')
, ('Corrida')

INSERT INTO PLATAFORMAS VALUES
('Xbox')
, ('Ps4')
, ('Pc')
--UPDATE PLATAFORMAS SET NOME = 'XboxOne' WHERE ID = 1

INSERT INTO JOGOS_PLATAFORMAS VALUES
(100,1), (100,2)
, (101,1), (101,2)
, (102,1), (102,2)

INSERT INTO JOGOS VALUES 
	('RD2','26/10/2018'
		 ,'America, 1899. The end of the Wild West era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee. With federal agents and the best bounty hunters in the nation massing on their heels, the gang must rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal divisions threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang who raised him.'
		 , '349,90'
		 , 0
		 , 2
	 )
 ,
	 ('Dragon Age: Inquisition','18/11/2014'
		 ,'Quando o céu se rasga e o caos desaba sobre a terra, o mundo precisa de heróis. Torne-se o salvador ou a salvadora de Thedas no Dragon Age: Inquisition. Você é o Inquisidor ou a Inquisidora com a obrigação de salvar o mundo de si mesmo.'
		 , '59,99'
		 , 0
		 , 3
	 )
 ,
	('Crash Team Racing Nitro-Fueled','20/06/2019'
		 ,'Crash is back in the driver’s seat! Get ready to go fur-throttle with Crash™ Team Racing Nitro-Fueled. It’s the authentic CTR experience plus a whole lot more, now fully-remastered and revved up to the max.'
		 , '139,41'
		 , 1
		 , 4
	 )

----DELETAR CONTEÚDO DA TABELA 
--DELETE FROM USUARIOS
--OU
--TRUNCATE TABLE USUARIOS

--DQL------------------------------------------------------------------------------------------------------------------------------------

SELECT * FROM USUARIOS
SELECT * FROM PLATAFORMAS
SELECT * FROM TIPOS_JOGOS
SELECT * FROM JOGOS
SELECT * FROM JOGOS_PLATAFORMAS

--USE JEFFTHINGS

--INSERT INTO TIPOS_JOGOS VALUES ('Esportes')

--alter table JOGOS add PRECO decimal

--SELECT * FROM JOGOS

--UPDATE JOGOS
--SET PRECO = 170.00 WHERE ID=102

--Scaffold-DbContext "Server=.\SQLExpress;Database=JeffThings;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domains