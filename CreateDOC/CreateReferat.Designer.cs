namespace CreateDOC
{
    partial class Creator
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseDoc = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ChooseDoc
            // 
            this.ChooseDoc.Location = new System.Drawing.Point(12, 17);
            this.ChooseDoc.Name = "ChooseDoc";
            this.ChooseDoc.Size = new System.Drawing.Size(105, 29);
            this.ChooseDoc.TabIndex = 0;
            this.ChooseDoc.Text = "Выбрать файл";
            this.ChooseDoc.UseVisualStyleBackColor = true;
            this.ChooseDoc.Click += new System.EventHandler(this.ChooseDoc_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.Location = new System.Drawing.Point(182, 14);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(136, 34);
            this.SaveBut.TabIndex = 1;
            this.SaveBut.Text = "Выбрать место сохранения";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 224);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.ChooseDoc);
            this.Name = "Creator";
            this.Text = "Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseDoc;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

