using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tickets.Controllers;
using Tickets.Models;

namespace Tickets.Views
{
    public partial class F_Tickets : Form
    {
        //Classe somente para visualizar dados na Grid de Tickets
        public class TicketsGrid{
            public int Id { get; set; }
            public string Funcionário { get; set; }
            public int Quantidade { get; set; }
            public string Situacao { get; set; }
            public DateTime DtEntrega { get; set; }
        }
        private TicketController ticketController = new TicketController();        
        private List<TicketsGrid> ticketsGrid = new List<TicketsGrid>();
        Panel Panel;
        private int IdTicket;
        private bool Editar;
        public F_Tickets(Panel panel)
        {
            Panel = panel;
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Editar = false;
            F_CadTickets f_cadTickets = new F_CadTickets(Editar);
            f_cadTickets.rbInativo.Enabled = false;
            f_cadTickets.ShowDialog();
            AtualizaGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            if(ticketsGrid.Count > 0)
            {                
                if ((int)dgvTickets.CurrentRow.Cells[0].Value > 0)
                {
                    IdTicket = (int)dgvTickets.CurrentRow.Cells[0].Value;
                    F_CadTickets f_cadTickets = new F_CadTickets(Editar, IdTicket);
                    f_cadTickets.PopulaCampos();
                    f_cadTickets.ShowDialog();                   
                    AtualizaGrid();
                }
            }                       
        }
        private void AjeitaCampos()
        {
            dgvTickets.Columns[0].HeaderText = "Id";
            dgvTickets.Columns[0].Resizable = DataGridViewTriState.True;
            dgvTickets.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvTickets.Columns[1].HeaderText = "Funcionário";
            dgvTickets.Columns[1].Resizable = DataGridViewTriState.True;
            dgvTickets.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvTickets.Columns[2].HeaderText = "Quantidade";
            dgvTickets.Columns[2].Resizable = DataGridViewTriState.True;
            dgvTickets.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvTickets.Columns[3].HeaderText = "Situação";
            dgvTickets.Columns[3].Resizable = DataGridViewTriState.True;
            dgvTickets.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvTickets.Columns[4].HeaderText = "Data/Hora";
            dgvTickets.Columns[4].Resizable = DataGridViewTriState.True;
            dgvTickets.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void AtualizaGrid()
        {
            ticketsGrid.Clear();
            FuncionarioController funcionarioController = new FuncionarioController();            
            foreach  (TicketDTO ticket in ticketController.GetTickets())
            {
                //Pegando cada funionário
                FuncionarioDB funcionarioDB = funcionarioController.GetFuncionario(ticket.fk_funcionario);
                if (ticket.situacao == "A")
                    ticket.situacao = "Ativo";
                else
                    ticket.situacao = "Inativo";
                TicketsGrid ticketGrid = new TicketsGrid
                {
                    Id = ticket.id_ticket,
                    Funcionário = funcionarioDB.nome,
                    Quantidade = ticket.quantidade,
                    Situacao = ticket.situacao,
                    DtEntrega = ticket.dtentrega
                };
                ticketsGrid.Add(ticketGrid);
            }                       
            dgvTickets.DataSource = null;
            dgvTickets.DataSource = ticketsGrid;
            AjeitaCampos();
        }
        private void F_Tickets_Shown(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
