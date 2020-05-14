using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class House
    {
        int a, b;
        public House(House obj)
        {
            this.a = obj.A;
            this.b = obj.B;
        }
        public House()
        {

        }
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public object Clone()
        {
            return this;
        }
        public object DeepClone()
        {
            //return new House(this);
            return this.MemberwiseClone();
        }
    }
}
