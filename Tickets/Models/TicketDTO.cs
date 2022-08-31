using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class TicketDTO
    {     
        public int id_ticket { get; set; }       
        public int fk_funcionario { get; set; }
        public int quantidade { get; set; }
        public string situacao { get; set; }
        public DateTime dtentrega { get; set; }
    }
}
