using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{


    public class Device
    {
        private string deviceName;
        public string DeviceName
        {
            get
            {
                return deviceName;
            }
            set
            {
                if (deviceName != value && DeviceNameChanged != null)
                {
                    this.DeviceNameChanged(this, EventArgs.Empty);
                }
                deviceName = value;
            }
        }

        public event EventHandler DeviceNameChanged;
        public event ChangeStateDelegate ReadyToWorkChanged;
        public event EventHandler DriverChanged;
        public delegate string ChangeStateDelegate();
        public e_Device DeviceType { set; get; }
        private Driver deviceDriver;
        public string NameUseDriver { set; get; }
        public Driver DeviceDriver 
        {

            get
            {
                return deviceDriver;
            }
            set
            {
                 deviceDriver = value;
                 
                 if ((object)deviceDriver == null)
                 {
                     readyToWork = false;
                     NameUseDriver = "";
                 }
                 else
                 { 
                     readyToWork = true;
                 NameUseDriver = deviceDriver.NameDriver;
                 }

                if ( DriverChanged != null)
                {
                    this.DriverChanged(this, EventArgs.Empty);
                }
               
            }

        }

        private bool readyToWork;

        public Device(string Name, e_Device DeviceType)
        {
            this.DeviceType = DeviceType;
            this.deviceName = Name;
            
        }
        public bool Compeare(Device deviceObj, Driver driverObj)
        {
            if (driverObj.DeviceType == deviceObj.DeviceType && DriverManeger.OSComputer == driverObj.OSDriver.ToString())
                return true;
            else
                return false;
        }


        public bool ReadyToWork
        {
            get
            {
                return readyToWork;

            }
            set
            {
                if (readyToWork != value && ReadyToWorkChanged != null)
                {
                    this.ReadyToWorkChanged();
                }
                readyToWork = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1} {2} : Драйвер {3} установлен",
                                DeviceName,
                                DeviceType,
                                (object)deviceDriver == null ? "" : ": " + deviceDriver.NameDriver,
                                ReadyToWork ? "" : "не");
        }
    }
}
