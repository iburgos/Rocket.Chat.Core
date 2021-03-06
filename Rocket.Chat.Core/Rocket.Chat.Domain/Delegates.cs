﻿namespace Rocket.Chat.Domain
{
    using Newtonsoft.Json.Linq;

    public delegate void DataReceived(string type, JObject data);

    public delegate void MessageReceived(Message rocketMessage);

    public delegate void DdpReconnect();
}