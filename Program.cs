using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your Permanent Address:");
            string permanentAddress = Console.ReadLine();
            Console.WriteLine("Your Present Address:");
            string presentAddress = Console.ReadLine();
            Console.WriteLine("Your Mobile Number:");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Your Date of Birth");
            string dateOfBirth = Console.ReadLine();
            Console.WriteLine("Your Age:");
            string age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your Personal Information");
            Console.WriteLine("===================================================");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Permanent Address: " +permanentAddress);
            Console.WriteLine("Present Address: " +presentAddress);
            Console.WriteLine("Mobile Number: " +mobileNumber);
            Console.WriteLine("Date of Birth: " +dateOfBirth);
            Console.WriteLine("Age: " +age);
            Console.ReadKey();

        }
    }
}
