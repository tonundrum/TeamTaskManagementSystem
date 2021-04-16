using System;

namespace teamtaskmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "thepassword";
            string email = "ejsoriano11@gmail.com";
            int count = 0;
           
            while (count < 4)
            {
                if (count == 3)
                {
                    Console.WriteLine("Maximum attempts exceeded");
                    return;

                } else
                {
                    Console.WriteLine("Welcome to Asona Team Task Management System");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Enter your email: ");
                    string emailInput = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    string passwordInput = Console.ReadLine();
                  if (emailInput.Equals(email) && passwordInput.Equals(password))
                    {
                        Console.WriteLine("Welcome Elton to your task manager!");
                        Console.WriteLine("-----------------------------------------------------------");
                        var currentDate = DateTime.Now;
                        Console.WriteLine(currentDate);
                        Console.WriteLine("A - Create Tasks \t B - My Tasks");
                        string a = Console.ReadLine();
                  if (a.Equals("A") || a.Equals("a"))
                        {
                            Console.WriteLine("Enter the title of the task: ");
                            String title = Console.ReadLine();
                            Console.WriteLine("Write a short description about your task: ");
                            String description = Console.ReadLine();
                            Console.WriteLine("Please enter the email of the asignees of this task: ");
                            String asignees = Console.ReadLine();
                            Console.WriteLine("When is the deadline of the task: ");
                            string deadline = Console.ReadLine();

                            Console.WriteLine("Title of your task: " + title);
                            Console.WriteLine("Description: " + description);
                            Console.WriteLine("Asignees: " + asignees);
                        }
                  else if (a.Equals("B") || a.Equals("b"))
                        {
                            Console.WriteLine("Your tasks: ");
                            Console.WriteLine("1. Magpacute");
                        }
                  else
                        {
                            Console.WriteLine("Wrong input");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");

                        count++;
                    }
                }
            }

          
        }
    }
}

