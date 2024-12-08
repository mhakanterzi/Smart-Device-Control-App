using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Device_Control_App.Devices
{
    public class Curtains : Devices
    {
        public int OpenDegree { get; set; }

        public Func<int, int> SetCurtainsOpen;

        public Curtains(string name) : base(name)
        {
            OpenDegree = 0;

            SetCurtainsOpen = (openDegree) =>
            {
                OpenDegree=openDegree;
                Console.WriteLine($"{Name} %{OpenDegree} open");
                return OpenDegree;
            };
        }

    }
}
