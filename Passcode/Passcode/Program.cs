using System;
using System.Security.Cryptography;
using System.Transactions;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            while (code != "secret")

                {

                Console.WriteLine("username :");
                var username = Console.ReadLine();
                Console.WriteLine("Password :");
                code = Console.ReadLine();
                if (code != "secret")
                {
                    Console.WriteLine("{0}'s password wrong.", username);
                    
                }

                Console.WriteLine("{0} entered succesfully.", username);

            }
        }
    }
}
