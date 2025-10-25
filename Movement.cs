using System;
using System.Collections.Generic;
using System.Text;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Mods.Movement;

namespace StupidTemplate.Mods.Settings
{
    public class Movement
    {
        public static int flySpeedIndex = 2;
        public static float flySpeed = 15f;
        public static float SpeedBoost = 9;
        public static int speedBoostIndex = 2;

        public static void ChangeFlySpeed()
        {
            string[] speedNames = new string[] { "Very Slow", "Slow", "Normal", "Fast", "Very Fast", "Extreme" };
            float[] speedValues = new float[] { 5f, 10f, 15f, 20f, 30f, 50f };

            flySpeedIndex++;
            flySpeedIndex %= speedNames.Length;

            GetIndex("Change Fly Speed").overlapText = $"Change Fly Speed [{speedNames[flySpeedIndex]}]";
        }

        public static void ChangeSpeedBoost()
        {
            string[] speedNames = new string[] { "Very Slow", "Slow", "Normal", "Fast", "Very Fast", "Extreme" };
            float[] speedValues = new float[] { 3f, 6f, 9f, 12f, 18f, 30f };

            speedBoostIndex++;
            speedBoostIndex %= speedNames.Length;

            GetIndex("Change SpeedBoost").overlapText = $"Change SpeedBoost [{speedNames[speedBoostIndex]}]";
        }
    }
}