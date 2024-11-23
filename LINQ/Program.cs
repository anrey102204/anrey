using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal partial class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE MANAGEMENT SYSTEM\n");
            var crud = new CRUD();
            crud.Introduce();
        }
        public static void Option() 
        {
            Console.WriteLine("__OPTION__");
            Console.WriteLine();
            Console.WriteLine("1 .ADD EMPLOYEE");
            Console.WriteLine("2. READ EMPLOYEE");
            Console.WriteLine("3. UPDATE EMPLOYEE");
            Console.WriteLine("4. DELETE EMPLOYEE");
            Console.WriteLine("5. EXIT");
            Console.WriteLine("\n");

        }
        public static void viewallorReadone()
        {
            Console.WriteLine("1. LIST ALL EMPLOYEE");
            Console.WriteLine("2. FIND EMPLOYEE BY ID");
        }
   }
}
