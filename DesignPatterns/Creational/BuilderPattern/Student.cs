using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.BuilderPattern
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; private set; }
        public int Age { get; private set; }
        public string FatherName { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        private Student()
        {

        }

        private Student(Student oldStudent)
        {
            FirstName = oldStudent.FirstName;
            LastName = oldStudent.LastName;
            FullName = oldStudent.FullName;
            Age = oldStudent.Age;
            FatherName = oldStudent.FatherName;
            UserName = oldStudent.UserName;
            Password = oldStudent.Password;
        }

        public static Builder GetBuilder()
        {
            return new Builder();
        }

        public class Builder
        {
            private Student student = null;
            public Builder()
            {
                student = new Student();
            }

            public Builder withName(string firstName, string lastName)
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.FullName = firstName + " " + lastName; 
                return this;
            }

            public Builder ofAge(int age)
            {
                student.Age = age;
                return this;
            }

            public Builder sonOf(string fatherName)
            {
                student.FatherName = fatherName;
                return this;
            }

            public Builder withCredenticals(string userName, string password)
            {
                student.UserName = userName;
                student.Password = password;
                return this;
            }

            public Student Build()
            {
                try
                {
                    Student newStudent = new Student(student);

                    bool isValid = validate();
                    if (!isValid)
                    {
                        return null;
                    }
                    
                    return newStudent;
                }
                finally
                {
                    // Clear
                    student = null;
                }
            }

            private bool validate()
            {
                return student.FirstName != null;
            }
        }
    }
}
