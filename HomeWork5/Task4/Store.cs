using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Store
    {
        private Article[] articles = null;
        public Store(params Article[] articles)
        {
            this.articles = articles;
        }

        public string this[int index]
        {
            get
            {
                return articles[index].ProductName.ToString() + " " + articles[index].MarketName.ToString() + " " + articles[index].Price.ToString();
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].ProductName == index)
                    {
                        return articles[i].ProductName.ToString() + " " + articles[i].MarketName.ToString() + " " + articles[i].Price.ToString();
                        
                    }

                }
                return "Product is not exist.";
                
            }
        }
    }
}
