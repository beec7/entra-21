CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	tipo INTEGER,
	preco_unidatario DECIMAL(6,2)
);

CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	cpf VARCHAR(15)
);

CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1), --PK
	id_cliente INTEGER NOT NULL, -- FK
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(2) NOT NULL,
	cidade VARCHAR(30) NOT NULL,
	bairro VARCHAR(30)NOT NULL,
	logradouro VARCHAR (40)NOT NULL,
	numero VARCHAR(10)NOT NULL,
	descricao TEXT,

	-- FOREIGN KEY (nome_coluna_tabela_atual)
	-- REFERENCES nome_tabela_pai(nome_coluna_pai_pk)
	FOREIGN KEY (id_cliente) REFERENCES clientes(id)
);

CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL,
	status TINYINT NOT NULL, -- 0, 255
	data_compla DATETIME2,
	
	data_efetivacao_compra DATETIME2,
	
	data_criacao DATETIME2,

);
CREATE TABLE pedidos_pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_peca INTEGER,
	id_pedido INTEGER,

	quantidade SMALLINT,

	FOREIGN KEY (id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY (id_peca) REFERENCES pecas(id)
);