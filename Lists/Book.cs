using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Book
    {
        public string Name;
        public string Writer;
        public double Price;
        public int Pages;

        public override bool Equals(object obj)
        {
            Book bTmp = (Book)obj;

            return bTmp.Name == this.Name;
        }
        public Book(string name, string writer, int pages, double price)
        {
            this.Name = name;
            this.Pages = pages;
            this.Writer = writer;
            this.Price = price;
        }

        public Book(string name)
            : this(name, "", 1, 1.1)
        {

        }


        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book Name: " + Name);
            //sb.Append("\nBook Writer: " + Writer);
            //sb.Append("\nBook Price: " + Price);
            //sb.Append("\nBook Pages: " + Pages);

            //return sb.ToString();

            return string.Format("Name: {0}, Writer: {1}, Price: {2}, Pages: {3}",
                                Name, Writer, Price, Pages);
        }
    }
}
