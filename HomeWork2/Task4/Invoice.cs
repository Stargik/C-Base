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

    }
}
