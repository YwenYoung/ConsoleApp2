using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {    
            private string _name;           //默认字段私有，不与外界直接接口

            public string Name              //默认属性共有，隐藏字段暴露接口
            {
                get { return _name; }       //可读
                set { _name = value; }      //可写
            }

            public Person(string name)  //默认构造函数
            {
                this.Name = name;       //默认初始化
            }

            public virtual void SayHello()      //默认实现方法
            {
                Console.WriteLine("我是人类！");
            }
    }
}
