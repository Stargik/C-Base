using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Block
    {
        public int a, b, c, d;
        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (((Block)obj).a == this.a && ((Block)obj).b == this.b && ((Block)obj).c == this.c && ((Block)obj).d == this.d)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Block" + this.GetHashCode() + ": a = " + this.a + "; b = " + this.b + "; c = " + this.c + "; d = " + this.d;
        }
    }
}
