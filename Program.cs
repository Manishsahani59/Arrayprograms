using System;

namespace Arrayprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;
            do
            {
                Console.WriteLine(" 1. Traversing of Array ");
                Console.WriteLine(" 2. Addition of Two Matrix");
                Console.WriteLine(" 3. Subtraction  of two Matrix");
                Console.WriteLine(" 4. Multiplication of Two Matrix");
                Console.WriteLine(" 5. Determinant Of Matrix");
                Console.WriteLine(" 6. Diagonal Element of The Array and their Sum");
                Console.WriteLine(" 7. Any one  missing No for 0-100");
                Console.WriteLine(" 8. Bubble Sort ");
                Console.WriteLine(" 9. Insertion Sort");
                Console.WriteLine(" 10. Remove Element");
                Console.WriteLine(" 11. Max And Min Element From ");
                Console.WriteLine(" 12. Frist and Second Largest No ");
                Console.WriteLine(" 13. Sub Array with largest product ");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TraversingOfArray Traverse = new TraversingOfArray();
                        Traverse.TraversingofArray();
                        break;
                    case 2:
                        AdditionOfTwoArray Addition = new AdditionOfTwoArray();
                        Addition.AddTwoArray();
                        break;
                    case 3:
                        subtractionofTwoMatrix subtraction = new subtractionofTwoMatrix();
                        subtraction.subtractTwoArray();
                        break;
                    case 4:
                        MultiplicationOfTwoMatrix multiplication = new MultiplicationOfTwoMatrix();
                        multiplication.MuliplicationTwoArray();
                        break;
                    case 5:
                        DeterminantOfMatrix Determinant = new DeterminantOfMatrix();
                        Determinant.determinant();
                        break;
                    case 6:
                        FindDeagonalElementOfArray diagonalsum = new FindDeagonalElementOfArray();
                        diagonalsum.DiagonalElement();
                        break;
                    case 7:
                        MissingNumber missingNo = new MissingNumber();
                        missingNo.missingNumber();
                        break;
                    case 8:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.Bubblesort();
                       break;
                    case 9:
                        InsertionSort inseertionSrt = new InsertionSort();
                        inseertionSrt.Insertionsort();
                       break;
                    case 10:
                        RemoveElementFromArray removeelement = new RemoveElementFromArray();
                        removeelement.Insertionsort();
                       break;
                    case 11:
                        FristLagrest_fristMin max_min = new FristLagrest_fristMin();
                        max_min.FristMax_min();
                       break;
                    case 12:
                        FristsecondLargest f_s_largest = new FristsecondLargest();
                        f_s_largest.fristsecondlargest();
                        
                       break; 
                    case 13:
                        SubArrayWithHighestProduct subarry = new SubArrayWithHighestProduct();
                        subarry.HighestMultiplication();
                         break;
                    default:
                        Console.WriteLine("Entered Wrong Option");
                        break;
                }
                Console.WriteLine("If you continue Y/N");
                input = Convert.ToChar(Console.ReadLine());
            } while (input.Equals('Y') || input.Equals('y'));

           
        }
    }
}
