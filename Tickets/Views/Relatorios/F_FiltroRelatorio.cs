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
    public partial class F_FiltroRelatorio : Form
    {
        public F_FiltroRelatorio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbFuncionarios.Items.Count > 1)
            {
                //Caso RadioButton de funcionário esteja Marcado: Agrupar = true          
                bool Agrupar = rbFuncionario.Checked;
                int codFuncionario = 0;
                //Caso tenha selecionado algo que não seja Todos.
                if(cbFuncionarios.SelectedIndex > 0)                
                    codFuncionario = Convert.ToInt32(cbFuncionarios.Text.Substring(0, Utils.GetPos(cbFuncionarios.Text)));              
                F_Relatorio f_RelatorioGeral = new F_Relatorio(dataInicio.Value.Date, dataFim.Value.Date, Agrupar, codFuncionario);
                f_RelatorioGeral.ShowDialog();
            }
            else
                Utils.MessageExclamation("Você não possui tickets registrados.", "Atenção!");
        }
        private void PopulaComboboxFuncionario()
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            cbFuncionarios.Items.Clear();
            cbFuncionarios.Items.Add("Todos.");
            foreach (FuncionarioDTO func in funcionarioController.GetFuncionarios())
            {
                cbFuncionarios.Items.Add(func.ToString());
            }
            if (cbFuncionarios.Items.Count > 0)
                cbFuncionarios.SelectedIndex = 0;
        }

        private void F_FiltroRelatorio_Shown(object sender, EventArgs e)
        {
            PopulaComboboxFuncionario();
            cbFuncionarios.SelectedIndex = 0;
        }
    }
}
