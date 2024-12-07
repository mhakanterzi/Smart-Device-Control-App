using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{
    public class Lights : Devices
    {
        public int Brightness { get; set; }
        public string Color {  get; set; }

        public Func<int, int> SetBrightness;
        public Action<string> SetColor;
        public Lights(string name) : base(name)
        {
            Brightness = 100;
            Color = "White";

            SetBrightness = (brightness) =>
            {
                Brightness = brightness;
                Console.WriteLine($"{Name} brightness set %{Brightness}");
                return Brightness;
            };

            SetColor = (color) =>
            {
                Color = color;
                Console.WriteLine($"{Name} color set {Color}");
            };

        }
    }
}
