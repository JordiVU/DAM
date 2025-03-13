CREATE TABLE marcas (
    cifm VARCHAR2(10),
    nombre VARCHAR2(20),
    ciudad VARCHAR2(35),
    CONSTRAINT pk_marcas PRIMARY KEY (cifm)
);

CREATE TABLE coches (
    codcoche VARCHAR2(30),
    nombre VARCHAR2(20),
    modelo VARCHAR2(20),
    CONSTRAINT pk_coches PRIMARY KEY (codcoche)
);

CREATE TABLE concesionarios (
    cifc VARCHAR2(10),
    nombre VARCHAR2(20),
    ciudad VARCHAR2(35),
    CONSTRAINT pk_concesionarios PRIMARY KEY (cifc)
);

CREATE TABLE clientes (
    dni VARCHAR2(10),
    nombre VARCHAR2(20),
    apellidos VARCHAR2(30),
    ciudad VARCHAR2(35),
    CONSTRAINT pk_clientes PRIMARY KEY (dni)
);

CREATE TABLE distribucion (
    cifc VARCHAR2(10),
    codcoche VARCHAR2(30),
    cantidad NUMBER(30),
    CONSTRAINT pk_distribucion PRIMARY KEY (cifc, codcoche),
    CONSTRAINT fk_distribucion_concesionarios FOREIGN KEY (cifc)REFERENCES concesionarios(cifc) ON DELETE CASCADE,
    CONSTRAINT fk_distribucion_coches FOREIGN KEY (codcoche)REFERENCES coches(codcoche) ON DELETE CASCADE
);

CREATE TABLE ventas (
    cifc VARCHAR2(10),
    dni VARCHAR2(10),
    codcoche VARCHAR2(30),
    color VARCHAR2(20),
    CONSTRAINT pk_ventas PRIMARY KEY (cifc, dni, codcoche),
    CONSTRAINT fk_ventas_concesionarios FOREIGN KEY (cifc) REFERENCES concesionarios(cifc) ON DELETE CASCADE,
    CONSTRAINT fk_ventas_clientes FOREIGN KEY (dni) REFERENCES clientes(dni) ON DELETE CASCADE,
    CONSTRAINT fk_ventas_coches FOREIGN KEY (codcoche) REFERENCES coches(codcoche) ON DELETE CASCADE
);

CREATE TABLE marco (
    cifm VARCHAR2(15),
    codcoche VARCHAR2(30),
    CONSTRAINT pk_marco PRIMARY KEY (cifm, codcoche),
    CONSTRAINT fk_marco_marcas FOREIGN KEY (cifm) REFERENCES marcas(cifm) ON DELETE CASCADE,
    CONSTRAINT fk_marco_coches FOREIGN KEY (codcoche) REFERENCES coches(codcoche) ON DELETE CASCADE
);

INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('111111A', 'Cliente1', 'Sánchez', 'Madrid');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('222222B', 'Cliente2', 'Martínez', 'Barcelona');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('333333C', 'Cliente3', 'Díaz', 'Madrid');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('444444D', 'Cliente4', 'Solguera', 'Sevilla');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('555555E', 'Cliente5', 'Moreno', 'Valencia');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('666666F', 'Cliente6', 'Torregrosa', 'Madrid');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('777777G', 'Cliente7', 'Fernández', 'Bilbao');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('888888H', 'Cliente8', 'Lumire', 'Madrid');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('999999I', 'Cliente9', 'Wayne', 'Málaga');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('101010J', 'Cliente10', 'Detmi', 'Madrid');
INSERT INTO clientes (dni, nombre, apellidos, ciudad)
VALUES
    ('111111K', 'Cliente11', 'Zaragoza', '123000456');

	

INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM1', 'Honda', 'Madrid');
INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM2', 'Audi', 'Barcelona');
INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM3', 'Dacia', 'Madrid');
INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM4', 'Seat', 'Sevilla');
INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM5', 'Nissan', 'Valencia');
INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM6', 'Skoda', 'Madrid');
INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM7', 'Mercedes', 'Bilbao');
	INSERT INTO marcas (cifm, nombre, ciudad)
VALUES
    ('CIFM8', 'Ford', 'Bilbao');

	
INSERT INTO concesionarios (cifc, nombre, ciudad)
VALUES
    ('CIFC1', 'Hijos M.Crespo', 'Madrid');
INSERT INTO concesionarios (cifc, nombre, ciudad)
VALUES
    ('CIFC2', 'Hermanos Amorós', 'Barcelona');
INSERT INTO concesionarios (cifc, nombre, ciudad)
VALUES
    ('CIFC3', 'Borja Motor', 'Sevilla');

INSERT INTO concesionarios (cifc, nombre, ciudad)
VALUES
    ('CIFC4', 'Alicante Motor', 'Marca2');
INSERT INTO concesionarios (cifc, nombre, ciudad)
VALUES
    ('CIFC5', 'Marcos Automoción', 'Marca3');


INSERT INTO coches (codcoche, nombre, modelo)
VALUES
    ('CODC1', 'Coche1', 'XPR');
INSERT INTO coches (codcoche, nombre, modelo)
VALUES
    ('CODC2', 'Coche2', 'AUTR');
INSERT INTO coches (codcoche, nombre, modelo)
VALUES
    ('CODC3', 'Auto3', 'LMM');
INSERT INTO coches (codcoche, nombre, modelo)
VALUES
    ('CODC4', 'Auto4', 'DMM');
INSERT INTO coches (codcoche, nombre, modelo)
VALUES
    ('CODC5', 'Coche5', 'STP');


INSERT INTO distribucion (cifc, codcoche, cantidad)
VALUES
    ('CIFC1', 'CODC1', 10);
INSERT INTO distribucion (cifc, codcoche, cantidad)
VALUES
    ('CIFC1', 'CODC2', 20);
INSERT INTO distribucion (cifc, codcoche, cantidad)
VALUES
    ('CIFC3', 'CODC3', 5);
INSERT INTO distribucion (cifc, codcoche, cantidad)
VALUES
    ('CIFC4', 'CODC3', 300);
INSERT INTO distribucion (cifc, codcoche, cantidad)
VALUES
    ('CIFC5', 'CODC5', 8);
	
SELECT dni,nombre,apellidos,ciudad FROM clientes WHERE ciudad = 'Madrid';

SELECT nombre FROM coches ORDER BY nombre ASC;

SELECT cifc FROM distribucion WHERE cantidad > 18;

SELECT cifc FROM distribucion WHERE cantidad BETWEEN 10 AND 18;

SELECT cifc FROM distribucion WHERE cantidad >= 10 AND cantidad <= 18;

SELECT cifc AS calc1 FROM distribucion WHERE cantidad > 10 OR cantidad < 3;

SELECT codcoche AS cocheConC FROM coches WHERE nombre LIKE 'C%' OR nombre LIKE 'c%';

SELECT codcoche AS cocheSinA FROM coches WHERE nombre NOT LIKE '%A%' AND nombre NOT LIKE '%a%';

SELECT DISTINCT nombre AS calc2 FROM marcas WHERE ciudad = 'Madrid'; 

SELECT cifc FROM distribucion WHERE cantidad IS NOT NULL;

SELECT cifm, nombre FROM marcas WHERE ciudad LIKE '_i%';

SELECT m.cifm, m.nombre, m.ciudad FROM marcas m WHERE m.ciudad LIKE 'Alicante' OR m.ciudad LIKE 'Valencia' OR m.ciudad LIKE 'Castellon' OR m.ciudad LIKE 'Tarragona' 
		OR m.ciudad LIKE 'Madrid' OR m.ciudad LIKE 'Sevilla' OR m.ciudad LIKE 'Barcelona' OR m.ciudad LIKE 'Cordoba';

COMMIT;
	