using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Collections;

namespace checkFile_sendEmail
{
    class Program
    {
        public static string[] extesnsions = new string[] { ".ltg", ".txt" };

        static void Main(string[] args)
        {
           checkFileAccum(ConfigurationManager.AppSettings["filelocation"]);
        }

        public static void checkFileAccum(string Location)
        {
            List<String> files = DirSearch(Location);
            foreach (string f in files)
            {
                if (IsBelowThreshold(f, int.Parse(ConfigurationManager.AppSettings["hours"])))
                {
                    File.Delete(f);
                }
            }
        }
        public static List<String> DirSearch(string sDir)
        {
            List<String> files = new List<String>();
            var ext = new List<string> { "ltg", "txt"};
            try
            {
                var myFiles = Directory.GetFiles(sDir, "*.*", SearchOption.AllDirectories);
                myFiles.Where(s => ext.Contains(Path.GetExtension(s)));
                foreach (string f in myFiles)
                {
                    files.Add(f);
                }
            }
            catch (System.Exception)
            {
            }
            return files;
        }
        public static bool IsBelowThreshold(string filename, int hours)
        {
            var threshold = DateTime.Now.AddHours(-hours);
            return System.IO.File.GetCreationTime(filename) <= threshold;
        }
    }
}
