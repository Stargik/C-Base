using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(6, 5);
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 20));
            matrix.ChangeMatrix(7, 9);
            matrix[3, 5] = 8;
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(matrix[3, 5]);
            Console.WriteLine(new string('-', 20));
            matrix.ChangeMatrix(4, 3);
            matrix.ShowMatrix();


        }
    }
}
