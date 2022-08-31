using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class FuncionarioDTO
    {
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string situacao { get; set; }
        public DateTime dtalteracao { get; set; }
        public override string ToString()
        {
            return $"{id_funcionario} - {nome}";
        }
    }
}
