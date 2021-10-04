using System;

namespace CsharpConcepts8._0
{
    class Topic13
    {
        public void Entry()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3 };
            var index = numbers.IndexOfAny(2, 3);
            Console.WriteLine(index);

            var ind = numbers.IndexOfAny(stackalloc[] { 1, 2, 3 });
            Console.WriteLine(ind);
        }
    }
}
