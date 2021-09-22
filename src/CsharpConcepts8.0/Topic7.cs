using System;

namespace CsharpConcepts8._0
{
    class Topic7
    {
        public void Entry()
        {
#nullable enable
            Topic7Test topic7Test = null; // Observe the compiler warning ( Converting null literal or possible null value to non-nullable type.)
                                          //here. If we remove #nullable context, this warning will disappear
            Console.WriteLine(topic7Test?.Id);
#nullable disable
        }
    }

    class Topic7Test
    {
        public int Id { get; set; }
    }
}
