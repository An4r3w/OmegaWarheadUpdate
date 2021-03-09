using System;
using Exiled.API.Interfaces;

namespace OmegaWharedUpdate
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public string DetonationBroadcast { get; set; } = "KABOOM, you just got Alpha Warhead'd";

        public int BroadcastTime { get; set; } = 5;

        public string CassieMessage { get; set; } = "Alpha Warhead Detonated .g5 .g3";
    }
}
