using System;

namespace CsharpConcepts8._0
{
    class Topic12
    {
        public void Entry()
        {
            var cords = new GenericType<int>() { X = 1, Y = 2 };  // This is unmanaged type in c# 8.0
            Console.WriteLine($"X {cords.X} :: Y {cords.Y}");

            //var name = new GenericType<string>() { X = "shreesha", Y = "rao" };  // This is not unmanaged. That's the reason it gives error
        }

        public struct GenericType<T> where T : unmanaged
        {
            public T X;
            public T Y;
        }
    }
}
