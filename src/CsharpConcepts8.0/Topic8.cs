using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CsharpConcepts8._0
{
    class Topic8
    {
        public void Entry()
        {
            Task.Run(async () =>
            {
                var collection = GetEnumerableAsync();
                await foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            });
        }

        private async IAsyncEnumerable<int> GetEnumerableAsync()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var item in array)
            {
                await Task.Delay(500);
                yield return item;
            }

        }
    }
}
