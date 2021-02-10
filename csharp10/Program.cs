using System;


namespace csharp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PLease Enter your First Name  ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("PLease Enter your Middle Name  ");
            string MiddleName  = Console.ReadLine();
            Console.WriteLine("PLease Enter your Last Name  ");
            string LastName = Console.ReadLine();
            
            // Console.WriteLine("Hello {0}", Username);
            Console.WriteLine("Hello {0},{1},{2} ",  FirstName ,MiddleName,LastName );
            
            Console.ReadLine();
             

        }
    }
}
