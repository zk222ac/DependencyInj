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
        public ClassB(ClassA classA )
        {
            ClassA = classA;
        }
        public void PrintClassAProperties()
        {
            Console.WriteLine($"Print ClassA properties such as X:{ClassA.X} and Y:{ClassA.Y}");
        }

    }
}
