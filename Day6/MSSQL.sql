
-- create
create table STUDENTS(
  ID int primary key identity,
  NAME varchar(10) not null,
  EMAIL varchar(20) not null unique,
  CLASS int default 1
);

-- insert
insert into STUDENTS(name, email, class) values
  ('Alpha', 'user1@mail.com', 1),
  ('Beta', 'user2@mail.com', 2),
  ('Gamma', 'user3@mail.com', 2),
  ('Delta', 'user4@mail.com', 1),
  ('Epsilon', 'user5@mail.com', 3),
  ('Eeta', 'user6@mail.com', 3),
  ('Theta', 'user7@mail.com', 4),
  ('Lambda', 'user8@mail.com', 5);
    
-- fetch 
-- select * from students;

-- select NAME, ID from STUDENTS where email = 'user1@mail.com';
-- select name, id, class from students order by name asc;
-- select name, id, class from students order by name desc;
-- select name, id, class from students where id between 1 and 4;
-- select name, id, class from students where class in (1,3);


select class, count(id) as countof from students group by class having count(id)<5;

select top 3 name, id, class from students; 

select name, id, class from students order by id offset 4 rows fetch next 3 rows only;
select sum(class) as [sum] from students;
select count(class) as [count] from students;
select min(class) as [min] from students;
select max(class) as [max] from students;
select avg(class) as [avg] from students;


-------------------------------------------------------

create table products(
    id BIGINT IDENTITY PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10,2) NOT NULL CHECK (price<0),
    stock INT NOT NULL DEFAULT 0 CHECK (stock>=0),
    created_at DATETIME2 DEFAULT GETDATE()
)
One-to-One: A single record in one table is related to a single record in another table (e.g., each person has one passport).
One-to-Many: A single record in one table can be related to multiple records in another table (e.g., a teacher can have many students).
Many-to-One: Multiple records in one table can relate to a single record in another table (e.g., many students can belong to one class).
Many-to-Many: Multiple records in one table can relate to multiple records in another table (e.g., students can enroll in multiple courses, and each course can have multiple students).















