using System;

namespace CsharpConcepts8._0
{
    ref struct Topic6RefStruct
    {
        public int Num { get; set; }

        //program won't compile without this publicly accessible Dispose method
        public void Dispose()
        {
            //Dispose unmanaged resources
        }
    }
    class Topic6
    {
        //This is not allowed. A ref struct cannot be a static or an instance member of a class or a normal struct.
        //public Topic6RefStruct Topic6Struct { get; set; }
        public void Entry()
        {
            using Topic6RefStruct topic6Struct = new Topic6RefStruct
            {
                Num = 5
            };
            Console.WriteLine(GetNum(topic6Struct));
        }

        private int GetNum(Topic6RefStruct topic6Struct)
        {
            return topic6Struct.Num;
        }
    }
}
