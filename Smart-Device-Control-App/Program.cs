using Smart_Device_Control_App.Controller;
using Smart_Device_Control_App.Devices;
using Smart_Device_Control_App.Modes;
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
            NightModeController controller = new NightModeController();
            controller.ApplyNightMode();

            CinemaModeController run = new CinemaModeController();
            run.ApplyCinemaMode();
        }
    }
}