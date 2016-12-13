namespace LAB4_SPZ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.mGenerateDriversButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(30, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(218, 311);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(350, 25);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(218, 311);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // mGenerateDriversButton
            // 
            this.mGenerateDriversButton.Location = new System.Drawing.Point(30, 351);
            this.mGenerateDriversButton.Name = "mGenerateDriversButton";
            this.mGenerateDriversButton.Size = new System.Drawing.Size(218, 23);
            this.mGenerateDriversButton.TabIndex = 2;
            this.mGenerateDriversButton.Text = "ГЕНЕРАЦИЯ ДРАЙВЕРОВ";
            this.mGenerateDriversButton.UseVisualStyleBackColor = true;
            this.mGenerateDriversButton.Click += new System.EventHandler(this.mGenerateDriversButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 428);
            this.Controls.Add(this.mGenerateDriversButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button mGenerateDriversButton;
    }
}

