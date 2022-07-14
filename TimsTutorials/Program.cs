using System;
using System.Threading;

namespace TimsTutorials
{

    //included inherritance
   public class Program : Fantasybooks
    {
        static void Main(string[] args)

        {

            //Example data types and variables

            String password = "password";

            String guess = "";

            int trycount = 0;

            int trylimit = 3;

            bool outoftry = false;

            int launch = 5;

            //initiated while loop with delay process threading function
            
            while (launch <= 5 && launch >= 0) 
            {

                Console.WriteLine("Launching program module..... " + launch);

                Console.WriteLine("\n");

                Thread.Sleep(1000);

                launch--;

            }

            //do while looping with nested if statements

            do
            {

                if (trycount <= trylimit)

                {

                    Console.Write("\n" + "Enter a valid password. You have four attempts only : ");

                    guess = Console.ReadLine();

                    trycount++;

                    if (guess != password)
                    {

                        Console.WriteLine("\n" + "Keep trying!!" + " You have tried " + trycount + " times.");

                    }

                } else
                {

                    outoftry = true;

                } 

            } while (guess != password && !outoftry);

            if (outoftry)

            {

                Console.WriteLine("\n" + "Applicaiton closed");

                //closing the console window

                Environment.Exit(0);

            } else
            
            {

                Console.WriteLine("\n" + "Thank you!!!");

            }


            
            //a prompt for the user to enter field

            Console.Write("\n" + "Please enter your name : ");

            String name = Console.ReadLine();

            Console.Write("\n" + "How old are you ? : ");

            int age = Convert.ToInt32(Console.ReadLine());

            Methods.User(name, age);

            //a printout to the console

            Console.WriteLine("\n" + "Right, lets learn more about you, " + name);

                //a call to a method
            Methods.Bodybio();

            Console.WriteLine("\n" + "Do you like books? : ");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {

                Console.WriteLine("\n" + "Awsome, please tell me a book that you like!!!");


                Methods.Choosebook();
                

                Console.WriteLine("\n" + "Thank you!! Books are amazing read as many as you can please!!!");

                
                
                Goodbooks();

                


            } else
            {

                Console.WriteLine("\n" + ("Books are good for the soul and mind, dont you know!!!"));

            }



            




            Console.WriteLine("\n" + "Hi there again " + name +  " would you like to play the number max game ? y/n ");

            //while loop with condition key pressed

            


           if (Console.ReadKey().Key == ConsoleKey.Y)
            {

                //assigning input form the user

                Console.Write("\n" + "Please enter a number : ");

                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n" + "Please enter another number : ");

                double number2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n" + "Please enter another number : ");

                double number3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n" + "Here is your highest number entry : " + Methods.NumMax(number1, number2, number3));

            }


            else if (Console.ReadKey().Key != ConsoleKey.Y)
            {

                Console.WriteLine("\n" + "You really should play this game!!");




            }







            Console.WriteLine("\n" + "Okay, how about a game of power numbers, y/n : ");

            

           

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {

                int numba1;

                int numba2;

                Console.WriteLine("\n" + "Great stuff!!");

                Console.Write("\n" + "Enter an integer number : ");

                numba1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n" + "Enter a power number : ");

                numba2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n" + "Here is your number to the power of " + numba2 + " : " + Methods.GetPow(numba1, numba2));


            }

            else if  (Console.ReadKey().Key != ConsoleKey.Y)
            {

                Console.WriteLine("\n" + "You really need to play this game!!");


            }





            Console.Write("\n" + "Are you ready to play again : ");

            if (Console.ReadKey().Key != ConsoleKey.N)
            {

                Console.WriteLine("\n" + "How about building some 2d Arrays!!");

                Methods.Array2d();



            }

            //a string array build

            String[] goodbye = { " Thank you ", " for ", " playing ", " this ", " game!!! " };

            //adapted for looping

            for (int i = 0; i < goodbye.Length; i++)
            {

                Console.WriteLine("\n");

                Console.Write("\n" + " " + goodbye[i] + "\n");

            } 

            Console.WriteLine("\n" + "Good Bye!!!!");

            


            Console.ReadLine();
            


        }

        

        //method calulator

       public static void Calculator()
        {

            Console.WriteLine("\n" + "\n" + "Welcome to the calculator game!!!");

            double num1, num2;

            String message = null;

            do
            {
                // Exceptions trieed examples?????
                try
                {

                    Console.Write("\n" + "Please enter a whole number : ");

                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n" + "Please enter another whole number : ");

                    num2 = Convert.ToDouble(Console.ReadLine());




                    Console.WriteLine("\n" + "Select form the list of calculations : ");

                    Console.WriteLine("\n" + "[1] Addition" + "\n" + "[2] Subtraction" + "\n" + "[3] Divide" + "\n" + "[4] Multiplication");

                    int selection;

                    switch (selection = Convert.ToInt32(Console.ReadLine()))
                    {

                        case 1:

                            Console.WriteLine("\n" + "Your numbers will equal : " + (num1 + num2));

                            break;

                        case 2:

                            Console.WriteLine("\n" + "Your numbers will equal : " + (num1 - num2));

                            break;

                        case 3:

                            Console.WriteLine("\n" + "Your numbers will equal : " + (num1 / num2));

                            break;

                        case 4:

                            Console.WriteLine("\n" + "Your numbers will equal : " + (num1 * num2));

                            break;

                        default:

                            Console.WriteLine("\n" + "This is not a valid response, sorry!!!");

                            break;

                    }



                }
                catch (Exception e)
                {

                    message = e.Message;

                    Console.WriteLine("\n" + "you have ruined this game!!" + "\n" + message);

                }
                finally
                {

                    Console.WriteLine("Try again, please!!!!");

                }

            } while (message == null);

        }

            //a return method with a double number

           public static double Cubing(double numberCube)

        {


            double result = Math.Pow(numberCube, 3);

            return result;


        }

    }
}
