using Mirror;
using UnityEngine;
using Harmony;
using RemoteAdmin;
using System;

namespace BetterSinkholes
{
    [HarmonyPatch(typeof(SinkholeEnvironmentalHazard), "DistanceChanged", new Type[] { typeof(GameObject) })]
    public class ImproveThoseSinkholesBaby
    {
        public Plugin plugin;
        public ImproveThoseSinkholesBaby(Plugin plugin) => this.plugin = plugin;
        public static bool Prefix(SinkholeEnvironmentalHazard __instance, GameObject player)
        {
            
            if (!NetworkServer.active)
            {
                Plugin.addDebug("NetworkServer is not active.");
                return false;
            }

            PlayerEffectsController componentInParent = player.GetComponentInParent<PlayerEffectsController>();
            if(componentInParent == null)
            {
                Plugin.addDebug("ComponentInParent is null.");
                return false;
            }

            if ((double)Vector3.Distance(player.transform.position, __instance.transform.position) > (double)__instance.DistanceToBeAffected * Plugin.SlowDistance)
            {
                componentInParent.DisableEffect("SinkHole");
                Plugin.addDebug("SinkHole effect has been disabled for componentInParebt");
                return false;
            }

            if(__instance.SCPImmune)
            {
                CharacterClassManager component = player.GetComponent<CharacterClassManager>();
                if(component == null || component.IsAnyScp())
                {
                    Plugin.addDebug("SCP immunity detected.");
                    return false;
                }
            }

            if (Plugin.EnableBetterSinkholes && (double)Vector3.Distance(player.transform.position, __instance.transform.position) < (double)__instance.DistanceToBeAffected * Plugin.TeleportDistance)
            {
                player.GetComponent<PlyMovementSync>().OverridePosition(Vector3.down * 1998.5f, 0f, true);
                PlayerEffectsController componentInParent2 = player.GetComponentInParent<PlayerEffectsController>();
                componentInParent2.DisableEffect("SinkHole");
                componentInParent2.GetEffect<CustomPlayerEffects.Corroding>("Corroding").isInPd = true;
                componentInParent2.EnableEffect("Corroding");
                QueryProcessor.Localplayer.GetComponent<Broadcast>().TargetAddElement(player.gameObject.GetComponent<NetworkIdentity>().connectionToClient, Plugin.TeleportMessage, Plugin.TeleportMessageDuration, false);
                Plugin.addDebug("The teleportation clearly doesn't work");
                return false;
            }

            Plugin.addDebug("Added SinkHole effect for componentInParent.");
            componentInParent.EnableEffect("SinkHole");
            return false;
        }
    }
}
