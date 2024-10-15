-- 1
SELECT
	Nome,
	Ano
FROM Filmes;

-- 2
SELECT 
	Nome,
	Ano
FROM Filmes
ORDER BY Ano ASC;

-- 3
SELECT 
	Nome,
	Ano,
	Duracao as 'Duração'
FROM Filmes
WHERE Nome LIKE 'De Volta para o fut%';

-- 4 
SELECT
	Nome,
	Ano,
	Duracao AS 'Duração'
FROM Filmes
WHERE Ano = '1997';

-- 5
SELECT
	Nome,
	Ano,
	Duracao AS 'Duração'
FROM Filmes
WHERE Ano LIKE '200%'; 

-- 6
SELECT 
	Nome,
	Ano,
	Duracao AS 'Duração'
FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC;

-- 7
SELECT 
	Ano,
	COUNT(Ano) AS 'Quantidade'
FROM Filmes
GROUP BY ANO
ORDER BY COUNT(ANO) DESC;

-- 8 
SELECT
	PrimeiroNome AS 'Primeiro Nome',
	UltimoNome AS 'Último Nome'
FROM Atores
WHERE Genero = 'M';

-- 9 
SELECT
	PrimeiroNome AS 'Primeiro Nome',
	UltimoNome AS 'Último Nome'
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome;

-- 10
SELECT
	F.Nome AS 'Nome do Filme',
	G.Genero AS 'Gênero'
FROM Filmes F
INNER JOIN FilmesGenero FG
ON F.Id = FG.IdFilme
INNER JOIN Generos G
ON G.Id = FG.IdGenero;

-- 11
SELECT
	F.Nome AS 'Nome do Filme',
	G.Genero AS 'Gênero'
FROM Filmes F
INNER JOIN FilmesGenero FG
ON F.Id = FG.IdFilme
INNER JOIN Generos G
ON G.Id = FG.IdGenero
WHERE Genero = 'Mistério';

-- 12
SELECT
	F.Nome AS 'Nome do Filme',
	A.PrimeiroNome AS 'Primeiro Nome do Ator',
	A.UltimoNome AS 'Último Nome do Ator',
	E.Papel
FROM Filmes F
INNER JOIN ElencoFilme E
ON F.Id = E.IdFilme
INNER JOIN Atores A
ON A.Id = E.IdAtor;