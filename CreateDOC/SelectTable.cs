using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;


namespace CreateDOC
{
    class SelectTable
    {
        string wave;
        public int TableCount;
        public int PageCount;
        public SelectTable(string wave)
        {
            this.wave = wave;
        }
        public int getNumTable(){
            Word.Application word = new Word.Application(); //создаем COM-объект Word
            word.Visible = false;
            Word.Document doc = word.Documents.Open(wave);
            TableCount=doc.Tables.Count;
            doc.Close();
            word.Quit();
            return TableCount;
        }
        public int getNumPage()
        {
            
            Word.Application word = new Word.Application(); //создаем COM-объект Word
            word.Visible = false;
            Word.Document doc = word.Documents.Open(wave);
            Word.WdStatistic pages = Word.WdStatistic.wdStatisticPages;
            object Format = Word.WdSaveFormat.wdFormatUnicodeText;
            PageCount = doc.ComputeStatistics(pages);
            wave += ".txt";
            doc.SaveAs(wave, Format);
            doc.Close();
            ((Word.Application)word).Quit();
            return PageCount;
        }
    }
}
