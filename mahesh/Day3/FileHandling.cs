using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms.FileHandling
{
    internal class FileHandling
    {
        public void CreateFile()
        {
            FileInfo file = new FileInfo("C:\\Users\\vmuser\\Desktop\\Shell SE - Sai Mahesh\\C#\\New folder\\fileName.txt");
            using StreamWriter str = file.CreateText();
            Console.WriteLine("File creation successful! 👌");

            str.WriteLine("first line super");
            str.WriteLine("second line sus");

            Console.WriteLine("Wrote something in a file");
        }

        public void DeleteFile()
        {
            FileInfo fi = new
               FileInfo("Sample.txt");
            fi.Delete();
        }

        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("Sample.txt");
            // Copy the first file to the second file
            fi1.CopyTo("Temp\\Sample.txt");
            fi1.MoveTo("Temp2\\Sample.txt");
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("Sample.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
