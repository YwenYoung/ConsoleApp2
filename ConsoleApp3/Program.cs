using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Company cmp = new Company();
            Employee emp = new Employee();
            Manager mag = new Manager();
            Programmer pgm = new Programmer();
            Company[] cmps = { emp, mag, pgm };
            for (int i = 0; i < cmps.Length; i++)
            {
                cmps[i].DaKa();
            }
            Console.ReadKey();
        }
    }
}

public class Company        //父类
{
	public virtual void DaKa()
		{
			Console.WriteLine("打卡！");
		}
};

public class Employee : Company     //子类
{
    public override void DaKa()
    {
        Console.WriteLine("员工9点打卡！");
    }
}

public class Manager : Company     //子类
{
    public override void DaKa()
    {
        Console.WriteLine("经理8点打卡！");
    }
}

public class Programmer : Company     //子类
{
    public override void DaKa()
    {
        Console.WriteLine("程序员不打卡！");
    }
}

