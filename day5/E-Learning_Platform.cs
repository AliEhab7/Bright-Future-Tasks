using System.Net.Cache;
using System.Numerics;
using System.Xml.Schema;

namespace DotNet_task1
{

     abstract class User
    {
        protected string name ,email;

           protected User(string name, string email)
            {
                this.name = name;
                this.email = email;
            }
        void Login()
        {
            Console.WriteLine("Login successfully");
        }
        void Logout()
        {
            Console.WriteLine("Logout successfully");
        }

    }

    class Teacher : User
    {
        private List<string> courses = new List<string>();
        private List <int> total_degree = new List<int>() , capacity = new List<int>();
        public Teacher(string name, string email) : base(name, email)
        {
        }
        void CreateCourse(string course_name)
        {
            courses.Add(course_name);
            total_degree.Add(100);
            capacity.Add(30);
        }
        void editCourse(string course_name, int degree, int capacity)
        {
            int index = courses.IndexOf(course_name);
            if (index != -1)
            {
                total_degree[index] = degree;
                this.capacity[index] = capacity;
            }
        }

    }
    class Student : User
    {
        List<string> enrolled_courses = new List<string>();
        public Student(string name, string email) : base(name, email)
        {
        }
        void EnrollInCourse(string course_name)
        {
            enrolled_courses.Add(course_name);
        }
        void enrolledCourses()
        {
            Console.WriteLine($"Student name :{name} :");
            int cnt = 1;
            foreach (var course in enrolled_courses)
            { 
                Console.WriteLine($"{cnt++}. {course}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

        }
    }
}
