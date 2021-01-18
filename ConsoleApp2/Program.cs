using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Ywen\Desktop\枢纽各项功能目录Video_2020-12-21_154700.wmv";
            string target = @"C:\Users\Ywen\Desktop\测试.wmv";
            CopyFile(source, target);
            Console.WriteLine("复制成功！");
            Console.ReadKey();
        }

        public static void CopyFile(string source, string target)   //传入源文件和目标文件的参数
        {
            //创建一个读取流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {   //创建一个写入流
                using (FileStream fsWrite = new FileStream(target,
                                                FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 1];  //把字节读到一个声明的字节中
                                                                //如果文件比较大，所以在读取的时候应该通过一个循环去读取
                    while (true)
                    {   //返回本次读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)     //如果返回0就意味着什么都没读到，读取结束
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                        //这里写r是因为最后一次读取是按照r的最小类型的信息来读取
                        //而不是按照buffer.Length
                    }
                }
            }
        }
    }
}
