using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    [Table("ticket", Schema = "public")]
   public class TicketDB
    {
        [Key]
        public int id_ticket { get; set; }
        public int fk_funcionario { get; set; }
        public int quantidade { get; set; }
        public string situacao { get; set; }
        public DateTime dtentrega { get; set; }
    }
}
