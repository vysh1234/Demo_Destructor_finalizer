using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Destructor
{
    public class Class : IDisposable
    {
        public void Display_Msg()
        {
            Console.WriteLine("inside display method()");
        }
        public Class()
        {
            Console.WriteLine("Default constructor..");
        }
        public Class(string msg)
        {
            Console.WriteLine("parametrized constructor..");
        }
        ~Class()
        {
            Console.WriteLine("Freeing up resources");
        }
        //public override string ToString() => GetType().Name;
        
        public void Dispose()
        {
            Console.WriteLine("Freeing up resources with dispose.");
           
            GC.SuppressFinalize(this);

        }
    }
}
