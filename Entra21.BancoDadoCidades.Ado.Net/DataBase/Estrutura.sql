CREATE TABLE cidades(
id INTEGER PRIMARY KEY IDENTITY(1,1),
id_unidade_federativa INTEGER,
nome VARCHAR(50),
quantidade_habitante INTEGER,
pib DECIMAL (17,2),
data_hora_fundacao DATETIME2,

FOREIGN KEY (id_unidade_federativa) REFERENCES  unidade_federativa(id));