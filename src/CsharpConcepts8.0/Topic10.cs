using System;

namespace CsharpConcepts8._0
{
    class Topic10
    {
        public void Entry()
        {
            var sequence = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Index index = 0;
            Index lastIndex = ^1;
            Console.WriteLine(sequence[index]);
            Console.WriteLine(sequence[lastIndex]); //The ^0 index is the same as sequence[sequence.Length]

            Range range = 0..10; //The start of the range is inclusive, but the end of the range is exclusive
            Console.WriteLine(ArrayToString(sequence[range]));
            Console.WriteLine($"All numbers in range .. {ArrayToString(sequence[..])}");
            Console.WriteLine($"Numbers in range 1.. {ArrayToString(sequence[1..])}");
            Console.WriteLine($"Numbers in range ..10 {ArrayToString(sequence[..10])}");

            var str = "HelloWorld"; //Indices and ranges are supported in strings also. 
            Console.WriteLine(str[index]);
            Console.WriteLine(str[lastIndex]);
            Console.WriteLine(str[..]);
        }

        string ArrayToString(int[] arr)
        {
            return string.Join(',', arr);
        }
    }
}
