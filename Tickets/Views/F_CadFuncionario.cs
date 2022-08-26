using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Controllers;
using Tickets.Models;

namespace Tickets.Views
{
    public partial class F_CadFuncionario : Form
    {
        private FuncionarioController funcionarioController = new FuncionarioController();
        private int IdFuncionario;
        private bool Editar;
        public F_CadFuncionario(bool editar)
        {
            Editar = editar;
            InitializeComponent();
        }
        public F_CadFuncionario(int idFuncionario, bool editar)
        {
            IdFuncionario = idFuncionario;
            Editar = editar;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                FuncionarioDB funcionarioDB = new FuncionarioDB();                
                //Adicionando
                if (!Editar)
                {
                    funcionarioDB.nome = txtNome.Text;
                    funcionarioDB.cpf = Utils.RetiraPontos(txtCpf.Text);
                    funcionarioDB.situacao = "A";
                    funcionarioDB.dtalteracao = DateTime.Now;
                    funcionarioController.Incluir(funcionarioDB);
                    Utils.MessageInfo("Funcionário cadastrado com sucesso!", "Parabéns!");
                }
                //Editando
                else
                {
                    funcionarioDB.id_funcionario = IdFuncionario;
                    funcionarioDB.nome = txtNome.Text;
                    funcionarioDB.cpf = Utils.RetiraPontos(txtCpf.Text);
                    if(rbAtivo.Checked)
                        funcionarioDB.situacao = "A";
                    else
                        funcionarioDB.situacao = "I";
                    funcionarioDB.dtalteracao = DateTime.Now;
                    funcionarioController.Editar(funcionarioDB);
                    Utils.MessageInfo("Funcionário editado com sucesso!", "Parabéns!");
                }
                LimparCampos();
            }            
        }
        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
        }
        private bool ValidaCampos()
        {
            if(txtNome.Text == string.Empty)
            {
                Utils.MessageExclamation("Campo nome é obrigatório!", "Atenção!");
                txtNome.Focus();
                return false;
            }
            if(txtCpf.Text == string.Empty)
            {
                Utils.MessageExclamation("Campo Cpf é obrigatório!", "Atenção!");
                txtCpf.Focus();
                return false;
            }
            //if (CpfJaExiste())
            //{
            //    Utils.MessageExclamation("Cpf já cadastrado!", "Atenção!");
            //    txtCpf.Focus();
            //    return false;
            //}
            return true;
        }
        public void PopulaCampos()
        {
            FuncionarioDB funcionarioDB = funcionarioController.GetFuncionario(IdFuncionario);
            if (funcionarioDB != null)
            {
                txtNome.Text = funcionarioDB.nome;
                txtCpf.Text = funcionarioDB.cpf;
                if (funcionarioDB.situacao == "A")
                    rbAtivo.Checked = true;
                else
                    rbInativo.Checked = true;                
            }
        }
    }
}
