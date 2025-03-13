ALTER TABLE pedidos ADD (fecha_compra DATE);
ALTER TABLE pedidos ADD (fecha_entrega TIMESTAMP);
ALTER TABLE pedidos ADD (fecha_devolucion VARCHAR2(10));

INSERT INTO pedidos (id_pedido, id_cliente, id_producto, fecha_compra, fecha_entrega, fecha_devolucion) VALUES (1, 'C001', 'P001', TO_DATE('15/12/2023', 'DD/MM/YYYY'), TO_TIMESTAMP('15-12-2023 14:30:00', 'DD-MM-YYYY HH24:MI:SS'), '15/12/2023');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto, fecha_compra, fecha_entrega, fecha_devolucion) VALUES (1, 'C002', 'P004', TO_DATE('16/12/2023', 'DD/MM/YYYY'), TO_TIMESTAMP('16-12-2023 14:30:00', 'DD-MM-YYYY HH24:MI:SS'), '16/12/2023');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto, fecha_compra, fecha_entrega, fecha_devolucion) VALUES (1, 'C003', 'P004', TO_DATE('17/12/2023', 'DD/MM/YYYY'), TO_TIMESTAMP('17-12-2023 14:30:00', 'DD-MM-YYYY HH24:MI:SS'), '17/12/2023');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (4, 'C004', 'P005');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (5, 'C005', 'P006');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (6, 'C006', 'P007');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (7, 'C007', 'P010');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (8, 'C008', 'P004');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (9, 'C009', 'P009');
INSERT INTO pedidos (id_pedido, id_cliente, id_producto) VALUES (10, 'C010', 'P008');

INSERT INTO pedidos () VALUES TO_CHAR(SYSTIMESTAMP, 'DD-MM-YYYY') AS fecha_devolucion FROM pedidos;