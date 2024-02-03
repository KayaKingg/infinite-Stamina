using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stamina
{
    public class Stamina : Plugin<Config>
    {
        public override string Name => "Stamina";
        public override string Author => "KayaKing";
        public override Version Version { get; } = new Version(3, 1, 1);
        public override Version RequiredExiledVersion { get; } = new Version(8, 2, 0);
        public static Stamina Instance { get; set; }

        public override void OnEnabled()
        {
            base.OnEnabled();
            Exiled.Events.Handlers.Player.ChangingMoveState += PlayerRunning;
            Log.Info($"<color=#8B0000>[KayaKing]</color> <color=yellow>Tarafından Yapılmıştır İyi Eğlenceler!</color>");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Player.ChangingMoveState -= PlayerRunning;
            Log.Info($"<color=yellow>Kaldırıldı!</color>");
        }

        private void PlayerRunning(ChangingMoveStateEventArgs ev)
        {
            {
                ev.Player.IsUsingStamina = false;
            }
        }
    }
}