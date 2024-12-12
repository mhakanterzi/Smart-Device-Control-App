using Smart_Device_Control_App.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Modes
{
    public class NightMode
    {
        public static Action RunNightMode (Lights lights, AirPurifier airPurifier, Curtains curtains, RobotCleaner robotCleaner, Thermostat thermostat) 
            {
            return() => {
                Console.WriteLine("Night Mode is running...");
                lights.TurnOff();
                airPurifier.SetMode("Eco");
                airPurifier.SetSpeed(20);
                curtains.SetCurtainsOpen(0);
                robotCleaner.CleanAction("Vacuuming");
                thermostat.SetDegree(25);
                };
            }
    }

}
