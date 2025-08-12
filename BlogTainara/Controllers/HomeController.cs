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
        
        //Criar objetos
        Categoria tecnologia = new()
        {
            Id = 1,
            Nome = "Tecnologia"
        };

        
        // Outro modo de manipular um objeto
        Categoria ia = new();
        ia.Id = 2;
        ia.Nome = "IA"; 

        Categoria eletronico = new(3, "Eletrônicos"); 
        

        List<Postagem> postagens = new List<Postagem>
{
    new Postagem
    {
        Id = 1,
        Nome = "A tecnologia é um servo útil, mas um mestre perigoso",
        CategoriaId = 1,
        Categoria = tecnologia,
        DataPostagem = DateTime.Now,
        Descricao = "A tecnologia está evoluindo mais rápido do que a capacidade humana.",
        Texto = "A arte desafia a tecnologia e a tecnologia inspira a arte.",
        Thumbnail = "~/img/tec.jpg",
        Foto = "~/img/tec.jpg"
    },
    new Postagem
    {
        Id = 2,
        Nome = "A verdadeira questão da IA não é se máquinas podem pensar, mas se os homens podem.",
        CategoriaId = 2,
        Categoria = ia,
        DataPostagem = DateTime.Now,
        Descricao = "A IA é o novo ouro. Quem souber usar, liderará o mercado.",
        Texto = "A IA sem controle pode se tornar a pior invenção da civilização humana.",
        Thumbnail = "~/img/ia.jpg",
        Foto = "~/img/ia.jpg"
    },
    new Postagem
    {
        Id = 3,
        Nome = "Hardware é o que você chuta. Software é o que você xinga.",
        CategoriaId = 3,
        Categoria = eletronico,
        DataPostagem = DateTime.Now,
        Descricao = "Computador: onde a esperança encontra a frustração.",
        Texto = "O hardware é o corpo, o software a alma.",
        Thumbnail = "img/"
        Foto = "~/img/hardware.jpg"
    }
};



        return View(postagens);
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
