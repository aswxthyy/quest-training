
create table student(
  id int primary key identity,
  name varchar(10)
);

insert into student (name) values
('Alpha'),
('Beta'),
('Gamma'),
('Delta'),
('Epsilon');

create table subjects(
  id int primary key identity,
  sub_code varchar(6),
  subject varchar(50)
);

insert into subjects (sub_code, subject) values
('CST101','Advanced Physics'),
('CST201','Engineering Graphics'),
('CST305','Data Structures'),
('HUN404','Operating Systems');

create table exam(
  id int primary key identity,
  exam_name varchar(10),
  min_marks int,
  max_marks int,
);

insert into exam (exam_name, min_marks, max_marks) values
('S1',40,100),
('S2',50,100),
('S3',45,100);

create table marks(
  id int primary key identity,
  std_id int,
  sub_id int,
  exam int,
  marks int,
  
  CONSTRAINT fk_std_id FOREIGN KEY (std_id) REFERENCES student(id),
  CONSTRAINT fk_sub_id FOREIGN KEY (sub_id) REFERENCES subjects(id),
  CONSTRAINT fk_exam_id FOREIGN KEY (exam) REFERENCES exam(id)
);

INSERT INTO marks (std_id, sub_id, exam, marks) VALUES
(1,2,1,75),  
(2,2,2,80), 
(3,4,2,60),  
(4,1,3,50),
(5,3,2,90);  

go

create view studentmarks as 
select 
student.id,
subjects.subject,
marks.marks,
exam.exam_name
from 
marks 
inner join 
student on marks.std_id = student.id
inner join
subjects on marks.sub_id = subjects.id
inner join 
exam on marks.exam = exam.id;

go

select * from studentmarks;

select 
exam.exam_name,
student.name,
marks.marks
from 
marks
inner join 
student on marks.std_id = student.id
inner join
subjects on marks.sub_id = subjects.id
inner join 
exam on marks.exam = exam.id;

-------------------------------------

Theory : 

DDL (Data Definition Language)
Purpose: Defines the structure of the database.
Commands: CREATE, ALTER, DROP
Examples: Creating tables or modifying their structure.

DML (Data Manipulation Language)
Purpose: Manipulates data within existing tables.
Commands: INSERT, UPDATE, DELETE
Examples: Adding new records or modifying existing ones.

DCL (Data Control Language)
Purpose: Controls access to data.
Commands: GRANT, REVOKE
Examples: Assigning permissions to users.

TCL (Transaction Control Language)
Purpose: Manages transactions in the database.
Commands: COMMIT, ROLLBACK, SAVEPOINT
Examples: Saving changes or undoing them.

DQL (Data Query Language)
Purpose: Queries data from the database.
Commands: SELECT
Examples: Retrieving data from tables.

Aggregate Functions
Purpose: Perform calculations on multiple rows and return a single value.
Common Functions:
COUNT(): Counts rows.
SUM(): Sums numeric values.
AVG(): Calculates average.
MAX(): Finds the maximum value.
MIN(): Finds the minimum value.

Joins
Purpose: Combine rows from two or more tables based on related columns.
Types:
INNER JOIN: Returns matching rows from both tables.
LEFT JOIN (OUTER): Returns all rows from the left table and matched rows from the right.
RIGHT JOIN (OUTER): Returns all rows from the right table and matched rows from the left.
FULL OUTER JOIN: Returns rows when there is a match in one of the tables.

GROUP BY and HAVING
GROUP BY: Groups rows that have the same values in specified columns into summary rows (e.g., to calculate aggregate functions).
HAVING: Filters records after aggregation; used with GROUP BY to apply conditions on groups.

DISTINCT
Purpose: Removes duplicate rows from the result set.
Example: SELECT DISTINCT column_name FROM table;
Views
Purpose: Virtual tables based on the result of a SELECT query.
Use: Simplifies complex queries and provides a layer of security by restricting access to specific data.

CREATE INDEX
Purpose: Improves the speed of data retrieval operations on a table.
Example: CREATE INDEX index_name ON table_name (column_name);

Subquery
Purpose: A query nested inside another query.
Use: Can be used in SELECT, INSERT, UPDATE, or DELETE statements to provide data for the main query.

Stored Procedure
Purpose: A saved collection of SQL statements that can be reused.
Use: Encapsulates complex operations, accepts parameters, and can improve performance by reducing network traffic.

Triggers
Purpose: Automatically execute a specified action in response to certain events on a table (like INSERT, UPDATE, DELETE).
Use: Enforces business rules and maintains data integrity.
These notes provide a high-level understanding of each topic. Let me know if you need more details on any specific area!






























