using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInj
{
    class ClassA
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ClassB ClassB { get; set; }

        public ClassA()
        {
            X = 100;
            Y = 200;
            ClassB = new ClassB(this);
        }

        public void MethodA()
        {
            Console.WriteLine("MethodA");
        }

    }
}
