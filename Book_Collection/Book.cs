using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Collection
{
    public class Book
    {
        private string auther;
        private string title;
        private int price;

        public string Auther
        {
            get => auther;
            set
            {
                if (value != "")
                    auther = value;
                else
                    throw new Exception("Auther name is blank");
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (value != "")
                    title = value;
                else
                    throw new Exception("Title is blank");
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new Exception("Non valid value for price");
            }
        }

        public Book(string a = "Unknown", string t = "Untitled", int p = 0)
        {
            Auther = a;
            Title = t;
            Price = p;
        }

        public override string ToString()
        {
            return Auther + "\t" + Title + "\t" + Price;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book)
            {
                Book b = obj as Book;
                if (ToString() == b.ToString())
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }            
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }




    }
}
