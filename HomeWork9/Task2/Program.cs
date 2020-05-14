using System;

namespace Task2
{
    class Program
    {
        public delegate int ValueDelegate();
        public delegate double SrArithmetic(ValueDelegate[] valueDelegates);
        static void Main(string[] args)
        {
            Random rand = new Random();
            ValueDelegate[] ValueDelegates = new ValueDelegate[6];
            for (int i = 0; i < ValueDelegates.Length; i++)
            {
                ValueDelegates[i] = () => rand.Next(0, 10);
            }

            SrArithmetic srArithmetic = delegate (ValueDelegate[] valueDelegates) 
            {
                int sum = 0;
                for (int i = 0; i < valueDelegates.Length; i++)
                {
                    sum += valueDelegates[i]();
                }
                return (double)sum / valueDelegates.Length;
            };

            double result = srArithmetic(ValueDelegates);

            

            Console.WriteLine(result);
        }
    }
}
