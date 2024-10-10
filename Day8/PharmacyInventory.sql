create table Suppliers(
  id int primary key identity,
  name varchar(40),
  contact_person varchar(40),
  phone bigint,
  email varchar(50),
  address varchar(100)
);

create table Medications(
  id int primary key identity,
  name varchar(40),
  category varchar(20),
  price decimal(5,2),
  expiry_date date,
  supplier_id int,
  stock_quantity int,
  
  constraint fk_med_spp_id foreign key(supplier_id) references suppliers(id)
);

create table Customers(
  id int primary key identity,
  name varchar(40),
  phone bigint,
  email varchar(50),
  address varchar(100)
);

create table Inventory(
  id int primary key identity,
  medication_id int,
  supplier_id int,
  stock_in int,
  stock_out int,
  date_added date,
  
  constraint fk_inv_med_id foreign key(medication_id) references Medications(id),
  constraint fk_inv_spp_id foreign key(supplier_id) references suppliers(id)
  
);

create table Sales(
  id int primary key identity,
  customer_id int,
  medication_id int,
  quantity int,
  sale_date date,
  total_price decimal(5,2),
  
  constraint fk_sal_cust_id foreign key(customer_id) references Customers(id),
  constraint fk_sal_med_id foreign key(medication_id) references Medications(id)
);
-------------------------------------------
go

create procedure enter_supplier(
  @name varchar(40),
  @contact_person varchar(40),
  @phone bigint,
  @email varchar(50),
  @address varchar(100)
)
as
begin
  insert into suppliers (name, contact_person, phone, email, address)
  values (@name, @contact_person, @phone, @email, @address);
end;
exec enter_supplier 
  @name = 'Supplier A',
  @contact_person = 'John Doe',
  @phone = 1234567890,
  @email = 'contact@supplierA.com',
  @address = '123 Supplier St, City A';

exec enter_supplier 
  @name = 'Supplier B',
  @contact_person = 'Jane Smith',
  @phone = 9876543210,
  @email = 'contact@supplierB.com',
  @address = '456 Supplier Ave, City B';

exec enter_supplier 
  @name = 'Supplier C',
  @contact_person = 'Alice Brown',
  @phone = 5551234567,
  @email = 'contact@supplierC.com',
  @address = '789 Supplier Blvd, City C';

exec enter_supplier 
  @name = 'Supplier D',
  @contact_person = 'Bob White',
  @phone = 5559876543,
  @email = 'contact@supplierD.com',
  @address = '321 Supplier Pl, City D';

exec enter_supplier 
  @name = 'Supplier E',
  @contact_person = 'Charlie Green',
  @phone = 5556543210,
  @email = 'contact@supplierE.com',
  @address = '654 Supplier Ct, City E';

-------------------------------------------
go 

create procedure enter_medication(
  @name varchar(40),
  @category varchar(20),
  @price decimal(5,2),
  @expiry_date date,
  @supplier_id int,
  @stock_quantity int
)
as
begin
  insert into medications (name, category, price, expiry_date, supplier_id, stock_quantity)
  values (@name, @category, @price, @expiry_date, @supplier_id, @stock_quantity);
end;
exec enter_medication 
  @name = 'Medication A',
  @category = 'Pain Relief',
  @price = 10.00,
  @expiry_date = '2025-12-31',
  @supplier_id = 1,
  @stock_quantity = 100;

exec enter_medication 
  @name = 'Medication B',
  @category = 'Antibiotic',
  @price = 15.00,
  @expiry_date = '2024-11-30',
  @supplier_id = 2,
  @stock_quantity = 200;

exec enter_medication 
  @name = 'Medication C',
  @category = 'Antihistamine',
  @price = 8.50,
  @expiry_date = '2025-10-15',
  @supplier_id = 3,
  @stock_quantity = 150;

exec enter_medication 
  @name = 'Medication D',
  @category = 'Antidepressant',
  @price = 20.00,
  @expiry_date = '2025-09-01',
  @supplier_id = 4,
  @stock_quantity = 75;

exec enter_medication 
  @name = 'Medication E',
  @category = 'Vitamins',
  @price = 12.25,
  @expiry_date = '2024-08-20',
  @supplier_id = 5,
  @stock_quantity = 200;
-------------------------------------------
go
create procedure enter_customer (
  @name varchar(40),
  @phone bigint,
  @email varchar(50),
  @address varchar(100)
)
as
begin
  insert into customers (name, phone, email, address)
  values (@name, @phone, @email, @address);
end;
exec enter_customer 
  @name = 'Customer One',
  @phone = 5551234567,
  @email = 'customer1@example.com',
  @address = '789 Customer Rd, City A';

exec enter_customer 
  @name = 'Customer Two',
  @phone = 5557654321,
  @email = 'customer2@example.com',
  @address = '321 Customer St, City B';

exec enter_customer 
  @name = 'Customer Three',
  @phone = 5559876543,
  @email = 'customer3@example.com',
  @address = '456 Customer Ave, City C';

exec enter_customer 
  @name = 'Customer Four',
  @phone = 5554567890,
  @email = 'customer4@example.com',
  @address = '789 Customer Blvd, City D';

exec enter_customer 
  @name = 'Customer Five',
  @phone = 5556543210,
  @email = 'customer5@example.com',
  @address = '321 Customer Ct, City E';

-------------------------------------------
go
create procedure enter_inventory (
  @medication_id int,
  @supplier_id int,
  @stock_in int,
  @stock_out int,
  @date_added date
)
as
begin
  insert into inventory (medication_id, supplier_id, stock_in, stock_out, date_added)
  values (@medication_id, @supplier_id, @stock_in, @stock_out, @date_added);
end;

exec enter_inventory 
  @medication_id = 1,
  @supplier_id = 1,
  @stock_in = 50,
  @stock_out = 5,
  @date_added = '2024-01-10';

exec enter_inventory 
  @medication_id = 2,
  @supplier_id = 2,
  @stock_in = 30,
  @stock_out = 10,
  @date_added = '2024-01-15';

exec enter_inventory 
  @medication_id = 3,
  @supplier_id = 3,
  @stock_in = 20,
  @stock_out = 2,
  @date_added = '2024-01-20';

exec enter_inventory 
  @medication_id = 4,
  @supplier_id = 4,
  @stock_in = 25,
  @stock_out = 5,
  @date_added = '2024-01-25';

exec enter_inventory 
  @medication_id = 5,
  @supplier_id = 5,
  @stock_in = 40,
  @stock_out = 0,
  @date_added = '2024-02-01';

-------------------------------------------
go
create procedure enter_sale (
  @customer_id int,
  @medication_id int,
  @quantity int,
  @sale_date date,
  @total_price decimal(5,2)
)
as
begin
  insert into sales (customer_id, medication_id, quantity, sale_date, total_price)
  values (@customer_id, @medication_id, @quantity, @sale_date, @total_price);
end;

exec enter_sale 
  @customer_id = 1,
  @medication_id = 1,
  @quantity = 2,
  @sale_date = '2024-01-20',
  @total_price = 20.00;

exec enter_sale 
  @customer_id = 2,
  @medication_id = 2,
  @quantity = 1,
  @sale_date = '2024-01-22',
  @total_price = 15.00;

exec enter_sale 
  @customer_id = 3,
  @medication_id = 3,
  @quantity = 3,
  @sale_date = '2024-01-25',
  @total_price = 25.50;

exec enter_sale 
  @customer_id = 4,
  @medication_id = 4,
  @quantity = 1,
  @sale_date = '2024-01-28',
  @total_price = 20.00;

exec enter_sale 
  @customer_id = 5,
  @medication_id = 5,
  @quantity = 4,
  @sale_date = '2024-02-02',
  @total_price = 49.00;














