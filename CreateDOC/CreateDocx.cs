using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace CreateDOC
{
    class CreateDocx
    {
        string docname;
        public CreateDocx(string wave)
        {
            docname = wave;
        }
        private void Replace(Word.Find find, string was, string will)
        {
            find.ClearFormatting();
            find.Replacement.ClearFormatting();
            find.Text = was;
            find.Replacement.Text = will;
            object missing = Type.Missing;
            object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }
         /// /// <summary>
        /// И, наконец, замена
        /// </summary>
        /// <param name="n1">КОличество страниц</param>
        /// <param name="n2">КОличество рисунков</param>
        /// <param name="n3">КОличество таблиц</param>
        /// <param name="n4">КОличество ссылок</param>
        /// <param name="keyWord">Ключевые слова</param>
        /// <param name="Meeta">Цель рабты</param>
       
        public void Santa(int n1, int n2, int n3, int n4, string keyWord, string Meeta){
            string image = Convert.ToString(n2);
            string page = Convert.ToString(n1);
            string table = Convert.ToString(n3);
            string link = Convert.ToString(n4);
            
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;
            app.Documents.Open(docname);
            Microsoft.Office.Interop.Word.Find find = app.Selection.Find;

            Replace(find, "num_page", page);
            Replace(find, "num_pic", image);
            Replace(find, "num_tables", table);
            Replace(find, "num_links", link);
            Replace(find, "num_links", link);
            Replace(find, "CelWork", Meeta);
            Replace(find, "KeyWords", keyWord);

            object saveOptionsObject = Word.WdSaveOptions.wdSaveChanges;
            app.Quit(saveOptionsObject, Type.Missing, Type.Missing);
        }
    }
}
