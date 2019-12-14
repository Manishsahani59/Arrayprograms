using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class MissingNumber
    {
        public void missingNumber()
        {

            Console.WriteLine("Enter the Array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Element of the Array");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Your Array is --->");
            Utility.traverse(a);
            Console.WriteLine("The Missing Number is ---> " + Utility.missingNumber(a,size));


        }
    }
}
