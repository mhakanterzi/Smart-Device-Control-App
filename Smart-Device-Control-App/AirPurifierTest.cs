using Smart_Device_Control_App.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App
{
    public class AirPurifierTest
    {
        public void Run()
        {
            AirPurifier airpurifier = new AirPurifier("Living Room Air Purifier");

            //Delegate
            DeviceAction deviceAction;

            deviceAction = airpurifier.TurnOn;
            deviceAction();

            //Actiion
            airpurifier.SetMode("Eco");

            //Func
            Func<int, int> brightnessAction = airpurifier.SetSpeed;
            int currentBrightness = brightnessAction(80);

            deviceAction = airpurifier.TurnOff;
            deviceAction();
        }
    }
}

