using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class Transitioner
    {
        private String directory;
        private String date;
        private String name;

        public String getDirectory(){ return directory; }
        public void setDirectory(String s){directory = s;}
        public String getDate() { return date; }
        public void setDate(String s) { date = s; }
        public String getName() { return name; }
        public void setName(String s) { name = s; }

        public String transition()
        {
            int photoCount = 0;

            //Locate the Directory
            try
            {
                DirectoryInfo d = new DirectoryInfo(@directory);
                FileInfo[] infos = d.GetFiles();
                photoCount = infos.Length;

                //For each photo, change the name
                for (int i = 0; i < photoCount; i++)
                {
                    String index1 = i.ToString();
                    if (i < 10) index1 = "0" + index1;
                    String ext = infos[i].FullName.Substring(infos[i].FullName.IndexOf('.')); //Get Extension of the file
                    System.IO.File.Move(infos[i].FullName, directory + "\\" + date + " " + name + " " + index1 + ext);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excpetion is " + e);
                return "" + e;
            }
            

            //Return number of photos
            return "" + photoCount;
        }
    }
}
