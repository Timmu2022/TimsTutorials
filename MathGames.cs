using System;

public class Class1
{
	public Class1()
	
	
	{
		

			Console.WriteLine("Hi there would you like to play the number max game ? y/n ")

		while (Console.ReadKey().key != ConsoleKey.Y)

			{

				Console.WriteLine("\n" + "Please play this game, thank you!! ")



		}

			Console.WriteLine("\n" + "Here is your highest number entry : " + NumMax());

			Console.ReadLine();

		}

	}


	static double NumMax(double num1, double num2)
    
	
	{

		double result;

		Console.Write("\n" + "Please enter a number : ");

		double num1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("\n" + "Please enter another number : ");

		double num2 = Convert.ToDouble(Console.ReadLine());

		if (num1 > num2)
        {

			result = num1;

        }

		else
        {

			result = num2;

        }



		return result;

    }

}
