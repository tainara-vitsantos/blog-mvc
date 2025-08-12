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

        Categoria front = new(4, "frontend");
            Categoria seguranca = new(4, "dados");
                Categoria cloud= new(4, "nuvem");


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
        Thumbnail = "/img/tec.jpg",
        Foto = "/img/tec.jpg"
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
        Thumbnail = "/img/ia.jpg",
        Foto = "/img/ia.jpg"

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
        Thumbnail = "/img/hardware.jpg",
        Foto = "/img/hardware.jpg"
    },
    new Postagem
    {
    Id = 4,
    Nome = "Front-end: a interface que conecta usuário e ideia.",
    CategoriaId = 4,
    Categoria = front,
    DataPostagem = DateTime.Now,
    Descricao = "HTML, CSS e JavaScript trabalhando juntos para transformar design em experiência.",
    Texto = "O front-end é a camada visível do software: onde usabilidade, acessibilidade e performance se encontram para encantar o usuário.",
    Thumbnail = "/img/front.jpg",
    Foto = "/img/front.jpg"

    },

     new Postagem
    {
        Id = 5,
        Nome = "Segurança digital: o escudo invisível da web.",
        CategoriaId = 5,
        Categoria = seguranca,
        DataPostagem = DateTime.Now,
        Descricao = "A informação é o novo petróleo — proteja-a.",
        Texto = "Um sistema seguro é construído antes do ataque, não depois.",
        Thumbnail = "/img/security.jpg",
        Foto = "/img/security.jpg"
    },
    new Postagem
    {
        Id = 6,
        Nome = "Cloud computing: o céu não é o limite.",
        CategoriaId = 6,
        Categoria = cloud,
        DataPostagem = DateTime.Now,
        Descricao = "Serviços escaláveis e acessíveis de qualquer lugar.",
        Texto = "A nuvem é mais do que armazenamento: é flexibilidade e poder de processamento.",
        Thumbnail = "/img/cloud.jpg",
        Foto = "/img/cloud.jpg"
    },
};





        return View(postagens);
    }

    public IActionResult Postagem()
    {
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
