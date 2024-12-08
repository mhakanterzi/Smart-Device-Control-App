using Smart_Device_Control_App.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App
{
    public class Program
    {
        static void Main(string[] args)
        {

            ElectronicDevices start = new ElectronicDevices("Computer");

            DeviceAction deviceAction;

            deviceAction = start.TurnOn;
            deviceAction();


            Thermostat degree = new Thermostat("Home");

            Func<int, int> openActions = degree.SetDegree;
            int currentDegree = openActions(26);
        }
    }
}