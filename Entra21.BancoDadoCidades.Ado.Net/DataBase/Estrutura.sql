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

SELECT id, nome, quantidade_habitante, pib, data_hora_fundacao, id_unidade_federativa FROM cidades

INSERT INTO unidades_federativas(nome, sigla) VALUES (@NOME, @SIGLA);

INSERT INTO cidades(nome, quantidade_habitante, pib, data_hora_fundacao, id_unidade_federativa) VALUES (@NOME, @QUANTIDADE_HABITANTE, @PIB, @DATA_HORA_FUNDACAO, @ID_UNIDADE_FERERATIVA)

UPDATE unidades_federativas SET nome = @NOME , sigla = @SIGLA WHERE id = @ID;

UPDATE cidades SET nome = @NOME, quantidade_habitante = @QUANTIDADE_HABITANTE, pib = @PIB, data_hora_fundacao = @DATA_HORA_FUNDACAO, id_unidade_federativa = @ID_UNIDADE_FERERATIVA WHERE id = @ID;

DELETE FROM cidades WHERE id = @ID

DELETE FROM unidades_federativas WHERE id = @ID

SELECT 
c.id AS 'id',
c.nome AS 'nome',
c.quantidade_habitante AS 'quantidade_habitante',
c.pib AS 'pib',
c.data_hora_fundacao AS 'data_hora_fundacao',
uf.id AS 'unidade_federativa_id',
uf.nome AS 'unidade_federativa_nome',
uf.sigla AS 'unidade_federativa_silga'
FROM cidades AS c 
INNER JOIN unidades_federativas AS uf ON(c.id_unidade_federativa = uf.id)

INSERT INTO cidades(nome, quantidade_habitante, pib, data_hora_fundacao, id_unidade_federativa) VALUES ('Blumenau', 366418, 45000.50, '1850-09-02 10:10:10', 1)