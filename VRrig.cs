using UnityEngine;
using GorillaLocomotion;


namespace StupidTemplate.Mods
{
    class VRrig
    {
        public static void FixRig()
        {
            {
                // Rotation
                VRRig.LocalRig.head.trackingRotationOffset.x = 0f;
                VRRig.LocalRig.head.trackingRotationOffset.y = 0f;
                VRRig.LocalRig.head.trackingRotationOffset.z = 0f;
                // Position
                VRRig.LocalRig.head.trackingPositionOffset.x = 0f;
                VRRig.LocalRig.head.trackingPositionOffset.y = 0f;
                VRRig.LocalRig.head.trackingPositionOffset.z = 0f;
            }
        }

        public static void Upsidedownhead()
        {
            VRRig.LocalRig.head.trackingRotationOffset.z = 180f;
        }

        public static void RSidewayshead()
        {
            VRRig.LocalRig.head.trackingRotationOffset.x = -180f;
        }

        public static void LSidewayshead()
        {
            VRRig.LocalRig.head.trackingRotationOffset.x = 180f;
        }
    }
}