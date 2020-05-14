using System;

namespace Task3
{
    class Program
    {
        public delegate int Arithmetic(int operand1, int operand2);
        static void Main(string[] args)
        {
            Arithmetic Add = (int a, int b) => { return a + b; };
            Arithmetic Sub = (int a, int b) => { return a - b; };
            Arithmetic Mul = (int a, int b) => { return a * b; };
            Arithmetic Div = (int a, int b) => { int sum = b == 0 ? a : a / b; return sum; };
            Console.WriteLine(Add(2,4));
            Console.WriteLine(Sub(4,2));
            Console.WriteLine(Mul(2,2));
            Console.WriteLine(Div(8,4));
            
        }
    }
}
