using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Repositories
{
    public class PatientRepository : IHospital
    {
        var connStr = "DataSource = .; InitialCatalog = QuestDB; IntegratedSecurity = True";
        connStr = "Server = .; Database = QuestDB; IntegratedSecurity = True";

        public void override CreateTable()
        {
            
           var conn = new SqlConnection(connStr);
           conn.Open();
           var createTableQuery = @"create table Patients 
            (
                ID int primary key identity,
                Name varchar(100),
                Age int,
                Gender varchar(10),
                MedicalCondition varchar(200)
            );";

           var command  = new SqlCommand(createTableQuery, conn);
           command.ExecuteNonQuery();
           conn.Close();
        }

        public void override Add(Patient patient)
        {
            var insertQuery = "insert into Patients(Name, Age, Gender, MedicalCondition) values(@Name, @Age, @Gender, @MedicalCondition)";

            var conn = new SqlConnection(connStr);
            conn.Open();
            var command  = new SqlCommand(insertQuery, conn);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@Name", patient.Name);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

            conn.Close();
            
        }

        public void override Select()
        {
            var selectQuery = "select ID, Name, Age, Gender, MedicalCondition";

            var conn = new SqlConnection(connStr);
            conn.Open();

            var command  = new SqlCommand(selectQuery, conn);
            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                var ID = reader.GetInt32(0);
                var Name = reader.GetString(1);
                var Age = reader.GetInt32(2);
                var Gender = reader.GetString(3);
                var MedicalCondition = reader.GetString(4);

                System.Console.WriteLine($"ID : {ID}    Name : {Name}   Age : {Age}   Gender : {Gender}");
                System.Console.WriteLine($"Medical Condition : {MedicalCondition}");
            }

            conn.Close();

        }

        public void override Update(Patient patient)
        {
            var updateQuery = "update Patients set Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition where ID = @ID"
            
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command  = new SqlCommand(updateQuery, conn);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@ID", patient.ID);
            command.Parameters.AddWithValue("@Name", patient.Name);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
            
            conn.Close();
        }

        public void override Delete(int id)
        {
            var deleteQuery = "delete from Patients where ID = @ID";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command  = new SqlCommand(deleteQuery, conn);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@ID", id);

            conn.Close()
        }

    }

}