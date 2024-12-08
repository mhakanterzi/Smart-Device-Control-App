using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{
    public class Thermostat : Devices
    {
        public int Degree { get; set; }

        public Func<int, int> SetDegree;

        public Thermostat(string name) : base(name)
        {
            Degree = 22;

            SetDegree = (degree) =>
            {
                Degree = degree;
                Console.WriteLine($"{Name} temprature set {Degree} degree.");
                return Degree;
            };
        }
    }
}
