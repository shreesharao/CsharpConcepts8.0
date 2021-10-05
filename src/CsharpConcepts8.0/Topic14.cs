using System;

namespace CsharpConcepts8._0
{
    class Topic14
    {
        public void Entry()
        {
            var workspace = "workspace";
            var path = @$"d:\{workspace}\git\CsharpConcepts8.0"; //Earlier c# versions it had to be - $@"d:\{workspace}\git\CsharpConcepts8.0";
            Console.WriteLine(path);
        }
    }
}
