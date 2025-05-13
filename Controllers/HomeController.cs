using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GeminiApi.Models;
using GeminiApi.Repo;
using GeminiApi.Interfaces;

namespace GeminiApi.Controllers;

public class HomeController : Controller
{
    private IAChatbotService _chatbotService;

    public HomeController(IAChatbotService chatbotService)
    {
        _chatbotService = chatbotService;
    }

    public async Task<IActionResult> Index()
    {
        var response = await _chatbotService.ObtenerRespuestaChatbot("Resumen de quitofest");
        ViewBag.respuesta = response;
        return View();
    }
}
