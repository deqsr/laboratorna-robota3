using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(20000, "sofa", "4room");
            Console.WriteLine("quantity of goods: ");
            int quantity = int.Parse(Console.ReadLine());
            invoice.Quantity = quantity;
            Console.WriteLine("With VAT");
            Console.WriteLine("Without VAT");
            string article = Console.ReadLine();
            invoice.Article = article;
            Console.WriteLine(invoice.tax());
        }
    }
}
