using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Laba4
{

    public static class DriverManeger

    {
        public static event EventHandler OSChanged;

       public static event EventHandler ReadyComputerChanged;

        public static event EventHandler CountWorkDeviceChanged;
        public static List<Device> Device { get; set; }

        public  static  Dictionary<e_Device , Driver> Driver ;

        private static string oSComputer;

        private static bool ComputerReady;

        private static int CountWorkDevice;
        public static Device CurrentDevice { set; get; }
        public static Driver CurrentDriver { set; get; }

        public static string OSComputer
        {
            get
            {
                return oSComputer;
            }
            set
            {
                if (oSComputer != value && OSChanged != null)
                {
                    OSChanged(null, EventArgs.Empty);
                }
                oSComputer = value;
            }
        }

      /*  public string CountDevice
        {
            get
            {
                return CountWorkDevice;
            }
            set
            {
                if (CountWorkDevice != value && CountWorkDeviceChanged != null)
                {
                    this.CountWorkDeviceChanged(this, EventArgs.Empty);
                }
                CountWorkDevice = value;
            }
        }*/
      
     // public bool Compeare (Driver obj1, Driver obj2)
       // {

        //}
        public static bool WorkReady                            // свойство, генерирующее событие
        {
            get
            {
                return ComputerReady;
            }
            set
            {
                // если приходящее от пользователя значение не совпадает с текущим состоянием выполнения задачи
                // и на событие изменения состояния задачи кто-то подписан - происходит генерация данного события
                if (ComputerReady != value && ReadyComputerChanged != null)
                {
                    ReadyComputerChanged(null, EventArgs.Empty);
                }
                ComputerReady = value;
            }
        }
        static DriverManeger()
        {
            Device = new List<Device>();
            Driver = new Dictionary<e_Device, Driver>();
        }
    }

    
}
