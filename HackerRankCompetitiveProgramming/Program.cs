using HackerRankCompetitiveProgramming._30DaysOfCode;
using HackerRankCompetitiveProgramming.InterviewPreparation.WarmUpChallenges;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCompetitiveProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            InProgress();
            // Solved();
            // UnSolved();
        }

        static void InProgress()
        {
            Day8DictionariesAndMaps day8DictionariesAndMaps = new Day8DictionariesAndMaps();
        }

        static void Solved()
        {
            // SockMerchant sockMerchant = new SockMerchant();
        }

        static void UnSolved()
        {
            SockMerchant sockMerchant = new SockMerchant();
        }


        static void MainAxia(string[] args)
        {
            SampleDllTesting sampleDllTesting = new SampleDllTesting();

            sampleDllTesting.DllTesting();

            ShowRestaurants();

            string loginUrl = "http://apps.demo.zanibal.com/ebclient/rest/api/v1/security/login/customer?username=pac_doubra&password=password";
            string createOrderUrl = "http://apps.demo.zanibal.com/ebclient/rest/api/v1/order/tradeorder/submit";
            DasboardOrder t = new DasboardOrder();
            t.CreateOrder2(createOrderUrl);
           
            var result = t.GetAsync(loginUrl).GetAwaiter().GetResult();
            Console.WriteLine(result);
            



            // var GetResponse = GetAsync("http://apps.demo.zanibal.com/ebclient/rest/api/v1/security/login/customer?username=pac_doubra&password=password");
            // BasicGet1();
            // GetSampleToken();
            //Console.WriteLine("Hello World!");
        }

        public static void CreateOrder1()
        {

        }

        
        public static void BasicGet1()
        {
            try
            {
                string html = string.Empty;
                string url = @"http://apps.demo.zanibal.com/ebclient/rest/api/v1/security/login/customer?username=pac_doubra&password=password";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Content-Type", "application/json");
                request.Headers.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");

                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                Console.WriteLine(html);
            }
            catch (Exception ex)
            {
                // throw;
            }
        }
        private static async Task<string> GetAccessToken()
        {
            string baseUrl = "http://apps.demo.zanibal.com/ebclient/rest/api/v1/security/login/customer?username=pac_doubra&password=password";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                // We want the response to be JSON.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Build up the data to POST.
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                //postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                //postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                //postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);

                // Post to the Server and parse the response.
                HttpResponseMessage response = await client.PostAsync("Token", content);
                string jsonString = await response.Content.ReadAsStringAsync();
                object responseData = JsonConvert.DeserializeObject(jsonString);

                // return the Access Token.
                return ((dynamic)responseData).access_token;
            }
        }

        public static void GetSampleToken()
        {
            try
            {
                string pathapi = "http://apps.demo.zanibal.com/ebclient/rest/api/v1/security/login/customer?username=pac_doubra&password=password";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(pathapi);
                request.Method = "GET";
                string postData = "grant_type=password";
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(postData);

                request.ContentType = "application/json";
                request.Headers.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");

                request.ContentLength = byte1.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(byte1, 0, byte1.Length);

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string getreaderjson = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
        }


        private static void ShowRestaurants()
        {
            var responseCreateOrder = ZomatoInfo.CreateOrder();
            var responseLogin = ZomatoInfo.GetLogin();
            var response = ZomatoInfo.GetRestaurants();

            var restaurants = response.Restaurants;

            Console.WriteLine($"Results found : {response.ResultsFound}");
            Console.WriteLine($"Results shown : {response.ResultsShown}");
            Console.WriteLine();

            Console.WriteLine($"{"ID",-10} {"NAME",-40} {"CUISINES",-50} {"LOCATION",-40}");
            foreach (var r in restaurants)
            {
                var restaurant = r.Restaurant;

                Console.WriteLine($"{restaurant.ID,-10} {restaurant.Name,-40} {restaurant.Cuisines,-50} {restaurant.Location.LocalityVerbose,-40}");
            }

            Console.ReadLine();
        }
    }


    public class SampleDllTesting
    {
        public void DllTesting()
        {
            try
            {
                Assembly asm = Assembly.LoadFrom(@"D:\test dll\HackerRankCompetitiveProgramming.dll");
                Type t = asm.GetType("HackerRankCompetitiveProgramming.Simple");

                dynamic instance = Activator.CreateInstance(t);
                var response = instance.Example();

                //var customResponse = instance.CustomExample()
            }
            catch (Exception ex)
            {
                // throw;
            }
        }
    }

    public class DasboardOrder
    {
        public string myJson = "{'Username': 'myusername','Password':'pass'}";
        public static string myOrder = @"{
                        'portfolioName' : '0000001201',
                        'securityName' : 'ACCESS',
                        'priceType' : 'MARKET',
                        'orderDate' : '09/21/2020',
                        'orderOrigin' : 'WEB',
                        'orderType' : 'BUY',
                        'quantityRequested' : '10',
                        'orderCurrency' : 'NGN',
                        'orderTermName' :'0000000001'
                        }";

        public async Task<string> GetAsync(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }


        public static void CreateOrder()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://apps.demo.zanibal.com/ebclient/rest/api/v1/order/tradeorder/submit");

                var postData = "thing1=" + Uri.EscapeDataString("hello");
                postData += "&thing2=" + Uri.EscapeDataString("world");
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public void CreateOrder2(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                httpWebRequest.Headers.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    //string json = "{\"user\":\"test\"," +
                    //"\"password\":\"bla\"}";

                    //streamWriter.Write(json);
                    streamWriter.Write(myOrder);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                // throw;
            }
        }
    }


    public static class ZomatoInfo
    {
        const string url = "https://developers.zomato.com/api/v2.1/";
        const string apiKey = "749b7981ff9e98b3b0ed487c17028e6e";

        public static RestaurantList GetRestaurants()
        {
            string urlParameters = $"search?entity_id=59&entity_type=city&apikey={apiKey}";
            var response = APICall.RunAsync<RestaurantList>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }

        public static LoginResponse GetLogin()
        {
            const string urlLogin = "http://apps.demo.zanibal.com/ebclient/rest/api/v1/security/login/customer";
            string urlParameters = "?username=pac_doubra&password=password";
            var response2 = APICall.RunAsync2<LoginResponse>(urlLogin, urlParameters).GetAwaiter().GetResult();
            var response = APICall.RunAsync<LoginResponse>(urlLogin, urlParameters).GetAwaiter().GetResult();
            return response;
        }

        public static LoginResponse CreateOrder()
        {
            const string urlLogin = "http://apps.demo.zanibal.com/ebclient/rest/api/v1/order/tradeorder/submit";
            string urlParameters = "";// "?username=pac_doubra&password=password";
            var response = APICall.RunPostAsync<LoginResponse>(urlLogin, urlParameters).GetAwaiter().GetResult();
            // var response = APICall.RunAsync<LoginResponse>(urlLogin, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }

    public static class APICall
    {
        private static HttpClient GetHttpClient(string url)
        {
            var client = new HttpClient { BaseAddress = new Uri(url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            client.DefaultRequestHeaders.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");
            return client;
        }

        private static HttpWebRequest GetHttpClient2(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            return request;
        }

        private static HttpWebRequest PostHttpClient(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Authorization", "Basic cm9vdDpBZG1pbiQxMjM0");

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            return request;
        }

        private static async Task<T> GetAsync<T>(string url, string urlParameters)
        {
            try
            {
                using (var client = GetHttpClient(url))
                {
                    HttpResponseMessage response = await client.GetAsync(urlParameters);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<T>(json);
                        return result;
                    }
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }

        private static async Task<T> GetAsync2<T>(string url, string urlParameters)
        {
            try
            {
                HttpWebRequest request = GetHttpClient2(url+urlParameters);
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    if(response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            var json = await reader.ReadToEndAsync();
                            var result = JsonConvert.DeserializeObject<T>(json);
                            return result;
                        } 
                    }
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }

        public static async Task<T> RunAsync<T>(string url, string urlParameters)
        {
            return await GetAsync<T>(url, urlParameters);
        }

        public static async Task<T> RunAsync2<T>(string url, string urlParameters)
        {
            return await GetAsync2<T>(url, urlParameters);
        }

        public static async Task<T> RunPostAsync<T>(string url, string urlParameters)
        {
            return await PostAsync<T>(url, urlParameters);
        }

        private static async Task<T> PostAsync<T>(string url, string urlParameters)
        {
            try
            {
                string myOrder = @"{
                        'portfolioName' : '0000001201',
                        'securityName' : 'ACCESS',
                        'priceType' : 'MARKET',
                        'orderDate' : '09/21/2020',
                        'orderOrigin' : 'WEB',
                        'orderType' : 'BUY',
                        'quantityRequested' : '10',
                        'orderCurrency' : 'NGN',
                        'orderTermName' :'0000000001'
                        }";
        HttpWebRequest request = PostHttpClient(url + urlParameters);

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(myOrder);
                }

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            var json = await reader.ReadToEndAsync();
                            var result = JsonConvert.DeserializeObject<T>(json);
                            return result;
                        }
                    }
                    else
                    {
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            var json = await reader.ReadToEndAsync();
                            var result = JsonConvert.DeserializeObject<T>(json);
                            //return result;
                        }
                        return default(T);
                    }
                    
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }
    }

    public class Location
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("locality_verbose")]
        public string LocalityVerbose { get; set; }
    }

    public class RestaurantRecord
    {
        [JsonProperty("restaurant")]
        public Restaurant Restaurant { get; set; }
    }
    public class Restaurant
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("cuisines")]
        public string Cuisines { get; set; }

        [JsonProperty("average_cost_for_two")]
        public int AverageCostForTwo { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RestaurantList
    {
        [JsonProperty("results_found")]
        public int ResultsFound { get; set; }

        [JsonProperty("results_shown")]
        public int ResultsShown { get; set; }

        [JsonProperty("restaurants")]
        public RestaurantRecord[] Restaurants { get; set; }
    }

    public class LoginResponse
    {
        [JsonProperty("msgArgs")]
        public string[] MsgArgs { get; set; }

        [JsonProperty("msgCode")]
        public string MsgCode { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class Simple
    {
        public string Example()
        {
            return "Kalakaar!!";
        }

        public string CustomExample(string customInput)
        {
            return "Good Job!! " + customInput;
        }
    }
}
