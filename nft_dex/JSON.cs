using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace dex_dotnet_bot
{
    class JSON
    { // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Owner
        {
            [JsonProperty("avatarUrl")]
            public string AvatarUrl { get; set; }

            [JsonProperty("nickName")]
            public string NickName { get; set; }
        }

        public class Row
        {
            [JsonProperty("productId")]
            public string ProductId { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("coverUrl")]
            public string CoverUrl { get; set; }

            [JsonProperty("tradeType")]
            public int TradeType { get; set; }

            [JsonProperty("nftType")]
            public int NftType { get; set; }

            [JsonProperty("amount")]
            public string Amount { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }

            [JsonProperty("setStartTime")]
            public long SetStartTime { get; set; }

            [JsonProperty("setEndTime")]
            public long SetEndTime { get; set; }

            [JsonProperty("timestamp")]
            public long Timestamp { get; set; }

            [JsonProperty("rarity")]
            public object Rarity { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("owner")]
            public Owner Owner { get; set; }
        }

        public class Data
        {
            [JsonProperty("total")]
            public int Total { get; set; }

            [JsonProperty("rows")]
            public List<Row> Rows { get; set; }
        }

        public class Root
        {
            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("message")]
            public object Message { get; set; }

            [JsonProperty("messageDetail")]
            public object MessageDetail { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }

            [JsonProperty("success")]
            public bool Success { get; set; }
        }



    }
}
