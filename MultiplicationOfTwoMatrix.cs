using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class MultiplicationOfTwoMatrix
    {
        public void MuliplicationTwoArray()
        {
            int m, n;
            const int max = 100;
            Console.WriteLine("Enter the row ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Colums");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[m, n];
           
            
            Console.WriteLine("Enter the Elements of the first matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The First Matrix is---->");
            Utility.TwoDimensioaltraverse(arr1, m, n);
            Console.WriteLine("Enter the Dimension of the Second Matrix");
            Console.WriteLine("Enter the row ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Colums");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = new int[m1, n1];
            Console.WriteLine("Enter the Elements of the second matrix");
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Seconnd Matrix is---->");
            Utility.TwoDimensioaltraverse(arr2, m1, n1);

            Console.WriteLine("The multiplication of Both matrix is --->");
            int[,] multiplication = new int[max,max];
            Utility.MultiplicatoinOfTwoMatrix(arr1,arr2, multiplication, m,n,m1,n1);

        }
    }
}
