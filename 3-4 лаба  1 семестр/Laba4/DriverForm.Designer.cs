namespace Laba4
{
    partial class DriverForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDriverName = new System.Windows.Forms.TextBox();
            this.tbVersionDriver = new System.Windows.Forms.TextBox();
            this.cbDriverOS = new System.Windows.Forms.ComboBox();
            this.cbDriverDevice = new System.Windows.Forms.ComboBox();
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название драйвера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Версия драйвера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поддержка ОС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип устройства";
            // 
            // tbDriverName
            // 
            this.tbDriverName.Location = new System.Drawing.Point(146, 13);
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Size = new System.Drawing.Size(100, 20);
            this.tbDriverName.TabIndex = 4;
            // 
            // tbVersionDriver
            // 
            this.tbVersionDriver.Location = new System.Drawing.Point(146, 40);
            this.tbVersionDriver.Name = "tbVersionDriver";
            this.tbVersionDriver.Size = new System.Drawing.Size(100, 20);
            this.tbVersionDriver.TabIndex = 5;
            // 
            // cbDriverOS
            // 
            this.cbDriverOS.FormattingEnabled = true;
            this.cbDriverOS.Location = new System.Drawing.Point(146, 67);
            this.cbDriverOS.Name = "cbDriverOS";
            this.cbDriverOS.Size = new System.Drawing.Size(121, 21);
            this.cbDriverOS.TabIndex = 6;
            // 
            // cbDriverDevice
            // 
            this.cbDriverDevice.FormattingEnabled = true;
            this.cbDriverDevice.Location = new System.Drawing.Point(146, 95);
            this.cbDriverDevice.Name = "cbDriverDevice";
            this.cbDriverDevice.Size = new System.Drawing.Size(121, 21);
            this.cbDriverDevice.TabIndex = 7;
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(36, 309);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 8;
            this.btApply.Text = "Готово";
            this.btApply.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(204, 309);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 396);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.cbDriverDevice);
            this.Controls.Add(this.cbDriverOS);
            this.Controls.Add(this.tbVersionDriver);
            this.Controls.Add(this.tbDriverName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDriverName;
        private System.Windows.Forms.TextBox tbVersionDriver;
        private System.Windows.Forms.ComboBox cbDriverOS;
        private System.Windows.Forms.ComboBox cbDriverDevice;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
    }
}