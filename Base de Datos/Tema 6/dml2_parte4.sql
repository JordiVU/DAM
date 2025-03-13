-- EXTRA
SELECT COUNT(numpedido)
FROM pedido
WHERE EXTRACT(YEAR FROM fecha) = 2022 AND numvend > 8 
GROUP BY numvend
HAVING COUNT(numpedido) > 2;

-- Ejercicio 1
SELECT numpieza, numbin, cantdisponible, fecharecuento, periodorecuen, cantminima,
NVL(numbin, 0) result
FROM inventario
WHERE cantdisponible < cantminima;

-- Ejercicio 2
SELECT fecha,
DECODE(numpedido,	1, 10,
					2, 20, 
					numpedido) AS result
FROM pedido
WHERE EXTRACT(MONTH FROM fecha) BETWEEN 1 AND 6;

-- Ejercicio 3
CREATE VIEW comandas_antiguas AS 
SELECT COUNT(numpedido), EXTRACT(MONTH FROM fecha) 
FROM pedido
WHERE fecha BETWEEN TO_DATE('01-01-2022, DD-MM-YYYY') AND TO_DATE('31-12-2022, DD-MM-YYYY')  
GROUP BY EXTRACT(MONTH FROM fecha)
ORDER BY EXTRACT(MONTH FROM fecha);

-- Ejercicio 4
-- TO_CHAR(fecha, 'Day') --> MON, TUS, WES

CREATE VIEW pedidos_semana AS
SELECT TO_CHAR(fecha, 'Day'), COUNT(numpedido)
FROM pedido
WHERE EXTRACT(YEAR FROM fecha) = 2022
GROUP BY TO_CHAR(fecha, 'Day');

-- Ejercicio 5
SELECT COUNT(numlinea), numpedido
FROM linped
WHERE EXTRACT(YEAR FROM fecharecep) = 2022
GROUP BY numpedido
HAVING COUNT(numlinea)>2
ORDER BY numpedido DESC;

-- Ejercicio 6
SELECT numpedido, SUM(cantpedida)
FROM linped
WHERE fecharecep < TO_DATE('01/06/2022', 'DD/MM/YYYY')
GROUP BY numpedido
HAVING SUM(cantpedida) > 3;

-- Ejercicio 7
SELECT numpieza, SYSDATE - fecharecuento
FROM inventario
ORDER BY fecharecuento;

-- Ejercicio 8
SELECT numvend, COUNT(numpedido)
FROM pedido
WHERE EXTRACT(YEAR FROM fecha) = 2022
GROUP BY numvend
HAVING COUNT(numpedido) > 2
ORDER BY numvend;

-- Ejercicio 9
SELECT numvend, COUNT(numpedido)
FROM pedido
WHERE EXTRACT(MONTH FROM fecha) = 12
GROUP BY numvend
HAVING COUNT(numpedido) > 1;

-- Ejercicio 10
SELECT numpedido, preciocompra, DECODE(SUM(cantpedida), 100, 'Pocas', 200, 'Algunas', 500, 'Muchas', 'Otro caso') AS result
FROM linped
GROUP BY numpedido, preciocompra
HAVING SUM(cantpedida) > 5;

-- Ejercicio 11
SELECT numpieza, MAX(preciocompra), MIN(preciocompra), AVG(preciocompra), SUM(cantpedida)
FROM linped
GROUP BY numpieza
ORDER BY SUM(cantpedida) DESC;