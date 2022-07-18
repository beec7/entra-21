CREATE TABLE tipos_personagens(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	tipo VARCHAR(20));

CREATE TABLE editoras(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	apelido VARCHAR(20),
	nome VARCHAR(50),
	faturamento DECIMAL(13,2),
	data_criacao DATETIME2);

CREATE TABLE personagens(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_editora INTEGER,
	id_tipo_personagem INTEGER,

	nome VARCHAR(50),

	FOREIGN KEY(id_editora) REFERENCES editoras(id),
	FOREIGN KEY(id_tipo_personagem) REFERENCES tipos_personagens(id));


	INSERT INTO editoras (nome, apelido, data_criacao, faturamento) VALUES 
('DC','DC Comics', '1939-01-20', 2727000000.00),
('Marvel', 'Marvel Comics', '1939-01-01', 3200000000.00),
('The Boys', 'TheBoys Comics', '2006-01-01', 1000000000.00)

SELECT * FROM editoras 

SELECT * FROM personagens

SELECT * FROM tipos_personagens

SELECT
p.id AS 'id',
p.nome AS 'nome',
tp.id AS 'tipo_personagem_id',
tp.tipo AS 'tipo_personagem_tipo',
e.id AS 'editora_id',
e.nome AS 'editora_nome'
FROM personagens AS p
INNER JOIN tipos_personagens AS tp ON(p.id_tipo_personagem = tp.id )
INNER JOIN editoras AS e ON (p.id_editora = e.id)

