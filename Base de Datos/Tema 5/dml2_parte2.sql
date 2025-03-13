CREATE TABLE vendedor(
	numvend INTEGER,
	nomvend VARCHAR(20),
	nombrecomer VARCHAR(20),
	telefono VARCHAR(20),
	calle VARCHAR(30),
	ciudad VARCHAR(20),
	provincia VARCHAR(20),
	CONSTRAINT pk_vendedor PRIMARY KEY(numvend)
);
CREATE TABLE pieza(
	numpieza VARCHAR(20),
	nompieza VARCHAR(30),
	preciovent NUMBER(10,2),
	CONSTRAINT pk_pieza PRIMARY KEY(numpieza)
);
CREATE TABLE pedido(
	numpedido INTEGER,
	numvend INTEGER,
	fecha DATE,
	CONSTRAINT pk_pedido PRIMARY KEY(numpedido)
);
CREATE TABLE linped(
	numpedido INTEGER,
	numlinea INTEGER,
	numpieza VARCHAR(20),
	preciocompra NUMBER(20,2),
	cantpedida NUMBER(20,2),
	fecharecep DATE,
	cantrecibida NUMBER(20,2),
	CONSTRAINT pk_linped PRIMARY KEY(numpedido,numlinea)
);
CREATE TABLE inventario(
	numpieza VARCHAR(20),
	numbin INTEGER,
	cantdisponible INTEGER,
	fecharecuento DATE,
	periodorecuen INTEGER,
	cantminima INTEGER,
	CONSTRAINT pk_inventario PRIMARY KEY(numbin)
);
CREATE TABLE preciosum(
	numpieza VARCHAR(20),
	numvend INTEGER,
	preciounit NUMBER(20,2),
	diassum NUMBER(20,2),
	descuento INTEGER,
	CONSTRAINT pk_preciosum PRIMARY KEY(numpieza,numvend)
);



-- Inserciones para la tabla vendedor
INSERT INTO vendedor VALUES (1, 'Juan Pérez', 'ElectroHogar Pérez', '555-1234', 'Avenida 123', 'Ciudad Capital', 'Alicante');
INSERT INTO vendedor VALUES (2, 'María Rodríguez', 'Tecnología Rodes', '555-5678', 'Calle 456', 'Ciudad Principal', 'Barcelona');
INSERT INTO vendedor VALUES (3, 'Óscar Lino', 'Harw S.A', '555-5678', 'Calle 456', 'Ciudad Principal', 'Bilbao');
INSERT INTO vendedor VALUES (4, 'Federico Aus', 'Harw S.A', '555-5678', 'Calle 456', 'Ciudad Principal', 'Valencia');
INSERT INTO vendedor VALUES (5000, 'Luís Ros', 'Harw S.A', '555-5678', 'Calle 456', 'Ciudad Principal', 'Valencia');

-- Inserciones para la tabla pieza
INSERT INTO pieza VALUES ('DD-0001-210', 'Laptop Dell', 1200.00);
INSERT INTO pieza VALUES ('FD-001-144', 'Smartphone Samsung', 699.99);
INSERT INTO pieza VALUES ('A-1001-L', 'Tablet Samsung', 349.99);
INSERT INTO pieza VALUES ('X-0001-PC', 'Impresora Epson', 199.50);
INSERT INTO pieza VALUES ('M-0003-C', 'Auriculares Bluetooth', 59.99);
INSERT INTO pieza VALUES ('C-1002-H', 'Disco Duro Externo', 129.95);
INSERT INTO pieza VALUES ('O-0001-P', 'Teclado mecánico', 89.99);


-- Inserciones para la tabla pedido
INSERT INTO pedido VALUES (1, 1, TO_DATE('2022-02-18', 'YYYY-MM-DD'));
INSERT INTO pedido VALUES (2, 2, TO_DATE('2022-02-19', 'YYYY-MM-DD'));

-- Inserciones para la tabla linped
INSERT INTO linped VALUES (1, 1, 'DD-0001-210', 1100.00, 2, TO_DATE('2022-05-01', 'YYYY-MM-DD'), 2);
INSERT INTO linped VALUES (1, 2, 'FD-001-144', 650.00, 3, TO_DATE('2022-02-18', 'YYYY-MM-DD'), 3);
INSERT INTO linped VALUES (2, 1, 'FD-001-144', 699.99, 1, TO_DATE('2022-02-19', 'YYYY-MM-DD'), 1);
INSERT INTO linped VALUES (1, 3, 'DD-0001-210', 1100.00, 2, TO_DATE('2022-05-01', 'YYYY-MM-DD'), 2);

-- Inserciones para la tabla inventario
INSERT INTO inventario VALUES ('DD-0001-210', 1, 5, TO_DATE('2022-02-18', 'YYYY-MM-DD'), 1, 2);
INSERT INTO inventario VALUES ('FD-001-144', 2, 8, TO_DATE('2022-02-19', 'YYYY-MM-DD'), 1, 1);

-- Inserciones para la tabla preciosum
INSERT INTO preciosum VALUES ('DD-0001-210', 1, 1100.00, 30, 5);
INSERT INTO preciosum VALUES ('FD-001-144', 2, 699.99, 20, 8);
INSERT INTO preciosum VALUES ('A-1001-L', 3, 279.99, 25, 3);
INSERT INTO preciosum VALUES ('X-0001-PC', 4, 189.50, 20, 5);
INSERT INTO preciosum VALUES ('M-0003-C', 5, 34.99, 15, 2);
INSERT INTO preciosum VALUES ('C-1002-H', 3, 24.99, 18, 1);
INSERT INTO preciosum VALUES ('O-0001-P', 1, 69.95, 22, 4);


CREATE TABLE auditoria_pedido (
    id_audit NUMBER,
    fecha TIMESTAMP,
    operacion VARCHAR2(10),
    CONSTRAINT pk_auditoria_pedido PRIMARY KEY(id_audit) 
);
CREATE SEQUENCE sec_auditoria
START WITH 1
INCREMENT BY 1;

CREATE SEQUENCE sec_id
START WITH 1
INCREMENT BY 1;

CREATE TABLE auditoria_suministro (
    id_audit NUMBER,
    fecha_hora TIMESTAMP,
    operacion VARCHAR2(10),
    numpieza VARCHAR2(20),
    numvend INTEGER,
    preciounit_anterior NUMBER(20,2),
    preciounit_nuevo NUMBER(20,2),
    CONSTRAINT pk_auditoria PRIMARY KEY(id_audit) 
);


-- Consultas de las actividades DML II Part 2

SELECT DISTINCT numpieza, preciovent FROM pieza;

SELECT COUNT(DISTINCT numpieza || preciovent) FROM pieza;

SELECT DISTINCT numpedido, numvend, fecha FROM pedido; 

SELECT COUNT(DISTINCT numpedido || numvend || fecha FROM pedido;

SELECT v.nomvend, v.numvend FROM vendedor v WHERE v.nombrecomer LIKE '%S.A%' AND v.provincia = 'Valencia' 
OR v.provincia = 'Alicante' OR v.provincia = 'Castellon' ORDER BY v.nomvend;

SELECT nomvend FROM vendedor WHERE nombrecomer IS NOT NULL AND telefono IS NULL AND numvend > 3 AND numvend < 5 AND nomvend LIKE '%Martinez' ORDER BY numvend;

SELECT COUNT(numpieza) AS num_piezas_precio FROM pieza WHERE preciovent > 10; 

SELECT COUNT(DISTINCT numpieza) FROM preciosum WHERE numvend NOT IN(3, 9, 100, 4);

SELECT COUNT(DISTINCT numpieza) FROM preciosum WHERE diassum BETWEEN 3 AND 8 OR descuento IS NULL;

COMMIT;