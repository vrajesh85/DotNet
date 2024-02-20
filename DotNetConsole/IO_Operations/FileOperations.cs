using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotNetConsole.IO_Operations
{
    internal class FileOperations
    {
        public byte[] ReadDataIntoByteArray()
        {
           // using (var fs = new FileStream(filePath, FileMode.Open))
            {
                return File.ReadAllBytes(@"C:\Users\rvemula1\Downloads\OptumScriptSwitch_7.0.0.8300.exe");
            }
        }

        public void ReadFromStream()
        {
            using var stream = new FileStream(@"C:\Temp\FileWrite.txt", FileMode.Create);
             
            byte[] byteArray = { 0, 1, 2, 3, 4, 7 };
            stream.Write(byteArray, 0, byteArray.Length);

            stream.ReadTimeout = 2;

            stream.Position = 0;

            int bytesRead = 0;
            int chunkSize = 1;
            while(bytesRead < chunkSize && chunkSize > 0)
            {
                // Read() always returns the number of bytes received
               
                bytesRead += chunkSize = stream.Read(byteArray, bytesRead, byteArray.Length - bytesRead);
                stream.Seek(1, SeekOrigin.Begin);
                Console.WriteLine($"position is {stream.Position}");
            }

        }

        //public void ReadFromFileStream()
        //{
        //    string path = @"C:\Temp\FileStream.txt";
        //   // using var fileStream = File.OpenWrite();
        //    string str = "This is another string ";
        //    var byteArray = Encoding.UTF8.GetBytes(str);

        //    fileStream.Write(byteArray, 0, byteArray.Length);

        //    var directory = AppDomain.CurrentDomain.BaseDirectory;

        //   // using var fileStream2 = new FileStream(str)
           
        //}
    }
}
