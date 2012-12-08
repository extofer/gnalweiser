using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;

namespace gnalweiser.lib
{
    public static class TxtLogger
    {
        private const string Logfile = "LogFile.txt";

        public static void LogTxt(string text)
        {

            using (FileStream aFile = new FileStream(Logfile, FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(aFile);
                sw.WriteLine(text);
                sw.Close();
                aFile.Close();

            }

        }


        public static bool IsAvailable(int i)
        {
            //TextReader tr = new StreamReader(Logfile);
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(Logfile);
            string[] newtext;


            while ((line = file.ReadLine()) != null)
            {
                newtext = line.Split('|');

                line = newtext[0];
                Console.WriteLine(line);
                counter++;
            }

            file.Close();

            return true;
        }


        //    //
        
        //public void LogTxt(TextWriter tw, string text)
        //{
        //    
        //    //tw.Close();
        //}

        //private bool IsLogFile()
        //{
        //    return false;
        //}

        //public void ReadLine()
        //{
        //    // create reader & open file
        //    TextReader tr = new StreamReader("date.txt");

        //    // read a line of text
        //    Console.WriteLine(tr.ReadLine());

        //    // close the stream
        //    tr.Close();
        //}



    }
}
