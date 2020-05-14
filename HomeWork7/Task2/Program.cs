using System;

namespace Task2
{
    class Program
    {
        static public void MySort(Train[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i].numberTrain > arr[j].numberTrain)
                    {
                        Train buf = arr[j];
                        arr[j] = arr[i];
                        arr[i] = buf;
                    }
                }
            }
        }
        static void Show(Train[] trains)
        {
            Console.Write("Введите название номер поезда: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number < trains.Length)
            {
                Console.WriteLine("Название номера поезда: " + trains[number-1].numberTrain);
                Console.WriteLine("Название пункта назначения: " + trains[number-1].nameTarget);
                Console.WriteLine("Время отправления: " + trains[number-1].timeToGo);
            }
            else
            {
                Console.WriteLine("Такого поезда нет.");
            }
                    
        }

        static void SetTrains(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите название пункта назначения: ");
                string targetName = Console.ReadLine();
                Console.Write("Введите название номер поезда: ");
                int numberTrain = Int32.Parse(Console.ReadLine());
                Console.Write("Введите время отправления: ");
                string timeToGo = Console.ReadLine();
                trains[i] = new Train(targetName, numberTrain, timeToGo);
               
            }
            MySort(trains);
        }
        static void Main(string[] args)
        {

            Train[] trains = new Train[8];
            SetTrains(trains);
            Show(trains);


            
           
        }

        
    }
}
