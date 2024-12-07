using Smart_Device_Control_App.Devices;
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
            LigtsTest ligtsTest = new LigtsTest();
            ligtsTest.Run();

            AirPurifierTest airPurifier = new AirPurifierTest();
            airPurifier.Run();
        }
    }
}