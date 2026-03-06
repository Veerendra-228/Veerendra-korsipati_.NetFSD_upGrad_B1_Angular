create database assignment1db
use assignment1db

--level 2 problem 1--
--tables creation--
CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    store_id INT,
    order_status VARCHAR(20),
    FOREIGN KEY (store_id) REFERENCES stores(store_id)
);
CREATE TABLE order_items (
    order_id INT,
    item_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),
    PRIMARY KEY (order_id, item_id),
    FOREIGN KEY (order_id) REFERENCES orders(order_id)
);
--values insertion--
INSERT INTO stores VALUES (1,'Hyderabad Store');
INSERT INTO stores VALUES (2,'Mumbai Store');
INSERT INTO stores VALUES (3,'Delhi Store');

INSERT INTO orders VALUES (101,1,'Completed');
INSERT INTO orders VALUES (102,2,'Completed');
INSERT INTO orders VALUES (103,1,'Pending');
INSERT INTO orders VALUES (104,3,'Completed');
INSERT INTO orders VALUES (105,2,'Processing');

INSERT INTO order_items VALUES (101,1,2,500,0.10);
INSERT INTO order_items VALUES (101,2,1,700,0.05);
INSERT INTO order_items VALUES (102,1,3,400,0.00);
INSERT INTO order_items VALUES (104,1,1,1000,0.15);
INSERT INTO order_items VALUES (105,1,2,600,0.05);

--requirement 1---
SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
ON s.store_id = o.store_id
INNER JOIN order_items oi
ON o.order_id = oi.order_id
GROUP BY s.store_name;
--requirement 2---
SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
ON s.store_id = o.store_id
INNER JOIN order_items oi
ON o.order_id = oi.order_id
GROUP BY s.store_name;
--requirement 3---
SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
ON s.store_id = o.store_id
INNER JOIN order_items oi
ON o.order_id = oi.order_id
WHERE o.order_status = 'Completed'
GROUP BY s.store_name;
--requirement 4---
SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
ON s.store_id = o.store_id
INNER JOIN order_items oi
ON o.order_id = oi.order_id
WHERE o.order_status = 'Completed'
GROUP BY s.store_name;
--requirement 5---
SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
ON s.store_id = o.store_id
INNER JOIN order_items oi
ON o.order_id = oi.order_id
WHERE o.order_status = 'Completed'
GROUP BY s.store_name
ORDER BY total_sales DESC;


