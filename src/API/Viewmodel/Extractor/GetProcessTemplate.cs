﻿using Newtonsoft.Json;

namespace RestAPI.Viewmodel.Extractor
{
    public class GetProcessTemplate
    {
        public class Properties
        {
            [JsonProperty(PropertyName = "class")]
            public string Class { get; set; }
            public string parentProcessTypeId { get; set; }
            public bool isEnabled { get; set; }
            public string version { get; set; }
            public bool isDefault { get; set; }
        }

        public class PTemplate
        {
            public string typeId { get; set; }
            public object referenceName { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public Properties properties { get; set; }
        }
    }
}
