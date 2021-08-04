using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json; 
using Telegram.Bot.Types.Enums; 
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading;
using Telegram.Bot; 
using System.Timers;
using System.Web;
using System.Net;
using System.Text; 

namespace dex_dotnet_bot
{
  public  class Program
    {


        // private static System.Timers.Timer aTimer;
        static Int64 prodid012;
        static Int64 prodid345;
        static Int64 prodid67;
        static Int64 prodid89;
        static string cookie;
        static string csrftoken;
        static List<int> id_list012 = new List<int>();
        static List<int> id_list345 = new List<int>();
        static List<int> id_list67 = new List<int>();
        static List<int> id_list89 = new List<int>(); 
        static TelegramBotClient Bot_ntf; 
        static Int64 chanall_id = 401036948;
        static Int64 productId ; 
        static int count_glob;

        static string if_title_Zombie;
        static double target_price_Zombie;

        static string if_title_Midsummer;
        static double target_price_Midsummer;

        static string if_title_MOBOX;
        static double target_price_MOBOX;

        static string if_title_Time_End;
        static double target_price_Time_End;

        static string if_title_NARAKA;
        static double target_price_NARAKA;

        static string if_title_Orlinski;
        static double target_price_Orlinski;

        static string if_title_Dream;
        static double target_price_Dream;

        static string if_title_BunnyPark;
        static double target_price_BunnyPark;

        static string if_title_Legends;
        static double target_price_Legends;

        static string if_title_OG;
        static double target_price_OG;

        static string if_title_3;
        static double target_price_3;

        static string if_title_2;
        static double target_price_2;

        static string if_title_1;
        static double target_price_1;

        public static void Main(string[] args)
        {
            Console.WriteLine("input count_glob");
            count_glob=Convert.ToInt32(Console.ReadLine());
             
            string json_fiiile;
            using (var wc = new System.Net.WebClient())
                json_fiiile = wc.DownloadString(@"https://raw.githubusercontent.com/dodo-pitsa/json/main/json1.json");

            //
            var tar_price = JsonConvert.DeserializeObject<title_price.Root>(json_fiiile);

           
            if_title_MOBOX = tar_price.Mystery[0].Name;
            target_price_MOBOX = tar_price.Mystery[0].Value;

            if_title_Time_End = tar_price.Mystery[1].Name;
            target_price_Time_End = tar_price.Mystery[1].Value;

            if_title_NARAKA = tar_price.Mystery[2].Name;
            target_price_NARAKA = tar_price.Mystery[2].Value;

            if_title_Orlinski = tar_price.Mystery[3].Name;
            target_price_Orlinski = tar_price.Mystery[3].Value;

            if_title_Dream = tar_price.Mystery[4].Name;
            target_price_Dream = tar_price.Mystery[4].Value; ;

            if_title_BunnyPark = tar_price.Mystery[5].Name;
            target_price_BunnyPark = tar_price.Mystery[5].Value; ;

            if_title_Legends = tar_price.Mystery[6].Name;
            target_price_Legends = tar_price.Mystery[6].Value; ;

            if_title_OG = tar_price.Mystery[7].Name;
            target_price_OG = tar_price.Mystery[7].Value; ;

            if_title_3 = tar_price.Mystery[8].Name;
            target_price_3 = tar_price.Mystery[8].Value; ;

            if_title_2 = tar_price.Mystery[9].Name;
            target_price_2 = tar_price.Mystery[9].Value; ;

            if_title_1 = tar_price.Mystery[10].Name;
            target_price_1 = tar_price.Mystery[10].Value;

            if_title_Midsummer = tar_price.Mystery[11].Name;
            target_price_Midsummer = tar_price.Mystery[11].Value;

            if_title_Zombie = tar_price.Mystery[12].Name;
            target_price_Zombie = tar_price.Mystery[12].Value;

            for (int i=0; tar_price.Mystery.Count>i;i++ )
            {
                Console.WriteLine(tar_price.Mystery[i].Name);
                Console.WriteLine(tar_price.Mystery[i].Value);
            }
            string Bot_ntf_api = "1866819612:AAHKMvSXhcD3tuwub6L07Esp2rn1ExcSbYU";
            Bot_ntf = new TelegramBotClient(Bot_ntf_api); 
            mmeth1();
            Thread.Sleep(4000); 
            Bot_ntf.StartReceiving();
            Thread myThread0 = new Thread(thead012); 
            Thread myThread2 = new Thread(thead345);
            Thread myThread3 = new Thread(thead67);
            Thread myThread4 = new Thread(thead89); 
            myThread0.Start(); 
            myThread2.Start();
            myThread3.Start(); 
            myThread4.Start(); 
            Console.ReadLine();
             


        }



        static void thead012()
        {
             
            int count = 0;
            while (true)
            {

                try
                {
                    var myStopwatch = new System.Diagnostics.Stopwatch();
                    myStopwatch.Start();
                    var cc = id_list012.Any(item => item == prodid012);
                    if ((prodid012.ToString().EndsWith("0") || prodid012.ToString().EndsWith("1") || prodid012.ToString().EndsWith("2")) && cc == false)
                    {
                        string json;
                        var url = "https://www.binance.com/bapi/nft/v1/friendly/nft/nft-trade/product-detail";
                        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                        httpRequest.Method = "POST";
                        httpRequest.Accept = "application/json";
                        httpRequest.ContentType = "application/json";
                        var data = @"{""productId"":" + prodid012 + "}";

                        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                        {
                            streamWriter.Write(data);
                            streamWriter.Close();
                        }

                        StreamReader rsps = new StreamReader(httpRequest.GetResponse().GetResponseStream());
                        json = rsps.ReadToEnd();
                        var s = JsonConvert.DeserializeObject<nft.Root>(json);
                        if (s.Code != "961601012")
                        {
                            try
                            {

                                string Currency = null;
                                string Title = null;
                                int Status = 0;
                                int id = s.Data.ProductDetail.Id;



                                if (s.Data.ProductDetail.Currency != null)
                                {
                                    Currency = s.Data.ProductDetail.Currency;
                                    Title = s.Data.ProductDetail.Title;
                                    Status = s.Data.ProductDetail.Status;

                                }




                                double price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture);
                                string price_peee = price.ToString().Replace(',', '.');
                                //if (s.Data.ProductDetail.BatchNum > 1)
                                //    {
                                //        price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture) / s.Data.ProductDetail.BatchNum;
                                //    }



                                int trade_type = s.Data.ProductDetail.TradeType;
                                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                                string tiiime = null;
                                if (cc == false && s.Data.ProductDetail.ListTime != null)
                                {
                                    long tieunix = Convert.ToInt64(s.Data.ProductDetail.ListTime) / 1000;

                                    tiiime = dtDateTime.AddSeconds(tieunix).ToLocalTime().ToString();

                                    Console.WriteLine(DateTime.Now);
                                    Console.WriteLine(tiiime + "\n" + id + "\n" + price + "\n" + Title);
                                    id_list012.Add(id);
                                }


                                if ( price <= target_price_1 && Title == if_title_1 && trade_type == 0 && Currency == "BUSD")
                                {                               
                                                                       
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);

                                    Console.WriteLine(price + "\n" + Title);
                                   
                                    
                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs+ "Время = {0}"+ myStopwatch.Elapsed);
                                     

                                }
                                if ( price <= target_price_2 && Title == if_title_2 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if ( price <= target_price_3 && Title == if_title_3 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if ( price <= target_price_OG && Title == if_title_OG && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if ( price <= target_price_Legends && Title == if_title_Legends && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if ( price <= target_price_BunnyPark && Title == if_title_BunnyPark && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if ( price <= target_price_Dream && Title == if_title_Dream && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if ( price <= target_price_Orlinski && Title == if_title_Orlinski && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if ( price <= target_price_NARAKA && Title == if_title_NARAKA && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if ( price <= target_price_Time_End && Title == if_title_Time_End && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id,  s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_MOBOX && Title == if_title_MOBOX && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Midsummer && Title == if_title_Midsummer && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Zombie && Title == if_title_Zombie && trade_type == 0 && Currency == "BUSD")
                                {
                                    string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                    

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }

                                httpRequest = null; 
                                myStopwatch.Stop();

                            }
                            catch
                            {

                            }
                        }
                    }

                    prodid012++;
                    count++;
                    // Console.WriteLine(productId);
                    if (count == count_glob)
                    {
                        count = 0;
                        prodid012 = id_list012.Max();
                    }
                }
                catch (Exception ex)
                {
               //     Bot_ntf.SendTextMessageAsync(chanall_id, ex.ToString() +"\n" +productId);
                }

            }
        }
        static void thead345()
        {
        //    Bot_ntf.SendTextMessageAsync(chanall_id, "thead345");
            int count = 0;
            while (true)
            {

                try
                {
                    var myStopwatch = new System.Diagnostics.Stopwatch();
                    myStopwatch.Start();
                    var cc = id_list345.Any(item => item == prodid345);
                    if ((prodid345.ToString().EndsWith("3") || prodid345.ToString().EndsWith("4") || prodid345.ToString().EndsWith("5")) && cc == false)
                    {
                        string json;
                        var url = "https://www.binance.com/bapi/nft/v1/friendly/nft/nft-trade/product-detail";
                        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                        httpRequest.Method = "POST";
                        httpRequest.Accept = "application/json";
                        httpRequest.ContentType = "application/json";
                        var data = @"{""productId"":" + prodid345 + "}";

                        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                        {
                            streamWriter.Write(data);
                            streamWriter.Close();
                        }

                        StreamReader rsps = new StreamReader(httpRequest.GetResponse().GetResponseStream());
                        json = rsps.ReadToEnd();

                        var s = JsonConvert.DeserializeObject<nft.Root>(json);
                        if (s.Code != "961601012")
                        {
                            try
                            {

                                string Currency = null;
                                string Title = null;
                                int Status = 0;
                                int id = s.Data.ProductDetail.Id;



                                if (s.Data.ProductDetail.Currency != null)
                                {
                                    Currency = s.Data.ProductDetail.Currency;
                                    Title = s.Data.ProductDetail.Title;
                                    Status = s.Data.ProductDetail.Status;

                                }




                                double price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture);
                                string price_peee = price.ToString().Replace(',', '.');
                                //if (s.Data.ProductDetail.BatchNum > 1)
                                //    {
                                //        price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture) / s.Data.ProductDetail.BatchNum;
                                //    }



                                int trade_type = s.Data.ProductDetail.TradeType;
                                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                                string tiiime = null;
                                if (cc == false && s.Data.ProductDetail.ListTime != null)
                                {
                                    long tieunix = Convert.ToInt64(s.Data.ProductDetail.ListTime) / 1000;

                                    tiiime = dtDateTime.AddSeconds(tieunix).ToLocalTime().ToString();

                                    Console.WriteLine(DateTime.Now);
                                    Console.WriteLine(tiiime + "\n" + id + "\n" + price + "\n" + Title);
                                    id_list345.Add(id);
                                }


                                if (price <= target_price_1 && Title == if_title_1 && trade_type == 0 && Currency == "BUSD")
                                {

                                      string outs = Sel(price_peee, id); 
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);

                                    Console.WriteLine(price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_2 && Title == if_title_2 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                     

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_3 && Title == if_title_3 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_OG && Title == if_title_OG && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Legends && Title == if_title_Legends && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_BunnyPark && Title == if_title_BunnyPark && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Dream && Title == if_title_Dream && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_Orlinski && Title == if_title_Orlinski && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_NARAKA && Title == if_title_NARAKA && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Time_End && Title == if_title_Time_End && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_MOBOX && Title == if_title_MOBOX && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Midsummer && Title == if_title_Midsummer && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Zombie && Title == if_title_Zombie && trade_type == 0 && Currency == "BUSD")
                                {
                                    string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);


                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }

                                httpRequest = null; 
                                myStopwatch.Stop();
                            }
                            catch
                            {

                            }
                        }
                    }

                    prodid345++;
                    count++;
                    // Console.WriteLine(productId);
                    if (count == count_glob)
                    {
                        count = 0;
                        prodid345 = id_list345.Max();
                    }
                }
                catch (Exception ex)
                {
              //      Bot_ntf.SendTextMessageAsync(chanall_id, ex.ToString());
                }

            }
        } 
        static void thead67()
        {
         //   Bot_ntf.SendTextMessageAsync(chanall_id, "thead67");
            int count = 0;
            while (true)
            {

                try
                {
                    var myStopwatch = new System.Diagnostics.Stopwatch();
                    myStopwatch.Start();
                    var cc = id_list67.Any(item => item == prodid67); 
                    if ((prodid67.ToString().EndsWith("6") || prodid67.ToString().EndsWith("7")) && cc == false)
                    {
                        string json;
                        var url = "https://www.binance.com/bapi/nft/v1/friendly/nft/nft-trade/product-detail";
                        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                        httpRequest.Method = "POST";
                        httpRequest.Accept = "application/json";
                        httpRequest.ContentType = "application/json";
                        var data = @"{""productId"":" + prodid67 + "}";

                        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                        {
                            streamWriter.Write(data);
                            streamWriter.Close();
                        }

                        StreamReader rsps = new StreamReader(httpRequest.GetResponse().GetResponseStream());
                        json = rsps.ReadToEnd();

                        var s = JsonConvert.DeserializeObject<nft.Root>(json);
                        if (s.Code != "961601012")
                        {
                            try
                            {

                                string Currency = null;
                                string Title = null;
                                int Status = 0;
                                int id = s.Data.ProductDetail.Id;



                                if (s.Data.ProductDetail.Currency != null)
                                {
                                    Currency = s.Data.ProductDetail.Currency;
                                    Title = s.Data.ProductDetail.Title;
                                    Status = s.Data.ProductDetail.Status;

                                }




                                double price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture);
                                string price_peee = price.ToString().Replace(',', '.');
                                //if (s.Data.ProductDetail.BatchNum > 1)
                                //    {
                                //        price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture) / s.Data.ProductDetail.BatchNum;
                                //    }



                                int trade_type = s.Data.ProductDetail.TradeType;
                                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                                string tiiime = null;
                                if (cc == false && s.Data.ProductDetail.ListTime != null)
                                {
                                    long tieunix = Convert.ToInt64(s.Data.ProductDetail.ListTime) / 1000;

                                    tiiime = dtDateTime.AddSeconds(tieunix).ToLocalTime().ToString();

                                    Console.WriteLine(DateTime.Now);
                                    Console.WriteLine(tiiime + "\n" + id + "\n" + price + "\n" + Title);
                                    id_list67.Add(id);
                                }

                                if (price <= target_price_1 && Title == if_title_1 && trade_type == 0 && Currency == "BUSD")
                                {

                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);

                                    Console.WriteLine(price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_2 && Title == if_title_2 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_3 && Title == if_title_3 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_OG && Title == if_title_OG && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Legends && Title == if_title_Legends && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_BunnyPark && Title == if_title_BunnyPark && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Dream && Title == if_title_Dream && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_Orlinski && Title == if_title_Orlinski && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_NARAKA && Title == if_title_NARAKA && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Time_End && Title == if_title_Time_End && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_MOBOX && Title == if_title_MOBOX && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Midsummer && Title == if_title_Midsummer && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Zombie && Title == if_title_Zombie && trade_type == 0 && Currency == "BUSD")
                                {
                                    string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);


                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }


                                httpRequest = null;

                                myStopwatch.Stop();
                            }
                            catch
                            {

                            }
                        }
                    }

                    prodid67++;
                    count++;
                    // Console.WriteLine(productId);
                    if (count == count_glob)
                    {
                        count = 0;
                        prodid67 = id_list67.Max();
                    }
                }
                catch (Exception ex)
                {
                 //   Bot_ntf.SendTextMessageAsync(chanall_id, ex.ToString());
                }

            }
        }
        static void thead89()
        {
         //   Bot_ntf.SendTextMessageAsync(chanall_id, "thead89");
            int count = 0;
            while (true)
            {

                try
                {
                    var myStopwatch = new System.Diagnostics.Stopwatch();
                    myStopwatch.Start();
                    var cc = id_list89 .Any(item => item == prodid89); 
                    

                    if ((prodid89.ToString().EndsWith("8") || prodid89.ToString().EndsWith("9")) && cc == false)
                    {
                        string json;
                        var url = "https://www.binance.com/bapi/nft/v1/friendly/nft/nft-trade/product-detail";
                        var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                        httpRequest.Method = "POST";
                        httpRequest.Accept = "application/json";
                        httpRequest.ContentType = "application/json";
                        var data = @"{""productId"":" + prodid89 + "}";

                        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                        {
                            streamWriter.Write(data);
                            streamWriter.Close();
                        }

                        StreamReader rsps = new StreamReader(httpRequest.GetResponse().GetResponseStream());
                        json = rsps.ReadToEnd();

                        var s = JsonConvert.DeserializeObject<nft.Root>(json);
                        if (s.Code != "961601012")
                        {
                            try
                            {

                                string Currency = null;
                            string Title = null; 
                            int id = s.Data.ProductDetail.Id;
                           


                                if (s.Data.ProductDetail.Currency != null)
                                {
                                    Currency = s.Data.ProductDetail.Currency;
                                    Title = s.Data.ProductDetail.Title; 

                                }

                           


                            double price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture); 
                           string price_peee = price.ToString().Replace(',', '.');
                            //if (s.Data.ProductDetail.BatchNum > 1)
                            //    {
                            //        price = double.Parse(s.Data.ProductDetail.Amount, System.Globalization.CultureInfo.InvariantCulture) / s.Data.ProductDetail.BatchNum;
                            //    }


                             
                            int trade_type = s.Data.ProductDetail.TradeType;
                            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                            string tiiime = null;
                            if (cc == false && s.Data.ProductDetail.ListTime != null)
                            {
                                long tieunix = Convert.ToInt64(s.Data.ProductDetail.ListTime) / 1000;

                                    tiiime = dtDateTime.AddSeconds(tieunix).ToLocalTime().ToString();
                                    Console.WriteLine(DateTime.Now);
                                    Console.WriteLine(tiiime + "\n" + id + "\n" + price + "\n" + Title);
                                    id_list89.Add(id);
                                }

                                if (price <= target_price_1 && Title == if_title_1 && trade_type == 0 && Currency == "BUSD")
                                {

                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);

                                    Console.WriteLine(price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_2 && Title == if_title_2 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_3 && Title == if_title_3 && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";

                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_OG && Title == if_title_OG && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);
                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    // Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Legends && Title == if_title_Legends && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_BunnyPark && Title == if_title_BunnyPark && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Dream && Title == if_title_Dream && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_Orlinski && Title == if_title_Orlinski && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);


                                }
                                if (price <= target_price_NARAKA && Title == if_title_NARAKA && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Time_End && Title == if_title_Time_End && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_MOBOX && Title == if_title_MOBOX && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Midsummer && Title == if_title_Midsummer && trade_type == 0 && Currency == "BUSD")
                                {
                                      string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);
                                   

                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }
                                if (price <= target_price_Zombie && Title == if_title_Zombie && trade_type == 0 && Currency == "BUSD")
                                {
                                    string outs = Sel(price_peee, id);

                                    string url_out = "https://www.binance.com/ru/nft/goods/blindBox/detail?productId=" + id + "&isOpen=false&isProduct=1";
                                    Bot_ntf.SendTextMessageAsync(chanall_id, s.Data.ProductDetail.BatchNum + " pack" + "\n" + Title + "\n" + price_peee + "\n" + url_out);
                                    //  Console.WriteLine(dtDateTime.ToString() + "\n" + price + "\n" + Title);


                                    myStopwatch.Stop();

                                    Bot_ntf.SendTextMessageAsync(chanall_id, outs + "Время = {0}" + myStopwatch.Elapsed);

                                }


                                httpRequest = null; 
                                myStopwatch.Stop();
                            }
                            catch
                            {

                            }
                        }
                    }

                    prodid89++;
                    count++; 
                   // Console.WriteLine(productId);
                    if (count == count_glob)
                    {
                        count = 0; 
                        prodid89= id_list89.Max();
                    }
                }
                catch (Exception ex)
                { 
                   // Bot_ntf.SendTextMessageAsync(chanall_id, ex.ToString());
                }

            }
        }

        
        static string Sel(string price, Int64 id)
        {

            try
            { 

                var url = "https://www.binance.com/bapi/nft/v1/private/nft/nft-trade/order-create";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Headers["clienttype"] = "web";
                httpRequest.Headers["cookie"] = @"cid=yg0qixfu; cid=Vk9YQlHp; _ga=GA1.2.649249011.1604941716; bnc-uuid=5f373dd0-5fe9-4cc8-9337-7f27ef4e6cc6; source=yandex.ru; fiat-prefer-currency=RUB; afUserId=de904750-dc56-47e7-8135-b8be739f40ab-o; _hjid=bebc03ff-be03-4f1e-9825-47232b774f5d; __ssid=56373b9ebad26292a2bd25b7b849edf; lastRskxRun=1617007613382; rskxRunCookie=0; rCookie=5bs8mrkvh72mrofo66txekmuckzpk; userPreferredCurrency=USD_USD; nft-init-compliance=true; crypto_deposit_refactor=1; sensorsdata2015jssdkcross=%7B%22distinct_id%22%3A%2217080186%22%2C%22first_id%22%3A%22175adfb1ada810-0c0a3abdaddb2b-230346d-2073600-175adfb1adb94d%22%2C%22props%22%3A%7B%22%24latest_traffic_source_type%22%3A%22%E7%9B%B4%E6%8E%A5%E6%B5%81%E9%87%8F%22%2C%22%24latest_search_keyword%22%3A%22%E6%9C%AA%E5%8F%96%E5%88%B0%E5%80%BC_%E7%9B%B4%E6%8E%A5%E6%89%93%E5%BC%80%22%2C%22%24latest_referrer%22%3A%22%22%7D%2C%22%24device_id%22%3A%22175adfb1ada810-0c0a3abdaddb2b-230346d-2073600-175adfb1adb94d%22%7D; home-ui-ab=B; defaultMarketTab=favorite; s9r1=7A3524F3E8C796EC3D7B196933ECF955; cr00=064D67CF7921257936C4564E7F02A43D; d1og=web.17080186.CEF6E77932F095CC6EDDB888F922BC57; r2o1=web.17080186.1AA56C4D94D294DA6036F6699078E55F; f30l=web.17080186.A24143FFEEBFAA2549BDD6C300370EC5; logined=y; isAccountsLoggedIn=y; __BINANCE_USER_DEVICE_ID__={""807b6dca480ea4a0b3d94c80e53a8341"":{""date"":1627708279633,""value"":""1627708279717x21WdSmNJ3rVixdSsfT""}}; lang=en; p20t=web.17080186.6E54F9C7D1BC71E11E19E0ECF46584D6; BNC_FV_KEY=31fe01a5643ba077a57f5322559e593fc9d9b090; BNC_FV_KEY_EXPIRE=1627819603277";
                httpRequest.Headers["csrftoken"] = "6cb6095611f0b5024196039293ba621a";
                httpRequest.ContentType = "application/json";

                var data = @"{""amount"":""15"",""productId"":""4682124"",""tradeType"":0}
";
                data = data.Replace("15", price);
                data = data.Replace("4682124", id.ToString());
                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }
                HttpWebResponse httpResponse=null; 
                httpResponse = (HttpWebResponse)httpRequest.GetResponse(); 
                               

                var de = new StreamReader(httpResponse.GetResponseStream()).ReadToEnd();
                var status = JsonConvert.DeserializeObject<status.Root>(de); 
                if (status.Code == "000000")
                {
                    status.Code = "Купил";
                     
                }
                if (status.Code == "961601004")
                {
                
                status.Code = "Не успел"; 
                }
                           
            Thread.Sleep(50);
            httpResponse.Close();
            return (status.Code + "\n" + status.Message + "\n" + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Bot_ntf.SendTextMessageAsync(chanall_id, ex.ToString());
                return ex.ToString();
            }

        }
       

     
        static void mmeth1( )
        {
            try
            {

                string json;
                var url = "https://www.binance.com/bapi/nft/v1/public/nft/product-list";
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";
                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";
                var data = "{\"category\":\"0\",\"keyword\":\"\",\"orderBy\":\"list_time\",\"orderType\":-1,\"page\":1,\"rows\":1}";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                    streamWriter.Close();
                }

                StreamReader rsps = new StreamReader(httpRequest.GetResponse().GetResponseStream());
                json = rsps.ReadToEnd();


                var s = JsonConvert.DeserializeObject<JSON.Root>(json);

                productId = Convert.ToInt64(s.Data.Rows[0].ProductId);
                prodid012 = Convert.ToInt64(s.Data.Rows[0].ProductId);
                prodid345 = Convert.ToInt64(s.Data.Rows[0].ProductId);
                prodid67 = Convert.ToInt64(s.Data.Rows[0].ProductId);
                prodid89 = Convert.ToInt64(s.Data.Rows[0].ProductId);
                httpRequest = null;
                //   Console.WriteLine(productId);
                Console.WriteLine(productId);
            }
            catch (Exception ex)
            {
                Bot_ntf.SendTextMessageAsync(chanall_id, ex.ToString());
            }

        }

    }


        // запускаем прием обновлений



    }

