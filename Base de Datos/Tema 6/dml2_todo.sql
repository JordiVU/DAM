--1
CREATE VIEW empresa_luis AS
SELECT NVL(v.nomvend, 'Sin nombre')
FROM vendedor v
WHERE v.nombrecomer IN 
	SELECT(v.nombrecomer
	FROM vendedor v
	WHERE UPPER(v.nomvend) = 'LUIS GARCIA');

--2
CREATE VIEW monitores_obsoletos AS
SELECT p.nompieza, p.preciovent, 
DECODE(p.numpieza, 1, '01',
					2, '02',)
					3, '03',
					p.numpieza) AS result
FROM pieza p
WHERE UPPER(p.nompieza) LIKE '%Monitor%' AND p.numpieza NOT EXISTS
	(SELECT l.numpieza
	FROM linped l
	WHERE l.numpieza = p.numpieza);
	
--3
SELECT p.numpieza, p.nompieza
FROM pieza p 
JOIN linped l ON p.numpieza = l.numpieza
GROUP BY p.numpieza, p.nompieza
HAVING COUNT(l.numpieza) >= 
	ALL(SELECT COUNT(l.numpieza) 
	FROM linped l
	GROUP BY l.numpieza)

--4
INSERT INTO pieza(numpieza, nompieza, preciovent)
SELECT	('0' || p.numpieza), p.nompieza, p.preciovent
FROM pieza p
JOIN linped l ON p.numpieza = l.numpieza
GROUP BY p.numpieza, p.nompieza, p.preciovent
HAVING COUNT(l.numpieza) >=
	ALL(SELECT COUNT(cantpedida)
	FROM linped
	GROUP BY numpieza);
		
--5
UPDATE vendedor
SET nombrecomer = 
	(SELECT nombrecomer 
	FROM preciosum s 
	WHERE s.numpieza = 
	ANY(SELECT s.numpieza
		FROM preciosum s
		WHERE numvend = 5));

--6
SELECT numpieza,nompieza
FROM pieza p, linped l
GROUP BY numpieza, nompieza
HAVING AVG(preciocompra) <
	(SELECT AVG(preciocompra) 
	FROM linped) AND COUNT(preciocompra) > 5;

--7
SELECT v.nombrecomer
FROM vendedor v
JOIN pedido p l ON p.numpedido = v.numpedido
JOIN linped l ON l.numvend = p.numvend
GROUP BY v.nombrecomer
HAVING SUM(preciocompra*cantrecibida)>=
	ALL(SELECT SUM(l.preciocompra * l.cantrecibida)
		FROM linped l
		JOIN pedido p ON p.numpedido = l.numpedido
		JOIN vendedor v ON v.numvend = p.numvend
		GROUP BY v.nombrecomer);

--8
INSERT INTO vendedor(numvend, nomvend, nombrecomer) VALUES(
(SELECT SUM(numvend) FROM vendedor) + 1,
'Henry David Thoreau',
	(SELECT v.nombrecomer 
	FROM vendedor v
	JOIN pedido p ON p.numvend = v.numvend
	JOIN linped l ON l.numpedido = p.numpedido
	GROUP BY v.nombrecomer
	HAVING SUM(l.preciocompra * l.cantrecibida) >=
		ALL(SELECT SUM(l.preciocompra * l.cantrecibida) 
			FROM linped l
			JOIN pedido p ON p.numpedido = l.numpedido
			JOIN vendedor v ON v.numvend = p.numvend
			GROUP BY v.nombrecomer)));

--9
SELECT p.numpieza, p.nompieza
FROM pieza p
JOIN linped l ON l.numpieza = p.numpieza 
WHERE l.preciocompra <= (SELECT MAX(ps.preciounit) * 0.1 FROM preciosum ps)
GROUP BY p.numpieza, p.nompieza
HAVING COUNT(l.numpieza) >= 3;

--Ejercicio 10
SELECT p.numpieza, p.nompieza
FROM pieza p
JOIN linped l ON p.numpieza=l.numpieza 
WHERE l.preciocompra <= 
	(SELECT MAX(ps.preciounit) * 0.1 
	FROM preciosum ps
	JOIN linped l ON l.numpieza = ps.numpieza)
GROUP BY p.numpieza, p.nompieza
HAVING COUNT(numpedido) > 3;

--Ejercicio 11
SELECT l.numpedido, v.numvend, v.nomvend, SUM(l.preciocompra * l.cantrecibida)
FROM linped l
JOIN pedido p ON p.numpedido = l.numpedido
JOIN vendedor v ON v.numvend = p.numvend
WHERE EXTRACT(YEAR FROM p.fecha) = 2022
GROUP BY l.numpedido, v.numvend, v.nomvend 
HAVING SUM(l.preciocompra * l.cantrecibida) >
	ANY(SELECT SUM(l.preciocompra * l.cantrecibida)
		FROM linped l);