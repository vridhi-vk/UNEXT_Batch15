namespace SimplePrograms.Arrays_and_Collections
{
    internal class ArrayManipulations
    {
        public void disp1D()
        {
            int[] numbers = new int[4];
            numbers[0] = 5;
            numbers[1] = 6;
            numbers[2] = 7;
            numbers[3] = 8;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }

        public void disp2D()
        {
            int[,] numbersMatrix = { { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 } };

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Row {0}", i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0}", numbersMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void dispJA()
        {
            int[][] numbers = new int[4][];

            numbers[0] = new int[] { 1, 2, 4, 3 };
            numbers[1] = new int[] { 2, 4, 3, };
            numbers[2] = new int[] { 7, 4, };
            numbers[3] = new int[] { 3, 7, 3 };

            Console.WriteLine(numbers[1][2]);
            Console.WriteLine(numbers[3][2]);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Row({0}): ", i);
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write("{0} ", numbers[i][j]);
                }
                Console.WriteLine();
            }
        }

        }
    }
