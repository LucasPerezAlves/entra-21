-- PRIMARY KEY => Chave primária (identificador único do registro)
CREATE TABLE produtos (
	-- IDENTITY(primeiroId, valorIncremento)
	id INTEGER PRIMARY KEY IDENTITY(1,1), 
	nome VARCHAR(100),
	valor DECIMAL(5, 2),
	categoria VARCHAR(10)
);
ALTER TABLE produtos ALTER COLUMN categoria VARCHAR(12);

SELECT id, nome,valor, categoria FROM produtos;

INSERT INTO produtos (nome, valor, categoria) 
	VALUES ('Nescau', 10.70, 'achocolatado');
INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Nescau cereal', 14.20, 'cereal');

INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Bebida nescau com leite', 14.20, 'achocolatado');

	
INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Leitche com nescau', 14.20, 'achocolatado');

	
INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Nescafé da vida', 14.20, 'achocolatado');

-- Filtrar o produto em que o nome é exatamente Nescau
SELECT 
	id, nome 
	FROM produtos 
	WHERE nome = 'Nescau';

-- Filtrar o produto em que o nome 
-- começa com Nescau
SELECT id, nome
	FROM produtos
	WHERE nome LIKE 'Nescau%';

-- Filtrar o produto em que o nome 
-- termina com Nescau
SELECT id, nome
	FROM produtos
	WHERE nome LIKE '%Nescau';

-- Filtrar o produto em que o nome 
-- contém Nescau	
SELECT id, nome
	FROM produtos
	WHERE nome LIKE '%Nescau%';

SELECT id, nome, valor FROM produtos;

UPDATE produtos SET valor = 7.90 WHERE id = 5;
UPDATE produtos SET valor = 17.50 WHERE id = 5;
UPDATE produtos SET valor = 60.00 WHERE id = 6;

SELECT id, nome, valor FROM produtos;

-- Ordenar os registros A-Z 0-9
SELECT id, nome, valor 
	FROM produtos
	ORDER BY valor ASC;

-- Ordenar os registros Z-A 9-0
SELECT id, nome, valor 
	FROM produtos
	ORDER BY valor DESC;

SELECT id, nome
	FROM produtos
	ORDER BY nome ASC;

-- Descobrir o menor valor
SELECT MIN(valor) FROM produtos;

-- Descobrir o id, nome e valor do(s) produto(s) que contém o menor valor
SELECT id, nome, valor
	FROM produtos 
	WHERE valor = (SELECT MIN(p.valor) FROM produtos p);

-- Descobrir o maior valor
SELECT MAX(valor)
	FROM produtos;
-- Descobrir o maior valor da categoria Achocolatado
SELECT MAX(valor)
	FROM produtos
	WHERE categoria = 'Cereal';

SELECT id, nome, valor, categoria FROM produtos;

-- Descobrir a soma dos valores
SELECT SUM(valor) FROM produtos;

-- Descobrir a média dos preços
-- AVG => Average
SELECT AVG(valor)
	FROM produtos
	WHERE categoria = 'Achocolatado';

SELECT id, nome, valor, categoria 
	FROM produtos
	WHERE categoria = 'Achocolatado';

-- Descobrir a quantidade de caracteres 
SELECT id, nome, LEN(nome) FROM produtos;

-- Descobrir as inforamções do produto que contém o menor nome
-- AS => Apelido da coluna, tabela
SELECT 
	id AS 'Código', 
	nome AS 'Nome Produto', 
	LEN(nome) AS 'Quantidade de caracteres do nome do produto'
	FROM produtos
	WHERE LEN(nome) = (SELECT MIN(LEN(p.nome)) FROM produtos p);

-- Descobrir os produtos que não são a categoria 'Achocolatado'
SELECT
	id,
	nome,
	categoria
	FROM produtos
	WHERE categoria != 'Achocolatado'
