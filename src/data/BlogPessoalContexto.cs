using BlogPessoal.src.modelos;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlogPessoal.src.data
{
    public class BlogPessoalContexto : DbContext
    {
        public DbSet<UsuarioModelo> Usuarios { get; set; }
        public DbSet<TemaModelo> Temas { get; set; }
        public DbSet<PostagemModelos> Postagens { get; set; }

        public BlogPessoalContexto(DbContextOptions<BlogPessoalContexto> opt) : base(opt)
        {

        }
    }
}
