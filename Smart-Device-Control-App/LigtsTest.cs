using Smart_Device_Control_App.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App
{
    public class LigtsTest
    {
        public void Run()
        {
            Lights light = new Lights("Living Room Lights");

            //Delegate
            DeviceAction deviceAction;

            deviceAction = light.TurnOn;
            deviceAction();

            //Actiion
            light.SetColor("Yellow");

            //Func
            Func<int, int> brightnessAction = light.SetBrightness;
            int currentBrightness = brightnessAction(80);

            deviceAction = light.TurnOff;
            deviceAction();
        }
    }
}
