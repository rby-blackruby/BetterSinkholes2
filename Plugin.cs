using EXILED;
using Harmony;

namespace BetterSinkholes
{
    public class Plugin : EXILED.Plugin
    {
        public override string getName { get; } = "Better Sinkholes";

        public static bool EnableBetterSinkholes;
        public static float TeleportDistance;
        public static float SlowDistance;
        public static string TeleportMessage;
        public static uint TeleportMessageDuration;
        public static bool EnableDebug;

        public static HarmonyInstance HarmonyInstance { set; get; }
        public override void OnEnable()
        {
            Plugin.Info("Whatever.");
            EnableBetterSinkholes = Plugin.Config.GetBool("bs_enable", true);

            if(EnableBetterSinkholes == false)
            {
                Plugin.Info("BetterSinkholes is disabled on this server.");
                return;
            }

            SlowDistance = Plugin.Config.GetFloat("bs_slow_distance", 1.15f);
            TeleportDistance = Plugin.Config.GetFloat("bs_teleport_distance", 0.7f);
            TeleportMessage = Plugin.Config.GetString("bs_teleport_message", null);
            TeleportMessageDuration = Plugin.Config.GetUInt("bs_teleport_message_duration", 5U);
            EnableDebug = Plugin.Config.GetBool("bs_enable_debug", true);

            HarmonyInstance = HarmonyInstance.Create($"blackruby.exiled.bettersinkholes");
            HarmonyInstance.PatchAll();

        }

        public override void OnDisable()
        {
            HarmonyInstance.UnpatchAll();
        }

        public override void OnReload()
        {
            
        }
    }
}
