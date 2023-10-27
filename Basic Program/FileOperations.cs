using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_Program
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo _file = new FileInfo("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample.txt");
            using StreamWriter str = _file.CreateText();
            Console.WriteLine("File Created Successfully!!!");
            str.WriteLine("Hai Good Morning");
            str.WriteLine("Have A Nice Day");
            Console.WriteLine("File Writted");
        }
    }
}
