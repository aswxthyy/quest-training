using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Repositories
{
    public class DoctorRepository : IHospital
    {
        var connStr = "DataSource = .; InitialCatalog = QuestDB; IntegratedSecurity = True";
        connStr = "Server = .; Database = QuestDB; IntegratedSecurity = True";

        public void override CreateTable()
        {
           
            var conn = new SqlConnection(connStr);
            conn.Open();
            var createTableQuery = @"create table Doctors
            (
                ID int primary key identity,
                Name varchar(100),
                Specialisation varchar(100),
                PatientID int 
                foreign key(PatientID) references Patients(ID)
            );";

            var command  = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void override Add(Doctor doctor)
        {
            var insertQuery = "insert into Doctors(ID, Name, Specialisation, PatientID) values(@ID, @Name, @Specialisation, @PatientID)";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command  = new SqlCommand(insertQuery, conn);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@ID", doctor.ID);
            command.Parameters.AddWithValue("@Name", doctor.Name);
            command.Parameters.AddWithValue("@Specialisation", doctor.Specialisation);
            command.Parameters.AddWithValue("@Patient", doctor.PatientID);

            conn.Close();
        }

        public void override Select()
        {
            var selectQuery = "select ID, Name, Specialisation, PatientID";

            var conn = new SqlConnection(connStr);
            conn.Open();

            var command  = new SqlCommand(selectQuery, conn);
            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                var ID = reader.GetInt32(0);
                var Name = reader.GetString(1);
                var Specialisation = reader.GetString(3);
                var PatientID = reader.GetInt32(4);

                System.Console.WriteLine($"ID : {ID}    Name : {Name}   Specialisation : {Specialisation}");
                System.Console.WriteLine($"Patient ID : {PatientID}");
            }

            conn.Close();
        }

        public void override Update(Doctor doctor)
        {
            var updateQuery = "update Doctors set Name = @Name, Specialisation = @Specialisation, PatientID = @PatientID where ID = @ID"
            
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command  = new SqlCommand(updateQuery, conn);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@ID", doctor.ID);
            command.Parameters.AddWithValue("@Name", doctor.Name);
            command.Parameters.AddWithValue("@Specialisation", doctor.Specialisation);
            command.Parameters.AddWithValue("@Patient", doctor.PatientID);
            
            conn.Close();
        }

        public void override Delete(int id)
        {
            var deleteQuery = "delete from Doctors where ID = @ID";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command  = new SqlCommand(deleteQuery, conn);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@ID", id);

            conn.Close()
        }


    }

}