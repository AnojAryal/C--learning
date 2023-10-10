using System;
using System.IO;


namespace FileIO
{
    internal class FileIO1
    {
        public void WriteContents()
        {
            try
            {
                FileInfo file = new FileInfo(@"data1.txt");
                FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Line-1");
                sw.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        public void  AppendContents()
        {
            try
            {
                StreamWriter sw = File.AppendText(@"data1.txt");
                sw.WriteLine("Line-2");
                sw.Close();

            }
            catch (Exception) { }
        }
        public void ReadContents()
        {
            try
            {
                FileInfo file = new FileInfo(@"data1.txt");
                FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                StreamReader sr = new StreamReader(fs);
                String contents = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(contents);
            }
            catch (Exception ex) {
                
                Console.WriteLine(ex.Message); 
            }
        }

    }
}
