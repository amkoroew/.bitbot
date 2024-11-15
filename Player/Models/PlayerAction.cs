﻿using Newtonsoft.Json;

namespace Player.Models;

public class PlayerAction
{
    [JsonProperty("src")]
    public uint Src { get; set; }

    [JsonProperty("dest")]
    public uint Dest { get; set; }

    [JsonProperty("amount")]
    public uint Amount { get; set; }
}