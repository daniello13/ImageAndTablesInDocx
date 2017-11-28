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
    public partial class Creator : Form
    {
        string filename;
        int image;
        int table;
        int page;
        int links;
        string Meta;
        string KeyWords;
        public Creator()
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
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string DocName = saveFile.FileName;
            try
            {
                File.Delete("daoc.docx");
                File.Delete("daoc.zip");
                Directory.Delete("libr", true);
            }
            catch { }
            try
            {
                SelectPic maer = new SelectPic(filename);
                // вытянуть количество рисунков
                maer.Copying();
                maer.InZIP();
                image = maer.UnZIP();

                //вытянуть кол-во таблиц
                SelectTable rt = new SelectTable(filename);
                table = rt.getNumTable();
                //вытянуть кол-во страниц
                page = rt.getNumPage();
                //вытянуть кол-во ccылок
                SelectLinks dert = new SelectLinks(filename);
                links = dert.NumLinks();
                //вытянуть цель работы
                Meta = dert.Meta();
                KeyWords = dert.keyWo();
                dert.Del();
                string pathParent = "parene.docx";
                if (File.Exists(DocName))
                {
                    File.Delete(DocName);
                }
                File.Copy(pathParent, DocName);
                // сохраняем текст в файл
                CreateDocx merr = new CreateDocx(DocName);
                merr.Santa(page, image, table, links, KeyWords, Meta);
            }
            catch(Exception p){
                MessageBox.Show("Убедитесь, что права доступа и файл не используется другими приложениями");
            }
            try
            {
                File.Delete("daoc.docx");
                File.Delete("daoc.zip");
                Directory.Delete("libr", true);
            }
            catch { }
            Application.Exit();

        }
    }
}
