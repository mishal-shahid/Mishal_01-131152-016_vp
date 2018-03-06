using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Assignment_1
{
    class profile
    {
        private
        string name;
        int id;
        string semester;
        string dept;
        string uni;
        float cgpa;
        string present;
        public
            profile()
        {
            name = null;
            id = 0;
            semester = null;
            dept = null;
            uni = null;
            cgpa = 0;
            present = null;
        }
        //creates profile by getting info and store in file
        public void create_Profile(string name, string id, string semester, string dept, string university, float cgpa,string present, string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = File.ReadAllText(path);
            sr.Close();
            StreamWriter obj = File.AppendText(path);
            obj.AutoFlush = true;

                if (line.Contains(id))//check for unique id
                {
                    Console.WriteLine("already exsist");

                }
                else
                {
                    obj.WriteLine(name + " " + id + " " + semester + " " + dept + " " + university + " " + cgpa +" "+present);
                    Console.WriteLine("record added");
                }

            
            obj.Close();
        }
        //search for record by name or id in file
        public void search(string name, string fpath)
        {
            StreamReader obj = new StreamReader(fpath);
            string[] line = File.ReadAllLines(fpath);//storing all lines in an array
            int count = 0;
            foreach (string a in line)
            {
                if (a.Contains(name))
                {
                    string [] words =a.Split(' ');//spliting each into words
                    for(int i=0;i<words.Length-1;i++)
                    Console.Write(words[i]+" ");
                    Console.Write("\n");
                    count++;
                    
                }

            }
            obj.Close();
            if (count == 0)
                Console.WriteLine(" no record found");
            else
            Console.WriteLine("number of students found are "+count);

        }
        //search record of student by their semester
        public void search(string dep, string sem, string fpath)
        {
            // StreamWriter obj1 = new StreamWriter(fpath);
            //obj1.rea
            StreamReader obj = new StreamReader(fpath);
            string[] line = File.ReadAllLines(fpath);//storing all lines in an array
            int count = 0;
            foreach (string a in line)
            {
                if (a.Contains(dep)&&a.Contains(sem))
                {
                    string[] words = a.Split(' ');//spliting line into words
                    for (int i = 0; i < words.Length - 1; i++)
                        Console.Write(words[i] + " ");
                    Console.Write("\n");
                    count++;

                }

            }
            obj.Close();
            if (count == 0)
                Console.WriteLine(" no record found");
            else
                Console.WriteLine("number of students found are " + count);

        }
        //delete record of entered id student
        public void delete_Record(string id, string path)
        {
            StreamReader obj = new StreamReader(path);
            string[] line = File.ReadAllLines(path);
            obj.Close();
            StreamWriter obj1 = new StreamWriter(path);
            obj1.AutoFlush = true;
            int count = 0;
            foreach (string a in line)
            {

                if (!a.Contains(id))
                {
                    obj1.WriteLine(a);
                    count++;

                }
            }
            obj1.Close();
            if(count==0)
                Console.WriteLine("record deleted");
            else
                Console.WriteLine("no record found");
        }
        //calculate top 3 cgpas from file and display their corresponding students
        public void find_Top3(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] line = File.ReadAllLines(path);
            sr.Close();
            string len = null;
            string[] arr = new string[20];

            foreach (string a in line)
            {
                string[] words = a.Split(' ');
                len = len + " " + words[words.Length - 2];//storing 2nd last index of each line
                arr = len.Split(' ');
                Array.Sort(arr);
            }
            Console.WriteLine("3 highest cgpa are");

            for (int i = arr.Length-1; i>=arr.Length-3; i--)
            {
                foreach (string k in line)
                {
                  if (k.Contains(arr[i]))
                  {
                      string[] arra = k.Split(' ');
                      for (int j = 0; j < arra.Length - 1; j++)
                      {
                          Console.Write(arra[j] + " ");
                      }
                      Console.Write("\n");
                  }
                  
                }
            }
         
        }
        //mark attendance of student of some dept and semester
        public void mark_Attendance(string dept, string sem, string path)
        { 
            StreamReader sr= new StreamReader(path);
            string [] line= File.ReadAllLines(path);
            sr.Close();
            StreamWriter sw = new StreamWriter(path);
            sw.AutoFlush = true;
            string choice = null; string x = null;
            int count = 0;
            foreach(string k in line)
            {
                if (k.Contains(dept) && k.Contains(sem))
                {
                    count++;
                    Console.WriteLine(k);
                    choice = Console.ReadLine();
                    if (k.Contains("absent"))
                    {
                        if (choice == "p")
                        {
                            x = k.Replace("absent", "present");//replacing a word in line
                            sw.WriteLine(x);
                        }
                        else if (choice == "a")
                        {
                            sw.WriteLine(k);
                        }
                        else
                            Console.WriteLine("invalid input");
                    }
                    if (k.Contains("present"))
                    {
                        if (choice == "a")
                        {
                            x = k.Replace("present", "absent");//replacing word in line
                            sw.WriteLine(x);
                        }
                        else if (choice == "p")
                        {
                            sw.WriteLine(k);
                        }
                        else
                            Console.WriteLine("invalid input");
                    }
                }
                else
                    sw.WriteLine(k);
            }
            sw.Close();
            if(count==0)
                Console.WriteLine(" no record found");

        }
        //view attendance record of students
        public void view_Attendance(string dept, string sem, string path)
        {
            StreamReader sw = new StreamReader(path);
            string[] line = File.ReadAllLines(path);
            sw.Close();
            int count = 0;
            Console.WriteLine("name id sem dept uni cgpa attendance");
            foreach (string m in line)
            {
                if (m.Contains(dept) && m.Contains(sem))
                {
                    count++;
                    Console.WriteLine(m);
                }
            }
            if(count==0)
                Console.WriteLine("no record found");
        }
    }
}
