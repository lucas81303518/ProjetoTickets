using System;
using System.Windows.Forms;
using Tickets.Views;
using Tickets.Views.Relatorios;

namespace Tickets
{
    public partial class F_Principal : Form
    {
        private F_Funcionario f_Funcionario;
        private F_Tickets f_Tickets;
        private F_FiltroRelatorio f_FiltroRelatorio;
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {         
            if (f_Funcionario == null || f_Funcionario.IsDisposed)
            {
                f_Funcionario = new F_Funcionario();
                Utils.CentralizaTela(f_Funcionario, pnlPrincipal);
            }
            else                       
                f_Funcionario.BringToFront();                                       
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            if (f_Tickets == null || f_Tickets.IsDisposed)
            {
                f_Tickets = new F_Tickets(pnlPrincipal);
                Utils.CentralizaTela(f_Tickets, pnlPrincipal);
            }
            else
                f_Tickets.BringToFront();                      
        }

        private void btnRelatorioGeral_Click(object sender, EventArgs e)
        {
            if (f_FiltroRelatorio == null || f_FiltroRelatorio.IsDisposed)
            {
                f_FiltroRelatorio = new F_FiltroRelatorio();
                Utils.CentralizaTela(f_FiltroRelatorio, pnlPrincipal);
            }
            else
                f_FiltroRelatorio.BringToFront();                                          
        }
    }
}
