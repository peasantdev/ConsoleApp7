using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job job = new Job();
            job.Employees = new List<Employee>();//instantiating
            Employee employee = new Employee();//instantiating
            employee.FirstName = "Test";
            employee.LastName = "Test2";
            job += employee;//Overloading the additional operator. Adding employee and job together.
            Console.ReadLine();
        }

    }
}
