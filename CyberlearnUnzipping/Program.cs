using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace CyberlearnUnzipping
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"C:\Users\antoine.widmer\Downloads\Module 634-1-ExamenModuleJanvier2023-1952378";
            string toPath = @"C:\git\unzipped2";

            var dirs = Directory.GetDirectories(startPath);
            foreach(string dir in dirs)
            {
                string folder = dir.Substring(0, dir.LastIndexOf(("\\")));

                var fileName = dir.Substring(dir.LastIndexOf(("\\")) + 1);
                
                var names = fileName.Split(" ");
                var namesCount = names.Length;
                //var firstname = names[namesCount-1];
                var firstnames = names[namesCount - 1].Split("_");
                var lastname = "";
                for (int i = 0; i< namesCount - 1; i++){
                    lastname = lastname + " " + names[i];
                }
                var filenameOut = lastname + "_" +firstnames[0];
                var files = Directory.GetFiles(dir);

                foreach (string f in files)
                {
                    var ext = Path.GetExtension(f);
                    if (ext.Contains(".zip"))
                    {
                        ZipFile.ExtractToDirectory(f, toPath + "\\" + filenameOut);
                        //Directory.Delete(dir, true);
                    }

                    else
                        Console.WriteLine(firstnames[0] + " " + lastname);
                }
                
                


            }


            
        }
    }
}
