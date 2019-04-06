using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Collection
{
    public class Library
    {
        private Stack<Book> stacklist = new Stack<Book>();
        
        //private static Random rd = new Random();

        private static string[] authers = { "Auther1", "Auther2", "Auther3", "Auther4", "Auther5", "Auther6", "Auther7", "Auther8", "Auther9", "Auther10" };
        private static string[] titles = { "Title1", "Title2", "Title3", "Title4", "Title5", "Title6", "Title7", "Title8", "Title9", "Title10" };

        public Library(int cnt = 0)
        {
            if (cnt > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    stacklist.Push(new Book(authers[i], titles[i], i * 1000 + 100));
                }
            }
        }


        public void Push(Book b)
        {
            stacklist.Push(b); // lcvac pahunakum nor tarr avelacnel chenq karox  
        }

        public Book Pop()
        {
            return stacklist.Pop(); // datark pahunakic tarr heracnel chenq karox 
        }

        public Book Peek()
        {
            return stacklist.Peek(); // tarri yntrum datark pahunakic chenq karox anel 
        }

        public int Count
        {
            get
            {
                return stacklist.Count;
            }
        }

        public void Show()
        {
            Library sl = this;
            int l = sl.Count;
            for (int i = 1; i <= l; i++)
            {
                Console.WriteLine(i + ". " + sl.Peek());
                sl.Pop();
            }
        }



    }
}
