CREATE TABLE pizzas(
    npizza NUMBER(10),
    precio NUMBER(10),
    CONSTRAINT pk_pizzas PRIMARY KEY(npizza)
);

CREATE TABLE elaboraciones(
    npizza NUMBER(10),
    ingrediente VARCHAR2(50),
    cantidad NUMBER(10),
    CONSTRAINT pk_elaboracion PRIMARY KEY(npizza,ingrediente),
    CONSTRAINT fk_elaboracion_pizzas FOREIGN KEY(npizza)
        REFERENCES pizzas(npizza) ON DELETE CASCADE
);

CREATE TABLE clientes(
    codcliente NUMBER(10),
    nombre VARCHAR2(50),
    CONSTRAINT pk_clientes PRIMARY KEY(codcliente)
);
CREATE TABLE compras(
    pedido VARCHAR2(50),
    npizza NUMBER(10),
    codcliente NUMBER(10),
    fecha DATE,
    CONSTRAINT pk_compras PRIMARY KEY(pedido),
    CONSTRAINT fk_compras_pizzas FOREIGN KEY(npizza)
        REFERENCES pizzas(npizza) ON DELETE CASCADE,
    CONSTRAINT fk_compras_clientes FOREIGN KEY(codcliente)
        REFERENCES clientes(codcliente) ON DELETE CASCADE
);

-- Inserciones en la tabla de Pizzas
INSERT INTO pizzas (npizza, precio) VALUES (1, 10.99);
INSERT INTO pizzas (npizza, precio) VALUES (2, 12.99);
INSERT INTO pizzas (npizza, precio) VALUES (3, 15.99);

-- Inserciones en la tabla de Elaboraciones
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (1, 'Tomate', 2);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (1, 'Queso', 3);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (2, 'Camembert', 2);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (2, 'Queso', 4);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (3, 'Champiñones', 3);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (3, 'Alcachofa', 2);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (3, 'Orégano', 5);
INSERT INTO elaboraciones (npizza, ingrediente, cantidad) VALUES (3, 'Extra tomate', 5);

-- Inserciones en la tabla de Clientes
INSERT INTO clientes (codcliente, nombre) VALUES (101, 'Juan Pérez');
INSERT INTO clientes (codcliente, nombre) VALUES (102, 'María González');
INSERT INTO clientes (codcliente, nombre) VALUES (103, 'Carlos Rodríguez');
INSERT INTO clientes (codcliente, nombre) VALUES (104, 'Luís Tomás');

-- Inserciones en la tabla de Compras
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A001', 1, 101, TO_DATE('2024-02-01', 'YYYY-MM-DD'));
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A002', 2, 102, TO_DATE('2024-02-02', 'YYYY-MM-DD'));
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A003', 3, 103, TO_DATE('2024-02-03', 'YYYY-MM-DD'));
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A004', 2, 101, TO_DATE('2023-02-02', 'YYYY-MM-DD'));
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A005', 3, 101, TO_DATE('2023-02-03', 'YYYY-MM-DD'));
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A006', 1, 101, TO_DATE('2023-02-01', 'YYYY-MM-DD'));
INSERT INTO compras (pedido, npizza, codcliente, fecha) VALUES ('A007', 1, 101, TO_DATE('2022-02-01', 'YYYY-MM-DD'));

-- Consultas
SELECT AVG(precio) FROM pizzas; 
SELECT MAX(precio) FROM pizzas;
SELECT AVG(cantidad), npizza FROM elaboraciones GROUP BY npizza;
SELECT COUNT(pedido) FROM compras;
SELECT COUNT(ingrediente), npizza FROM elaboraciones GROUP BY npizza HAVING COUNT(ingrediente) > 3; 
SELECT ingrediente, SUM(cantidad) FROM elaboraciones GROUP BY ingrediente ORDER BY SUM(cantidad) DESC;
SELECT codcliente, COUNT(DISTINCT npizza) FROM compras GROUP BY codcliente HAVING COUNT(DISTINCT npizza) >= 3;
SELECT npizza FROM compras GROUP BY npizza HAVING COUNT(npizza) > 5;
SELECT npizza, COUNT(ingrediente) FROM elaboraciones GROUP BY npizza HAVING COUNT(ingrediente) > 5;
SELECT codcliente, COUNT(npizza) FROM compras GROUP BY codcliente ORDER BY COUNT(npizza);

-- Campos: codcliente, pedido
-- FROM: compras
-- Where? No
-- Group by? SI (codcliente)
-- Having? No
-- Order by?

COMMIT;