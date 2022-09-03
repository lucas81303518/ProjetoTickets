using NUnit.Framework;
using System;
using System.Configuration;
using Tickets.Controllers;
using Tickets.Models;

namespace Testes
{
    public class Tests
    {
        TicketController ticketController;
        [SetUp]
        public void Setup()
        {
            ticketController = new TicketController();
        }

        [Test]
        public void Test1()
        {                        
            TicketDB ticketDB = new()
            {
                fk_funcionario = 1,
                dtentrega = DateTime.Now,
                quantidade = 100,
                situacao = "A"
            };
            var result = ticketController.Incluir(ticketDB);
            Assert.True(result);
        }
    }
}