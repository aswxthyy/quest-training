Q1.ASSIGNMENT :

You are working on a database for a school’s student
management system. The system contains a table named 
courses that stores information about the courses offered 
at the school and the students enrolled in them.
 
You have been tasked to generate a report that shows the following information for each course:
1. The total number of students enrolled.
2. The total fees collected for each course. 
3. The course with the maximum number of enrolments.

Write SQL queries to accomplish the following tasks:
1. Find the total number of students enrolled in each course:
    * The result should display the course_name and the total count of students enrolled in that course.
2. Calculate the total fees collected for each course:
    * The result should display the course_name and the sum of the course_fee collected.
3. Determine the course with the maximum number of enrolments:
    * Display the course_name and the number of students enrolled for the course with the highest enrolment

ANSWERS :

create table COURSES(
  ID int primary key identity,
  NAME varchar(10) not null,
  FEES int not null,
  COURSE varchar(30) not null,
);

insert into COURSES(name, fees, course) values
('Alpha', 10000, 'C#'),
('Beta', 10500, 'Java'),
('Gamma', 10500, 'Java'),
('Delta', 10000, 'C#'),
('Epsilon', 8000, 'Python'),
('Eeta', 8000, 'Python'),
('Theta', 10000, 'C#'),
('Zeta', 12000, 'Ruby');


select count(course) as TOTAL_STUDENTS, course as [COURSE] from courses group by course;
select sum(fees) as TOTAL_FEES, course as [COURSE] from courses group by course;
select top 1 course,count(id) as [MAX_ENROLLED_COURSE] FROM courses GROUP BY course ORDER BY count(id) DESC;

Output:

TOTAL_STUDENTS COURSE                        
-------------- ------------------------------
             3 C#                            
             2 Java                          
             2 Python                        
             1 Ruby                          
TOTAL_FEES  COURSE                        
----------- ------------------------------
      30000 C#                            
      21000 Java                          
      16000 Python                        
      12000 Ruby                          
course                         MAX_ENROLLED_COURSE
------------------------------ -------------------
C#                                               3







Q2. Question:
You are tasked with creating a system to track patients and the appointments they make with doctors. Each patient has basic information like their name, age, gender, and contact details, while appointments include the appointment date, time, reason for the visit, and the doctor they will meet.

Tasks:
Create a patients table with the following details:

- id: A unique identifier for each patient (make it an auto-incrementing IDENTITY column).
- first_name: The first name of the patient (cannot be NULL).
- last_name: The last name of the patient (cannot be NULL).
gender: The gender of the patient (only 'M', 'F', or 'Other' allowed).
- age: The age of the patient (must be a positive integer and less than 120).
- phone_number: The patient's phone number.
- email: The patient's email address (must be unique).
- created_at: The date and time the patient was registered (default to the current date and time).

Create an appointments table with the following details:

- id: A unique identifier for each appointment (make it an auto-incrementing IDENTITY column).
- patient_id: The ID of the patient who booked the appointment.
- appointment_date: The date of the appointment (cannot be in the past).
- appointment_time: The time of the appointment.
- reason_for_visit: A description of why the patient is visiting (cannot be NULL).
- doctor_name: The name of the doctor (cannot be NULL).
- created_at: The date and time the appointment was created (default to the current date and time).
Insert data:

Insert at least 5 patients and 5 appointments into the respective tables.
Make sure to follow the constraints for age, appointment_date, reason_for_visit, and doctor_name.

create table patients (
    id int identity primary key,
    first_name varchar(50) not null,
    last_name varchar(50) not null,
    gender char(1) check (gender IN ('M', 'F', 'O')), 
    age int check (age > 0 and age < 120),
    phone_number varchar(10),
    email varchar(60) unique NOT NULL,
    created_at datetime default getdate()
);

create table appointments (
    id int identity primary key,
    patient_id int not null,
    appointment_date date check (appointment_date >= CAST(GETDATE() AS DATE)), 
    appointment_time time not null,
    reason_for_visit varchar(100) not null,
    doctor_name varchar(100) not null,
    created_at datetime default getdate(),
    foreign key (patient_id) references patients(id) 
);


INSERT INTO patients (first_name, last_name, gender, age, phone_number, email) VALUES
('John', 'Doe', 'M', 30, '1234567890', 'john.doe@example.com'),
('Jane', 'Smith', 'F', 28, '0987654321', 'jane.smith@example.com'),
('Alex', 'Johnson', 'O', 45, '5551234567', 'alex.johnson@example.com'),
('Emily', 'Davis', 'F', 35, '5557654321', 'emily.davis@example.com'),
('Michael', 'Brown', 'M', 50, '5556789012', 'michael.brown@example.com');


INSERT INTO appointments (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name) VALUES
(1, '2024-10-10', '10:00', 'Routine Checkup', 'Dr. Smith'),
(2, '2024-10-11', '11:30', 'Flu Symptoms', 'Dr. Johnson'),
(3, '2024-10-12', '14:00', 'Follow-up', 'Dr. Lee'),
(4, '2024-10-13', '09:00', 'Annual Physical', 'Dr. White'),
(5, '2024-10-14', '15:00', 'Consultation', 'Dr. Black');


select * from patients;
select * from appointments;

OUTPUT:

id          first_name                                         last_name                                          gender age         phone_number email                                                        created_at             
----------- -------------------------------------------------- -------------------------------------------------- ------ ----------- ------------ ------------------------------------------------------------ -----------------------
          1 John                                               Doe                                                M               30 1234567890   john.doe@example.com                                         2024-10-09 03:43:36.280
          2 Jane                                               Smith                                              F               28 0987654321   jane.smith@example.com                                       2024-10-09 03:43:36.280
          3 Alex                                               Johnson                                            O               45 5551234567   alex.johnson@example.com                                     2024-10-09 03:43:36.280
          4 Emily                                              Davis                                              F               35 5557654321   emily.davis@example.com                                      2024-10-09 03:43:36.280
          5 Michael                                            Brown                                              M               50 5556789012   michael.brown@example.com                                    2024-10-09 03:43:36.280
id          patient_id  appointment_date appointment_time       reason_for_visit                                                                                     doctor_name                                                                                          created_at             
----------- ----------- ---------------- ---------------------- ---------------------------------------------------------------------------------------------------- ---------------------------------------------------------------------------------------------------- -----------------------
          1           1       2024-10-10       10:00:00.0000000 Routine Checkup                                                                                      Dr. Smith                                                                                            2024-10-09 03:43:36.293
          2           2       2024-10-11       11:30:00.0000000 Flu Symptoms                                                                                         Dr. Johnson                                                                                          2024-10-09 03:43:36.293
          3           3       2024-10-12       14:00:00.0000000 Follow-up                                                                                            Dr. Lee                                                                                              2024-10-09 03:43:36.293
          4           4       2024-10-13       09:00:00.0000000 Annual Physical                                                                                      Dr. White                                                                                            2024-10-09 03:43:36.293
          5           5       2024-10-14       15:00:00.0000000 Consultation                                                                                         Dr. Black                                                                                            2024-10-09 03:43:36.293