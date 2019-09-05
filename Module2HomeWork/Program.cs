using System;

namespace Module2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            string faveColor;            
            faveColor = Console.ReadLine();
            

            Console.WriteLine("What is your favorite animal?");
            string faveAnimal;
            faveAnimal = Console.ReadLine();
                        
            
            Console.WriteLine("Your mythical creature is a: " + faveColor + " " + faveAnimal);


            Console.WriteLine("Are the words equal?");

            if (faveAnimal.ToLower().Equals("faveAnimal.ToLower()"))
            {
                Console.WriteLine("Yes, they are equal!");
            }

            else
            {
                Console.WriteLine("No, they are not equal!");
            }
           

                       

        
        }
    }
}
