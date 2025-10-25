using System;
using GorillaLocomotion;
using StupidTemplate.Classes;
using StupidTemplate.Notifications;
using UnityEngine;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Mods.Settings.Movement;
using Photon.Pun;
using Constants;
using GorillaNetworking;
using Photon;
namespace StupidTemplate.Mods
{

    public class Fun
    {
        public static void Rocket()
        {
            if (ControllerInputPoller.instance.rightGrab)
                GTPlayer.Instance.playerRigidBody.AddForce(Vector3.up * 5000f);
        }



    }
}