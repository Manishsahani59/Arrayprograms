using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class FindDeagonalElementOfArray
    {

        public void DiagonalElement()
        {
            int m, n;
            
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
            Console.WriteLine("The Matrix is---->");
            Utility.TwoDimensioaltraverse(arr1, m, n);
            Utility.diagonalElement(arr1,m,n);
        }
    }
}
