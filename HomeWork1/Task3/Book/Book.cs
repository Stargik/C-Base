using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        Author author = null;
        Content content = null;
        Title title = null;

        public Book(string titleField)
        {
            this.Initialize();
            this.title.Field = titleField;
        }

        public string ContentField
        {
            set { content.Field = value; }
        }

        public string AuthorField
        {
            set { author.Field = value; }
        }


        void Initialize()
        {
            author = new Author();
            content = new Content();
            title = new Title();
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }



    }
}
