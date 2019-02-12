using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInj
{
    class ClassB
    {
        public int Z { get; set; }
        public int K { get; set; }
        public ClassA ClassA { get; set; }
        
        // here we inject ClassA dependency into ClassB constructor 
        public ClassB(ClassA classA )
        {
            ClassA = classA;
        }
        public void PrintClassAProperties()
        {
            // Call ClassA properties through CLassA instance 
            Console.WriteLine($"Print ClassA properties such as X:{ClassA.X} and Y:{ClassA.Y}");
        }

    }
}
