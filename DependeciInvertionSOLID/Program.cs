using System;

namespace DependeciInvertionSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new ConsolePrinter());
            book.Print();
        }
    }

    class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }
        public Book(IPrinter printer)
        {
            this.Printer = printer;
        }
        public void Print()
        {
            Printer.Print(Text);
        }

    }

    interface IPrinter
    {
        void Print(string text);
    }
    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
