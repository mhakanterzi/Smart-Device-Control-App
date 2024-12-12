using Smart_Device_Control_App.Devices;
using Smart_Device_Control_App.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Controller
{
    public class NightModeController
    {
        public Lights Lights { get; set; }
        public AirPurifier AirPurifier { get; set; }
        public Curtains Curtains { get; set; }
        public RobotCleaner RobotCleaner { get; set; }
        public Thermostat Thermostat { get; set; }

        public NightModeController()
        {
            Lights = new Lights("Home Lights");
            AirPurifier = new AirPurifier("Bedroom Air Purifier");
            Curtains = new Curtains("Bedroom Curtains");
            RobotCleaner = new RobotCleaner("Robot Cleaner");
            Thermostat = new Thermostat("Home Thermostat");
        }

        public void ApplyNightMode()
        {
            NightMode.RunNightMode(Lights, AirPurifier, Curtains, RobotCleaner, Thermostat)();
        }
    }
}
