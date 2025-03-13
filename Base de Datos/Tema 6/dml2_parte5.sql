-- Ejercicio 1
SELECT ps.numpieza, p.nompieza
FROM pieza p
JOIN piezasum ps ON ps.numpieza = p.numpieza
JOIN vendedor v ON v.numvend = ps.numvend
WHERE v.numvend = 2 OR v.numvend = 4;

-- Ejercicio 2
SELECT DISTINCT p.numpieza, v.provincia
FROM pedido p
JOIN piezasum ps ON ps.numpieza = p.numpieza
JOIN venedor v ON v.numvend = ps.numvend
ORDER BY DESC;

-- Ejercicio 3
SELECT l.numpieza, p.nompieza
FROM linped l
JOIN pedido p ON p.numpieza = l.numpieza
WHERE l.fecharecep = TO_DATE('18/02/2022','DD/MM/YYYY');

-- Ejercicio 4
SELECT COUNT(ps.numpieza)
FROM preciosum ps
JOIN vendedor v ON v.numvend = ps.numvend
WHERE v.nomvend = 'Harw S.A';
-- Cantidad piezas
-- From vendedor, preciosum, 

-- Ejercicio 5
SELECT pz.numpieza, pz.nompieza, pz.preciovent
FROM pieza pz
JOIN linped l ON l.numpieza = pz.numpieza
JOIN pedido p ON p.numpedido = l.numpedido
WHERE p.numvend = 1;

-- Ejercicio 6
SELECT v.numvend, v.nomvend, COUNT(l.numpedido)
FROM vendedor v
JOIN pedido p ON p.numvend = v.numvend
JOIN linped l ON l.numpedido = p.numpedido
WHERE v.provincia = 'Alicante';

-- Ejercicio 7
SELECT p.numpedido, v.numvend, v.nomvend, v.nombrecomer
FROM pedido p
JOIN vendedor v ON v.numvend = p.numvend
WHERE fecha <> TO_DATE('22/10/2002', 'DD/MM/YYYY');

-- Ejercicio 8
SELECT ps.preciounit, v.numvend, v.nomvend 
FROM preciosum ps
JOIN vendedor v ON v.numvend = ps.numvend
WHERE ps.numpieza IN ('DD-0001-210', 'FD-0001-144');

-- Ejercicio 9
SELECT DISTINCT v.nomvend
FROM vendedor v
JOIN pedido p ON p.numvend = v.numvend
JOIN linped l ON l.numpedido = p.numpedido
WHERE p.fecha BETWEEN TO_DATE('01/01/2023', 'DD/MM/YYYY') AND TO_DATE('02/10/2023', 'DD/MM/YYYY') 
ORDER BY v.numvend;