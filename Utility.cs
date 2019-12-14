using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class Utility
    {

        public static void stringtraverse(string[] arr)
        {
            foreach (string element in arr)
            {
                Console.Write(element + "    ");
            }
        }


        /// <summary>
        /// One Dimensioal Array Traversing Method
        /// </summary>
        /// <param name="arr">Array Traversing</param>
        public static void traverse(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + "    ");
            }
        }
        /// <summary>
        ///     Traversing of 2D array
        /// </summary>
        /// <param name="arr">Two Dimensional Array</param>
        /// <param name="m">Row</param>
        /// <param name="n">colmun</param>
        public static void TwoDimensioaltraverse(int[,] arr, int m, int n)
        {

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                } Console.WriteLine();
            }
        }


        /// <summary>
        /// Addition of Two Mtrix Method
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="result"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>

        public static void AddtionOfTwoMartix(int[,] arr1, int[,] arr2, int[,] result, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];
                    Console.Write(result[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }


        public static void SubtractionOfTwoMartix(int[,] arr1, int[,] arr2, int[,] result, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = arr1[i, j] - arr2[i, j];
                    Console.Write(result[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Multiplication of two matrix
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="result"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public static void MultiplicatoinOfTwoMatrix(int[,] arr1, int[,] arr2, int[,] result, int m, int n, int m1, int n1)
        {

            if (n == m1)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n1; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            result[i, j] = result[i, j] + arr1[i, k] * arr2[k, j];

                        }
                        Console.Write(result[i, j] + "  ");

                    }
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("Matrix Multiplication is Not Possible : plesase Try other Dimension");
            }

        }
        /// <summary>
        /// Determinant of the matrix of ANY OREDER
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>

        public static void DeterminantOfMatrix(int[,] arr, int N)
        {
            int deteminat = 0;
            if (N == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.WriteLine("The Determinatn of the matrix is -----> " + arr[i, j]);
                    }
                }
            }

            else if (N == 2)
            {

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        deteminat = (arr[0, 0] * arr[1, 1]) - (arr[0, 1] * arr[1, 0]);
                    }
                }
                Console.WriteLine("The Determinant of the matrix is ---->" + deteminat);
            }
            else
            {
                Console.WriteLine("Wait");
            }

        }

        /// <summary>
        ///     Find Diagonal Element and their Sum
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public static void diagonalElement(int[,] arr, int m, int n)
        {
            int diagonalelement = 0;
            Console.WriteLine("The Diagonal Element is ----> ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) {
                        Console.WriteLine(arr[i, j] + "  ");
                        diagonalelement = diagonalelement + arr[i, j];
                    }


                }
            } Console.WriteLine("The Sum of the Diagonal Element is ------> " + diagonalelement);

        }
        /// <summary>
        ///             Find The Missing Number from 0 -1000 if any one number is missiong
        /// </summary>
        /// <param name="arr">Arry list</param>
        /// <param name="n"> length of the arry</param>
        /// <returns></returns>
        public static int missingNumber(int[] arr, int n)
        {
            int expectedtotal = (n + 1) * (n + 2) / 2;
            int total = 0;
            int missing = 0;
            for (int i = 0; i < n; i++)
            {
                total = total + arr[i];
            }
            missing = expectedtotal - total;
            return missing;
        }

        public static void bubblesort(int[] arr, int size)
        {
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            Utility.traverse(arr);
        }

        /// <summary>
        ///     Insertion sort for Integer
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        public static void InsertionSort(int[] arr, int size)
        {
            int temp;
            int j;
            for (int i = 1; i < size; i++)
            {
                j = i;
                temp = arr[i];
                while (j > 0 && arr[j - 1] > temp)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            Console.WriteLine("\n");
            Utility.traverse(arr);
        }

        /// <summary>
        ///  Delete An Element form the Array
        /// </summary>
        /// <param name="arr"> array name</param>
        /// <param name="size"> length of the array</param>
        /// <param name="key"> the value want to delete</param>
        public static void RemoveElememt(int[] arr, int size, int key)
        {
            int i;
            int[] result = new int[size];
            for (i = 0; i < size; i++)
            {
                result[i] = arr[i];

                if (arr[i] == key)
                {
                    break;
                }


            }
            if (i < size)
            {
                size = size - 1;
                for (int j = i; j < size; j++)
                {
                    result[j] = arr[j + 1];
                }
            }

            Console.WriteLine("\n");
            Utility.traverse(result);

        }
        /// <summary>
        ///         get the Max And Min Value form the list array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        public static void max_min(int[] arr, int size)
        {
            int max, min;
            min = arr[0];
            max = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > max)

                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("The Max value is ----->   " + max + "    The Min value is ---->   " + min);

        }


        public static void fristandsecondLargeA(int[] arr, int size)
        {
            int larget = Int32.MinValue;
            int s_largest = Int32.MinValue;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > larget)
                {
                    s_largest = larget;
                    larget = arr[i];

                }
                else if (arr[i] > s_largest && arr[i] != larget)
                {
                    s_largest = arr[i];
                }
            }
            Console.WriteLine("The Frist Max is ---> " + larget + "The Seocnd Largest is ---> " + s_largest);


        }

        public static void subArrayHighestmulti(int[] arr, int size)
        {
            int frist, i, j;
            int second;
            int multi;
            int temp = 0;
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size - 1; j++)
                {
                    frist = i;
                    second = j;
                    multi = arr[i] * arr[j];
                    temp = multi;
                    if (temp < multi)
                    {
                        temp = multi;
                    }
                    //  Console.WriteLine("The index is a[i,j]-->" + frist + "," + second + " multiplication is " + temp);
                }

            }
            Console.WriteLine(temp);

        }

        public static int BinarySearch(int[] arr,int key)
            {
            int mid;
                int l = 0;
            int h = arr.Length - 1;
            while (l <= h)
            {
                mid = (l + h) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (key < arr[mid])
                {
                    h = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return -1;
            }


    }
}
