using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{
    public class RobotCleaner : Devices
    {
        public string CleanMode { get; set; }
        public Action<string> CleanAction;

        public RobotCleaner(string name) : base(name)
        {
            CleanMode = "Vacuuming";

            CleanAction = (setMode) =>
            {
                CleanMode = setMode;
                Console.WriteLine($"{Name} mode set {CleanMode}");
            };
        } 
    }
}
