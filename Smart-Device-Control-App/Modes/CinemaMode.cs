using Smart_Device_Control_App.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Modes
{
    public class CinemaMode
    {
        public static Action RunCinemaMode (Lights livingRoom, Lights kitchen, Curtains curtains, ElectronicDevices projection )
        {
            return () =>
            {
                livingRoom.SetColor("Suitable for movie");
                livingRoom.SetBrightness(20);
                kitchen.SetBrightness(30);
                curtains.SetCurtainsOpen(0);
                projection.TurnOn();
            };
        }
    }
}
