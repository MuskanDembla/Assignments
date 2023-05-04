using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class FullTime:Employee
    {
        DateTime joiningDate;
        int exp;
        float basicSalary;
        float da;
        float hra;
        
        public void GetDetails()
        {
            Console.Write("Enter joiningDate");
            joiningDate = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
            Console.WriteLine("ENter Reporting Manager");
            reportingManager = Console.ReadLine();



        }
    }
}
