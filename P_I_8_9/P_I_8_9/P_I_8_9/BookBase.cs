using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static P_I_8_9.BookCreate;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P_I_8_9
{
    public class BookMetod : BookCreate
    {
        public BookMetod()
        {
        }
        public int Poisk(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie, List<BookCreate> book)
        {
            string l = "\nНазвание = " + bookName + "\nАвтор = " + autor + "\nПереплет = " + pereplet + "\nГод выпуска = " + godVipyska + "\nКол-во страниц = " + kolvoStranic + "\nКраткое содержание = " + kratkoeSoderjanie + "\n";
            String[] Arraybook = new String[book.Count];
            for (int i = 0; i < book.Count; i++)
            {
                Arraybook[i] = book[i].ToString();
            }
            int _id = Array.IndexOf(Arraybook, l);
            return _id;
        }
        public double TimeBook(int kolvo)
        {
            return (kolvo * 5) / 60.0;
        }

        public int Vek(int Year)
        {
            return (Year / 100) + 1;
        }

    }
    public class BookCreate
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public static implicit operator BookCreate(Namebook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public static implicit operator BookCreate(KolStrbookbook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public static implicit operator BookCreate(Autorbook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public static implicit operator BookCreate(Perepletbook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public static implicit operator BookCreate(Yearbook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public static implicit operator BookCreate(KratkoeSoderjbook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public static implicit operator BookCreate(Allbook counter)
        {
            return new BookCreate(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public BookCreate()
        {

        }
        public BookCreate(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
 

        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
        public static bool operator true(BookCreate book)
        {
            return ((book.KolvoStranic * 5) / 60.0) < 8;
        }
        public static bool operator false(BookCreate book)
        {
            return ((book.KolvoStranic * 5) / 60.0) > 8;
        }
        public static int operator +(BookCreate book1, BookCreate book2)
        {
            return book1.KolvoStranic + book2.KolvoStranic;
        }

        public static int operator -(BookCreate book1, BookCreate book2)
        {
            return Math.Abs(book1.GodVipyska - book2.GodVipyska);
        }
    }
    abstract class AutorBook : BookCreate
    {
        public string Autors { get; set; }
        public abstract void AutorCreate(string autor);
    }
    class OneAutorBook : AutorBook
    {
        public override void AutorCreate(string autor)
        {
            Autors = autor;
        }
    }
    class OverAutorBook : AutorBook
    {
        public override void AutorCreate(string autor)
        {
            if ((Convert.ToInt32(autor)) > 1 & (Convert.ToInt32(autor) < 5))
                Autors = autor + " автрора";
            else
                Autors = autor + " автроров";
        }
    }
    public class Namebook : IComparable<Namebook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public Namebook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(Namebook book)
        {
            return BookName.CompareTo(book.BookName);
        }

        public static explicit operator Namebook(BookCreate counter)
        {
            return new Namebook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
    public class Autorbook : IComparable<Autorbook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public Autorbook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(Autorbook book)
        {
            return Autor.CompareTo(book.Autor);
        }

        public static explicit operator Autorbook(BookCreate counter)
        {
            return new Autorbook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
    public class Perepletbook : IComparable<Perepletbook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public Perepletbook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(Perepletbook book)
        {
            return Pereplet.CompareTo(book.Pereplet);
        }

        public static explicit operator Perepletbook(BookCreate counter)
        {
            return new Perepletbook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
    public class Yearbook : IComparable<Yearbook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public Yearbook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(Yearbook book)
        {
            return GodVipyska.CompareTo(book.GodVipyska);
        }

        public static explicit operator Yearbook(BookCreate counter)
        {
            return new Yearbook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
    public class KratkoeSoderjbook : IComparable<KratkoeSoderjbook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public KratkoeSoderjbook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(KratkoeSoderjbook book)
        {
            return KratkoeSoderjanie.CompareTo(book.KratkoeSoderjanie);
        }

        public static explicit operator KratkoeSoderjbook(BookCreate counter)
        {
            return new KratkoeSoderjbook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
    public class KolStrbookbook : IComparable<KolStrbookbook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public KolStrbookbook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(KolStrbookbook book)
        {
            return KolvoStranic.CompareTo(book.KolvoStranic);
        }

        public static explicit operator KolStrbookbook(BookCreate counter)
        {
            return new KolStrbookbook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
    public class Allbook : IComparable<Allbook>
    {
        public string BookName { get; set; }
        public string Pereplet { get; set; }
        public int GodVipyska { get; set; }
        public string Autor { get; set; }
        public string KratkoeSoderjanie { get; set; }
        public int KolvoStranic { get; set; }

        public Allbook(string bookName, string autor, string pereplet, int godVipyska, int kolvoStranic, string kratkoeSoderjanie)
        {
            BookName = bookName;
            Autor = autor;
            GodVipyska = godVipyska;
            KolvoStranic = kolvoStranic;
            Pereplet = pereplet;
            KratkoeSoderjanie = kratkoeSoderjanie;
        }
        public int CompareTo(Allbook book)
        {
            int compare;
            compare = BookName.CompareTo(book.BookName);
            if (compare == 0)
            {
                compare = Autor.CompareTo(book.Autor);
                if (compare == 0)
                {
                    compare = GodVipyska.CompareTo(book.GodVipyska);
                    if (compare == 0)
                    {
                        compare = KolvoStranic.CompareTo(book.KolvoStranic);
                        if (compare == 0)
                        {
                            compare = Pereplet.CompareTo(book.Pereplet);
                            if (compare == 0)
                            {
                                compare = KratkoeSoderjanie.CompareTo(book.KratkoeSoderjanie);
                            }
                        }
                    }
                }
            }
            return compare;
        }

        public static explicit operator Allbook(BookCreate counter)
        {
            return new Allbook(counter.BookName, counter.Autor, counter.Pereplet, counter.GodVipyska, counter.KolvoStranic, counter.KratkoeSoderjanie);
        }
        public override string ToString()
        {
            return "\nНазвание = " + BookName + "\nАвтор = " + Autor + "\nПереплет = " + Pereplet + "\nГод выпуска = " + GodVipyska + "\nКол-во страниц = " + KolvoStranic + "\nКраткое содержание = " + KratkoeSoderjanie + "\n";
        }
    }
}
