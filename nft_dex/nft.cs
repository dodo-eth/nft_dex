using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace dex_dotnet_bot
{
    class nft
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class CategoryVo
        {
            [JsonProperty("code")]
            public int Code { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class ProductDetail
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("productNo")]
            public string ProductNo { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("category")]
            public int Category { get; set; }

            [JsonProperty("relateId")]
            public string RelateId { get; set; }

            [JsonProperty("nftType")]
            public int NftType { get; set; }

            [JsonProperty("tradeType")]
            public int TradeType { get; set; }

            [JsonProperty("amount")]
            public string Amount { get; set; }

            [JsonProperty("maxAmount")]
            public string MaxAmount { get; set; }

            [JsonProperty("stepAmount")]
            public string StepAmount { get; set; }

            [JsonProperty("currentAmount")]
            public string CurrentAmount { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }

            [JsonProperty("setStartTime")]
            public long SetStartTime { get; set; }

            [JsonProperty("setEndTime")]
            public long SetEndTime { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("batchNum")]
            public int BatchNum { get; set; }

            [JsonProperty("stockNum")]
            public int StockNum { get; set; }

            [JsonProperty("leftStockNum")]
            public int LeftStockNum { get; set; }

            [JsonProperty("coverUrl")]
            public string CoverUrl { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("creatorId")]
            public object CreatorId { get; set; }

            [JsonProperty("listerId")]
            public object ListerId { get; set; }

            [JsonProperty("listTime")]
            public string ListTime { get; set; }

            [JsonProperty("source")]
            public int Source { get; set; }

            [JsonProperty("categoryVo")]
            public CategoryVo CategoryVo { get; set; }

            [JsonProperty("tokenList")]
            public List<object> TokenList { get; set; }
        }

        public class ProductFee
        {
            [JsonProperty("feeId")]
            public int FeeId { get; set; }

            [JsonProperty("type")]
            public int Type { get; set; }

            [JsonProperty("remark")]
            public string Remark { get; set; }

            [JsonProperty("totalFee")]
            public string TotalFee { get; set; }
        }

        public class Creator
        {
            [JsonProperty("avatarUrl")]
            public string AvatarUrl { get; set; }

            [JsonProperty("nickName")]
            public string NickName { get; set; }

            [JsonProperty("description")]
            public object Description { get; set; }
        }

        public class Owner
        {
            [JsonProperty("avatarUrl")]
            public string AvatarUrl { get; set; }

            [JsonProperty("nickName")]
            public string NickName { get; set; }

            [JsonProperty("description")]
            public object Description { get; set; }
        }

        public class NftInfo
        {
            [JsonProperty("nftId")]
            public int NftId { get; set; }

            [JsonProperty("tokenId")]
            public string TokenId { get; set; }

            [JsonProperty("rawUrl")]
            public object RawUrl { get; set; }

            [JsonProperty("coverUrl")]
            public object CoverUrl { get; set; }

            [JsonProperty("contractAddress")]
            public string ContractAddress { get; set; }

            [JsonProperty("mediaType")]
            public object MediaType { get; set; }

            [JsonProperty("rawSize")]
            public object RawSize { get; set; }

            [JsonProperty("specification")]
            public object Specification { get; set; }

            [JsonProperty("duration")]
            public object Duration { get; set; }

            [JsonProperty("rarity")]
            public object Rarity { get; set; }

            [JsonProperty("creator")]
            public Creator Creator { get; set; }

            [JsonProperty("owner")]
            public Owner Owner { get; set; }
        }

        public class Series
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("amount")]
            public int Amount { get; set; }

            [JsonProperty("rarity")]
            public int Rarity { get; set; }

            [JsonProperty("probability")]
            public string Probability { get; set; }
        }

        public class MysteryBoxProductDetailVo
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("productId")]
            public string ProductId { get; set; }

            [JsonProperty("image")]
            public string Image { get; set; }

            [JsonProperty("startTime")]
            public long StartTime { get; set; }

            [JsonProperty("endTime")]
            public long EndTime { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("artist")]
            public string Artist { get; set; }

            [JsonProperty("currentStore")]
            public int CurrentStore { get; set; }

            [JsonProperty("currentUserBalance")]
            public object CurrentUserBalance { get; set; }

            [JsonProperty("series")]
            public List<Series> Series { get; set; }

            [JsonProperty("coverUrl")]
            public string CoverUrl { get; set; }

            [JsonProperty("rules")]
            public string Rules { get; set; }

            [JsonProperty("duration")]
            public object Duration { get; set; }

            [JsonProperty("subTitle")]
            public string SubTitle { get; set; }

            [JsonProperty("mappingStatus")]
            public object MappingStatus { get; set; }

            [JsonProperty("creator")]
            public Creator Creator { get; set; }

            [JsonProperty("secondMarketSellingDelay")]
            public int SecondMarketSellingDelay { get; set; }

            [JsonProperty("limitPerTime")]
            public int LimitPerTime { get; set; }

            [JsonProperty("userBalance")]
            public string UserBalance { get; set; }
        }

        public class Data
        {
            [JsonProperty("productDetail")]
            public ProductDetail ProductDetail { get; set; }

            [JsonProperty("productFee")]
            public ProductFee ProductFee { get; set; }

            [JsonProperty("nftInfo")]
            public NftInfo NftInfo { get; set; }

            [JsonProperty("isOwner")]
            public int IsOwner { get; set; }

            [JsonProperty("timestamp")]
            public long Timestamp { get; set; }

            [JsonProperty("mysteryBoxProductDetailVo")]
            public MysteryBoxProductDetailVo MysteryBoxProductDetailVo { get; set; }
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
