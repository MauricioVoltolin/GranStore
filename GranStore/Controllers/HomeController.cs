using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = new()
        {
            new Categoria { Id = 1, Nome = "Celular" },
            new Categoria { Id = 2, Nome = "Computador" },
            new Categoria { Id = 3, Nome = "Notebook" },
            new Categoria { Id = 4, Nome = "Armazenamento" },
            new Categoria { Id = 5, Nome = "Monitor" },
            new Categoria { Id = 6, Nome = "Placa de Vídeo" },
            new Categoria { Id = 7, Nome = "Memória RAM" },
            new Categoria { Id = 8, Nome = "Fonte" },
            new Categoria { Id = 9, Nome = "Teclado" },
            new Categoria { Id = 10, Nome = "Mouse" },
        };

        List<Produto> produtos = new()
        {
            new Produto { Id = 1, Nome = "Samsung S24+", Descricao = "Celular da Samsung", Categoria = categorias[1], QtdeEstoque = 10, ValorCusto = 3000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/1.png" },
            new Produto { Id = 2, Nome = "Computador Completo I5", Descricao = "Computador Completo", Categoria = categorias[2], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/2.png" },
            new Produto { Id = 3, Nome = "Notebook Acer Nitro", Descricao = "Notebook Gamer", Categoria = categorias[3], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/3.png" },
            new Produto { Id = 4, Nome = "SSD 480GB", Descricao = "SSD melhor que HD", Categoria = categorias[4], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/4.png" },
            new Produto { Id = 5, Nome = "Monitor LG 24", Descricao = "Monitor Grande", Categoria = categorias[5], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/5.png" },
            new Produto { Id = 6, Nome = "RTX 6050", Descricao = "Placa de Vídeo Nova", Categoria = categorias[6], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/6.png" },
            new Produto { Id = 7, Nome = "Memória RAM DDR 32GB", Descricao = "Memória RAM cara demais", Categoria = categorias[7], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/7.png" },
            new Produto { Id = 8, Nome = "Fonte 500W Gold", Descricao = "Fonte boa", Categoria = categorias[8], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/8.png" },
            new Produto { Id = 9, Nome = "Teclado Husky 60%", Descricao = "Teclado pequeno", Categoria = categorias[9], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/9.png" },
            new Produto { Id = 10, Nome = "Mouse Readragon", Descricao = "Mouse com switch ruim", Categoria = categorias[9], QtdeEstoque = 10, ValorCusto = 2000.00m, ValorVenda = 4000.00m, Foto = "/img/produtos/10.png" }
        };

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
