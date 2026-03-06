--level 1 problem 2---
CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(50)
);
CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),
    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);
--table 1 values--
INSERT INTO brands VALUES (1,'Trek');
INSERT INTO brands VALUES (2,'Giant');
INSERT INTO brands VALUES (3,'Specialized');
--table 2 values--
INSERT INTO categories VALUES (1,'Mountain Bikes');
INSERT INTO categories VALUES (2,'Road Bikes');
INSERT INTO categories VALUES (3,'Electric Bikes');
--table 3 values--
INSERT INTO products VALUES (101,'Trek Marlin 7',1,1,2023,650);
INSERT INTO products VALUES (102,'Giant Escape 3',2,2,2022,480);
INSERT INTO products VALUES (103,'Specialized Turbo',3,3,2024,1200);
INSERT INTO products VALUES (104,'Trek Domane',1,2,2023,900);
INSERT INTO products VALUES (105,'Giant Talon',2,1,2021,520);

--requirement 1---
SELECT 
p.product_name,
b.brand_name,
c.category_name,
p.model_year,
p.list_price
FROM products p
INNER JOIN brands b
ON p.brand_id = b.brand_id
INNER JOIN categories c
ON p.category_id = c.category_id;

---requirement 2--
SELECT 
p.product_name,
b.brand_name,
c.category_name,
p.model_year,
p.list_price
FROM products p
INNER JOIN brands b
ON p.brand_id = b.brand_id
INNER JOIN categories c
ON p.category_id = c.category_id
WHERE p.list_price > 500;

--requirement 3--
SELECT 
p.product_name,
b.brand_name,
c.category_name,
p.model_year,
p.list_price
FROM products p
INNER JOIN brands b
ON p.brand_id = b.brand_id
INNER JOIN categories c
ON p.category_id = c.category_id
WHERE p.list_price > 500
ORDER BY p.list_price ASC;