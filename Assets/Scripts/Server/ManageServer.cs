using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using UnityEngine;

public class ManageServer : MonoBehaviour
{


    public class ServerManagement
    {
        public static async void callServerGetResults()
        {

            using var client = new HttpClient();
            string url = "http://localhost:4030/results";
            var result = await client.GetStringAsync(url);
            Debug.Log(result);

        }

        public static async void callServerPostTime(string time, string username)
        {
            string usernameToSend = HttpUtility.HtmlEncode(username.ToString());
            var url = "http://localhost:4030/upload";
            using var client = new HttpClient();
            var msg = new HttpRequestMessage(HttpMethod.Post, url);
            msg.Headers.Add("userName", usernameToSend);
            msg.Headers.Add("time", "3");
            await client.SendAsync(msg);
            
        }
    }
}

//username.Trim()