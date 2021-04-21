using System;

namespace CsharpConcepts8._0
{
    class Topic2
    {
        public void Entry()
        {
            var cls = new Topic2TestClass("shreesha", DateTime.Parse("02-01-1993"));
            Console.WriteLine(cls.GetName());
            Console.WriteLine($"{cls.GetName()} age {((ITopic2TestInterface)cls).GetAge()}");
        }
    }

    interface ITopic2TestInterface
    {
        string Name { get; set; }
        DateTime DOB { get; set; }
        string GetName();

        //Default interface methods
        string GetAge()
        {
            return (DateTime.Now.Date.Subtract(DOB).TotalDays/365).ToString();
        }
    }

    class Topic2TestClass : ITopic2TestInterface
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Topic2TestClass(string name, DateTime dob)
        {
            Name = name;
            DOB = dob;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
