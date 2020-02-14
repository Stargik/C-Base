using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article { get => article; set => article = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public decimal CountPrice(bool nds)
        {
            decimal cost = 0m;
            switch (article.ToLower())
            {
                case "computer":
                    cost = 6000m;
                    break;
                case "telephone":
                    cost = 4000m;
                    break;
                case "watch":
                    cost = 3000m;
                    break;
                default:
                    Console.WriteLine("Product is not exist.");
                    break;
            }
            if (nds)
            {
                cost *= 1.4m;
            }
            return cost * quantity;
        }

       

    }
}
