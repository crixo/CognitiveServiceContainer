﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CognitiveApp.Entities
{
    public class LanguageRequest
    {
        [JsonProperty("documents")]
        public List<DocumentLanguageRequest> Documents { get; set; }
    }

    public class DocumentLanguageRequest
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class LanguageResponse
    {
        [JsonProperty("documents")]
        public IEnumerable<DocumentLanguageResponse> Documents { get; set; }
        [JsonProperty("errors")]
        public IEnumerable<Error> Errors { get; set; }
    }

    public class DocumentLanguageResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("detectedLanguages")]
        public IEnumerable<DetectedLanguage> DetectedLanguage { get; set; }
    }

    public class DetectedLanguage
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("iso6391Name")]
        public string Iso6391Name { get; set; }
        [JsonProperty("score")]
        public double Score { get; set; }
    }
}
