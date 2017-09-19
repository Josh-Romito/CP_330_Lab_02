/********************
 * Joshua Romito   
 * Septemeber 19th 2017
 * CP_330 - Lab_02
 *********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Part 1.");
            Console.WriteLine("-----------------------------");
            //instantiating first employee - with no next in command
            Worker johnny = new Worker("Johnny", 1000000000, "OWNER", null);
            
            //authorizing amounts
            johnny.Authorize(1000);
            johnny.Authorize(1000000);

            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Part 2.");
            Console.WriteLine("-----------------------------");
           
            //instantiating multiple employee's
            Worker CEO = new Worker("Josh Romito", 1000000000, "CEO", null);        
            Worker CFO = new Worker("Juan", 1000000, "CFO", CEO);
            Worker manager = new Worker("Michael", 100000, "Manager", CFO);
            Worker supervisor = new Worker("Jim", 10000, "Supervisor", manager);
            Worker employee = new Worker("Mike", 1000, "Employee", supervisor);

            //calling authorize on base employee
            employee.Authorize(100);
            employee.Authorize(5000);
            employee.Authorize(75000);
            employee.Authorize(250000);
            employee.Authorize(651243);

            Console.ReadKey();
        }
    }
}
