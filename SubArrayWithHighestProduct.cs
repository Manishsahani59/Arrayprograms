using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class SubArrayWithHighestProduct
    {
        public void HighestMultiplication()
        {
            Console.WriteLine("Enter the Size of the array  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the Element Now --->");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Array is --->");
            Utility.traverse(arr);

            Utility.subArrayHighestmulti(arr, size);

        }

    }
}
