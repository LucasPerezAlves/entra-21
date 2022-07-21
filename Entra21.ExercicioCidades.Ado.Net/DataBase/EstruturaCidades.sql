CREATE TABLE cidades(
id_unidade_federativa INTEGER,
id INTEGER PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
quantidades_habitantes iNTEGER,
data_hora_fundacao DATETIME2,
pib DECIMAL (20,2),


FOREIGN KEY (id_unidade_federativa) REFERENCES unidades_federativas(id)
);

CREATE TABLE unidades_federativas(
id INTEGER PRIMARY KEY IDENTITY (1,1),
nome VARCHAR(30),
sigla VARCHAR(2)
);