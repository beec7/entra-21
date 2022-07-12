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
-- Tipos de peças
-- 1 - ssd
-- 2 - placa video
-- 3 - placa mão
-- 4 - Fonte
-- 5 - Memória RAM

INSERT INTO pecas(nome, tipo, preco_unidatario) VALUES 
('SSD 240 GB', 1 , 200),
('SSD 240 M2', 1, 420.20),
('RTX 3090', 2, 9999.99),
('GTX 1060', 2, 1500),
('16 GB DDR5 4800Ghz', 5, 800),
('16 GB DDR4 3200Ghz', 5, 350)

INSERT INTO clientes(nome, cpf) VALUES 
('Claudio', '070.355.489-73'),
('Cry', '032.599.384-69'),
('Júlianã', '123.495.392-02')

INSERT INTO enderecos(id_cliente, estado, cidade, bairro, cep, logradouro, numero) VALUES
(1, 'SC', 'Blumenau', 'Velha', '89070-301', 'Rua Divinópolis', 777),
(2, 'SC', 'Blumenau', 'Velha Grande', '89070-472','Morro da Edith', 36),
(3, 'SC', 'Blumenau', 'Judity', 'Sem cep', 'Rua da Kellen', 23);


-- Consulta para listar o nome, cpf e endereço completo do cliente
-- Consulta parte da tabela de cliente fazendo INNER JOIN com a tabela de endereço

SELECT 
	c.nome,
	c.cpf,
	CONCAT(e.estado,' - ',
	e.cidade, ' - ',
	e.bairro, ' - ', 
	e.logradouro, ' - ',
	e.numero) AS 'Endereço Completo'
	FROM clientes AS c
	INNER JOIN enderecos AS e ON (e.id_cliente = c.id)

----------------------------------------------------------------------------------------------------------------------------

--Consultar os endereços apresentado seu cliente filtrando
-- por bairros com nome 'Velha'
-- Consulta partindo da tabela de endereços com outra consukta na tabela de clientes

SELECT
	c.nome,
	e.bairro,
	e.logradouro
	FROM enderecos AS e
	INNER JOIN clientes AS c ON(c.id = e.id_cliente)
	WHERE e.bairro LIKE '%Velha%'

----------------------------------------------------------------------------------------------------------------------------

-- STATUS do pedidos
-- 0 - Carrinho
-- 1 - Aguardando pagamento
-- 2 - Pagamento efetivado
-- 3 - Entregar realizada

INSERT INTO pedidos(id_cliente, status, data_criacao)VALUES
(1, 0, GETDATE()), --Pedido para o Claudio
((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE()); -- Pedido para o Cry

-- Consultar pedidos listando, data da criação formato PT-BR, status com texto
-- e nome do cliente
-- Consulta partindo da tabela de pedidos com JSON em clientes

SELECT 
	FORMAT(p.data_criacao, 'dd/MM/yyyy'),
	CASE
		WHEN [status] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardado pagamento'
		WHEN [status] = 2 THEN 'Pagamento efetivado'
		ELSE 'Entregar realizada'
	END AS 'Status pedido',
	c.nome
	FROM pedidos AS p
	INNER JOIN clientes AS c ON(p.id_cliente = c.id);


UPDATE pedidos SET status = 1 WHERE id = 2 

-----------------------------------------------------------------------------------------------------------------------------


