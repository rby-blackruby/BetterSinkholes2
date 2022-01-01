using BetterSinkholes2.Configuration;
using Exiled.API.Features;
using HarmonyLib;

namespace BetterSinkholes2
{
    internal class BetterSinkholes2 : Plugin<Config>
    {
        public static int PatchCount = 0;
        public static Harmony harmony { set; get; }
        public static Config config;
        public static Translation translation;

        public override void OnEnabled()
        {
            config = Config;
            translation = new Translation();

            if (config.IsEnabled)
            {
                Log.Info("Loaded BetterSinkholes2 plugin.");
                DoPatching();
            }

        }

        public override void OnDisabled()
        {
            harmony.UnpatchAll();
        }

        // Enables the modifications made to the sinkholes
        public static void DoPatching()
        {
            harmony = new Harmony($"blackruby.exiled.bettersinkholes2{++PatchCount}");
            harmony.PatchAll();
        }
    }
}
