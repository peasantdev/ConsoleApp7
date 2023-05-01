using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Employee //Employee class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Job job, Employee employee)//Overloading the == operator.
        {
            if (employee.Id.Equals(5))
                return false;
            else
                return true;
        }

        public static bool operator !=(Job job, Employee employee)
        {
            if (employee.Id.Equals(null)) 
                return false;
            else
                return true;
        }

        public static Job operator +(Job job, Employee employee)
        {
            job.Employees.Add(employee);
            return job;
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
