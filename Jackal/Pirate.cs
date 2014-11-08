﻿using System;
using Newtonsoft.Json;

namespace Jackal
{
    public class Pirate
    {
        [JsonProperty]
        public readonly Guid Id;

        [JsonProperty]
        public readonly int TeamId;

        [JsonProperty]
        public TilePosition Position;

        [JsonProperty]
        public bool IsDrunk;

        internal int? DrunkSinceTurnNo;
        
        public Pirate(int teamId, TilePosition position)
        {
            Id = Guid.NewGuid();
            TeamId = teamId;
            Position = position;
        }
    }
}