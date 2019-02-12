using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInj
{
    class Program
    {
        static void Main(string[] args)
        {
            // first declare ClassA instance , because we need to pass 
            // the CLassA instance into ClassB Constructor 
            ClassA classA = new ClassA();

            ClassB b = new ClassB(classA);

            b.PrintClassAProperties();

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
