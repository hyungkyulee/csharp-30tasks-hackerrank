using System;

namespace Day13.AbstractClasses
{
    abstract class Book
    {
    
        protected String title;
        protected  String author;
    
        public Book(String t,String a){
            title=t;
            author=a;
        }
        public abstract void display();


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            String title=Console.ReadLine();
            String author=Console.ReadLine();
            int price=Int32.Parse(Console.ReadLine());
            Book new_novel=new MyBook(title,author,price);
            new_novel.display();
        }
    }

    internal class MyBook : Book
    {
        public int Price { get; }

        public MyBook(string title, string author, int price) : base(title, author)
        {
            Price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}