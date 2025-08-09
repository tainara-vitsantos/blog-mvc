using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogTainara.Models;
using System.Data;

namespace BlogTainara.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"]= "Olá mundo";
        //Criar objetos
        Categoria categoria = new()
        {
            Id = 1,
            Nome = "Tecnologia"
        };

        
        // Outro modo de manipular um objeto
        Categoria categoria2 = new();
        categoria.Id = 2;
        categoria.Nome = "IA"; 
        

        List<Postagem> postagens = [
            new(){
                Id = 1,
                Nome = "Saiu o ChatGPT 5!",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Now,  // DataPostagem = Date.Time.Parse("08/08/2025"),
                Descricao = "Estou com preguiça de pensar nisso",
                Texto = "Lorem ipsum"
            
            }
        ];


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
