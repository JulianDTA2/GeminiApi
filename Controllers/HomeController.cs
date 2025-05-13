using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GeminiApi.Models;
using GeminiApi.Repo;
using GeminiApi.Interfaces;

namespace GeminiApi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private IAChatbotService _chatbotService;




    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _chatbotService = new GeminiRepo();
    }

    public async Task<IActionResult> Index()
    {
        var response = await _chatbotService.ObtenerRespuestaChatbot("Resumen de quitofest");
        ViewBag.respuesta = response;
        return View();
    }

}
