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

    public partial class DeviceForm : Form
    {
        public Device Device { get; set; }

        private BindingSource bs = new BindingSource();
        public DeviceForm()
        {
            InitializeComponent();

            btApply.Click += new EventHandler(Apply);
            btCancel.Click += new EventHandler(Cancel);
            this.Load += new EventHandler(FormLoad);
            this.FormClosing += new FormClosingEventHandler(FormClose);

            cbDeviceName.Items.Add(e_Device.Flash);
            cbDeviceName.Items.Add(e_Device.GPU);
            cbDeviceName.Items.Add(e_Device.HDD);
            cbDeviceName.Items.Add(e_Device.KeyBoard);
            cbDeviceName.Items.Add(e_Device.Monitor);
            cbDeviceName.Items.Add(e_Device.MotherBoard);
            cbDeviceName.Items.Add(e_Device.Mouse);
            cbDeviceName.Items.Add(e_Device.NetworkPlate);
            cbDeviceName.Items.Add(e_Device.Printer);
            cbDeviceName.Items.Add(e_Device.Processor);
            cbDeviceName.Items.Add(e_Device.RAM);
            cbDeviceName.Items.Add(e_Device.SC_DVD);
            cbDeviceName.Items.Add(e_Device.Scaner);

             
       
        }

        private void Apply(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;    // установка результата завершения работы данного диалогового окна
            if (DriverManeger.CurrentDevice != null)
            {
                DriverManeger.CurrentDevice = Device;      // если текущий объект выбран идет режим редактирвания
            }
            else
            {
                DriverManeger.Device.Add(Device);         // в противном случае - новая задача добавляется в список
            }
            this.Close();                           // закрытие диалогового окна
        }

        // обработчик нажатия на кнопку "ОТМЕНА"
        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    // установка результата щавершения работы данного диалогового окна
            this.Close();                               // закрытие окна
        }

        // обработчик события загрузки и отображения даной формы пользователю
        private void FormLoad(object sender, EventArgs e)
        {
            if (DriverManeger.CurrentDevice != null)        // если текущая задача выбрана - окно используется для ей редактирования
            {
                var current = DriverManeger.CurrentDevice;
                Device = new Device(current.DeviceName, current.DeviceType);
                Device.DeviceDriver = current.DeviceDriver;
            }
            else                                        // в противном случае происзодит её создание
            {
                Device = new Device(string.Empty, e_Device.Flash);
            }
            bs.DataSource = Device;                        // привязка задачи к объекту упавления привязкой
            // привязка параметров задачи на элементы пользовательского интерфейса
            tbDeviceName.DataBindings.Add(new Binding("Text", bs, "DeviceName"));
            tbDeviceReady.DataBindings.Add(new Binding("Text", bs, "readyToWork"));
            cbDeviceName.DataBindings.Add(new Binding("SelectedItem", bs, "DeviceType"));
            tbUseDriver.DataBindings.Add(new Binding("Text", bs, "NameUseDriver"));
 
            cbDeviceName.SelectedItem = Device.DeviceType;
        }

        // Событие, возникающее при закрытии данного диалогового окна пользователем
        private void FormClose(object sender, FormClosingEventArgs e)
        {
            // сброс всех привязок у элементов польщзовательского интерфейса
            tbDeviceName.DataBindings.Clear();
            tbDeviceReady.DataBindings.Clear();
            tbUseDriver.DataBindings.Clear();
            cbDeviceName.DataBindings.Clear();

            bs.Clear();
        }

        
    }
}
