SELECT NVL(v.nomvend, 'Sin nombre'), COUNT(ps.numpieza)
FROM preciosum ps
JOIN vendedor v ON v.numvend = ps.numvend
GROUP BY v.nomvend;

CREATE VIEW beneficios AS
SELECT p.numpieza, MAX(p.preciovent) / AVG(l.preciocompra)
FROM linped l
JOIN pieza p ON p.numpieza = l.numpieza
GROUP BY p.numpieza;

SELECT p.numpieza, MAX(p.preciovent), MIN(p.preciovent) 
FROM pieza p
JOIN preciosum ps ON ps.numpieza = p.numpieza
WHERE ps.numvend <> 1
GROUP BY p.numpieza;

SELECT ps.numpieza, 
DECODE(COUNT(ps.numvend), 
			0, 'Faltan vendedores', 
			1, 'Vendedores completos', 
			'Demasiados vendedores' ) AS result
FROM preciosum ps
JOIN pieza p ON p.numpieza = ps.numpieza
WHERE p.preciovent > 250
GROUP BY ps.numpieza;

SELECT p.nompieza, AVG(ps.preciounit), MAX(ps.preciounit), MIN(ps.preciounit)
FROM pieza p
JOIN preciosum ps ON ps.numpieza = p.numpieza
GROUP BY p.nompieza
HAVING COUNT(ps.numvend) > 2;

--6
SELECT v.numvend, v.nomvend
FROM vendedor v
INNER JOIN pedido p ON p.numvend = v.numvend
INNER JOIN linped l ON l.numpedido = p.numpedido
GROUP BY v.numvend, v.nomvend
HAVING COUNT(DISTINCT l.numpieza) > 2;

--7
SELECT p.nompieza, AVG(ps.preciounit), p.preciovent
FROM pieza p
JOIN preciosum ps ON ps.numpieza = p.numpieza
WHERE p.preciovent > 300
GROUP BY p.nompieza, p.preciovent
HAVING AVG(ps.preciounit) BETWEEN 100 AND 280
ORDER BY p.nompieza;

--8
CREATE VIEW fechas_distintas AS
SELECT pd.numpedido, pd.numvend, NVL(v.nomvend, 'Sin nombre'), COUNT(DISTINCT pd.fecha) 
FROM linped l, pedido pd
INNER JOIN vendedor v ON v.numvend = pd.numvend
WHERE l.numpedido = pd.numpedido
GROUP BY pd.numpedido, pd.numvend, NVL(v.nomvend, 'Sin nombre')
HAVING COUNT(DISTINCT l.fecharecep) > 1;

--9
SELECT p.numpieza, NVL(p.nompieza, 'Sin nombre'), pd.numvend, v.nomvend
FROM pieza p
INNER JOIN linped l ON l.numpieza = p.numpieza
INNER JOIN pedido pd ON pd.numpedido = l.numpedido
INNER JOIN vendedor v ON v.numvend = pd.numvend
WHERE TO_CHAR(l.fecharecep, 'D') = '7'
ORDER BY p.nompieza;

--10
SELECT v.nombre, v.numvend,
DECODE(v.provincia, "Alicante", "C.V",
                    "Valencia", "C.V",
                    "Castellon", "C.V",
                    v.provincia) AS result
FROM vendedor v
JOIN pedido p ON p.numvend = v.numvend
JOIN linped l ON l.numpedido = l.numpedido
WHERE TO_CHAR(l.fecharecep, "D") BETWEEN "1" AND "5" AND
    l.fecharecep > SYSDATE - 30;

--11
CREATE VIEW pedido_30 AS
SELECT pd.numpedido, pd.fecha
FROM pedido pd
JOIN linped l ON l.numpedido = pd.numpedido
GROUP BY pd.numpedido, pd.fecha
HAVING SUM(l.cantpedida) > 30 AND SUM(l.cantrecibida) < 10;

--12
SELECT p.numpieza, p.nompieza, MAX(ps.preciounit)
FROM pieza p
JOIN preciosum ps ON ps.numpieza = p.numpieza
WHERE p.preciovent > 250 OR p.preciovent < 170
GROUP BY p.numpieza, p.nompieza
HAVING AVG(ps.descuento) BETWEEN 10 AND 17 AND
    AVG(ps.preciounit) > 150
ORDER BY MAX(ps.preciounit);

--13
SELECT p.numpieza, p.nompieza, p.preciovent
FROM pieza p
JOIN preciosum ps ON ps.numpieza = p.numpieza
JOIN linped l ON l.numpieza = ps.numpieza
GROUP BY p.numpieza, p.nompieza, p.preciovent
HAVING AVG(ps.preciounit) > MAX(l.preciocompra);