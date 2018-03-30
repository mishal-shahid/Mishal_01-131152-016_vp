using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace vpassignment2
{
    class profile
    {
        public void createprofile(string name, string id, string semester, string dept, string university, float cgpa, string present)
        {
            string[]line=dataOperation.dataProperty.read();
            bool check=true;
            foreach(string a in line)
            {
            if (a.Contains(id))
            {
                MessageBox.Show("already exsist");
                check=false;
            }
            }
            if(check==true)
            {
                string result=(name + " " + id + " " + semester + " " + dept + " " + university + " " + cgpa + " " + present);
                dataOperation.dataProperty.Append(result);
                MessageBox.Show("record added");
            }
        }
        public string search(string name)
        {
            string[] line = dataOperation.dataProperty.read();
            int count = 0;
            string lines=null;
            foreach (string a in line)
            {
                if (a.Contains(name))
                {
                    string []words = a.Split(' ');
                    for(int i=0;i<words.Length-1;i++)
                    lines += (words[i]+" ");
                    count++;
                  
                }

            }

     
            if (count == 0)
                MessageBox.Show(" no record found");
            return lines;
        }
        public string search(string dep, string sem)
        {

            string[] line = dataOperation.dataProperty.read();
            int count = 0;
            string lines = null;
            foreach (string a in line)
            {
                if (a.Contains(dep) && a.Contains(sem))
                {
                    string[] words = a.Split(' ');
                    for (int i = 0; i < words.Length - 1; i++)
                        lines+=(words[i] + " ");
                    count++;

                }

            }
 
            if (count == 0)
                MessageBox.Show(" no record found");
            else
                MessageBox.Show("number of students found are " + count);
            return lines;

        }
        public void delete(string id)
        {

            string[] line = dataOperation.dataProperty.read();
            string[] newline = new string[line.Length];

            int count = 0;
            for(int i=0;i<line.Length;i++)
            {

                if (!line[i].Contains(id))
                {
                    newline[count] = line[i];
                    count++;

                }
            }
            dataOperation.dataProperty.write(newline);
            if (count == 0)
                MessageBox.Show("no record found");
            else
                MessageBox.Show("record deleted");
        }
        public string max()
        {
            string[] lines = dataOperation.dataProperty.read() ;
            string [] liness=new string[lines.Length];
            int d=0;
            for(int i=0;i<lines.Length;i++)
            {
                if (lines[i]!=null&&lines[i]!="")
                {
                    liness[d] = lines[i];
                    d++;
                }
              

            }
            string[] line = new string[d];
            if (d != 0)
            {
               
                for (int r = 0; r < d; r++)
                    line[r] = liness[r];
            }
           
            string len = null;
            string[] arr = new string[20];
            string result=null;
            foreach (string a in line)
            {
                string[] words = a.Split(' ');
                len = len + " " + words[words.Length - 2];
                arr = len.Split(' ');
                Array.Sort(arr);
            }

            for (int i = arr.Length - 1; i >= arr.Length - 3; i--)
            {
                foreach (string k in line)
                {
                    if (k.Contains(arr[i]))
                    {
                        string[] arra = k.Split(' ');
                        for (int j = 0; j < arra.Length - 1; j++)
                        {
                            result+=(arra[j] + " ");
                        }
                    }

                }
            }
            return result;
        }
        public void attendance(string dept, string sem)
        {
            string[] line = dataOperation.dataProperty.read();
            string choice = null; string x = null; string arr = null;
            int count = 0;
            for(int i=0;i<line.Length;i++)
            {
                if (line[i].Contains(dept) && line[i].Contains(sem))
                {
                    count++;
                    DialogResult result = MessageBox.Show(line[i], "Mark present", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    choice = Console.ReadLine();
                    if (line[i].Contains("absent"))
                    {
                        if (result == DialogResult.Yes)
                        {
                            x =x+ line[i].Replace("absent", "present")+"/";
                        }
                        else if (result == DialogResult.No)
                        {
                            x=x+(line[i])+"/";
                        }
                        else
                            MessageBox.Show("invalid input");
                    }
                    if (line[i].Contains("present"))
                    {
                        if (result == DialogResult.No)
                        {
                            x = x+line[i].Replace("present", "absent")+"/";

                        }
                        else if (result == DialogResult.Yes)
                        {
                            x=x+(line[i])+"/";
                        }
                        else
                            MessageBox.Show("invalid input");
                    }
                }
                else
                {
                    arr =arr+ line[i]+"/";
                }
            }
            string[] output = x.Split('/');
            dataOperation.dataProperty.write(output);
            string []output1 = arr.Split('/');
            for (int i = 0; i < output1.Length; i++)
                dataOperation.dataProperty.Append(output1[i]);
            if (count == 0)
                MessageBox.Show(" no record found");

        }
        public string viewAttendance(string dept, string sem)
        {
            string[] line = dataOperation.dataProperty.read();
            int count = 0;
            string result=null;
            foreach (string m in line)
            {
                if (m.Contains(dept) && m.Contains(sem))
                {
                    count++;
                    result =result+m+" ";
                }
            }
            if (count == 0)
                Console.WriteLine("no record found");
            return result;

        }
    }
}
