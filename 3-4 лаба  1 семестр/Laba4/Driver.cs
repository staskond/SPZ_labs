using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public enum e_OC
    {
        WindowsXP,
        Windows7_8,
        Windows10,
        Mac,
        Linux,
        SteamOS
    }

    public enum e_Device // Тип устройства
    {
        MotherBoard,
        Processor,
        GPU,
        RAM,
        HDD,
        KeyBoard,
        Mouse,
        Flash,
        SC_DVD,
        Monitor,
        Printer,
        Scaner,
        NetworkPlate
    } 
    public class Driver

    {
        public string NameDriver { set; get; }
        private string versionDriver;

        public e_OC OSDriver {set; get;}
        public e_Device DeviceType { set; get; }

        public Driver(string NameDriver, string VersionDriver, e_Device DeviceType, e_OC OSDriver)
        {
            this.NameDriver = NameDriver;
            this.VersionDriver = VersionDriver;
            this.DeviceType = DeviceType;
            this.OSDriver = OSDriver;
        }

        public static bool operator == (Driver obj1, Driver obj2)
        {
            if (Object.ReferenceEquals(obj1, obj2))
            {
                return true;
            }
            else if (Object.ReferenceEquals(obj1, null) || Object.ReferenceEquals(obj1, null))
            {
                return false;
            }
            else
            {
                return obj1.VersionDriver != obj2.VersionDriver && obj1.DeviceType != obj2.DeviceType && obj1.OSDriver != obj2.OSDriver;
            }
        }
        public static bool operator != (Driver obj1, Driver obj2)
        {
            return !(obj1 == obj2);
        }
        public bool Compeare (Device deviceObj)
        {
            if (this.DeviceType == deviceObj.DeviceType && this.OSDriver.ToString() == DriverManeger.OSComputer)
                return true;
            else
                return false;
        }

        public  void ChangeVersion (string NewVersionDriver)
        {
            this.versionDriver = NewVersionDriver;
        }
        public event EventHandler OnVersionChanged;
        public string VersionDriver
        {
            get
            {
                return versionDriver;
            }
            set
            {
                if (versionDriver != value && OnVersionChanged != null)
                {
                    this.OnVersionChanged(this, EventArgs.Empty);
                }
                versionDriver = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1} : {2} : {3}",
                                NameDriver,
                                VersionDriver,
                                OSDriver,
                                DeviceType);
        }
    }
}
