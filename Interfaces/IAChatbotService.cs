namespace GeminiApi.Interfaces
{
    public interface IAChatbotService
    {
        public Task <string> ObtenerRespuestaChatbot(string prompt);
        public bool GuardarRespuestaBDDLocal(string prompt,string respuesta);
    }
}
