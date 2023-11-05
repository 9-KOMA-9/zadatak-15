namespace zadatak_14
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.internetexplorer = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.Button();
            this.startInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // internetexplorer
            // 
            this.internetexplorer.Location = new System.Drawing.Point(90, 61);
            this.internetexplorer.Name = "internetexplorer";
            this.internetexplorer.Size = new System.Drawing.Size(223, 73);
            this.internetexplorer.TabIndex = 0;
            this.internetexplorer.Text = "Pokreni Internet explorer";
            this.internetexplorer.UseVisualStyleBackColor = true;
            this.internetexplorer.Click += new System.EventHandler(this.internetexplorer_Click);
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(338, 61);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(223, 73);
            this.excel.TabIndex = 3;
            this.excel.Text = "Pokreni Excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(90, 163);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(223, 73);
            this.Word.TabIndex = 4;
            this.Word.Text = "Pokreni Word";
            this.Word.UseVisualStyleBackColor = true;
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // startInfo
            // 
            this.startInfo.Location = new System.Drawing.Point(338, 163);
            this.startInfo.Name = "startInfo";
            this.startInfo.Size = new System.Drawing.Size(223, 73);
            this.startInfo.TabIndex = 5;
            this.startInfo.Text = "Start Info";
            this.startInfo.UseVisualStyleBackColor = true;
            this.startInfo.Click += new System.EventHandler(this.startInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startInfo);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.internetexplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button internetexplorer;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button Word;
        private System.Windows.Forms.Button startInfo;
    }
}

