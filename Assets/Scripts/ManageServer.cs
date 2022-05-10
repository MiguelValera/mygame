using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
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

        public static async void callServerPostTime()
        {
            var url = "http://localhost:4030/upload";
            using var client = new HttpClient();

            var msg = new HttpRequestMessage(HttpMethod.Post, url);
            msg.Headers.Add("userName", "Testing Soro");
            msg.Headers.Add("time", "10");
            await client.SendAsync(msg);
            
        }
    }
}
