using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace CreateDOC
{
    class SelectPic
    {
        public string wave;
        public int PIC_count;
        public SelectPic(string wave1){
            wave = wave1;
        }
        public bool Copying()
        {
            try
            {
            
            string MotherLand = "daoc.docx";
            
                File.Copy(wave, MotherLand);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void InZIP(){
            File.Move("daoc.docx", "daoc.zip");
        }
        public int UnZIP()
        {
            
            try
            {
                ZipFile.ExtractToDirectory("daoc.zip", "libr");
                PIC_count = new DirectoryInfo(@"libr\word\media").GetFiles().Length; ///vk.com/lerka_gorbatko
                File.Move("daoc.zip", "daoc.docx");
                return PIC_count;
            }
            catch
            {
                return 0;
            }
        }
    }
}
