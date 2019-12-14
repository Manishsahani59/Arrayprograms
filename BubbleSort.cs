using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Arrayprograms
{
    class BubbleSort
    {
        public void Bubblesort()
        {
            
            Console.WriteLine("Enter the Size of the array  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size];
            Console.WriteLine("Enter the Element Now --->");

             string path= @"D:\path.txt";
             string path1= @"D:\demo.txt";
             string value=File.ReadAllText(path);
            //    Console.WriteLine(value);  

            //StreamWriter sw = new StreamWriter(path1);
            /* if Want sort Strng then use this array*/
            string[] arr = value.Split(" ");


            /* if Want sort integer then use this array*/
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = int.Parse(arr[i]);
            }


            /*  for (int i = 0; i < size; i++)
              {
                  arr[i] = Convert.ToInt32(Console.ReadLine());
              }
              */
            Console.WriteLine("Your Array is Before Sorting --->");
            Utility.traverse(arr1);
          //  Utility.traverse(arr);
            Console.WriteLine("\n");

            Console.WriteLine("Your Array is After Sorting --->");
            Utility.bubblesort(arr1, size);

          
          
            Console.WriteLine("Enter the element want to serch");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Utility.BinarySearch(arr1, key)); 

                
                }

    }
}
