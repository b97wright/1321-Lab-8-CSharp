using System;

namespace Lab8
{
    class Lab8A
    {
        static void Main(string[] args)
        {
            // variables 
            string uI;

            // making array
            int[] aNumOne = new int[5];
            int[] aNumTwo = new int[5];
            int[] aSum = new int[5];

            Console.WriteLine("Please enter 5 integers for the first array:");

            // array for first integers to be added to array
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Integer " + (i + 1) + " : ");
                uI = Console.ReadLine();
                aNumOne[i] = Convert.ToInt32(uI);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Please enter 5 integers for the second array:");

            // array for second integers to be added to array
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Integer " + (i + 1) + " : ");
                uI = Console.ReadLine();
                aNumTwo[i] = Convert.ToInt32(uI);
            }

            Console.WriteLine(" ");

            // array for sum to be added to array
            for (int i = 0; i < 5; i++)
            {
                aSum[i] = aNumOne[i] + aNumTwo[i];
            }

            Console.Write("The resulting sums are ");
            Console.Write(aSum[0] + "|" + aSum[1] + "|" + aSum[2] + "|" + aSum[3] + "|" + aSum[4] + "|");

        }
    }
}
