using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> llst = new LinkedList<int>();

            //MyLinkedList<int> lst = new MyLinkedList<int>();
            //Console.WriteLine(lst.Search(66));
            //Console.WriteLine();
            //lst.Append(3);
            //lst.Append(4);
            //lst.Add2Start(1);
            //lst.Add2Start(99);
            //Console.WriteLine(lst.Search(4));
            //Console.WriteLine(lst.Search(99));
            //Console.WriteLine();
            //lst.Add2Start(2);
            //lst.PrintAll();
            //lst.Append(369);
            //int iDeletedData;
            //bool res = lst.RemoveFromStart(out iDeletedData);
            //Console.WriteLine();
            //lst.PrintAll();

            MyLinkedList<string> sLst = new MyLinkedList<string>();

            Book b1 = new Book("GGG", "UUU", 240, 100);
            
            Book b2 = new Book("RRR", "CCC", 34, 30);
            
            Book b3 = new Book("HHH", "LLL", 78, 56);

            MyLinkedList<Book> cBook = new MyLinkedList<Book>();
            cBook.Add2Start(b1);
            cBook.Add2Start(b2);
            cBook.Add2Start(b3);

            Book b4 = new Book("NUNU", "WRITBK", 62, 23);
            cBook.Append(b4);

            Book b = new Book("lki", "vbn", 32, 9);
            b.Name = "RRR";
            Book found1 = cBook.SearchT(b);

            Book found2 = cBook.SearchT(b2);

            Console.WriteLine(cBook);

            Book bTmp;
            cBook.RemoveFromEnd(out bTmp);
            Console.WriteLine(cBook);
        }
    }
}
