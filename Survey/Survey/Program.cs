using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("What is your name?");   //Adını sorduk
            var name = TryAgain();             //Kullanıcıdan alınan veriyi name değişkinine kaydettik.

            Console.WriteLine("What is your age?");
            var age = TryAgain();

            Console.WriteLine("What month were you born in?");
            var month = TryAgain();

            Console.WriteLine("Your name is {0}.", name);
            Console.WriteLine("Your age is {0}.", age);
            Console.WriteLine("Your birth month is {0}.",month);

        }

        static string TryAgain() //Cevapların boş bırakılması halinde çalışacak komut.
        {   
            var answer = Console.ReadLine();
        
            if (answer =="")
            
                { 
                    Console.WriteLine("You didnt type anything. Please try again.");
                    return Console.ReadLine();

                }
            return answer;
                                                

         }
      
    }
}
