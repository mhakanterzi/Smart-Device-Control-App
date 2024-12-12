using Smart_Device_Control_App.Devices;
using Smart_Device_Control_App.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Controller
{
    public class CinemaModeController
    {
        public Lights livingRoom { get; set; }
        public Lights kitchen { get; set; }
        public Curtains curtains { get; set; }
        public ElectronicDevices projection { get; set; }

        public CinemaModeController()
        {
            Console.WriteLine("Cinema Mode is running...");
            livingRoom = new Lights("Living Rooms Lights");
            kitchen = new Lights("Kitchen Lights");
            curtains = new Curtains("Living Room Curtains");
            projection = new ElectronicDevices("Projection");
        }

        public void ApplyCinemaMode()
        {
            CinemaMode.RunCinemaMode(livingRoom, kitchen, curtains, projection)();
        }
    }
}
