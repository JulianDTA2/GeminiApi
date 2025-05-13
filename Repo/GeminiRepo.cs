using GeminiApi.Interfaces;
using GeminiApi.Models;
using Newtonsoft.Json;
using System.Text;

namespace GeminiApi.Repo
{
    public class GeminiRepo : IAChatbotService
    {

        private HttpClient _httpClient;
        private readonly string GeminiApiKey = "AIzaSyAjrvrnpZOWzq-NJ5kmS2WoYTXRrpJkHYM";

        public GeminiRepo() 
        { 
            _httpClient = new HttpClient();
        }
        public async Task<string> ObtenerRespuestaChatbot(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyAjrvrnpZOWzq-NJ5kmS2WoYTXRrpJkHYM";

            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text = prompt
                            }
                        }
                    }
                }
            };
            string json_data = JsonConvert.SerializeObject(request);
            var content = new StringContent(json_data, Encoding.UTF8, "aplication/json");
            var response = await _httpClient.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }
        public bool GuardarRespuestaBDDLocal(string prompt, string respuesta)
        {
            throw new NotImplementedException();
        }
    }
}
