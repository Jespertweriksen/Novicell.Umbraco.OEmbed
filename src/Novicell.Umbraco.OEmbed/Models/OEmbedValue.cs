﻿using Umbraco.Cms.Core.Media.EmbedProviders;

namespace Novicell.Umbraco.OEmbed.Models
{
    public class OEmbedValue
    {
        public string Url { get; set; }

        public OEmbedResponse OEmbed { get; set; }
    }
}