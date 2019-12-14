using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class DeterminantOfMatrix
    {

        public void determinant()
        {
            int m, n;

            Console.WriteLine("Enter the Order N  X  N");
            n = Convert.ToInt32(Console.ReadLine());
           
            int[,] arr1 = new int[n, n];
           
            Console.WriteLine("Enter the Elements of the first matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The First Matrix is---->");
            Utility.TwoDimensioaltraverse(arr1, n, n);
            Utility.DeterminantOfMatrix(arr1, n);

        }

    }
}
