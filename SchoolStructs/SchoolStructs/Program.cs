using System;

namespace SchoolStructs
{
    class Program
    {
        private static string course,
           uprogram,
           degree;

        public struct Student
        {
            public Student(string firstName, string lastName, 
                string addr1, string addr2, string cit,
                string stateProv, string zipNum, string countryOfOrigin,
                DateTime bday)
            {
                this.studentFirstName = firstName;
                this.studentLastName = lastName;
                this.address1 = addr1;
                this.address2 = addr2;
                this.city = cit;
                this.state = stateProv;
                this.zip = zipNum;
                this.country = countryOfOrigin;
                this.birthday = bday;
            }

            string studentFirstName, studentLastName,
                address1, address2,
                city, state, zip, country;
            DateTime birthday;

            public void printStudent()
            {
                Console.WriteLine("Student's First Name: {0}", studentFirstName);
                Console.WriteLine("Student's Last Name: {0}", studentLastName);
                Console.WriteLine("{0}", address1);
                Console.WriteLine("{0}", address2);
                Console.WriteLine("{0}, {1} {2} {3}", city, state, zip, country);
                Console.WriteLine("Born on : {0}" ,Convert.ToString(birthday));
            }
        }

        struct Teacher
        {
            string teacherFirstName, teacherLastName,
                address1, address2,
                city, state, zip, country;
            
            public Teacher(string name)
            {
                teacherFirstName = name;
                teacherLastName = "";
                address1 = "";
                address2 = "";
                city = "";
                state = "";
                zip = "";
                country = "";
            }
        }

        struct UProgram
        {
            
            public UProgram(string name)
            {
                
            }
        }

        struct Course
        {
            
            public Course(char course, int num)
            {
                
                
            }
        }

        static void Main(string[] args)
        {
            int numOfStudents = 5;
            Student[] studentInSchool = new Student[numOfStudents];
            
            studentInSchool[0] = new Student(firstName: "Foo", lastName: "Bar", 
                addr1: "1234 N Entropy Pl. SE", addr2: "", 
                cit: "MakeUp", stateProv: "LV", zipNum: "999", countryOfOrigin: "USA", 
                bday: (Convert.ToDateTime("01/07/90")));
            studentInSchool[0].printStudent();
            Console.ReadLine();



        }
    }
}
