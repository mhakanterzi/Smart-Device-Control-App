using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{
    public  class HomeAppliances : Devices
    {
        public string WorkMode { get; set; }

        public Action<string> SetMode;

        public HomeAppliances(string name) : base(name)
        {
            WorkMode = "Close";

            SetMode = (setmode) =>
            {
                WorkMode = setmode;
                Console.WriteLine($"{Name} mode set {WorkMode}");
            };
        }
    }
}
