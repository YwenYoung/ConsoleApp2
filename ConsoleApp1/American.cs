using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class American:Person
    {
        public American(string name)
            : base(name)
        { }

        public override void SayHello()
        {
            Console.WriteLine("我是美国人！我叫{0}", this.Name);
        }
    }
}
