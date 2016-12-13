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
    public partial class MainForm : Form
    {



        private BindingSource bsDriver = new BindingSource();    // объект упралвения привязкой списка сотрудников
        private BindingSource bsDevice = new BindingSource();    // объект управления привязкой списка задач

            // диалоговое окно для добавления и редактирования сотрудников
              // диалоговое окно для добавления и редактирования задач
        List<Driver> aaa = new List<Driver>();
        int count = 1;
        public List<e_OC> ocfromrandom = new List<e_OC>()
        {
            e_OC.Linux,
            e_OC.Mac,
            e_OC.SteamOS,
            e_OC.Windows10,
            e_OC.Windows7_8,
            e_OC.WindowsXP
        };
        public List<e_Device> deviceforrandom = new List<e_Device>()
        {
            e_Device.Flash,
            e_Device.GPU,
            e_Device.HDD,
            e_Device.KeyBoard,
            e_Device.Monitor,
            e_Device.MotherBoard,
            e_Device.Mouse,
            e_Device.NetworkPlate,
            e_Device.Printer,
            e_Device.Processor,
            e_Device.RAM,
            e_Device.SC_DVD,
            e_Device.Scaner
        
        }; 
        public MainForm()
        {

            
            InitializeComponent();




            bsDevice.DataSource = DriverManeger.Device;
            listDevice.DataSource = bsDevice;

            bsDriver.DataSource = aaa;
            listDriver.DataSource = bsDriver;



            btAddDevice.Click += (object s, EventArgs e) =>
                {
                    DriverManeger.CurrentDevice = null;
                    DeviceForm deviceDialog = new DeviceForm();
                    deviceDialog.Owner = this;
                    if (deviceDialog.ShowDialog() == DialogResult.OK)
                    {
                        bsDevice.ResetBindings(true);
                    }
                };
            btRemoveDevice.Click += (object s, EventArgs e) =>
                {
                    if (bsDevice.Count > 0)
                    {

                        bsDevice.RemoveCurrent();

                    }

                    else
                    {
                        MessageBox.Show("Список задач пуст, удалять нечего", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };

            listDevice.MouseDoubleClick += new MouseEventHandler(DeviceMouseDobleClick);
            listDriver.MouseDoubleClick += new MouseEventHandler(DriverMouseDobleClick);

            btRemoveDriver.Click += (object s, EventArgs e) =>
                {
                    if (bsDriver.Count > 0)
                    {

                        bsDriver.RemoveCurrent();

                    }

                    else
                    {
                        MessageBox.Show("Список задач пуст, удалять нечего", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };

            btRemove.Click += (object s, EventArgs e) =>
                {
                    if (bsDevice.Count > 0 && (Object)((Device)bsDevice.Current).DeviceDriver != null)
                    {
                        ((Device)bsDevice.Current).DeviceDriver = null;
                        bsDevice.ResetBindings(false);
                    }
                };

            btAdd.Click += (object s, EventArgs e) =>
                {
                    if (bsDriver.Count > 0 && bsDevice.Count > 0 && ((Object)((Device)bsDevice.Current).DeviceDriver) == null && ((Driver)bsDriver.Current).Compeare((Device)bsDevice.Current))    // если списки сотрудников и задач не пусты - обавление связе между ними возможно
                    {
                        ((Device)bsDevice.Current).DeviceDriver = (Driver)bsDriver.Current;
                        bsDevice.ResetBindings(false);


                    }
                    else
                    {
                        MessageBox.Show("Невозможно установить драйвер ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                };

            btGenericDriver.Click += (object s, EventArgs e) =>
            {
                Random rand = new Random();
              
                if (deviceforrandom.Count != 0)
                {
                    int randomNum = rand.Next(1, deviceforrandom.Count);

                    for (int i = 0; i < randomNum; i++)
                    {
                        int randomVersion = rand.Next(1, 5);
                        int randomVersion1 = rand.Next(100, 999);
                        int randomOCIndex = rand.Next(ocfromrandom.Count);
                        int randomIndex = rand.Next(deviceforrandom.Count);
                        e_Device device = deviceforrandom.ElementAt(randomIndex);
                        e_OC OS = ocfromrandom.ElementAt(randomOCIndex);
                        DriverManeger.Driver.Add(device, new Driver("Driver №" + count, "v" + randomVersion + ".0" + randomVersion1, device, OS));
                        count++;
                        deviceforrandom.Remove(device);


                    }
                }
                else
                {
                   
                    MessageBox.Show("Вы добавили все драйверы", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

                aaa.Clear();
                foreach (var item in DriverManeger.Driver)
                {
                    aaa.Add(item.Value);
                }
                bsDriver.ResetBindings(true);
            };

            cbSelectOS.Items.Add(e_OC.Linux);
            cbSelectOS.Items.Add(e_OC.Mac);
            cbSelectOS.Items.Add(e_OC.SteamOS);
            cbSelectOS.Items.Add(e_OC.Windows10);
            cbSelectOS.Items.Add(e_OC.Windows7_8);
            cbSelectOS.Items.Add(e_OC.WindowsXP);

            

        }
      
        
        
        private void DeviceMouseDobleClick(object sender, MouseEventArgs e)
        {
            if (bsDevice.Count > 0)          // если список сотрудников не пуст - возможно редактирование параметров выбранного сотрудника
            {
                DriverManeger.CurrentDevice = bsDevice.Current as Device;
                DeviceForm deviceDialog = new DeviceForm();
                deviceDialog.Owner = this;
                if (deviceDialog.ShowDialog() == DialogResult.OK)    // если диалоговое окно отработало с результатом OK - данные сотрудника изменились
                {
                    // обноление данных в массиве сотрудников
                    int index = bsDevice.Position;
                    DriverManeger.Device[index] = DriverManeger.CurrentDevice;
                    // обновление привязок данных

                    bsDevice.ResetBindings(false);
                    bsDriver.ResetBindings(false);
                }
            }
        }
   
        private void DriverMouseDobleClick(object sender, MouseEventArgs e)
        {
            if (bsDriver.Count > 0)          // если список драйверов не пуст - возможно редактирование параметров выбранного драйвера
            {
                DriverManeger.CurrentDriver = bsDriver.Current as Driver;
                DriverForm driverDialog = new DriverForm();    
                driverDialog.Owner = this;
                if (driverDialog.ShowDialog() == DialogResult.OK)    // если диалоговое окно отработало с результатом OK - данные сотрудника изменились
                {
                    // обноление данных в массиве сотрудников
                    int index = bsDriver.Position;
                    bsDriver[index] = DriverManeger.CurrentDriver;
                    DriverManeger.Driver[DriverManeger.CurrentDriver.DeviceType] = DriverManeger.CurrentDriver;
                    // обновление привязок данных
                    bsDevice.ResetBindings(true);
                    bsDriver.ResetBindings(true);
                }
            }
        }
       
 
      
        private void cbSelectOS_SelectedIndexChanged(object sender, EventArgs e)
        {

            DriverManeger.OSComputer = cbSelectOS.SelectedItem.ToString();

            lbTypeOS.Text = DriverManeger.OSComputer;
        }



    }
}
