using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;
using DBModel;

namespace Dashboard
{
    public class webApiClass
    {

        public static JArray marker { get; set; }


        readonly string baseUri = "https://recrespite-3c13b.firebaseio.com/";


        public List<Models.Article> GetArticles()
        {
            string uri =  baseUri+ "articles2/articles.json";




            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Models.Article>>(response.Result).Result;
            }

        }

        public List<Models.Event> GetEvents()
        {
            string uri =  baseUri+ "events / events.json";




            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Models.Event>>(response.Result).Result;
            }

        }
    




    public List<Models.Article> GetArticle(int id)
    {
        string uri = baseUri + "articles2/articles"+id+".json";




        using (HttpClient httpClient = new HttpClient())
            {
                WebClient c = new WebClient();
                var data = c.DownloadString("https://recrespite-3c13b.firebaseio.com/articles2/articles/"+id+".json");
                //Console.WriteLine(data);
                JArray o = JArray.Parse("["+data+"]");

                String[] categories;
                //  var firstItem = o[0]["Title"]
                List<Models.Article> art = new List<Models.Article>();
                art.Add(new Models.Article { articleId = o[0]["articleId"].ToString(), name = o[0]["name"].ToString(), articleImage = o[0]["articleImage"].ToString(), articlePDF = o[0]["articlePDF"].ToString(), description = o[0]["description"].ToString() });
                return art;
        }

    }

}



}

