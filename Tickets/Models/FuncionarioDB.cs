using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets.Models
{
    [Table("funcionario", Schema = "public")]
    public class FuncionarioDB
    {
        [Key]
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string situacao{ get; set; }
        public DateTime dtalteracao { get; set; }
    }
}
