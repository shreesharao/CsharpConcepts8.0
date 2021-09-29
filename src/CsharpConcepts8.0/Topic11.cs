using System;
using System.Collections.Generic;

namespace CsharpConcepts8._0
{
    class Topic11
    {
        public void Entry()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();

            numbers = numbers ?? new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }
    }
}
