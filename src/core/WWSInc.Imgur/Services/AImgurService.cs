using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WWSInc.Imgur.Models;

namespace WWSInc.Imgur.Services
{
    public abstract class AImgurService
    {
        internal readonly AuthTicketModel Auth;
        internal readonly ServicesSettingsModel Settings;
        internal HttpRequestMessage Request;

        public AImgurService(AuthTicketModel authTicket,
            ServicesSettingsModel imgurServicesSettings)
        {
            Auth = authTicket;
            Settings = imgurServicesSettings;
            Request = new HttpRequestMessage();
        }

        public async Task<Response<T>> GetAsync<T>(HttpRequestMessage request, Uri uri)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Settings.Accept);
                client.DefaultRequestHeaders.Add("User-Agent", Settings.UserAgentName);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Auth.AccessToken}");

                foreach (var header in request.Headers)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
                
                var json = await client.GetStringAsync(uri);
              
                var result = JsonConvert.DeserializeObject<Response<T>>(json);
                return result;
            }
        }

        public async Task<Response<T>> PostAsync<T>(HttpRequestMessage request, HttpContent httpContent, Uri uri)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Settings.Accept);
                client.DefaultRequestHeaders.Add("User-Agent", Settings.UserAgentName);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Auth.AccessToken}");

                using (var message = await client.PostAsync(uri, httpContent))
                {
                    var json = await message.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Response<T>>(json);
                    return result;
                }
            }
        }
    }
}
