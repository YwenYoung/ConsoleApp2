using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要的笔记本品牌~");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();

            Console.ReadKey();
        }

        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;

            switch (brand)
            {
                case "Lenove": nb = new Lenovo();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
            }


            return nb;
        }
    }
}

public abstract class NoteBook
{
    public abstract void SayHello();
}

public class Lenovo : NoteBook
{
    public override void SayHello()
    {
        Console.WriteLine("我是联想笔记本！");
    }
}
public class Acer : NoteBook
{
    public override void SayHello()
    {
        Console.WriteLine("我是宏基笔记本！");
    }
}
public class Dell : NoteBook
{
    public override void SayHello()
    {
        Console.WriteLine("我是戴尔笔记本！");
    }
}