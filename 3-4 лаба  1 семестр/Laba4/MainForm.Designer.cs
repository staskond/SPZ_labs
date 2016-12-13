namespace Laba4
{
    partial class MainForm
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
            this.labelReadyToWork = new System.Windows.Forms.Label();
            this.labelReadyToWorkResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listDriver = new System.Windows.Forms.ListBox();
            this.listDevice = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btGenericDriver = new System.Windows.Forms.Button();
            this.btRemoveDriver = new System.Windows.Forms.Button();
            this.btCompareDriver = new System.Windows.Forms.Button();
            this.btAddDevice = new System.Windows.Forms.Button();
            this.btRemoveDevice = new System.Windows.Forms.Button();
            this.cbSelectOS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTypeOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReadyToWork
            // 
            this.labelReadyToWork.AutoSize = true;
            this.labelReadyToWork.Location = new System.Drawing.Point(12, 599);
            this.labelReadyToWork.Name = "labelReadyToWork";
            this.labelReadyToWork.Size = new System.Drawing.Size(115, 13);
            this.labelReadyToWork.TabIndex = 0;
            this.labelReadyToWork.Text = "Готовность к работе:";
            // 
            // labelReadyToWorkResult
            // 
            this.labelReadyToWorkResult.AutoSize = true;
            this.labelReadyToWorkResult.Location = new System.Drawing.Point(133, 599);
            this.labelReadyToWorkResult.Name = "labelReadyToWorkResult";
            this.labelReadyToWorkResult.Size = new System.Drawing.Size(52, 13);
            this.labelReadyToWorkResult.TabIndex = 1;
            this.labelReadyToWorkResult.Text = "Не готов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ДРАЙВЕРЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(558, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "УСТРОЙСТВА";
            // 
            // listDriver
            // 
            this.listDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listDriver.FormattingEnabled = true;
            this.listDriver.ItemHeight = 16;
            this.listDriver.Location = new System.Drawing.Point(41, 35);
            this.listDriver.Name = "listDriver";
            this.listDriver.Size = new System.Drawing.Size(333, 372);
            this.listDriver.TabIndex = 4;
            // 
            // listDevice
            // 
            this.listDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listDevice.FormattingEnabled = true;
            this.listDevice.ItemHeight = 16;
            this.listDevice.Location = new System.Drawing.Point(464, 35);
            this.listDevice.Name = "listDevice";
            this.listDevice.Size = new System.Drawing.Size(326, 372);
            this.listDevice.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(383, 148);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(64, 56);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = ">";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(383, 231);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(64, 60);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "<";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btGenericDriver
            // 
            this.btGenericDriver.Location = new System.Drawing.Point(41, 423);
            this.btGenericDriver.Name = "btGenericDriver";
            this.btGenericDriver.Size = new System.Drawing.Size(333, 48);
            this.btGenericDriver.TabIndex = 8;
            this.btGenericDriver.Text = "Генерация драйверов";
            this.btGenericDriver.UseVisualStyleBackColor = true;
            // 
            // btRemoveDriver
            // 
            this.btRemoveDriver.Location = new System.Drawing.Point(41, 477);
            this.btRemoveDriver.Name = "btRemoveDriver";
            this.btRemoveDriver.Size = new System.Drawing.Size(149, 43);
            this.btRemoveDriver.TabIndex = 9;
            this.btRemoveDriver.Text = "Удалить";
            this.btRemoveDriver.UseVisualStyleBackColor = true;
            // 
            // btCompareDriver
            // 
            this.btCompareDriver.Location = new System.Drawing.Point(214, 477);
            this.btCompareDriver.Name = "btCompareDriver";
            this.btCompareDriver.Size = new System.Drawing.Size(160, 43);
            this.btCompareDriver.TabIndex = 10;
            this.btCompareDriver.Text = "Сравнить";
            this.btCompareDriver.UseVisualStyleBackColor = true;
            // 
            // btAddDevice
            // 
            this.btAddDevice.Location = new System.Drawing.Point(464, 423);
            this.btAddDevice.Name = "btAddDevice";
            this.btAddDevice.Size = new System.Drawing.Size(326, 48);
            this.btAddDevice.TabIndex = 11;
            this.btAddDevice.Text = "Добавить";
            this.btAddDevice.UseVisualStyleBackColor = true;
            // 
            // btRemoveDevice
            // 
            this.btRemoveDevice.Location = new System.Drawing.Point(464, 478);
            this.btRemoveDevice.Name = "btRemoveDevice";
            this.btRemoveDevice.Size = new System.Drawing.Size(326, 42);
            this.btRemoveDevice.TabIndex = 12;
            this.btRemoveDevice.Text = "Удалить";
            this.btRemoveDevice.UseVisualStyleBackColor = true;
            // 
            // cbSelectOS
            // 
            this.cbSelectOS.FormattingEnabled = true;
            this.cbSelectOS.Location = new System.Drawing.Point(464, 527);
            this.cbSelectOS.Name = "cbSelectOS";
            this.cbSelectOS.Size = new System.Drawing.Size(167, 21);
            this.cbSelectOS.TabIndex = 13;
            this.cbSelectOS.SelectedIndexChanged += new System.EventHandler(this.cbSelectOS_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Тип ОС";
            // 
            // lbTypeOS
            // 
            this.lbTypeOS.AutoSize = true;
            this.lbTypeOS.Location = new System.Drawing.Point(541, 568);
            this.lbTypeOS.Name = "lbTypeOS";
            this.lbTypeOS.Size = new System.Drawing.Size(0, 13);
            this.lbTypeOS.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 630);
            this.Controls.Add(this.lbTypeOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSelectOS);
            this.Controls.Add(this.btRemoveDevice);
            this.Controls.Add(this.btAddDevice);
            this.Controls.Add(this.btCompareDriver);
            this.Controls.Add(this.btRemoveDriver);
            this.Controls.Add(this.btGenericDriver);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listDevice);
            this.Controls.Add(this.listDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelReadyToWorkResult);
            this.Controls.Add(this.labelReadyToWork);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReadyToWork;
        private System.Windows.Forms.Label labelReadyToWorkResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listDriver;
        private System.Windows.Forms.ListBox listDevice;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btGenericDriver;
        private System.Windows.Forms.Button btRemoveDriver;
        private System.Windows.Forms.Button btCompareDriver;
        private System.Windows.Forms.Button btAddDevice;
        private System.Windows.Forms.Button btRemoveDevice;
        private System.Windows.Forms.ComboBox cbSelectOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTypeOS;
    }
}

