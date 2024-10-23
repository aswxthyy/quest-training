using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15newcontact
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class ContactRepository
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Documents\\Questdb.mdf;Integrated Security=True;";

        public ContactRepository()
        {
            CreateContactsTable();
        }

        private void CreateContactsTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contacts' AND xtype='U')
            CREATE TABLE Contacts (
                ContactID INT PRIMARY KEY IDENTITY(1,1),
                Name VARCHAR(100) NOT NULL,
                Phone VARCHAR(20) NOT NULL,
                Email VARCHAR(100) NULL
            );";

            SqlConnection connection = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand(createTableQuery, connection);

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();

        }

        public void AddContact(Contact contact)
        {
            string query = "INSERT INTO Contacts (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }

        public Contact SearchByNameOrPhone(string input)
        {
            string query = "SELECT * FROM Contacts WHERE Name = @Input OR Phone = @Input";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Input", input);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Contact
                        {
                            ContactID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.GetString(2),
                            Email = reader.IsDBNull(3) ? null : reader.GetString(3)
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateContact(Contact contact)
        {
            string query = "UPDATE Contacts SET Name = @Name, Phone = @Phone, Email = @Email WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactID", contact.ContactID);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }

        public void DeleteContact(int contactID)
        {
            string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactID", contactID);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContactRepository repository = new ContactRepository();

            repository.AddContact(new Contact { Name = "John Doe", Phone = "123456789", Email = "john@example.com" });

            var contact = repository.SearchByNameOrPhone("John Doe");
            if (contact != null)
            {
                Console.WriteLine($"Found: {contact.Name}, Phone: {contact.Phone}, Email: {contact.Email}");

                contact.Name = "John Smith";
                repository.UpdateContact(contact);
                Console.WriteLine("Contact updated.");

                repository.DeleteContact(contact.ContactID);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }

            Console.ReadLine();
        }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace Details
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string PhNo { get; set; }
        public string Email { get; set; }

        public PersonalDetails(string name, string phno, string email)
        {
            Name = name;
            PhNo = phno;
            Email = email;
        }
    }

    internal class Program
    {
        static void InsertDetails(List<PersonalDetails> people)
        {

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (var person in people)
                {
                    var insertQuery = @"INSERT INTO PEOPLE (name, phno, email) VALUES (@name, @phno, @email)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", person.Name);
                        command.Parameters.AddWithValue("@phno", person.PhNo);
                        command.Parameters.AddWithValue("@email", person.Email);

                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();
                Console.WriteLine("Personal Details inserted successfully.");
            }
        }
        static void Main(string[] args)
        {
            const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aswathy\Documents\QuestDB.mdf; Integrated Security = True;";

            var createTableQuery = @"CREATE TABLE PEOPLE
                                        (name varchar(50),
                                        phno varchar(10),
                                        email varchar(50)
                                        )";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();

            conn.Close();

            var person = new List<PersonalDetails>()
            {
                new PersonalDetails("Alpha", "6567869873", "alpha@mail.com"),
                new PersonalDetails("Beta", "8987869873", "beta@mail.com"),
                new PersonalDetails("Gamma", "9797869873", "alpha@mail.com"),
                new PersonalDetails("Delta", "2327869873", "delta@mail.com"),
                new PersonalDetails("Epsilon", "1217869873", "epsilon@mail.com")
            };

            InsertDetails(person);
        }

    }
}
*/




/*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlInsertFromList
{
    internal class Program
    {
        const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rahul vv\Documents\QuestDB.mdf; Integrated Security = True;";

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Book 1", "Author A", 500),
                new Book("Book 2", "Author B", 600),
                new Book("Book 3", "Author C", 700),
                new Book("Book 4", "Author D", 800),
                new Book("Book 5", "Author E", 900)
            };

            InsertBooksIntoDatabase(books);
        }

        static void InsertBooksIntoDatabase(List<Book> books)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (var book in books)
                {
                    var insertQuery = @"INSERT INTO BOOKS (name, author, price) VALUES (@name, @author, @price)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", book.Name);
                        command.Parameters.AddWithValue("@author", book.Author);
                        command.Parameters.AddWithValue("@price", book.Price);

                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();
                Console.WriteLine("Books inserted successfully.");
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book(string name, string author, int price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
    }
}
*/