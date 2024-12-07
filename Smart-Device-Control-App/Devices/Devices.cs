using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{

    public delegate void DeviceAction();

    public abstract class Devices
    {
        public string Name { get; set; }
        public bool IsOn { get; set; } 

        public Devices(string name)
        {
            Name = name;
            IsOn = false;
        }

        // For Start Device
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} is now ON");
        }

        // For Stop Devices
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} is now OFF");
        }
    }
}
