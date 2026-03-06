create database assignment2db
use assignment2db

--level 2 problem 2--
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100)
);
CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);
CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT,
    PRIMARY KEY (store_id, product_id),
    FOREIGN KEY (store_id) REFERENCES stores(store_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);
CREATE TABLE order_items (
    order_id INT,
    item_id INT,
    product_id INT,
    quantity INT,
    PRIMARY KEY (order_id, item_id)
);

INSERT INTO products VALUES (1,'Trek Marlin 7');
INSERT INTO products VALUES (2,'Giant Escape 3');
INSERT INTO products VALUES (3,'Specialized Turbo');

INSERT INTO stores VALUES (1,'Hyderabad Store');
INSERT INTO stores VALUES (2,'Mumbai Store');

INSERT INTO stocks VALUES (1,1,50);
INSERT INTO stocks VALUES (1,2,30);
INSERT INTO stocks VALUES (2,1,40);
INSERT INTO stocks VALUES (2,3,25);

INSERT INTO order_items VALUES (101,1,1,5);
INSERT INTO order_items VALUES (102,1,1,3);
INSERT INTO order_items VALUES (103,1,2,4);

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM stocks st
INNER JOIN products p
ON st.product_id = p.product_id
INNER JOIN stores s
ON st.store_id = s.store_id
LEFT JOIN order_items oi
ON st.product_id = oi.product_id
GROUP BY p.product_name, s.store_name, st.quantity;

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM stocks st
INNER JOIN products p
ON st.product_id = p.product_id
INNER JOIN stores s
ON st.store_id = s.store_id
LEFT JOIN order_items oi
ON st.product_id = oi.product_id
GROUP BY p.product_name, s.store_name, st.quantity;

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM stocks st
INNER JOIN products p
ON st.product_id = p.product_id
INNER JOIN stores s
ON st.store_id = s.store_id
LEFT JOIN order_items oi
ON st.product_id = oi.product_id
GROUP BY p.product_name, s.store_name, st.quantity;

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM stocks st
INNER JOIN products p
ON st.product_id = p.product_id
INNER JOIN stores s
ON st.store_id = s.store_id
LEFT JOIN order_items oi
ON st.product_id = oi.product_id
GROUP BY p.product_name, s.store_name, st.quantity
ORDER BY p.product_name;