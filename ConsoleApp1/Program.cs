using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习多态功能的编程！
            //Person[] pers = new Person[8];

            Chinese cn1 = new Chinese("张三");
            Chinese cn2 = new Chinese("李四");

            Japanese jn1 = new Japanese("太郎");
            Japanese jn2 = new Japanese("次郎");

            Korean kn1 = new Korean("金日");
            Korean kn2 = new Korean("金月");

            American am1 = new American("Tomi");
            American am2 = new American("Rose");
            Person[] pers = { cn1, cn2, jn1, jn2, kn1, kn2, am1, am2 };
            
            for ( int i =0; i < pers.Length; i++ )
            {
                /*
                if ( pers[i] is Chinese )
                {
                    ((Chinese) pers[i]).SayHello();
                }
                else if (pers[i] is Japanese)
                {
                    ((Japanese) pers[i]).SayHello();
                }
                /************************************************************************/
                /* pers前面必须要加上子类名称强转父类，否则调用的SayHello是父类的！
                 * Korean和American是同理的，不再赘述！
                 * 另外pers为什么不可以提前写成组然后给组赋各个子类的值呢？
                   */
                pers[i].SayHello();
            }
                        
            Console.ReadKey();
        }
    }
}
