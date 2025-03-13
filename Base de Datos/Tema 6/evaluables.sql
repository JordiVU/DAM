--Ejercicio 1
SELECT NVL(v.numvend, 'Sin valor'), v.nomvend, ps.numpieza
FROM vendedor v
JOIN pedido pd ON pd.numvend = v.numvend
JOIN preciosum ps ON ps.numvend = v.numvend
GROUP BY v.numvend, v.nomvend, ps.numpieza
HAVING AVG(preciounit) > 
	(SELECT AVG(preciounit)
	FROM preciosum
	WHERE numpieza LIKE '%FD-001-000%'
	GROUP BY numvend);

--Ejercicio 2	
INSERT INTO preciosum(numpieza, numvend, preciounit, diassum, descuento)
VALUES(
'FD-001-000',
	(SELECT v.numvend
	FROM vendedor v
	JOIN pedido pd ON pd.numvend = v.numvend
	JOIN linped l ON l.numpedido = pd.numpedido
	WHERE l.numpieza LIKE '%FD-001-144%' AND EXTRACT(YEAR FROM fecha) > EXTRACT(YEAR FROM SYSDATE) - 6
	GROUP BY v.numvend
	HAVING SUM(l.cantpedida) >= 
		ALL(SELECT SUM(l.cantpedida)
		FROM linped l
		JOIN pedido pd ON pd.numpedido = l.numpedido
		JOIN vendedor v ON v.numvend = pd.numvend
		WHERE l.numpieza LIKE '%FD-001-144%' AND EXTRACT(YEAR FROM fecha) > EXTRACT(YEAR FROM SYSDATE) - 6
		GROUP BY v.numvend)),
10,
	(SELECT MIN(ps.diassum)
	FROM preciosum ps
	JOIN pieza p ON p.numpieza = ps.numpieza
	WHERE p.numpieza LIKE '%FD-001-144%'),
5);

--Ejercicio 3
CREATE VIEW jefe_ventas AS
SELECT v.nomvend, p.numpieza, p.nompieza, DECODE(v.numvend, 100, 'Jefe Ventas', v.numvend) result
FROM vendedor v
JOIN preciosum ps ON ps.numvend = v.numvend
JOIN pieza p ON p.numpieza = ps.numpieza
JOIN pedido pd ON pd.numvend = v.numvend
WHERE ps.preciounit > 200 AND 
	EXTRACT(YEAR FROM pd.fecha) = '2022'
ORDER BY v.numvend, v.nomvend, p.nompieza;

--Ejercicio 4
SELECT v.nomvend, COUNT(ps.numpieza) AS pcontadas, 
	DECODE(v.ciudad, 'Alicante', 'C. Valenciana',
						'Valencia', 'C. Valenciana',
						'Castellon', 'C. Valenciana', v.ciudad) AS result
FROM vendedor v
LEFT JOIN preciosum ps ON ps.numvend = v.numvend
WHERE ps.numpieza = 
	ANY(SELECT l.numpieza
		FROM linped l)
GROUP BY v.nomvend, v.ciudad;

--Ejercicio 5
SELECT p.nompieza, ps.preciounit, MAX(ps.descuento), ps.numpieza
FROM pieza p
JOIN preciosum ps ON ps.numpieza = p.numpieza
WHERE NOT EXISTS
		(SELECT v.numvend
		FROM vendedor v
		JOIN preciosum ps ON ps.numvend = v.numvend
		WHERE v.nombrecomer LIKE '%Mecemsa%')
GROUP BY p.nompieza, ps.preciounit, ps.numpieza
HAVING COUNT(ps.preciounit) > 1 
ORDER BY ps.numpieza;

--Ejercicio 6
SELECT l.numpedido, v.numvend, v.nomvend, (l.preciocompra * l.cantrecibida)
FROM linped l
JOIN pedido p ON p.numpedido = l.numpedido
JOIN vendedor v ON v.numvend = p.numvend
WHERE (l.preciocompra * l.cantrecibida) < 
	ALL(SELECT (l.preciocompra * l.cantrecibida)
		FROM linped l) AND TO_CHAR(p.fecha, 'YYYY') > '2022';