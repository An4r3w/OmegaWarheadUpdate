using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using WarheadEvent = Exiled.Events.Handlers.Warhead;

namespace OmegaWharedUpdate
{
    internal class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "An4r3w";

        public override string Name { get; } = "Omega Warhead";

        public override string Prefix { get; } = "Omega Warhead";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(2, 8, 0);

        internal EventHandlers EventHandlers { get; set; }

        public override PluginPriority Priority { get; } = PluginPriority.Default;

        public override void OnEnabled()
        {
            Plugin.Singleton = this;
            this.EventHandlers = new EventHandlers();
            WarheadEvent.Detonated += EventHandlers.onWarheadExplosion;
        }

        public override void OnDisabled()
        {
            WarheadEvent.Detonated -= EventHandlers.onWarheadExplosion;
            this.EventHandlers = null;
        }


        public static Plugin Singleton;
    }
}
