ALTER TABLE pieza ADD (descripcion VARCHAR2(100));

ALTER TABLE pieza MODIFY(
nompieza VARCHAR2(30)
);

ALTER TABLE vendedor MODIFY(
nomvend VARCHAR2(30)
);

ALTER TABLE vendedor MODIFY(
ciudad VARCHAR2(20)
);

CREATE SEQUENCE seq_tienda_dam START WITH 1 INCREMENT BY 1 NOMAXVALUE;

-- Ejercicio 1 parte A

INSERT INTO pieza 
(numpieza, nompieza, preciovent, descripcion) 
VALUES 
('A-1001-L', 'MOUSE ADL 3B', 7, 'Periférico de entrada');

INSERT INTO pieza 
(numpieza, preciovent) 
VALUES 
('C-1002-H', 4);

INSERT INTO pieza 
(numpieza, preciovent) 
VALUES 
('C-1002-J', 0);

INSERT INTO pieza
(numpieza, nompieza)
VALUES
('C-400-Z', 'FILTRO PANTALLA X200');

INSERT INTO pieza
(numpieza, nompieza, preciovent)
VALUES
('DK 144-0001', 'USB 1TB PANASONIC', 65);

INSERT INTO pieza
(numpieza, nompieza, preciovent, descripcion)
VALUES
('DK 144-0002-P', 'DISCO EXTERNO 1TB CRUCIAL XD', 80, 'Sin descripcion');

INSERT INTO pieza
(numpieza, nompieza, preciovent)
VALUES
('O-0001-P', 'TECLADO ATSU', 20);

INSERT INTO pieza
(numpieza, nompieza, preciovent, descripcion)
VALUES
('T-0002-AT', 'TECLADO ESTANDAR PC', 25, 'Sin descripcion');

INSERT INTO pieza
(numpieza)
VALUES
('X-0001-PC');

INSERT INTO pieza
(numpieza, nompieza, preciovent, descripcion)
VALUES
('P-1113-PC', 'POCKET_PC', 30, 'Periferico de salida');

-- Ejercicio 1 parte B

INSERT INTO vendedor
(numvend, nomvend, nombrecomer, telefono, calle, ciudad, provincia)
VALUES
(200, 'Seveirno Martín', 'SEVESOFT', '666777888', 'General Lacy, 17', 'ALICANTE', 'ALICANTE');

INSERT INTO vendedor
(numvend, nomvend, nombrecomer, telefono, calle, ciudad, provincia)
VALUES
(3, 'Godofredo Martínez', 'MECESMSA', '777888999', 'Avda. Valencia, 3', 'SAN VICENTE', 'ALICANTE');

INSERT INTO vendedor
(numvend, nomvend, nombrecomer, calle, ciudad, provincia)
VALUES
(5, 'Juanito Reina Princesa', 'LA''DECAI', 'Asis 10', 'GIJON', 'ASTURIAS');

INSERT INTO vendedor
(numvend, nomvend, nombrecomer, telefono, calle, ciudad, provincia)
VALUES
(6, 'Manuel Pérez Rodríguez', 'SOFTHARD', '2223344567', 'Temul, 1', 'TOLEDO', 'TOLEDO');

INSERT INTO vendedor
(numvend, nomvend, nombrecomer)
VALUES
(100, 'Toñi García', 'SOFTHARD');

-- Ejercicio 1 parte C

CREATE SEQUENCE seq_pedido START WITH 1 INCREMENT BY 1 NOMAXVALUE;

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 200, TO_DATE('10/10/2010', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 200, TO_DATE('05/08/2023', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 3, TO_DATE('05/03/2009', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 5, TO_DATE('01/03/2021', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 200, TO_DATE('10/10/2020', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 3, TO_DATE('30/12/2009', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 3, TO_DATE('12/07/2009', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 3, TO_DATE('14/10/2009', 'DD/MM/YYYY'));

INSERT INTO pedido
(numpedido, numvend, fecha)
VALUES
(seq_pedido.NEXTVAL, 3, TO_DATE('14/10/2009', 'DD/MM/YYYY'));

-- Ejercicio 1 parte D 

CREATE SEQUENCE seq_preciosum START WITH 1 INCREMENT BY 1 NOMAXVALUE;

ALTER TABLE preciosum ADD (id NUMBER(30));

INSERT INTO preciosum
(id, numvend, numpieza, preciounit, diassum, descuento)
VALUES
(seq_preciosum.NEXTVAL, 3, 'A-1001-L', 5, 3, 10);

INSERT INTO preciosum
(id, numvend, numpieza, preciounit, diassum)
VALUES
(seq_preciosum.NEXTVAL, 200, 'C-1002-H', 2, 5);

INSERT INTO preciosum
(id, numvend, numpieza, diassum)
VALUES
(seq_preciosum.NEXTVAL, 5, 'DK 144-0002-P', 2);

INSERT INTO preciosum
(numvend, diassum, descuento)
VALUES
(100, 'O-0001-PP', 2, 5);

-- Ejercicio 1 parte G

INSERT INTO pieza 
(numpieza, preciovent) 
VALUES 
('M-0002-JT',  100000000000,50);

--Nos dara un error ORA-00913: demasiados valores. Dandonos a entender que no podemos introducir ese rango de precio, ya que es muy superior al permitido.

-- Ejercicio 2 parte A
UPDATE pedido SET fecha = '01/01/2024' WHERE fecha = '14/10/2009'; 

-- EJERCICIO 2 Parte B 
UPDATE vendedor SET telefono = 'SIN TELÉFONO' WHERE telefono IS NULL;

-- EJERCICIO 2 Parte C
UPDATE vendedor SET ciudad = 'TOLEDO' WHERE ciudad <> 'ALICANTE';

-- EJERCICIO 2 Parte D
UPDATE preciosum SET preciounit = 10 WHERE preciounit IS NULL;

-- EJERCICIO 2 parte E
UPDATE pieza SET preciovent = preciovent + 100 WHERE nompieza LIKE '%USB%' OR nompieza LIKE '%DISCO%';

-- EJERCICIO 2 parte F
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'A-1001-L';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'C-1002-H';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'C-1002-J';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'C-400-Z';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'DK 144-0001';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'T-0002-AT';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'DK 144-0002-P';
UPDATE pieza SET preciovent = 3 WHERE numpieza = '0-0001-PP';
SAVEPOINT sav1;
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'X-0001-PC';
UPDATE pieza SET preciovent = 3 WHERE numpieza = 'P-1113-PC';
ROLLBACK TO sav1;

-- EJERCICIO 3 parte A
DELETE FROM pieza WHERE descripcion IS NULL;

-- EJERCICIO 3 Parte B, no hay tablas que coincidan nombre con las piezas pero si sabemos que el numero de vendedor de JUANITO REINA PRINCESA es 3.
DELETE FROM preciosum WHERE numvend = 3; 

-- EJERCICIO 3 Parte C
DELETE FROM pedido;

-- EJERCICIO 3 Parte D, de la parte de piezas ya hemos eliminado antes C-1002-H al no tener descripcion.
DELETE FROM preciosum WHERE numpieza = 'C-1002-H' OR numpieza = 'A-1001-L';
DELETE FROM pieza WHERE numpieza = 'C-1002-H' OR numpieza = 'A-1001-L';

-- EJERCICIO 3 Parte E
DELETE FROM pedido WHERE fecha >= TO_DATE('01/01/2024', 'DD/MM/YYYY');


-- EJERCICIO 4
-- Cuando utilizamos las politicas de ON DELETE CASCADE y ON DELETE SET NULL debemos tener en cuenta que deben ser implementadas a la hora de la creacion de la tabla
-- concretamente a la hora de realizar las CONSTRAINT de la Foreign Key, estableceremos las politicas de borrado. Si colocamos ON DELETE CASCADE haremos que en consecuencia 
-- que se borre tambien en las otras tablas, a diferencia de ON DELETE SET NULL que provocaremos que en vez de borrar el campo sea reamplazado por un NULL.

-- EJEMPLO ON DELETE CASCADE
-- CONSTRAINT fk_pedidos FOREIGN KEY (id_pedido) REFERENCES vendedor (id_pedido) ON DELETE CASCADE;

-- EJEMPLO ON DELETE SET NULL.
-- CONSTRAINT fk_pedidos FOREIGN KEY (id_pedido) REFERENCES vendedor (id_pedido) ON DELETE SET NULL;