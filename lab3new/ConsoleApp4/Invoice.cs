using System;
using System.Collections.Generic;




namespace ConsoleApp4
{
    internal class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        private double sum;
        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public double tax()
        {
            double tax = 0;
            double sum = 0;
            int price = account * quantity;
            switch (Article)
            {
                case "With VAT":
                    {
                        tax = 0.20;
                        sum = price + price * tax;
                        break;
                    }
                case "Without VAT":
                    {
                        sum += price;
                        break;
                    }
            }
            return sum;
        }
    }
}
