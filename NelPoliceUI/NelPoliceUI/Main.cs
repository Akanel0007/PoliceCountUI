using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;

namespace NelPoliceUI
{
    public class Main : RocketPlugin<NelConfig>
    {
        public static Main Instance;
        protected override void Load()
        {
            Logger.Log("Nel Plugins", ConsoleColor.Red);
            Logger.Log("Police UI Loaded", ConsoleColor.Blue);
            Logger.Log("Akanel#0007", ConsoleColor.Red);
            Logger.Log("Nel Plugins Police UI Version 1", ConsoleColor.Red);
            Logger.Log("Nel Plugins", ConsoleColor.Red);
            Instance = this;
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected += Events_OnPlayerDisconnected;
        }

        public int Akanelpolis; // Bu eklenti Akanel#0007 Tarafından Yapılmıştır
        private void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            EffectManager.sendUIEffect(27411, 27411, true, Akanelpolis.ToString());

            if (player.IsAdmin)
            {
                return;
            }
            else if (player.HasPermission(this.Configuration.Instance.NelPolis))
            {
                Akanelpolis = Akanelpolis + 1;
            }

            EffectManager.sendUIEffect(27411, 27411, true, Akanelpolis.ToString());
        }

        private void Events_OnPlayerDisconnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            if (player.IsAdmin)
            {
                return;
            }
            else if (player.HasPermission(this.Configuration.Instance.NelPolis))
            {
                if (Akanelpolis == 0)
                {
                    return;
                }
                Akanelpolis = Akanelpolis - 1;
            }


            EffectManager.sendUIEffect(27411, 27411, true, Akanelpolis.ToString());
        }


        protected override void Unload()
        {
            Logger.Log("Nel Plugins");
            Logger.Log("Police UI Loaded", ConsoleColor.Blue);
            Logger.Log("Akanel#0007", ConsoleColor.Red);
            Logger.Log("Nel Plugins Police UI Version 1", ConsoleColor.Red);
            Logger.Log("Nel Plugins");
        }
    }
}
