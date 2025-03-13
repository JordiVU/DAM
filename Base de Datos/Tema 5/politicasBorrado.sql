CREATE TABLE  clientes (
id VARCHAR2(20),
nombre_completo VARCHAR2(20),
CONSTRAINT pk_id_clientes PRIMARY KEY(id)
);

CREATE TABLE productos (
id VARCHAR2(20),
descripcion VARCHAR2(20),
CONSTRAINT pk_id_productos PRIMARY KEY(id)
);

CREATE TABLE pedidos (
id_pedido NUMBER,
id_cliente VARCHAR2(20),
id_producto VARCHAR2(20),
CONSTRAINT pk_pedido PRIMARY KEY(id_pedido),
CONSTRAINT fk_pedidos_cliente FOREIGN KEY (id_cliente) REFERENCES clientes(id),
CONSTRAINT fk_pedidos_producto FOREIGN KEY (id_producto) REFERENCES productos(id) 
);

DELETE FROM clientes WHERE id = 'C001';

-- Nos dara un ERROR al existir una FK en otra tabla que señala a esta clave primaria.

UPDATE productos
SET id = 'PXXX'
WHERE id = 'P001';

-- Nos dara un ERROR debio a que no podemos modificar datos que estan siendo señalados en otra tabla por una FK.

DELETE FROM pedidos WHERE id_cliente = 'C001';
DELETE FROM clientes WHERE id = 'C001';
DELETE FROM productos WHERE id = 'P001';

ALTER TABLE pedidos DROP CONSTRAINT fk_pedidos_cliente;
ALTER TABLE pedidos DROP CONSTRAINT fk_pedidos_producto;

ALTER TABLE pedidos ADD CONSTRAINT fk_pedidos_cliente FOREIGN KEY(id_cliente) REFERENCES clientes(id) ON DELETE CASCADE;
ALTER TABLE pedidos ADD CONSTRAINT fk_pedidos_producto FOREIGN KEY(id_producto) REFERENCES productos(id) ON DELETE SET NULL;

DELETE FROM clientes WHERE id = 'C007';
DELETE FROM productos WHERE id = 'P008';