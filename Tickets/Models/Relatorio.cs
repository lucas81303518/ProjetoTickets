using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Relatorio
    {        
        public int IdTicket { get; set; }
        public int CodFuncionario { get; set; }
        public string Funcionario { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Quantidade { get; set; }
        public string Situacao { get; set; }

    }
}
