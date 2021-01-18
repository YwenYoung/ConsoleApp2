using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Japanese : Person
    {
        public Japanese(string name)
            : base(name)
        { }

        public override void SayHello()
        {
            Console.WriteLine("我是日本人！我叫{0}", this.Name);
        }
    }
}
