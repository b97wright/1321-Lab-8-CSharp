using System;

namespace Lab8
{
    class Lab8C
    {
        static void Main(string[] args)
        {
            // variables 
            string uI;
            int row = 1, column = 1, count = 0;

            // making array

            Console.Write("Please enter the number of rows: ");
            uI = Console.ReadLine();
            row = Convert.ToInt32(uI);

            Console.Write("Please enter the number of columns:  ");
            uI = Console.ReadLine();
            column = Convert.ToInt32(uI);

            int[,] aNums = new int[row, column];
            int[] aNumsOneD = new int[row * column];

            Console.WriteLine(" ");

            Console.WriteLine("I have " + row + " rows and " + column + " columns. I need to fill-up " + (row * column) + " spaces. ");

            Console.WriteLine(" ");

            Console.WriteLine("The " + row + "x" + column + " array: ");

            // nested for loop to loop theough the rows and columns of the 2D array
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    count++;
                    aNums[i, j] = count;

                    Console.Write(count + "|");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");

            Console.WriteLine("The " + row + "x" + column + " 2-D array flattened into a "+ (row * column) + " cell 1-D array: ");

            count = 0;

            // nested for loop to loop through the 2d array to put the 2d array in 1d array
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    aNumsOneD[count] = aNums[i, j];
                    Console.Write(aNumsOneD[count] + "|");
                    count++;
                }
            }

        }
    }
}
