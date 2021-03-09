using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace OmegaWharedUpdate
{
    public class EventHandlers
    {
		public void onWarheadExplosion()
		{
			foreach (var player in Player.List)
			{
				player.Kill(DamageTypes.Nuke);
				player.Broadcast((ushort)Plugin.Singleton.Config.BroadcastTime, Plugin.Singleton.Config.DetonationBroadcast, 0);
				Cassie.Message(Plugin.Singleton.Config.CassieMessage);
			}
		}
    }
}
