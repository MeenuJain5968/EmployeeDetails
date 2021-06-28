using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace RESTAPIDemo
{
    static class RestHelper
    {
        private static readonly string baseURL = "https://gorest.co.in/public-api/";
        private static readonly string accessToken = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

       public static async Task<string> GetAll(string pageNumber,string totalPages)
        {

            if (int.Parse(pageNumber) > int.Parse(totalPages))
                pageNumber = totalPages;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users"+ "?page="+pageNumber))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();                                                
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static string JsonFormat(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Newtonsoft.Json.Formatting.Indented);
        }

        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> InsertDetails(string name, string gender, string email, string status)
        {
            var inputData = new Dictionary<string, string>
            {
               {"name",name},
               { "gender",gender},
               {"email", email},
               {"status",status }
             };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                using (HttpResponseMessage res = await client.DeleteAsync(baseURL + "users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        
                        MessageBox.Show(((int)res.StatusCode).ToString() + '-' + res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
    
