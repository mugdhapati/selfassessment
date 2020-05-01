using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            // Instantiate three Student objects.
            Student Student1 = new Student();
            Student Student2 = new Student();
            Student Student3 = new Student();

            //Instantiate a UProgram object called Information Technology.
            UProgram uProgram = new UProgram();
            uProgram.ProgramName = "Information Technology";

            //Instantiate a Course object called Programming with C#.
            Course course = new Course();
            course.CourseName = "Programming with C#";

            //Add your three students to this Course object.

            course.ArrayStudents = new Student[3];
            course.ArrayStudents[0] = Student1;
            course.ArrayStudents[1] = Student2;
            course.ArrayStudents[2] = Student3;

            //Instantiate at least one Teacher object.
            Teacher teacher1 = new Teacher();

            //Add that Teacher object to your Course object.
            course.ArrayTeachers = new Teacher[1];
            course.ArrayTeachers[0] = teacher1;
            

            //Instantiate a Degree object, such as Bachelor. 
            Degree degree = new Degree();
            degree.DegreeName = "Bachlors";

            //Add your Course object to the Degree object.
            degree.Course = course;

            //Output to console
            Console.WriteLine("The {0} program contains the {1} degree", uProgram.ProgramName, uProgram.Degree.DegreeName);
            Console.WriteLine();
            Console.WriteLine("The {0} degree contains the course {1}", degree.DegreeName, degree.Course.CourseName);
            Console.WriteLine();
            Console.WriteLine("The {0} course contains {1} students", course.CourseName, School.StudentsEnrolledInSchool);
            Console.WriteLine();

            StreamReader streamReaderObject = null;
            try
            {
                streamReaderObject = new StreamReader("file1.txt");
                // Reads all characters from the current position to the end of the stream
                // Stores in String variable "contents"

                String contents = streamReaderObject.ReadToEnd();
                streamReaderObject.Close();


                //Write no. of text elements in the text file to Console
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The file can't be found");
            }
            finally
            {
                if (streamReaderObject != null)
                {
                    streamReaderObject.Close();

                    streamReaderObject.Dispose();
                }
            }
        }
    }
    public class Student
    {
        #region
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string address;
        private int grade;
        private int rollNo;
        #endregion

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
        public int RollNo { get; set; }

        //creating var called Instances

        private static int instances = 0;

        public Student()
        {
            instances++;
        }

        //Constructor
        public Student(string firstName, string lastName, DateTime birthdate, string address, int grade, int rollno)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthdate;
            this.Address = address;
            this.Grade = grade;
            this.RollNo = rollno;
            instances++;
        }
    }
    class Teacher
    {
        #region
        private string teacherFirstName;
        private string teacherLastName;
        private string subject;
        private string email;

        #endregion
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        // Default Constructor
        public Teacher()
        {

        }

        //Constructor

        public Teacher(string teacherFirstname, string teacherLastname, string subject, string email)
        {
            this.TeacherFirstName = teacherFirstname;
            this.TeacherLastName = teacherLastname;
            this.Subject = subject;
            this.Email = email;
        }

    }
    public class Course
    {
        #region Variables
        private string courseName;
        private Student[] arrayStudents;
        private Teacher[] arrayTeachers;

        #endregion
        public string CourseName { get; set; }
        public Student[] ArrayStudents { get; set; }
        public Teacher[] ArrayTeachers { get; set; }
        // Default Constructor
        public Course()
        {

        }
        //Constructor
        public Course(string courseName, Student [] arrayStudents, Teacher [] arrayTeachers)
        {
            this.CourseName = courseName;
            this.ArrayStudents = arrayStudents;
            this.ArrayTeachers = arrayTeachers;
        }
    }
    class Degree
    {
        #region
        private string degreeName;
        private Course courseName;
        #endregion

        public string DegreeName { get; set; }
        public Course Course { get; set; }
        // Default Constructor
        public Degree()
        {

        }

        //Constructor

        public Degree(string degreeName, Course course)
        {
            this.DegreeName = degreeName;
            this.Course = course;
        }
    }
   class UProgram
    {
        #region
        private string programName;
        private string degreeOffered;
        private Degree degree;
        #endregion

        public string ProgramName { get; set; }
        public string DegreeOffered { get; set; }
        public Degree Degree { get; set; }
        // Default Constructor
        public UProgram()
        {

        }

        //Constructor

        public UProgram(string programName, string degreeOffered, Degree degree)
        {
            this.ProgramName = programName;
            this.DegreeOffered = degreeOffered;
            this.Degree = degree;

        }
    }
    public static class School
    {

        public static int StudentsEnrolledInSchool = 0;

    }
}
