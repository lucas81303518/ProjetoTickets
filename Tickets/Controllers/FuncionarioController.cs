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
        public void Incluir(FuncionarioDB funcionario)
        {
            Context context = new Context();
            if(funcionario != null)
            {
                context.funcionario.Add(funcionario);
                context.SaveChanges();
            }            
        }
        public void Editar(FuncionarioDB funcionario)
        {
            try
            {
                Context context = new Context();
                var func = context.funcionario.FirstOrDefault(f => f.id_funcionario == funcionario.id_funcionario);
                if (func != null)
                {
                    func.id_funcionario = funcionario.id_funcionario;
                    func.nome = funcionario.nome;
                    func.cpf = funcionario.cpf;
                    func.situacao = funcionario.situacao;
                    func.dtalteracao = funcionario.dtalteracao;
                    context.SaveChanges();
                }
            }
            catch
            {                
                throw;
            }                     
        }
        public FuncionarioDB GetFuncionario(int id)
        {
            Context context = new Context();
            var funcionario = context.funcionario.FirstOrDefault(f => f.id_funcionario == id);
            if (funcionario != null)
                return funcionario;
            else
                return null;
        }
        public List<FuncionarioDTO> GetFuncionarios()
        {
            Context context = new Context();
            List<FuncionarioDTO> lista;
            lista = (from Funcionarios in context.funcionario
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
    }
}
