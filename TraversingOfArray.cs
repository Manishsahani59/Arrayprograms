using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class TraversingOfArray
    {

        public void TraversingofArray()
        {
            Console.WriteLine("Enter the Array size");
            int size= Convert.ToInt32(Console.ReadLine());
            int []a = new int[size];
            for (int i = 0;i<size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Your Array is --->");
            Utility.traverse(a);
        }
    }
}
