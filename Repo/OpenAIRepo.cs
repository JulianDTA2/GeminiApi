using GeminiApi.Interfaces;

namespace GeminiApi.Repo
{
    public class OpenAIRepo : IAChatbotService
    {
        public Task<string> ObtenerRespuestaChatbot(string prompt)
        {
            throw new NotImplementedException();
        }
        public bool GuardarRespuestaBDDLocal(string prompt, string respuesta)
        {
            throw new NotImplementedException();
        }

    }
}
