using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{
    public class AirPurifier : Devices
    {
        public int Speed {  get; set; }
        public string Mode { get; set; }

        public Func<int, int> SetSpeed;
        public Action<string> SetMode;

        public AirPurifier(string name) : base(name) 
        {
            Speed = 0;
            Mode = "Eco";

            SetSpeed = (speed) =>
            {
                Speed = speed;
                Console.WriteLine($"{Name} speed set %{Speed}");
                return Speed;
            };

            SetMode = (mode) =>
            {
                Mode = mode;
                Console.WriteLine($"{Name} mode set {Mode}");
            };
        }
    }
}
