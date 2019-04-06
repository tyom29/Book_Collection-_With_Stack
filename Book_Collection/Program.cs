using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create new library with N books\n");
            Library library = new Library(10);
            //library.Show();

            Console.WriteLine("\nPush new book\n");

            library.Push(new Book());
            //library.Show();

            Console.WriteLine("\nPop book\n");

            library.Pop();
            library.Show();


        }
    }
}
