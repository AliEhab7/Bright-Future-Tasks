using System.Net.Cache;

namespace DotNet_task1
{

    class Student
    {
        private string name;
        private int age, grade;
        public Student(string name,int age , int grade)
        {
           if(age < 5)
            {
                Console.WriteLine("Invalid Age");
            }
           if(grade <0 || grade > 100)             
            {
                Console.WriteLine("Invalid Grade");
            }
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public string Name{
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 5)
                {
                    Console.WriteLine("Invalid Age");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Invalid Grade");
                }
                else
                {
                    grade = value;
                }
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
        }

    }
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Student std1 = new Student("levmz", 20, 85);
            std1.DisplayInfo();
            std1.Age = 3; 
            std1.Grade = 105; 
             std1.DisplayInfo();
        }
    }
}
