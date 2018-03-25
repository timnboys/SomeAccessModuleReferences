﻿namespace TwitchLib.Models.API.v5.Ingests
{
    #region using directives
    using Newtonsoft.Json;
    #endregion
    public class Ingests
    {
        #region Ingests
        [JsonProperty(PropertyName = "ingests")]
        public Ingest[] IngestServers { get; protected set; }
        #endregion
    }
}
