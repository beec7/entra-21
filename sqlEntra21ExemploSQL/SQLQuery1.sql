CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR (100),
	subtitulo VARCHAR (50), -- armazena ate 50 caracter
	descricao TEXT,			-- armazena textos grandes
	data_publicacao DATETIME2, --Data e hora
	tipo VARCHAR(15)
);

INSERT INTO trabalhos
	(titulo , subtitulo, descricao,data_publicacao,tipo)
	VALUES('A melhor pizza do mundo',
	'como degustar uma pizza de calabresa',
	'Grande descricao aki',
	'1994-06-04','Receita');

INSERT INTO trabalhos
	(titulo , subtitulo, descricao,data_publicacao,tipo)
	VALUES('Clean code','Como trabalhar melhor no seu dia a dia',
	'Utilizar var no lugar de tipo primitivos',
	'2000-03-20','Leitura técnica');

INSERT INTO trabalhos
	(titulo , subtitulo, descricao,data_publicacao,tipo)
	VALUES('Pudim com ovo','Aprenda o que nao fazer na sua vida',
	'Jogue o pudim no lixo e face um ovo','2022-07-06','Receita');

INSERT INTO trabalhos
	(titulo , subtitulo, descricao,data_publicacao,tipo)
	VALUES('Estrutura de dados',
	'como sofrer sem saber, porem e necessario',
	'Importante para aprender fifo, lifo, fefo, lista encadeadas',
	'1980-05-11','Leitura técnica');

INSERT INTO trabalhos
	(titulo , subtitulo, descricao,data_publicacao,tipo)
	VALUES('Strogonoff de frango','a Vitória da batata palha',
	'Compre frango e batata palha, jogue na panela, acenda o fogao espera 5 minutos e ta pronto o sorvetinho',
	'2000-09-10','Receita');

	SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo
		FROM trabalhos;

--Concatena informacao de duas colunas
SELECT 
	CONCAT (titulo, ' - ', subtitulo) AS 'Titulo completo' 
	FROM trabalhos

--Consultar a descricao limitando a quantidade de caracteres
SELECT
	titulo AS 'Titulo',
	CONCAT (SUBSTRING (descricao, 0 ,20 ),'...') AS 'Descricao'
	FROM trabalhos;

-- Apresenta o trabalho filtrado o ano da publicacao entre 1990 ate 2000
SELECT id , titulo, data_publicacao
	FROM trabalhos
	WHERE 
		YEAR(data_publicacao) >= 1990 AND
		YEAR(data_publicacao) <= 2000;

--Consultar data publicacao formato BR huehue
SELECT id, titulo, 
	CONCAT(	
		DAY(data_publicacao), '/' ,
		MONTH(data_publicacao), '/',
		YEAR(data_publicacao))
	FROM trabalhos;

--Consultar a data da publicacao formatando no padrao BR, utilizando fucao para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy')
	FROM trabalhos;

---------------------------------w3chools.com/sql----------------------

--PAGINACAO Limitar a consulta para dois registros
SELECT TOP(2)id, titulo FROM trabalhos; 

--Apresentar o codigo , nome, preco, se esta favoritado
--filtrando por placa mae ou placa de video do maior preço para o menor

--SELECT TOP(2)id, nome, preco, favoritado
--	FROM produtos
--	WHERE categoria = 'placa mãe' OR categoria= 'placa de video'
--	ORDER BY preco DESC


--PAGINCAO ___________________________________
-- Consulta com paginacao aoresentando 2 registros da paginas 1
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginacao aoresentando 2 registros da paginas 2
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;


-- Consulta com paginacao aoresentando 2 registros da paginas 3
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;

-- Calculo 
--pagina = 1
--quantidadePorPagina = 2
-- (pagina -2) / quantidadePorPagina