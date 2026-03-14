using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

public class BibliotecaContext : DbContext {
    public BibliotecaContext(DbContextOptions options) : base(options) {}
    public DbSet<Livro> Livros { get; set; }
}