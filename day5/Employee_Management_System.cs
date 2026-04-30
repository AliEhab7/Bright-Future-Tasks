using System.Net.Cache;
using System.Numerics;

namespace DotNet_task1
{

    abstract class Employee
    {
        protected string name;
        protected int salary;

        protected Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        abstract public int CalculateBonus();
        abstract public void DisplayInfo();
       
    }
    class Manager : Employee { 
    
        public Manager(string name, int salary) : base(name, salary)
        {
        }
        public override int CalculateBonus()
        {
            return (int)(salary * 1.1);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Works as Manager, Salary: {CalculateBonus()}");
        }
        }

    class Developer : Employee { 

        public Developer(string name, int salary) : base(name, salary)
        {
        }
        public override int CalculateBonus()
        {
            return (int)(salary * 1.05);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Works as Developer, Salary: {CalculateBonus()}");
        }
            }


  
        internal class Program
    {

       static void DisplayEmployeesInfo(List<Employee> myEmployees)
        {
            foreach (var employee in myEmployees)
            {
                employee.DisplayInfo();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
         
         Employee Adel = new Manager("Adel", 5000);
            Employee mazen = new Manager("Mazen", 7000);
            Employee khaled = new Developer("khaled", 4000);
            List<Employee> myEmployees = new List<Employee>() { Adel, mazen, khaled };
            DisplayEmployeesInfo(myEmployees) ;
        }
    }
}
