using System;
using System.Collections.Generic;
using System.Linq;
using Tickets.Banco;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class TicketController
    {
        Context context = new Context();
        public TicketController() { }
        public void Incluir(TicketDB ticketDB)
        {           
            if(ticketDB != null)
            {
                context.ticket.Add(ticketDB);
                context.SaveChanges();
            }
        }
        public void Editar(TicketDB ticketDB)
        {
            var ticket = context.ticket.FirstOrDefault(t => t.id_ticket == ticketDB.id_ticket);
            if(ticket != null)
            {
                ticket.id_ticket = ticketDB.id_ticket;
                ticket.fk_funcionario = ticketDB.fk_funcionario;
                ticket.quantidade = ticketDB.quantidade;
                ticket.situacao = ticketDB.situacao;               
                context.SaveChanges();
            }
        }
        public List<TicketDTO> GetTickets()
        {            
            List<TicketDTO> lista;
            return lista = (from tickets in context.ticket
                            orderby tickets.fk_funcionario, tickets.situacao
                            select new TicketDTO
                            {
                                id_ticket = tickets.id_ticket,
                                fk_funcionario = tickets.fk_funcionario,
                                quantidade = tickets.quantidade,
                                situacao = tickets.situacao,
                                dtentrega = tickets.dtentrega
                            }).ToList();
        }
        public List<Relatorio> GetTicketsComFiltro(DateTime dataInicio, DateTime dataFim, bool Agrupar, int codFuncionario)
        {            
            List<Relatorio> listaRelatorio = new List<Relatorio>(),
                            listaResult =  new List<Relatorio>();
            if(codFuncionario > 0)
            {
                //Gerando lista filtrada porém sem agrupamento, Filtrando o Código do Funcionário
                listaRelatorio = (from tickets in context.ticket
                                  join funcionarios in context.funcionario
                                  on tickets.fk_funcionario equals funcionarios.id_funcionario
                                  where ((tickets.fk_funcionario == codFuncionario) && (tickets.dtentrega.Day >= dataInicio.Day && tickets.dtentrega.Day <= dataFim.Day
                                         && tickets.dtentrega.Month >= dataInicio.Month && tickets.dtentrega.Month <= dataFim.Month
                                         && tickets.dtentrega.Year >= dataInicio.Year && tickets.dtentrega.Year <= dataFim.Year))
                                  orderby tickets.fk_funcionario, tickets.situacao
                                  select new Relatorio
                                  {
                                      IdTicket = tickets.id_ticket,
                                      CodFuncionario = tickets.fk_funcionario,
                                      Funcionario = funcionarios.nome,
                                      DataEntrega = tickets.dtentrega,
                                      Situacao = tickets.situacao,
                                      Quantidade = tickets.quantidade
                                  }).ToList();
            }
            else
            {
                //Gerando lista filtrada porém sem agrupamento
                listaRelatorio = (from tickets in context.ticket
                                  join funcionarios in context.funcionario
                                  on tickets.fk_funcionario equals funcionarios.id_funcionario
                                  where (tickets.dtentrega.Day >= dataInicio.Day && tickets.dtentrega.Day <= dataFim.Day
                                         && tickets.dtentrega.Month >= dataInicio.Month && tickets.dtentrega.Month <= dataFim.Month
                                         && tickets.dtentrega.Year >= dataInicio.Year && tickets.dtentrega.Year <= dataFim.Year)
                                  orderby tickets.fk_funcionario, tickets.situacao
                                  select new Relatorio
                                  {
                                      IdTicket = tickets.id_ticket,
                                      CodFuncionario = tickets.fk_funcionario,
                                      Funcionario = funcionarios.nome,
                                      DataEntrega = tickets.dtentrega,
                                      Situacao = tickets.situacao,
                                      Quantidade = tickets.quantidade
                                  }).ToList();
            }                    
            if (Agrupar)
            {
                var listaAgrupada = listaRelatorio.OrderBy(o => o.CodFuncionario)
                    .GroupBy(x => (x.CodFuncionario, x.Funcionario, x.Situacao))
                    .Select(z => new
                    {
                        z.Key.CodFuncionario,
                        z.Key.Funcionario,
                        z.Key.Situacao,
                        Quantidade = z.Sum(s => s.Quantidade)
                    }).ToList();
                //Populando a Lista de relatório.
                foreach (var listaAgr in listaAgrupada)
                {
                    Relatorio relatorio = new Relatorio
                    {
                        CodFuncionario = listaAgr.CodFuncionario,
                        Funcionario = listaAgr.Funcionario,
                        Situacao = listaAgr.Situacao,
                        Quantidade = listaAgr.Quantidade
                    };
                    listaResult.Add(relatorio);
                }
                return listaResult;
            }
            else
                return listaRelatorio;                               
        }
        public TicketDTO GetTicket(int id)
        {
            TicketDTO ticketDTO = new TicketDTO();
            var Ticket = context.ticket.FirstOrDefault(t => t.id_ticket == id);            
            if (Ticket != null)
            {                
                {
                    ticketDTO.id_ticket = Ticket.id_ticket;
                    ticketDTO.fk_funcionario = Ticket.fk_funcionario;
                    ticketDTO.situacao = Ticket.situacao;
                    ticketDTO.quantidade = Ticket.quantidade;
                    ticketDTO.dtentrega = Ticket.dtentrega;
                };
                return ticketDTO;
            }                
            else
                return null;
        }
    }
}
