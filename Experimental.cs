using System;
using GorillaLocomotion;
using StupidTemplate.Classes;
using StupidTemplate.Notifications;
using UnityEngine;
using static StupidTemplate.Menu.Main;
using Photon;


namespace StupidTemplate.Mods
{
    public class Experimental
    {
        public static void UpAndDown()
        {
            // Up
            if (ControllerInputPoller.instance.rightControllerTriggerButton)
            {
                GorillaTagger.Instance.rigidbody.linearVelocity += GorillaTagger.Instance.transform.up * (Time.deltaTime * 20f);
            }
            // Down
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.rigidbody.linearVelocity += Vector3.down * (Time.deltaTime * 20f);
            }
        }




    }
}