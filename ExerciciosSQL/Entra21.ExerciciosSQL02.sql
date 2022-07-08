CREATE TABLE enderecos(
id INTEGER PRIMARY KEY IDENTITY(1,1),
estado VARCHAR(2),
cidade VARCHAR(140),
bairro VARCHAR(120),
cep VARCHAR(10),
logradouro VARCHAR(250),
numero INT,
complemento TEXT);

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AC',
'Rio Branco',
'Ayrton Senna',
'69.911-866',
'Estrada Deputado José Rui da Silveira Lino',
'282',
'casa');

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
FROM enderecos;


INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('SC',
'Biguaçu',
'Fundos',
'88.161-400',
'',
'995',
'');

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
FROM enderecos;

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('MG',
'Santa Luiza',
'Padre Miguel',
'33.082-050',
'Rua Buenos Aires',
'371',
'Apartamento');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('BA',
'',
'São Tomé de Paripe',
'40.800-361',
'Travessa Luís Hage',
'685',
'');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('MG',
'Ipatinga',
'Vila Celeste',
'',
'Rua Antônio Boaventura Batista',
'645',
'');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('RS',
'Passo Fundo',
'Nenê Graeff',
'99.030-250',
'',
'154',
'');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AM',
'Manaus',
'Petrópolis',
'69.079-300',
'Rua Coronel Ferreira Sobrinho',
'264',
'Fundos');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('TO',
'Gurupi',
'Muniz Santa',
'77.402-130',
'Rua Adelmo Aires Negri',
'794',
'');


INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('TO',
'Gurupi',
'Muniz Santa',
'77.402-130',
'Rua Adelmo Aires Negri',
'794',
'');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AC',
'',
'Preventório',
'',
'Beco ligação II',
'212',
'Bloco B');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AP',
'Santana',
'Comercial',
'68.925-073',
'Rua Calçoene',
'648',
'');

INSERT INTO enderecos(
estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('PB',
'Cabedelo',
'Camalú',
'58.103-052',
'Rua Siqueira Campos',
'249',
'');

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
FROM enderecos;

DELETE FROM enderecos
WHERE id = 9;

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
FROM enderecos;

UPDATE enderecos SET logradouro = 'Thomé de Souza'
WHERE id = 2;

UPDATE enderecos SET complemento = 'Casa de madeira'
WHERE id = 2;

UPDATE enderecos SET cidade = 'Blumenau'
WHERE id = 4;

UPDATE enderecos SET complemento = 'Casinha'
Where id = 4;

UPDATE enderecos SET cep = '55.015-333'
WHERE id = 5

UPDATE enderecos SET complemento = 'Muito legal'
WHERE id = 5;

UPDATE enderecos SET logradouro = 'Jose Isidoro Correa'
WHERE id = 6;

UPDATE enderecos SET complemento = 'Cidade pequena'
WHERE id = 6

UPDATE enderecos SET complemento = 'Muito pequeno'
WHERE id = 8;

UPDATE enderecos SET cidade = 'Dinossauro'
WHERE id = 10;

UPDATE enderecos SET cep = '88.988-566'
WHERE id = 10;

UPDATE enderecos Set complemento = 'Cheirosa'
WHERE id = 11;

UPDATE enderecos SET complemento = 'BIG'
WHERE id = 12;

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
FROM enderecos;