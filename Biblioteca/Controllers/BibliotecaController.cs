using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller{
    public IActionResult Index(){

        List<Livro> l1 = new List<Livro>(){
            new Livro {
                Titulo = "Harry Potter",
                NumPaginas = 150,
                Autor = "Fulano",
                Genero = "Fantasia",
                DataPublicacao = DateOnly.MaxValue
            },
            new Livro {
                Titulo = "Alice no País das Maravilhas",
                NumPaginas = 500,
                Autor = "Ciclano",
                Genero = "Romance",
                DataPublicacao = new DateOnly(2000,01,01)
            }
        };
        return View(l1);
    }
}