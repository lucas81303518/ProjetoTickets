using System;
using System.Drawing;
using System.Windows.Forms;
using Tickets.Controllers;
using Tickets.Models;

namespace Tickets.Views
{
    public partial class F_CadFuncionario : Form
    {
        private FuncionarioController funcionarioController = new FuncionarioController();
        private FuncionarioDB funcionarioDB;
        private int IdFuncionario;
        private bool Editar;

        //Construtor para Inclusão do Funcionário
        public F_CadFuncionario(bool editar)
        {
            Editar = editar;
            InitializeComponent();
        }
        //Construtor para Edição do Funcionário
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
                    funcionarioDB.cpf = Utils.RetiraMascaraCpf(txtCpf.Text);
                    funcionarioDB.situacao = "A";
                    funcionarioDB.dtalteracao = DateTime.Now;
                    funcionarioController.Incluir(funcionarioDB);
                    Utils.MessageInfo("Funcionário cadastrado com sucesso!", "Parabéns!");
                    LimparCampos();
                }
                //Editando
                else
                {
                    if(Utils.MessageYesNo("Deseja alterar os dados do Funcionário?", "Atenção!"))
                    {
                        funcionarioDB.id_funcionario = IdFuncionario;
                        funcionarioDB.nome = txtNome.Text;
                        funcionarioDB.cpf = Utils.RetiraMascaraCpf(txtCpf.Text);
                        if (rbAtivo.Checked)
                            funcionarioDB.situacao = "A";
                        else
                            funcionarioDB.situacao = "I";
                        funcionarioDB.dtalteracao = DateTime.Now;
                        funcionarioController.Editar(funcionarioDB);
                        Utils.MessageInfo("Funcionário editado com sucesso!", "Parabéns!");
                        Close();                        
                    }                    
                }                
            }            
        }
        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
        }
        public bool ValidaCampos()
        {
            if(txtNome.Text == string.Empty)
            {
                Utils.MessageExclamation("Campo nome é obrigatório!", "Atenção!");
                txtNome.Focus();
                return false;
            }
            //Se retornar somente a mascara
            if(txtCpf.Text == "   .   .   -")
            {
                Utils.MessageExclamation("Campo Cpf é obrigatório!", "Atenção!");
                txtCpf.Focus();
                return false;
            }
            //Digitos + mascara = 14
            if (txtCpf.Text.Length != 14)
            {
                Utils.MessageExclamation("Quantidade de caracteres inválidos para Cpf!", "Atenção!");
                txtCpf.Focus();
                return false;
            }
            //Valida se Cpf já existe && Valida se o Cpf existente é o que está sendo editado
            funcionarioDB = funcionarioController.CpfJaExiste(Utils.RetiraMascaraCpf(txtCpf.Text));
            if ((funcionarioDB != null) && (IdFuncionario != funcionarioDB.id_funcionario))
            {
                Utils.MessageExclamation($"Cpf já cadastrado! \n{funcionarioDB.id_funcionario}-{funcionarioDB.nome}", "Atenção!");
                txtCpf.Focus();
                return false;
            }
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

        private void F_CadFuncionario_Shown(object sender, EventArgs e)
        {
            //Incluindo
            if (!Editar)
                lblIncluirOuEditar.Text = "Cadastrar Funcionário";
            else
                lblIncluirOuEditar.Text = "Editar Funcionário";
            int x = (panel1.Size.Width - lblIncluirOuEditar.Width) / 2;
            lblIncluirOuEditar.Location = new Point(x, 8);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {          
            Close();
        }       
    }
}
