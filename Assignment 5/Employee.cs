using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Employee
    {
        int id;
        string name;
        string reportingManager;

        public void GetMainDetails()
        {
            Console.Write("Enter ID");
            id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
            Console.WriteLine("ENter Reporting Manager");
            reportingManager = Console.ReadLine();
          
        }
        public void displayDetails()
        {
            Console.WriteLine("Id is {0},id");
            Console.WriteLine("Name is {0},name");
            Console.WriteLine("reportingManager is {0},reportingManager");

        }
    }
    }
    
    
