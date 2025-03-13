CREATE TABLE vendedor (
numvend NUMBER(10),
nomvend VARCHAR2(10),
nombrecomer VARCHAR2(10),
telefono VARCHAR2(10),
calle VARCHAR2(30),
ciudad VARCHAR2(10),
provincia VARCHAR2(10),
CONSTRAINT pk_numvend PRIMARY KEY(numvend)
);

CREATE TABLE pieza (
numpieza VARCHAR2(10),
nompieza VARCHAR2(10),
preciovent NUMBER(10, 2),
CONSTRAINT pk_numpieza PRIMARY KEY(numpieza)
);

CREATE TABLE pedido (
numpedido NUMBER(10),
numvend NUMBER(10),
fecha DATE,
CONSTRAINT pk_numpedido PRIMARY KEY(numpedido)
);

CREATE TABLE linped (
numpedido NUMBER(10),
numlinea NUMBER(10),
numpieza VARCHAR2(10),
preciocompra NUMBER(10, 2),
cantpedidad NUMBER(30),
fecharecep DATE,
cantrecibida NUMBER(10),
CONSTRAINT pk_numpedidolinea PRIMARY KEY(numpedido, numlinea)
);

CREATE TABLE inventario (
numpieza VARCHAR2(10),
numbin NUMBER(10),
cantdisponible NUMBER(30),
fecharecuento DATE,
periodorecuen NUMBER(10),
cantminima NUMBER(10),
CONSTRAINT pk_numbin PRIMARY KEY (numbin)
);

CREATE TABLE preciosum (
numpieza VARCHAR2(10),
numvend NUMBER(10),
preciounit NUMBER(15, 2),
diassum NUMBER(10),
descuento NUMBER(10),
CONSTRAINT pk_numpiezavend PRIMARY KEY(numpieza, numvend)
);

ALTER TABLE preciosum ADD CONSTRAINT fk_numpieza FOREIGN KEY (numpieza) REFERENCES pieza (numpieza);
ALTER TABLE preciosum ADD CONSTRAINT fk_numvend FOREIGN KEY (numvend) REFERENCES vendedor (numvend);

ALTER TABLE pedido ADD CONSTRAINT fk_numvend2 FOREIGN KEY (numvend) REFERENCES vendedor (numvend);

ALTER TABLE linped ADD CONSTRAINT fk_numpiza2 FOREIGN KEY (numpieza) REFERENCES pieza (numpieza);
ALTER TABLE linped ADD CONSTRAINT fk_numpedido FOREIGN KEY (numpedido) REFERENCES pedido (numpedido);

ALTER TABLE linped ADD CONSTRAINT uk_numpieza UNIQUE (numpieza);
