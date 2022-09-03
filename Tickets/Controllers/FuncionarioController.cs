using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Banco;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class FuncionarioController
    {
        private readonly Context _context;
        public FuncionarioController()
        {
            _context = new Context();
        }
        public bool Incluir(FuncionarioDB funcionario)
        {
            if (funcionario != null)
            {
                _context.funcionario.Add(funcionario);
                _context.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool Editar(FuncionarioDB funcionario)
        {                          
            var func = _context.funcionario.FirstOrDefault(f => f.id_funcionario == funcionario.id_funcionario);
            if (func != null)
            {
                func.id_funcionario = funcionario.id_funcionario;
                func.nome = funcionario.nome;
                func.cpf = funcionario.cpf;
                func.situacao = funcionario.situacao;
                func.dtalteracao = funcionario.dtalteracao;
                _context.SaveChanges();
                return true;
            }
            else
                return false;                                           
        }
        public FuncionarioDB GetFuncionario(int id)
        {         
            var funcionario = _context.funcionario.FirstOrDefault(f => f.id_funcionario == id);
            if (funcionario != null)
                return funcionario;
            else
                return null;
        }
        public List<FuncionarioDTO> GetFuncionarios()
        {          
            List<FuncionarioDTO> lista;
            lista = (from Funcionarios in _context.funcionario
                                           orderby Funcionarios.id_funcionario
                                           select new FuncionarioDTO
                                           {
                                               id_funcionario = Funcionarios.id_funcionario,
                                               nome = Funcionarios.nome,
                                               cpf = Funcionarios.cpf,
                                               dtalteracao = Funcionarios.dtalteracao,
                                               situacao = Funcionarios.situacao
                                           }).ToList();
            foreach (FuncionarioDTO Func in lista)
            {
                Func.cpf = Utils.AplicaMascaraCpf(Func.cpf);
            }
            return lista;
        }
        //Retorna o Funcionario com o Cpf existente
        public FuncionarioDB CpfJaExiste(string cpf)
        {            
            var funcionario = _context.funcionario.FirstOrDefault(f => f.cpf == cpf);
            if (funcionario != null)
                return funcionario;
            else
                return null;
        }
    }
}
