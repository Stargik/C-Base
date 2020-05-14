using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class MyMatrix
    {
        private int[][] matrix;
        Random random = new Random();
        public MyMatrix(int x, int y)
        {
            matrix = new int[x][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[y];
            }
            this.SetValue();
        }

        void SetValue()
        {
            for (int i = 0; i < matrix.Length; i++)
            {

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(0, 9);
                }
            }
        }

        public int this[int x, int y]
        {
            get
            {
                return matrix[x][y];
            }
            set
            {
                matrix[x][y] = value;
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.Length; i++) 
            { 
           
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ChangeMatrix(int x, int y)
        {
            int[][] newMatrix = new int[x][];
            for (int i = 0; i < newMatrix.Length; i++)
            {
                newMatrix[i] = new int[y];
            }

            for (int i = 0; i < newMatrix.Length; i++)
            {
                for (int j = 0; j < newMatrix[i].Length; j++)
                {
                    if (matrix.Length > i && matrix[i].Length > j)
                        newMatrix[i][j] = matrix[i][j];
                    else
                        newMatrix[i][j] = random.Next(0, 9);
                }
            }
            matrix = newMatrix;
        }
    }
}
