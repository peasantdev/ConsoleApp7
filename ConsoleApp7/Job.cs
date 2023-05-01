using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Job
    {
        public List<Employee> Employees { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void ListEmployee()
        {
            foreach (Employee employee in Employees) 
            {
                Console.WriteLine(employee.FirstName);
            }
        }
        
    }
}
