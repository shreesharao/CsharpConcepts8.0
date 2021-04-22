using System;
using System.IO;

namespace CsharpConcepts8._0
{
    class Topic4
    {
        public void Entry()
        {
            File.WriteAllText("WriteLines.txt", "second");
            using var file = new StreamReader("WriteLines.txt"); //equivalent to classic using statement
            int skippedLines = 0;
            while (!file.EndOfStream)
            {
                var line = file.ReadLine();
                if (!line.Contains("Second"))
                {
                    Console.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            Console.WriteLine(skippedLines);
        }
    }
    // file is disposed here
}
