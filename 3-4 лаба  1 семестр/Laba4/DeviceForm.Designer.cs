namespace Laba4
{
    partial class DeviceForm
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
            this.lbDeviceName = new System.Windows.Forms.Label();
            this.cbDeviceName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDeviceReady = new System.Windows.Forms.TextBox();
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbUseDriver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDeviceName
            // 
            this.lbDeviceName.AutoSize = true;
            this.lbDeviceName.Location = new System.Drawing.Point(12, 45);
            this.lbDeviceName.Name = "lbDeviceName";
            this.lbDeviceName.Size = new System.Drawing.Size(86, 13);
            this.lbDeviceName.TabIndex = 0;
            this.lbDeviceName.Text = "Тип устройства";
            // 
            // cbDeviceName
            // 
            this.cbDeviceName.FormattingEnabled = true;
            this.cbDeviceName.Location = new System.Drawing.Point(153, 45);
            this.cbDeviceName.Name = "cbDeviceName";
            this.cbDeviceName.Size = new System.Drawing.Size(121, 21);
            this.cbDeviceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя устройства";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Location = new System.Drawing.Point(153, 15);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(100, 20);
            this.tbDeviceName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Используемый драйвер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Готовность ";
            // 
            // tbDeviceReady
            // 
            this.tbDeviceReady.Location = new System.Drawing.Point(153, 143);
            this.tbDeviceReady.Name = "tbDeviceReady";
            this.tbDeviceReady.ReadOnly = true;
            this.tbDeviceReady.Size = new System.Drawing.Size(100, 20);
            this.tbDeviceReady.TabIndex = 7;
            this.tbDeviceReady.Text = "FALSE";
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(18, 267);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(138, 58);
            this.btApply.TabIndex = 8;
            this.btApply.Text = "Готово";
            this.btApply.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(199, 267);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(134, 58);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // tbUseDriver
            // 
            this.tbUseDriver.Location = new System.Drawing.Point(153, 77);
            this.tbUseDriver.Name = "tbUseDriver";
            this.tbUseDriver.ReadOnly = true;
            this.tbUseDriver.Size = new System.Drawing.Size(121, 20);
            this.tbUseDriver.TabIndex = 10;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 543);
            this.Controls.Add(this.tbUseDriver);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.tbDeviceReady);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDeviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDeviceName);
            this.Controls.Add(this.lbDeviceName);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.ComboBox cbDeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDeviceReady;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbUseDriver;
    }
}