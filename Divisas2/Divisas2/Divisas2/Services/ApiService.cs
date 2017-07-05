using Android.App;
using Android.Content;
using Android.Net;
using Divisas2.Models;
using Java.Net;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Divisas2.Services
{
    public class ApiService
    {
        public async Task<Response> CheckConnection()
        {
            ConnectivityManager connectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
            if (!(activeConnection != null))
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Please turn on your internet.",
                };
            }

            var isReachable = await IsRemoteReachable("https://www.google.com");
            if (!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Check you internet connection.",
                };
            }

            return new Response
            {
                IsSuccess = true,
                Message = "Ok",
            };
        }

        public async Task<bool> IsRemoteReachable(string url)
        {
            try
            {
                URL myUrl = new URL(url);
                URLConnection connection = myUrl.OpenConnection();
                connection.ConnectTimeout = 3000;
                await connection.ConnectAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

