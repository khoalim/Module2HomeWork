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

            if (faveColor.ToLower().Equals("faveAnimal.ToLower()"))
            {
                Console.WriteLine("Yes, they are equal!");
            }

            else
            {
                Console.WriteLine("No, they are not equal!");
            }


            Console.WriteLine("Please create a password");
            string password;
            password = Console.ReadLine();

            Console.WriteLine("Please re-enter password");
            string passwordVerify;
            passwordVerify = Console.ReadLine();

            if (password.ToLower().Equals("passwordVerify.ToLower()"))
            {
                Console.WriteLine("Success. Password Verified");

            }

            else
            {
                Console.WriteLine("Your password is incorrect. Try again.");
            }
                       

        
        }
    }
}
