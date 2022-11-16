using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._02
{
    internal class Book
    {
        private string category;
        private string author;
        private string relaseDate;
        private string title;
        private int pages;
        public Book() { }
        public string Category(string xd)
        {
            category = xd;
            return category;
        }
        public string Author(string xdd)
        {
            author = xdd;
            return author;
        }
        public string Title(string xddd)
        {
            title = xddd;
            return title;
        }
        public string RelaseDate(string xdddd)
        {
            relaseDate = xdddd;
            return relaseDate;
        }
        public int Pages(int xddddd)
        {
            pages = xddddd;
            return pages;
        }
        public void Vypis()
        {
            Console.WriteLine(Category("Category: Fantasy"));
            Console.WriteLine(Author("Author: Tolkien"));
            Console.WriteLine(Title("Title: LOTR"));
            Console.WriteLine(RelaseDate("Relase Date: 29.7.2005"));
            Console.WriteLine("numbers of pages: " + Pages(1172));
        }
    }
}

