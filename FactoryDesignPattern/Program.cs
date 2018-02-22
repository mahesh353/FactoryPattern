using System;
namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IGet ObjIntrface = null;
            ObjIntrface = ClassFactory.CreateandReturnObj(1);
            string response = ObjIntrface.ConcateString("First", "Second");
            Console.WriteLine(response);
            Console.Read();
        }
    }
}
