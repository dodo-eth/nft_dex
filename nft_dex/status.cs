using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace dex_dotnet_bot
{
    class status
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class MessageDetail
        {
            [JsonProperty("title")]
            public object Title { get; set; }

            [JsonProperty("type")]
            public object Type { get; set; }

            [JsonProperty("icon")]
            public object Icon { get; set; }

            [JsonProperty("action")]
            public object Action { get; set; }

            [JsonProperty("linkTitle")]
            public object LinkTitle { get; set; }

            [JsonProperty("linkUrl")]
            public object LinkUrl { get; set; }
        }

        public class Root
        {
            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("messageDetail")]
            public MessageDetail MessageDetail { get; set; }

            [JsonProperty("data")]
            public object Data { get; set; }

            [JsonProperty("success")]
            public bool Success { get; set; }
        }


    }
}
