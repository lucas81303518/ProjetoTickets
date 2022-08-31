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

namespace Tickets.Views.Relatorios
{
    public partial class F_Relatorio : Form
    {        
        private List<Relatorio> relatorios = new List<Relatorio>();
        private TicketController ticketController = new TicketController();
        private DateTime DataInicio, DataFim;
        private bool Agrupar;
        private int CodFuncionario;
      
        public F_Relatorio(DateTime dataInicio, DateTime dataFim, bool agrupar, int codFuncionario)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            Agrupar = agrupar;
            CodFuncionario = codFuncionario;
            InitializeComponent();
        }

        private void PopulaTabela()
        {            
            relatorios.Clear();
            relatorios = ticketController.GetTicketsComFiltro(DataInicio, DataFim, Agrupar, CodFuncionario);
            foreach  (Relatorio rel in relatorios)
            {
                if (rel.Situacao == "A")
                    rel.Situacao = "Ativo";
                else
                    rel.Situacao = "Inativo";
            }
            dgvRelatorio.DataSource = null;
            dgvRelatorio.DataSource = relatorios;
            AjeitaColunasGrid();
        }
        private void AjeitaColunasGrid()
        {
            if(Agrupar)
            {
                //Desabilita colunas da Grid (IdTicket, Data)
                dgvRelatorio.Columns[0].Visible = false;
                dgvRelatorio.Columns[3].Visible = false;
            }
            else
            {
                dgvRelatorio.Columns[1].HeaderText = "Cód. Ticket";

                dgvRelatorio.Columns[3].HeaderText = "Data/Hora";
                dgvRelatorio.Columns[3].Resizable = DataGridViewTriState.True;
                dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dgvRelatorio.Columns[1].HeaderText = "Cód";

            dgvRelatorio.Columns[2].HeaderText = "Nome";
            dgvRelatorio.Columns[2].Resizable = DataGridViewTriState.True;
            dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;                                

            dgvRelatorio.Columns[4].HeaderText = "Quantidade";

            dgvRelatorio.Columns[5].HeaderText = "Situação";
        }
        private void F_Relatorio_Shown(object sender, EventArgs e)
        {
            int TotalTickets = 0;
            PopulaTabela();
            if (Agrupar)            
                Titulo.Text = "Relatório de Tickets por funcionário";                                           
            else
                Titulo.Text = "Relatório Geral de Tickets";
            //Centralizando Titulo...
            int x = (pnlCabecalho.Size.Width - Titulo.Width) / 2;          
            Titulo.Location = new Point(x, Titulo.Size.Height);
            dataHoraAtual.Text = DateTime.Now.ToString("G");
            Periodo.Text = "Período de: " + DataInicio.ToString("d") + " até: " + DataFim.ToString("d");
            lblQtdRegistros.Text = relatorios.Count.ToString("N2");
            foreach (Relatorio rel in relatorios)
            {
                TotalTickets += rel.Quantidade;
            }
            lblTotalTickets.Text = TotalTickets.ToString("N2");            
        }              
    }
}
