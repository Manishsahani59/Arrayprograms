using System;
using System.Collections.Generic;
using System.Text;

namespace Arrayprograms
{
    class count
    {
        public void count1to100()
        { int count = 0;
            int temp = 10;
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + "   ");
                if (i == temp)
                {
                    Console.WriteLine();
                    temp = temp + 10;
                    
                }
               
            }
        }

    }
}
