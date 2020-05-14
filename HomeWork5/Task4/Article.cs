using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Article
    {
        private string productName, marketName;
        private int price;

        public string ProductName { get => productName; set => productName = value; }
        public string MarketName { get => marketName; set => marketName = value; }
        public int Price { get => price; set => price = value; }
    }
}
