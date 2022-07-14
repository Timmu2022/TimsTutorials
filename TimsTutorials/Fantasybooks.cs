using System;
using System.Collections.Generic;
using System.Text;

namespace TimsTutorials
{
   public class Fantasybooks 
    {



        

        public static void Goodbooks()
        {
          
        Book book3 = new Book("Lord of the Rings", "J.R.R Tolkein", 1178);

        Book book4 = new Book("The Death Gate Cycle Novel", "Margret Weis & Tracy Hickman", 3016);

        Book book5 = new Book("The Hobbit", "J.R.R Tolkein", 310);

        Book book6 = new Book("The Shannara Series", "Terry Brooks", 1200);


        Console.WriteLine("\n" + "Please find time to read : " + book3);

            Console.WriteLine("\n" + "Please find time to read : " + book4);

            Console.WriteLine("\n" + "Please find time to read : " + book5);

            Console.WriteLine("\n" + "Please find time to read : " + book6);




        }




    }
}
