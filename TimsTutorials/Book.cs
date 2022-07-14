using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TimsTutorials
{
    //Creating the Book object/class
   public class Book
    {

        public String title;

        public String author;

        public int pages;

        //static attribute

        public static int bookcount = 0;

        //Basic construcor method
        public Book(String aTitle, String aAuthor, int aPages)
        {

            title = aTitle;

            author = aAuthor;

            pages = aPages;

            //using a static attribute

            bookcount++;

        }
      


        //Getters and Setters????
        public string Title
        {

            get { return title;  }

            set
            {
                while (value == null)

                {

                    title = value;

                    Console.WriteLine("This is not a value, sorry. Please input a value");

                }

            } 
        }

        public string Author
        {

            get { return author; }

            set
            {
                while (value == null)

                {

                    author = value;

                    Console.WriteLine("This is not a value, sorry. Please input a value");

                }

            }
        }

        public int Pages
        {

            get { return pages; }

            set
            {
                while (value == 0)

                {
                    pages = value;

                    Console.WriteLine("Your having a laugh mate!!");

                } 

            }
        }

        //object method boolean
        public string IsBigBook()
        {

            string message;

            if (pages > 1500)
            {

                message = "Well done mate you smashed it!!";

               

            }

            else
            {

                message = "You aint reading enough matey, come on!!!!";

                
            }

            return message;

        }

     

        public override String ToString()
        {

            return "Your book title is : " + title + " " + "Your author is : " + author + " " +  " Your number of pages is : " + pages + ", " + IsBigBook();

            
        } 


    }
}
