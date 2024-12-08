﻿using Smart_Device_Control_App.Devices;
using Xunit;

namespace Smart_Device_Control_App.Tests
{
    public class LightsTests
    {
        DeviceAction deviceAction;

        [Fact]
        public void LightOn()
        {
            Lights light = new Lights("Living Room Lights");

            deviceAction = light.TurnOn;
            deviceAction();
            Assert.True(light.IsOn);
        }

        [Fact]
        public void LightColor()
        {
            Lights light = new Lights("Living Room Lights");
            light.SetColor("Yellow");
            Assert.Equal("Yellow", light.Color);
        }

        [Fact]
        public void LightBrightness()
        {
            Lights light = new Lights("Living Room Lights");

            Func<int, int> brightnessAction = light.SetBrightness;
            int currentBrightness = brightnessAction(80);
            Assert.Equal(light.Brightness, 80);
        }

        [Fact]
        public void LightOff()
        {
            Lights light = new Lights("Living Room Lights");

            deviceAction = light.TurnOff;
            deviceAction();
            Assert.False(light.IsOn);
        }

    }

    public class AirPurifierTest
    {
        DeviceAction deviceAction;

        [Fact]
        public void AirPurifierOn()
        {
            AirPurifier airpurifier = new AirPurifier("Living Room Air Purifier");

            deviceAction = airpurifier.TurnOn;
            deviceAction();

            Assert.True(airpurifier.IsOn);
        }

        [Fact]
        public void AirPurifierMode()
        {
            AirPurifier airpurifier = new AirPurifier("Living Room Air Purifier");

            airpurifier.SetMode("Eco");
            Assert.Equal("Eco", airpurifier.Mode);
        }

        [Fact]
        public void AirPurifierSpeed()
        {
            AirPurifier airpurifier = new AirPurifier("Living Room Air Purifier");

            Func<int, int> brightnessAction = airpurifier.SetSpeed;
            int currentBrightness = brightnessAction(80);

            Assert.Equal(airpurifier.Speed, 80);
        }

        [Fact]
        public void AirPurifierOff()
        {
            AirPurifier airpurifier = new AirPurifier("Living Room Air Purifier");

            deviceAction = airpurifier.TurnOff;
            deviceAction();

            Assert.False(airpurifier.IsOn);
        }
    }

    public class CurtainsTest
    {
        DeviceAction deviceAction;

        [Fact]
        public void CurtainsOn()
        {
            Curtains curtains = new Curtains("Living Room Curtains");

            deviceAction = curtains.TurnOn;
            deviceAction();
            Assert.True(curtains.IsOn);
        }

        [Fact]
        public void CurtainsDegree()
        {
            Curtains curtains = new Curtains("Living Room Curtains");

            Func<int, int> openActions = curtains.SetCurtainsOpen;
            int currentDegree = openActions(75);

            Assert.Equal(curtains.OpenDegree, 75);
        }

        [Fact]
        public void CurtainsOff()
        {
            Curtains curtains = new Curtains("Living Room Curtains");

            deviceAction = curtains.TurnOff;
            deviceAction();
            Assert.False(curtains.IsOn);
        }
    }

    public class HomeApplianceTest
    {
        DeviceAction deviceAction;

        [Fact]
        public void HomeApplianceOn()
        {
            HomeAppliances washingMachine = new HomeAppliances("Washing Machine");
            HomeAppliances dishMachine = new HomeAppliances("Dish Machine");

            deviceAction = washingMachine.TurnOn;
            deviceAction();

            deviceAction = dishMachine.TurnOn;
            deviceAction();

            Assert.True(washingMachine.IsOn);
            Assert.True(dishMachine.IsOn);
        }

        [Fact]
        public void HomeApplianceMode()
        {
            HomeAppliances washingMachine = new HomeAppliances("Washing Machine");
            HomeAppliances dishMachine = new HomeAppliances("Dish Machine");

            washingMachine.SetMode("Cotton");
            dishMachine.SetMode("Eco");

            Assert.Equal(washingMachine.WorkMode, "Cotton");
            Assert.Equal(dishMachine.WorkMode, "Eco");

        }

        [Fact]
        public void HomeApplianceOff()
        {
            HomeAppliances washingMachine = new HomeAppliances("Washing Machine");
            HomeAppliances dishMachine = new HomeAppliances("Dish Machine");

            deviceAction = washingMachine.TurnOff;
            deviceAction();

            deviceAction = dishMachine.TurnOff;
            deviceAction();

            Assert.False(washingMachine.IsOn);
            Assert.False(dishMachine.IsOn);
        }
    }


}