CREATE TABLE users(
	id BIGINT IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	username VARCHAR(25) NOT NULL,
	email VARCHAR(100) NOT NULL,
	phone_number VARCHAR(20),
	dob DATETIME,
	password_hash VARCHAR(250),
	about TEXT
);
ALTER TABLE users
ADD CONSTRAINT PK_user_id PRIMARY KEY (id);

ALTER TABLE users
ADD CONSTRAINT UQ_users_username UNIQUE (username)

ALTER TABLE users
ADD CONSTRAINT UQ_users_email UNIQUE (email)

CREATE INDEX IX_users_phone
ON users (phone_number)

ALTER TABLE users
ADD CONSTRAINT CHK_users_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20)

ALTER TABLE users
ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())


create table orders(
  id bigint primary key identity,
  quantity int not null default,
  product_id bigint not null,
  user_id bigint not null,
  
  constraint fk_orders_product_id
  foreign key(product_id) references products(id),
  
  constraint fk_orders_user_id
  foreign key(user_id) references users(id)
);


CREATE TABLE products
(
id BIGINT IDENTITY PRIMARY KEY,
name VARCHAR(100) NOT NULL,
description TEXT,
price DECIMAL(10,2) NOT NULL CHECK (price > 0),
stock_quantity INT NOT NULL DEFAULT 0,
created_at DATETIME2 DEFAULT GETDATE(),
)

INSERT INTO products (name, description, price, stock_quantity)
VALUES
('Laptop', 'High performance laptop with 16GB RAM and 512GB SSD.', 999.99, 50),
('Smartphone', 'Latest smartphone with OLED display and 128GB storage.', 699.50, 100),
('Headphones', 'Wireless noise-cancelling over-ear headphones.', 199.99, 150),
('Coffee Maker', 'Automatic drip coffee maker with 12-cup capacity.', 49.99, 200),
('Electric Kettle', '1.7-liter cordless electric kettle.', 29.95, 300),
('Smartwatch', 'Fitness tracking smartwatch with heart rate monitor.', 149.99, 80),
('Gaming Console', 'Next-gen gaming console with 1TB storage.', 499.00, 60),
('Bluetooth Speaker', 'Portable waterproof Bluetooth speaker.', 89.99, 120),
('Monitor', '27-inch 4K UHD monitor with HDR support.', 349.00, 75),
('Tablet', '10.5-inch tablet with 64GB storage and stylus support.', 279.99, 90);


create table product_categories(
  id bigint primary identity,
  category_id int,
  product_id bigint
  constraint fk_category_id
  foreign key(category_id) references categories(id),
  
  constraint fk_product_id
  foreign key(product_id) references products(id)
);

insert into product_categories values
(2,1), (3,1);
(3,1,), (3,2);

------------------------------------------

First Normal Form (1NF): Ensures that all columns contain atomic values and each record is unique.
Second Normal Form (2NF): Achieved when a database is in 1NF and all non-key attributes are fully functionally dependent on the primary key.
Third Normal Form (3NF): Achieved when a database is in 2NF and all attributes are dependent only on the primary key, eliminating transitive dependencies.
Boyce-Codd Normal Form (BCNF): A stricter version of 3NF where every determinant is a candidate key, resolving certain anomalies not addressed by 3NF.

------------------------------------------

JOINS :

INNER JOIN :

select 
order.id as order_id, 
product.id as product_id,
product.name,
product.price
from 
orders inner join products
on 
orders.product_id = product.id;

select 
order.id as order_id, 
product.id as product_id,
user.username,
product.name,
product.price
from 
orders 
inner join 
products on orders.product_id = product.id 
inner join 
users on orders.user_id = user.id;

LEFT JOIN : 

select 
order.id as order_id, 
product.id as product_id,
product.name,
product.price
from 
orders left join products
on 
orders.product_id = product.id;

RIGHT JOIN :

select 
order.id as order_id, 
product.id as product_id,
product.name,
product.price
from 
orders right join products
on 
orders.product_id = product.id;

---------------------------------








