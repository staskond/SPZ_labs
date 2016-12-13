using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class DriverForm : Form
    {
        private BindingSource bs = new BindingSource();
        Driver Driver { get; set; }
        public DriverForm()
        {
            InitializeComponent();
           this.Load += new EventHandler(FormLoad);
          //  this.FormClosing += new FormClosingEventHandler(FormClose);


            cbDriverOS.Items.Add(e_OC.Linux);
            cbDriverOS.Items.Add(e_OC.Mac);
            cbDriverOS.Items.Add(e_OC.SteamOS);
            cbDriverOS.Items.Add(e_OC.Windows10);
            cbDriverOS.Items.Add(e_OC.Windows7_8);
            cbDriverOS.Items.Add(e_OC.WindowsXP);

            cbDriverDevice.Items.Add(e_Device.Flash);
            cbDriverDevice.Items.Add(e_Device.GPU);
            cbDriverDevice.Items.Add(e_Device.HDD);
            cbDriverDevice.Items.Add(e_Device.KeyBoard);
            cbDriverDevice.Items.Add(e_Device.Monitor);
            cbDriverDevice.Items.Add(e_Device.MotherBoard);
            cbDriverDevice.Items.Add(e_Device.Mouse);
            cbDriverDevice.Items.Add(e_Device.NetworkPlate);
            cbDriverDevice.Items.Add(e_Device.Printer);
            cbDriverDevice.Items.Add(e_Device.Processor);
            cbDriverDevice.Items.Add(e_Device.RAM);
            cbDriverDevice.Items.Add(e_Device.SC_DVD);
            cbDriverDevice.Items.Add(e_Device.Scaner);
            

            btApply.Click += new EventHandler(Apply);
            btCancel.Click += new EventHandler(Cancel);
        }


       

        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    // установка результата щавершения работы данного диалогового окна
            this.Close();                               // закрытие окна
        }
       private void FormLoad(object sender, EventArgs e)
        {
            if ((object)DriverManeger.CurrentDriver != null)        // если текущая задача выбрана - окно используется для ей редактирования
            {
                var current = DriverManeger.CurrentDriver;
                Driver = new Driver(current.NameDriver, current.VersionDriver, current.DeviceType, current.OSDriver);

              
            }
            else                                        // в противном случае происзодит её создание
            {
                Driver = new Driver(string.Empty, string.Empty, e_Device.Flash, e_OC.Windows10);
            }
            bs.DataSource = Driver;                        // привязка задачи к объекту упавления привязкой
            // привязка параметров задачи на элементы пользовательского интерфейса
            tbDriverName.DataBindings.Add(new Binding("Text", bs, "NameDriver"));
            tbVersionDriver.DataBindings.Add(new Binding("Text", bs, "VersionDriver"));
            cbDriverOS.DataBindings.Add(new Binding("SelectedItem", bs, "OSDriver"));
            cbDriverDevice.DataBindings.Add(new Binding("SelectedItem", bs, "DeviceType"));
        }
       private void Apply(object sender, EventArgs e)
       {
           this.DialogResult = DialogResult.OK;    // установка результата завершения работы данного диалогового окна
           if ((object)DriverManeger.CurrentDriver != null)
           {
               DriverManeger.CurrentDriver = Driver;      // если текущий объект выбран идет режим редактирвания
           }
           else
           {
               DriverManeger.Driver.Add(e_Device.GPU, Driver);// в противном случае - новая задача добавляется в список
           }
           this.Close();                           // закрытие диалогового окна
       }

        // Событие, возникающее при закрытии данного диалогового окна пользователем
       private void FormClose(object sender, FormClosingEventArgs e)
        {
            // сброс всех привязок у элементов польщзовательского интерфейса
            tbDriverName.DataBindings.Clear();
            tbVersionDriver.DataBindings.Clear();
            cbDriverOS.DataBindings.Clear();
            cbDriverDevice.DataBindings.Clear();

            bs.Clear();
        }
    }
}
