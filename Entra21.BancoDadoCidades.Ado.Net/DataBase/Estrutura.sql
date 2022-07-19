CREATE TABLE unidades_federativas(
id INTEGER PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
sigla VARCHAR(2)
);

CREATE TABLE cidades(
id INTEGER PRIMARY KEY IDENTITY(1,1),
id_unidade_federativa INTEGER,
nome VARCHAR(50),
quantidade_habitante INTEGER,
pib DECIMAL (17,2),
data_hora_fundacao DATETIME2,

FOREIGN KEY (id_unidade_federativa) REFERENCES  unidades_federativas(id));


SELECT * FROM unidades_federativas

SELECT * FROM cidades

INSERT INTO unidades_federativas(nome, sigla) VALUES (@NOME, @SIGLA);

INSERT INTO cidades(nome, quantidade_habitante, pib, data_hora_fundacao, id_unidade_federativa) VALUES (@NOME, @QUANTIDADE_HABITANTE, @PIB, @DATA_HORA_FUNDACAO, @ID_UNIDADE_FERERATIVA)

UPDATE unidades_federativas SET nome = @NOME , sigla = @SIGLA WHERE id = @ID;

UPDATE cidades SET nome = @NOME, quantidade_habitante = @QUANTIDADE_HABITANTE, pib = @PIB, data_hora_fundacao = @DATA_HORA_FUNDACAO, id_unidade_federativa = @ID_UNIDADE_FERERATIVA WHERE id = @ID;

DELETE FROM cidades WHERE id = @ID

DELETE FROM unidades_federativas WHERE id = @ID

