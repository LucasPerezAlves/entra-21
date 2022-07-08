 --DROP TABLE alunos;

CREATE TABLE alunos(
	id INTEGER PRIMARY KEY,
	nome VARCHAR(60),
	nota_1 DECIMAL(4,2),
	nota_2 DECIMAL(4,2)
);

INSERT INTO alunos (id, nome) VALUES (1, 'Kauã');
INSERT INTO alunos (nome, id) VALUES ('Claúdio', 2);

SELECT id, nome, nota_1, nota_2 FROM alunos;

--Definir a nota 1 do Kauã
UPDATE alunos SET nota_1 = 4.75 WHERE id = 1;
-- Definir a nota 1 do Claúdio
UPDATE alunos SET nota_1 = 8.5 WHERE id = 2;


-- Definir a nota 2 do Claúdio
UPDATE alunos SET nota_2 = 7.5 WHERE id = 2;


SELECT nome, nota_1, nota_2 FROM alunos;

-- Definir nota 2 do Kauã
UPDATE alunos SET nota_2 = 9 WHERE id = 1;

ALTER TABLE alunos ADD media DECIMAL(4,2);

SELECT nome, nota_1, nota_2, media FROM alunos;
-- Definir a média do Kauã
-- UPDATE alunos SET media = 6.875 WHERE id = 1;
-- Definir a média do Claúdio
-- UPDATE alunos SET media = ((8.50 + 5.40)/2) WHERE id = 2;

-- Calcular a média de todos os registros da tabela de alunos;
UPDATE alunos SET media = ((nota_1 + nota_2) / 2);

ALTER TABLE alunos ADD aprovado BIT;

UPDATE alunos SET aprovado = 1 WHERE media >= 7;
UPDATE alunos SET aprovado = 0 WHERE media < 7;

SELECT id, nome, nota_1, nota_2, media, aprovado FROM alunos;

ALTER TABLE alunos ALTER COLUMN aprovado VARCHAR(9);

UPDATE alunos SET aprovado = 'Aprovado' WHERE aprovado = '1';
UPDATE alunos SET aprovado = 'Reprovado' WHERE aprovado = '0';

EXEC sp_rename 'alunos.aprovado', 'status', 'COLUMN';

SELECT id, nome, nota_1, nota_2, media, status FROM alunos;


INSERT INTO alunos (id, nome) VALUES (10, 'Ana');




