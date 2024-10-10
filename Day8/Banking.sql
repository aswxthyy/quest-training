create table Customers(
  ID int primary key identity,
  AccNo bigint,
  Name varchar(50),
  PhoneNo varchar(10),
  BankBalance bigint check(BankBalance >= 0)
);

create table Transactions(
  TransID int primary key identity,
  TransType varchar(20) check(TransType in ('Withdraw','Deposit','Transfer')),
  TransDate datetime,
  SenderID int,
  Sender varchar(50),
  ReceiverID int,
  Receiver varchar(50),
  Amount bigint,
  
  
  constraint fk_sender_id foreign key(SenderID) references Customers(ID),
  constraint fk_rece_id foreign key(ReceiverID) references Customers(ID)
);

INSERT INTO Customers (AccNo, Name, PhoneNo, BankBalance) VALUES
(1001, 'Alice Johnson', '1234567890', 5000),
(1002, 'Bob Smith', '0987654321', 3000),
(1003, 'Charlie Brown', '5551234567', 7000),
(1004, 'Diana Prince', '5559876543', 2500),
(1005, 'Eve Adams', '6668889999', 6000),
(1006, 'Frank Castle', '7775554444', 1500),
(1007, 'Grace Lee', '8882223333', 9000),
(1008, 'Hannah White', '9993334444', 3500),
(1009, 'Ivy Green', '4446667777', 1200),
(1010, 'Jack Black', '1112223333', 4500);

INSERT INTO Transactions (TransType, TransDate, SenderID, Sender, ReceiverID, Receiver, Amount) VALUES
('Deposit', '2024-10-01 10:00:00', 1, 'Alice Johnson', NULL, NULL, 1500),
('Withdraw', '2024-10-02 11:30:00', 2, 'Bob Smith', NULL, NULL, 500),
('Transfer', '2024-10-03 14:15:00', 3, 'Charlie Brown', 4, 'Diana Prince', 1000),
('Deposit', '2024-10-04 09:45:00', 4, 'Diana Prince', NULL, NULL, 300),
('Withdraw', '2024-10-05 15:00:00', 5, 'Eve Adams', NULL, NULL, 200),
('Transfer', '2024-10-06 12:30:00', 6, 'Frank Castle', 7, 'Grace Lee', 100),
('Deposit', '2024-10-07 08:00:00', 8, 'Hannah White', NULL, NULL, 500),
('Withdraw', '2024-10-08 16:45:00', 9, 'Ivy Green', NULL, NULL, 300),
('Transfer', '2024-10-09 13:20:00', 10, 'Jack Black', 1, 'Alice Johnson', 250),
('Deposit', '2024-10-10 09:10:00', 2, 'Bob Smith', NULL, NULL, 1000);


select * from customers;
select * from transactions;

update customers 
set bankbalance = bankbalance + 1500 
where id = 1;

update customers 
set bankbalance = bankbalance - 500 
where id = 2;

update customers 
set bankbalance = bankbalance - 1000 
where id = 3;

update customers 
set bankbalance = bankbalance + 1000 
where id = 4;

update customers 
set bankbalance = bankbalance + 300 
where id = 4;

update customers 
set bankbalance = bankbalance - 200 
where id = 5;

update customers 
set bankbalance = bankbalance - 100 
where id = 6;

update customers 
set bankbalance = bankbalance + 100 
where id = 7;

update customers 
set bankbalance = bankbalance + 500 
where id = 8;

update customers 
set bankbalance = bankbalance - 300 
where id = 9;

update customers 
set bankbalance = bankbalance - 250 
where id = 10;

update customers 
set bankbalance = bankbalance + 250 
where id = 1;

update customers 
set bankbalance = bankbalance + 1000 
where id = 2;

select * from customers;
select * from transactions;




