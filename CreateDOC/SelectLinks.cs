using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDOC
{
    class SelectLinks
    {
        public string wave;
        public int LINK_count;
        public SelectLinks(string wave1){
            wave = wave1;
            wave += ".txt";
        }
        public int NumLinks()
        {
            string line;
            string s = "Перечень";
            string s1 = "ПЕРЕЧЕНЬ";
            int o = 1;
            string s2, s3;

            System.IO.StreamReader file = new System.IO.StreamReader(wave, System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                if ((line.Contains(s) || line.Contains(s1))&&Prav(line))
                {
                    while((s2=file.ReadLine()) != null){
                        s3 =Convert.ToString(o)+".";
                        //if(s2.IndexOf())
                        if (s2.IndexOf(s3) == 0)
                        {
                            o++;
                            continue;
                        }
                        else
                        {

                            file.Close();
                            return o-1;
                        }
                    }
                    
                    file.Close();
                    return 0;
                }
            }
            
            file.Close();
            return 0;
        }
        bool Prav(string h)
        {
            string ex;
            for (int i = 0; i < 10; i++)
            {
                ex = Convert.ToString(i);
                if (h.Contains(ex))
                    return false;
            }
            return true;
            
        }
        public string Meta()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(wave, System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Цель работы"))
                {
                    file.Close();
                    return line;
                }
                
            }
            file.Close();
            return "Цель работы - ";
        }
        public string keyWo()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(wave, System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Ключевые слова"))
                {
                    file.Close();
                    return line;
                }

            }
            file.Close();
            return "";
        }
         public void Del()
        {
            File.Delete(wave);
        }
    }
}
