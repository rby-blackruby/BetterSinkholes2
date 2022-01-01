using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterSinkholes2.Configuration
{
    public class Translation : ITranslation
    {
        [Description("Message broadcasted to the player upon falling into a sinkhole. Default: nothing")]
        public string TeleportMessage { get; set; } = "";
    }
}
