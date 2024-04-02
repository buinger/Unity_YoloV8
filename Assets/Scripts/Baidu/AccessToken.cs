using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace com.baidu.ai
{
    public static class AccessToken
    {
        public static string apiKey = "ek4stEhxjdaMkou979ejpDPh";              //填写自己的apiKey(请改成自己的)
        public static string secretKey = "hcGrtORkKk4UP14HcPAxyMDG0X8Ic1Ca";         //填写自己的secretKey

        public static String getAccessToken()
        {
            String authHost = "https://aip.baidubce.com/oauth/2.0/token";
            HttpClient client = new HttpClient();
            List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
            paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            paraList.Add(new KeyValuePair<string, string>("client_id", apiKey));
            paraList.Add(new KeyValuePair<string, string>("client_secret", secretKey));

            HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            Debug.Log(result);
            string[] tokens = result.Split(new string[] { "\"access_token\":\"", "\",\"scope" }, StringSplitOptions.RemoveEmptyEntries);
            result = tokens[1];
            return result;
        }
    }
}