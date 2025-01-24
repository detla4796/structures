using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the task number:");
            Console.WriteLine("1. Circle task");
            Console.WriteLine("2. Resident task");
            Console.WriteLine("3. Student task");
            Console.Write("Enter the task number: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CircleTask.Run();
                    break;
                case 2:
                    ResidentTask.Run();
                    break;
                case 3:
                    StudentTask.Run();
                    break;
                default:
                    Console.WriteLine("Invalid task number");
                    break;
            }
        }
    }
}
