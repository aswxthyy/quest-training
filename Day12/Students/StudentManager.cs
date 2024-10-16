using System;
using System.Collections.Generic;

namespace Students
{
    class StudentManager
    {
        private List<StudentData> students = new List<StudentData>();

        public void Add(StudentData student)
        {
            if(GetStudentByNumber(student.RegNo) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }

            students.Add(student);
            Console.WriteLine("Added successfully");
        }
        public void Search(string regNo)
        {
            var student = GetStudentByNumber(regNo);
            Console.WriteLine(student);
        }

       public void Update(string regNo, string name, int standard, 
                    string subjectOne, int markOne, 
                    string subjectTwo, int markTwo, 
                    string subjectThree, int markThree)
        {
            var student = GetStudentByNumber(regNo);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            student.Name = name;
            student.RegNo = regNo;
            student.Standard = standard;

            student.SubjectOne = subjectOne;
            student.MarkOne = markOne;
            student.SubjectTwo = subjectTwo;
            student.MarkTwo = markTwo;
            student.SubjectThree = subjectThree;
            student.MarkThree = markThree;

            Console.WriteLine("Updated successfully");
        }


        public void Delete(string regNo)
        {
            var student = GetStudentByNumber(regNo);
            if(student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            students.Remove(student);
            Console.WriteLine("Deleted successfully");
        }

        private StudentData GetStudentByNumber(string regNo)
        {
            foreach (var student in students)
            {
                if (student.RegNo == regNo)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
