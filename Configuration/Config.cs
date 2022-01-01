using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterSinkholes2.Configuration
{
    public class Config : IConfig
    {
        [Description("Enable/disable BetterSinkholes")]
        public bool IsEnabled { get; set; } = true;

        [Description("Distance from the center of a sinkhole where you get teleported")]
        public float TeleportDistance { get; set; } = 0.6f;

        [Description("Distance from the center of a sinkhole where you start getting slowed")]
        public float SlowDistance { get; set; } = 1.2f;

        [Description("Broadcasted message duration. Default: 0")]
        public ushort TeleportMessageDuration { get; set; } = 0;
    }
}
