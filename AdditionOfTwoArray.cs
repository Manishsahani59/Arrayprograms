using System;
using System.Collections.Generic;
using System.Text;


namespace Arrayprograms
{
    class AdditionOfTwoArray
    {



         
        public void AddTwoArray()
        {
            int m, n;
          
            Console.WriteLine("Enter the row ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Colums");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[m,n];
            int[,] arr2 = new int[m, n];
            int[,] resultant = new int[m, n];
            Console.WriteLine("Enter the Elements of the first matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                  arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The First Matrix is---->");
            Utility.TwoDimensioaltraverse(arr1, m, n);
            Console.WriteLine("Enter the Elements of the second matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Seconnd Matrix is---->");
            Utility.TwoDimensioaltraverse(arr2, m, n);

            Console.WriteLine("The Addition of Both matrix is --->");
            Utility.AddtionOfTwoMartix(arr1, arr2, resultant, m, n);
           



        }
    }
}
