﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotSharp.MatchEndpoint
{
    public class TeamBan
    {
        internal TeamBan() { }

        /// <summary>
        /// The pick turn where the champion has been banned.
        /// </summary>
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
        /// <summary>
        /// ID of the banned champion.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
}
