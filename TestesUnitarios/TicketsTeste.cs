using System;
using Tickets.Controllers;
using Tickets.Models;
using Xunit;

namespace TestesUnitarios
{
    public class TicketsTeste
    {  
        [Fact]
        public void IncluirTicketTeste()
        {
            TicketController ticketController = new TicketController();
            TicketDB ticketDB = new()
            {
                fk_funcionario = 1,
                dtentrega = DateTime.Now,
                quantidade = 100,
                situacao = "A"
            };          
            Assert.True(ticketController.Incluir(ticketDB));
        }
    }
}
