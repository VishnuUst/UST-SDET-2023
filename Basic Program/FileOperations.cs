using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
        public void WriteData()
        {
            FileStream fs = new FileStream("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample2.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text You want to write the file");
            string?str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
        
            sw.Close();

        }
        public void ReadData()
        {
            FileStream fs = new FileStream("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(5,SeekOrigin.Current);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();


        }
       /* public void CopyFile()
        {
            FileInfo fileInfo = new FileInfo("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample.txt");
            FileInfo fileInfo1 = new FileInfo("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample2.txt");
            fileInfo.CopyTo("D:\\SDET-DAILYWORK\\Basic Solution\\copyandmove" + "\\Sample.txt");
            fileInfo1.MoveTo("D:\\SDET-DAILYWORK\\Basic Solution\\copyandmove"+"\\Sample2.txt");
            

        }*/
        public void DeleteFile()
        {
            FileInfo fileInfo = new FileInfo("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample2.txt");
            fileInfo.Delete();
        }
        public void FileProperties()
        {
            FileInfo fileInfo = new FileInfo("D:\\SDET-DAILYWORK\\Basic Solution\\Files\\Sample2.txt");
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Length.ToString());
        }
    }
}
