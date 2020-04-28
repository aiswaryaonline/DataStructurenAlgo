using System;
using System.Linq;

namespace DataStructures
{
    class Array
    {
        public int[] InitializeArrays()
        {
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for (int i = 0; i < numbers.Count(); i++)
                Console.WriteLine($"Number {i}");

            return numbers;
        }

        public int[] InitializeArraysBettweWay()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Count(); i++)
                Console.WriteLine($"Number {i}");

            return numbers;
        }

        public void AccessArrays()
        {
            var numbers = InitializeArraysBettweWay();

            Console.WriteLine($"Access item index 0: {numbers[0]}");
            Console.WriteLine($"Access item index 1: {numbers[1]}");
            Console.WriteLine($"Access item index 2: {numbers[2]}");
            Console.WriteLine($"Access item index 3: {numbers[3]}");
            Console.WriteLine($"Access item index 4: {numbers[4]}");
        }
        // http://zetcode.com/lang/csharp/arrays/

    }
}
