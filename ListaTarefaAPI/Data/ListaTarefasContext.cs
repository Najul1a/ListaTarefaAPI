using ListaTarefaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefaAPI.Data
{
    public class ListaTarefasContext : DbContext
    {
        public ListaTarefasContext
            (DbContextOptions<ListaTarefasContext> options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }

        public DbSet<TipoTarefa> TipoTarefa { get; set; }

    }
}
