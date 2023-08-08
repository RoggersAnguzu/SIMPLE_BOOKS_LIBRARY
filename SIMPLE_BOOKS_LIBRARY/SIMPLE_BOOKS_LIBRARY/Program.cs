using System;
namespace Books_Library
{
    public class Program
    {
        struct Library
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Books Information would you like to store: ");
            int option = int.Parse(Console.ReadLine());
            Library[] library = new Library[option];
            for (int i = 0; i < option; i++)
            {
                Console.WriteLine("Enter Book title: ");
                library[i].title = Console.ReadLine();

                Console.WriteLine("Enter Author Name: ");
                library[i].author = Console.ReadLine();

                Console.WriteLine("Enter Subject: ");
                library[i].subject = Console.ReadLine();

                Console.WriteLine("Enter the Book Id: ");
                library[i].book_id = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Following are the books Whose Details have been availed");

            for (int i = 0; i < option; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", library[i].title, library[i].author, library[i].subject, library[i].book_id);
                Console.WriteLine();
            }
        }
    }
}