using System;
using System.Drawing;
using System.Windows.Forms;
using Tickets.Controllers;
using Tickets.Models;

namespace Tickets.Views
{
    public partial class F_CadTickets : Form
    {
        private TicketController ticketController = new TicketController();
        private int IdTicket;
        private bool Editar;
        //Construtor para Inclusão
        public F_CadTickets(bool editar)
        {
            Editar = editar;
            InitializeComponent();
        }
        //Construtor para Edição
        public F_CadTickets(bool editar, int id_ticket)
        {
            IdTicket = id_ticket;
            Editar = editar;
            InitializeComponent();
        }
        public void PopulaCbFuncionario()
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            cbFuncionario.Items.Clear();
            foreach (FuncionarioDTO func in funcionarioController.GetFuncionarios())
            {
                cbFuncionario.Items.Add(func.ToString());
            }
            if (cbFuncionario.Items.Count > 0)
                cbFuncionario.SelectedIndex = 0;
        }

        private void F_CadTickets_Shown(object sender, EventArgs e)
        {            
            //Incluindo
            if (!Editar)
            {
                PopulaCbFuncionario();
                lblIncluirOuEditar.Text = "Cadastrar Ticket";
            }                
            else
                lblIncluirOuEditar.Text = "Editar Ticket";
            int x = (panel1.Size.Width - lblIncluirOuEditar.Width) / 2;          
            lblIncluirOuEditar.Location = new Point(x, 8);
        }
        private bool ValidaCampos()
        {
            if(cbFuncionario.Items.Count <= 0)
            {
                Utils.MessageExclamation("Você não possui Funcionário(s) cadastrado(s), primeiro cadastre um funcionário para depois criar um Ticket!", "Atenção!");                
                return false;
            }           
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {                
                TicketDB ticketDB = new TicketDB();
                //Incluindo
                if (!Editar)
                {                    
                    ticketDB.fk_funcionario = Convert.ToInt32(cbFuncionario.Text.Substring(0, Utils.GetPos(cbFuncionario.Text)));
                    ticketDB.situacao = "A";
                    ticketDB.quantidade = Convert.ToInt32(numericQtd.Value);
                    ticketDB.dtentrega = DateTime.Now;
                    ticketController.Incluir(ticketDB);
                    Utils.MessageInfo("Ticket cadastrado com sucesso.", "Parabéns!");
                    LimpaCampos();
                }
                //Editando
                else
                {
                    ticketDB.id_ticket = IdTicket;
                    ticketDB.fk_funcionario = Convert.ToInt32(cbFuncionario.Text.Substring(0, Utils.GetPos(cbFuncionario.Text)));
                    if (rbAtivo.Checked)
                        ticketDB.situacao = "A";
                    else
                        ticketDB.situacao = "I";
                    ticketDB.quantidade = Convert.ToInt32(numericQtd.Value);                    
                    ticketController.Editar(ticketDB);
                    Utils.MessageInfo("Ticket editado com sucesso.", "Parabéns!");
                    Close();
                }
            }            
        }
        public void PopulaCampos()
        {           
            //Preenche o Combobox com todos funcionários
            PopulaCbFuncionario();
            TicketDTO ticketDTO = ticketController.GetTicket(IdTicket);
            if(ticketDTO != null)
            {
                int i = 0;
                //Pegando o index do Combobox
                FuncionarioController funcionarioController = new FuncionarioController();
                foreach (FuncionarioDTO func in funcionarioController.GetFuncionarios())
                {
                    if (func.id_funcionario == ticketDTO.fk_funcionario)
                        break;
                    i++;
                }                
                cbFuncionario.SelectedIndex = i;
                numericQtd.Value = ticketDTO.quantidade;
                if (ticketDTO.situacao == "A")
                    rbAtivo.Checked = true;
                else
                    rbInativo.Checked = true;
            }
        }  
        private void LimpaCampos()
        {
            cbFuncionario.Items.Clear();
            PopulaCbFuncionario();
            numericQtd.Value = 1;
        }
    }
}
