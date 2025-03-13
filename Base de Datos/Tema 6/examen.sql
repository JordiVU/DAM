-- Ejercicio 1
SELECT v.numvend, v.numvend, p.nompieza
FROM preciosum ps 
JOIN linped l ON ps.numpieza = l.numpieza
JOIN pedido pd ON pd.numpedido = l.numpedido
JOIN vendedor v ON ps.numvend = v.numvend
JOIN pieza p ON ps.numpieza = p.numpieza
GROUP BY v.numvend, v.nomvend, p.nompieza
HAVING SUM(ps.preciounit) >
	(SELECT SUM(preciounit)
	FROM preciosum
	WHERE numvend = 2);

-- Ejercicio 2
INSERT INTO preciosum(numpieza, numvend, preciounit, diassum, descuento)
VALUES(
'AB-123-789',
(SELECT v.numvend
FROM vendedor v
JOIN pedido p ON p.numvend = v.numvend
JOIN linped l ON l.numpedido = p.numpedido
WHERE EXTRACT(YEAR FROM l.fecharecep) > EXTRACT(YEAR FROM SYSDATE) - 8 AND
p.numpieza = 'FD-001-114'
GROUP BY v.numvend
HAVING SUM(l.cantrecibida) >=
	ALL(SELECT SUM(l.cantrecibida)
		FROM linped l
		JOIN pedido p ON p.numpedido = l.numpedido
		JOIN vendedor v ON v.numvend = p.numvend
		EXTRACT(YEAR FROM l.fecharecep) > EXTRACT(YEAR FROM SYSDATE) - 8
		GROUP BY v.numvend)),
20,
(SELECT AVG(diasum)
FROM preciosum
WHERE numpieza = 'FD-001-114'),
10;

-- nompieza, numpieza, COUNT(numvend) / FILTRO: cuando se hayan pedido alguna vez esas piezas (subselect)
SELECT p.numpieza, p.nompieza, COUNT(ps.numvend) as cantVends
FROM pieza p
LEFT JOIN preciosum ps ON ps.numpieza = p.numpieza
WHERE ps.numpieza = 
	ANY(SELECT l.numpieza
		FROM linped l)
GROUP BY p.numpieza, p.nompieza;


-- numpedido, numvend, nomvend, (precicompra * cantrecibida) / 
-- FILTRO: Pedidos realizados despues del 2020 
--			Solo si el importe de venta es menor que la media de los importes de ventas de todos los pedidos de ese vendedor

SELECT l.numpedido, v.numvend, v.nomvend, (l.preciocompra * l.cantrecibida)
FROM linped l
JOIN pedido pd ON pd.numpedido = l.numpedido
JOIN vendedor v ON v.numvend = pd.numvend
WHERE (l.preciocompra * l.cantrecibida) <
		ALL(SELECT AVG(l.preciocompra * l.cantrecibida)
			FROM linped l)
AND TO_CHAR(pd.fecha, 'YYYY') > '2020';