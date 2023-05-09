using Rocket.API;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using SDG.Unturned;
using System;

namespace NelPoliceUI
{
    public class NelConfig : IRocketPluginConfiguration
    {
        public string NelPolis;
        public void LoadDefaults()
        {
            NelPolis = "NelPolis";
        }
    }
}
