using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateDOC
{
    public partial class MainWind : Form
    {
        string filename;
        int image;
        int table;
        public MainWind()
        {
            InitializeComponent();
            openFile.Filter = "DOCX files(*.docx)|*.docx";
            saveFile.Filter = "DOCX files(*.docx)|*.docx";
        }

        private void ChooseDoc_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFile.FileName;
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("daoc.docx");
                File.Delete("daoc.zip");
                Directory.Delete("libr", true);
            }
            catch { }
            SelectPic maer = new SelectPic(filename);
            // вытянуть количество рисунков
            maer.Copying();
            maer.InZIP();
            image = maer.UnZIP();

            //вытянуть кол-во таблиц
            SelectTable rt = new SelectTable(filename);
            table = rt.getNumTable();
        }
    }
}
