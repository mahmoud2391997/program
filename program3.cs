using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class program3
    {
        static void Main(string[] args)
        {
            // Object Syntax;
            //Declaration <Type> <ObjectName>;
            //Assignment <ObjectName> = new <Type>();
            //Intialization <Type> <ObjectName> = new <Type>();
            empolyee e1 = new empolyee();
            const double tax = 0.03;
            Console.Write("First Name: ");
            e1.FName =Console.ReadLine();
            Console.Write("Last Name: ");
            e1.LName =Console.ReadLine();
            
            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Logged hours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());
            var netSalary = e1.Wage * e1.LoggedHours - (e1.Wage * e1.LoggedHours * empolyee.TAX);
            Console.WriteLine($"First Name:{e1.FName} ");
            Console.WriteLine($"Last Name:{e1.LName} ");
            Console.WriteLine($"Wage: {e1.Wage} ");
            Console.WriteLine($"Logged hours:{e1.LoggedHours} ");
            Console.WriteLine($"Net salary:{netSalary} ");
           
        }
    }
}
