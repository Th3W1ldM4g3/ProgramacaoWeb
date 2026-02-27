using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller{
    public IActionResult Index(){

        List<Livro> l1 = new List<Livro>(){
            new Livro {
                l1.titulo = "Harry Potter",
                l1.numPaginas = 150,
                l1.autor = "Fulano",
                l1.genero = "Fantasia",
                l1.dataPublicacao = DateOnly.MaxValue
            },
            new Livro {
                l1.titulo = "Alice no País das Maravilhas",
                l1.numPaginas = 500,
                l1.autor = "Ciclano",
                l1.genero = "Romance",
                l1.dataPublicacao = new DateOnly(2000,01,01)
            }
        };
        return View(l1);
    }
}