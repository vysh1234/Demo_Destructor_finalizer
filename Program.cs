using System;

namespace Demo_Destructor
{
    class Program : Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo finalizer!");
            Class obj1 = new Class();
            obj1.Display_Msg();

            //Class obj2 = new Class("Secret message");
            //obj2.Display_Msg();

            obj1.Dispose();

            
        }
    }
}
