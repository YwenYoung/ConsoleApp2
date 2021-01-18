using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Korean:Person
    {
        public Korean(string name)
            : base(name)
        { }

        public override void SayHello()
        {
            Console.WriteLine("我是韩国人！我叫{0}", this.Name);
        }
    }
}
