using System.Data.Entity;
using Tickets.Models;

namespace Tickets.Banco
{
    public class Context:DbContext {
        public Context() : base("TicketRefeicao") { }
        public DbSet<FuncionarioDB> funcionario { get; set; }
        public DbSet<TicketDB>ticket { get; set; }
    } 
    
}
