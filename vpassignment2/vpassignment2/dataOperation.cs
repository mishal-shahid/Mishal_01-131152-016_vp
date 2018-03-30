using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace vpassignment2
{
    class dataOperation
    {
        private static dataOperation data;
        public static dataOperation dataProperty
        {
            get
            {
                if (data == null)
                    data = new dataOperation();
                return data;
            }

        }
        public string[] read()
        {

            var lines = File.ReadAllLines("fileee.txt");
            string[] result = new string[lines.Length];
            for(int i=0;i<lines.Length;i++)
            {
            if(!string.IsNullOrEmpty(lines[i]))
            result = lines;
            }

            return result;
        }
        public void Append(string result)
        {

            System.IO.StreamWriter fileW;
            using (fileW = File.AppendText("fileee.txt"))
            {
               
                    fileW.WriteLine(result);
                
            }
            fileW.Dispose();


        }
        public void write(string []result)
        {

            System.IO.StreamWriter fileW;
            using (fileW = new StreamWriter("fileee.txt"))
            {
                for(int i=0;i<result.Length;i++)
                    fileW.WriteLine(result[i]);
                
            }
            fileW.Dispose();


        }
        public void write(string result)
        {

            System.IO.StreamWriter fileW;
            using (fileW = new StreamWriter("fileee.txt"))
  
                    fileW.WriteLine(result);

            fileW.Dispose();


        }

    }
}
