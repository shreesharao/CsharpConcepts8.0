using System;

namespace CsharpConcepts8._0
{
    class Topic5
    {
        public void Entry()
        {
            int y = 5;
            int x = 7;
            Console.WriteLine(Add(x, y));

            static int Add(int left, int right) => left + right;
        }
    }
}
