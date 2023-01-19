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
            string startPath = @"C:\tests\6231";

            var dirs = Directory.GetDirectories(startPath);
            foreach(string dir in dirs)
            {
                string folder = dir.Substring(0, dir.LastIndexOf(("\\")));

                var fileName = dir.Substring(dir.LastIndexOf(("\\")) + 1);

                var names = fileName.Split(" ");
                var lastname = names[0];
                var lastnames = names[1].Split("_");
                var firstname = lastnames[0];
                var filenameOut = lastname + firstname;
                var files = Directory.GetFiles(dir);

                foreach (string f in files)
                {
                    var ext = Path.GetExtension(f);
                    if (ext.Contains(".zip"))
                    {
                        ZipFile.ExtractToDirectory(f, startPath + "\\" + filenameOut);
                        //Directory.Delete(dir, true);
                    }

                    else
                        Console.WriteLine(firstname + " " + lastname);
                }
                
                


            }


            
        }
    }
}
