using System;
using System.Collections.Generic;
using System.Text;

namespace TimsTutorials
{

    //a static methods class to store my methods and functions

    public static class Methods
    {


        //a method with functionality and parameters

        public static void User(String name, int age)
        {


            Console.WriteLine("\n" + "Thank you!!!");

            Console.Write("\n" + "Hi, " + name + " of " + age + " years. " + " , Would you like to play the calculator game? Y/N");

            while (Console.ReadKey().Key != ConsoleKey.Y)
            {

                Console.WriteLine("\n" + "You really should play this game!!");

            }

            //calling the method
            Program.Calculator();

            Console.WriteLine("\n" + "Now " + name + " Would you like to play the cubed number game ? : ");

            while (Console.ReadKey().Key != ConsoleKey.Y)
            {

                Console.WriteLine("\n" + "You really should play this game!!");

            }

            Console.Write("\n" + "Thank you " + name + " , enter a number to cube, please :  ");

            double cubenum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + "Here is your results of a cubed number you have supplied: " + Program.Cubing(cubenum));




        }

        //method to find the body mass of user

        public static void Bodybio()

        {

            Console.Write("\n" + "Enter your gender m/f : ");

            char gender = Convert.ToChar(Console.ReadLine());

            Console.Write("\n" + "Enter your height in cm : ");

            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n" + "Enter your weight in kg : ");

            double weight = Convert.ToDouble(Console.ReadLine());

            if (gender.Equals('m') && height > 100 && weight > 100)


            {
                Console.WriteLine("\n" + "You really should consider losing some weight sonny Jim");
            }

            else if (gender.Equals('m') && height < 100 && weight < 100)

            {

                Console.WriteLine("\n" + "You are in really good shape sonny Jim, well done!!!");

            }

            else if (gender.Equals('m') && height >= 100 && weight <= 100)

            {

                Console.WriteLine("\n" + "You are in really good shape sonny Jim, well done!!!");

            }

            else if (gender.Equals('m') && height < 100 && weight > 100)

            {

                Console.WriteLine("\n" + "You are in really bad shape, lose some kg's lad!!!");

            }

            else if (gender.Equals('f') && height > 100 && weight > 100)


            {

                Console.WriteLine("\n" + "Oh dear, you really need to lose some weight missus, seriously!!!");




            }

            else if (gender.Equals('f') && height < 100 && weight < 100)

            {

                Console.WriteLine("\n" + "You are in really good shape missus, well done!!!");

            }

            else if (gender.Equals('f') && height >= 100 && weight <= 100)

            {

                Console.WriteLine("\n" + "You are in really good shape missus, well done!!!");

            }

            else if (gender.Equals('f') && height < 100 && weight > 100)

            {

                Console.WriteLine("\n" + "You are in really bad shape missus, lose some Kg's!!!");

            }

            else

            {

                Console.WriteLine("Come on please enter a valid input here!!!");

            }

            Console.WriteLine("\n");

            Console.WriteLine("\n" + "\n" + "Thank you!!!");




        }

        //method with more parameters
        public static double NumMax(double numb1, double numb2, double numb3)


        {

            double result;



            if (numb1 >= numb2 && numb1 >= numb3)
            {

                result = numb1;

            }

            else if (numb2 >= numb1 && numb2 >= numb3)
            {

                result = numb2;

            }


            else

            {

                result = numb3;

            }

            //returning the parameters

            return result;

        }

        //method to power a number indices
        public static int GetPow(int baseNum, int powNum)
        {

            int result = 1;

            for (int i = 0; i < powNum; i++)
            {

                result = result * baseNum;

            }

            return result;

        }

        //creating books method
        public static void Choosebook()
        {



            //Instances of a Book object

            Console.Write("\n" + "Please tell me the tilte of a book!! : ");

            String booktitle = Console.ReadLine();

            Console.Write("\n" + "Please tell me the author of the book!!! : ");

            String bookauthor = Console.ReadLine();

            Console.Write("\n" + "How many pages does the book have? : ");

            int pagesbook = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(booktitle, bookauthor, pagesbook);

            Console.Write("\n" + "Please tell me another tilte of a book!! : ");

            String booktitle2 = Console.ReadLine();

            Console.Write("\n" + "Please tell me the author of the book!!! : ");

            String bookauthor2 = Console.ReadLine();

            Console.Write("\n" + "How many pages does the book have? : ");

            int pagesbook2 = Convert.ToInt32(Console.ReadLine());

            Book book2 = new Book(booktitle2, bookauthor2, pagesbook2);

            Console.WriteLine(book);

            Console.WriteLine(book2);

            //implementing a static method in Book class

            Console.WriteLine("\n" + "You have read  " + Book.bookcount + " books, well done!!");
        }

        /// Building 2D Arrays with input from reader.
        public static void Array2d()

        {

            Console.WriteLine("\n" + "Lets make a 2d number array!!!");

            Console.Write("\n" + "We will be building an array with 2 collumns with 3 elements each.");



            //int[,] yourarray = new int[arraycolumn, arrayelem];



            Console.WriteLine("\n" + "You must choose your element values.");

            Console.Write("\n" + "Enter your element number for the first collumn, plaease : ");

            int elemc1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Now enter your next element number for first collumn  : ");

            int elemc2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Now enter your final element number for first collumn  : ");

            int elemc3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Now enter your element number for second collumn  : ");

            int elem2c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Now enter your next element number for second collumn  : ");

            int elem2c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Now enter your final element number for second collumn  : ");

            int elem2c3 = Convert.ToInt32(Console.ReadLine());

            int[,] yourarray = { { elemc1, elemc2, elemc3 }, { elem2c1, elem2c2, elem2c3 } };

            Console.WriteLine("\n" + "Your array is as follows" + "\n" + "The first collumn has: " + "\n" + yourarray[0, 0] + "\n" + yourarray[0, 1] + "\n"
                + yourarray[0, 2] + "\n" + "Your second collumn values are : " + "\n" + yourarray[1, 0] + "\n" + yourarray[1, 1] + "\n" + yourarray[1, 2]);

            Console.WriteLine("\n" + "Thank you for playing!!!");







        }







    }
}
