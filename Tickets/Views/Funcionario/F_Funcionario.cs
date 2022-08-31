using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tickets.Controllers;
using Tickets.Models;

namespace Tickets.Views
{
    public partial class F_Funcionario : Form
    {
        private FuncionarioController funcionarioController = new FuncionarioController();
        private List<FuncionarioDTO> Funcionarios = new List<FuncionarioDTO>();    
        private int IdFuncionario;
        private bool Editar;
        public F_Funcionario()
        {          
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Editar = false;
            F_CadFuncionario f_CadFuncionario = new F_CadFuncionario(Editar);
            f_CadFuncionario.rbInativo.Enabled = false;
            f_CadFuncionario.ShowDialog();
            AtualizaGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            if ((int)dgvFuncionario.CurrentRow.Cells[0].Value > 0)
            {
                IdFuncionario = (int)dgvFuncionario.CurrentRow.Cells[0].Value;
                F_CadFuncionario f_CadFuncionario = new F_CadFuncionario(IdFuncionario, Editar);               
                f_CadFuncionario.PopulaCampos();
                f_CadFuncionario.ShowDialog();
                AtualizaGrid();
            }
            else
                Utils.MessageExclamation("Selecione um funcionário para edição!", "Atenção!");
        }
        private void AjeitaColunasGrid()
        {
            dgvFuncionario.Columns[0].HeaderText = "Id";
            dgvFuncionario.Columns[0].Resizable = DataGridViewTriState.True;
            dgvFuncionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvFuncionario.Columns[1].HeaderText = "Nome";
            dgvFuncionario.Columns[1].Resizable = DataGridViewTriState.True;
            dgvFuncionario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvFuncionario.Columns[2].HeaderText = "Cpf";
            dgvFuncionario.Columns[2].Resizable = DataGridViewTriState.True;
            dgvFuncionario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvFuncionario.Columns[3].HeaderText = "Situação";
            dgvFuncionario.Columns[3].Resizable = DataGridViewTriState.True;
            dgvFuncionario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvFuncionario.Columns[4].HeaderText = "Data/Hora";
            dgvFuncionario.Columns[4].Resizable = DataGridViewTriState.True;
            dgvFuncionario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public void AtualizaGrid()
        {           
            Funcionarios.Clear();
            foreach (FuncionarioDTO func in funcionarioController.GetFuncionarios())
            {
                if (func.situacao == "A")
                    func.situacao = "Ativo";
                else
                    func.situacao = "Inativo";
                Funcionarios.Add(func);
            }           
            dgvFuncionario.DataSource = null;
            dgvFuncionario.DataSource = Funcionarios;
            AjeitaColunasGrid();
        }
        public void F_Funcionario_Shown(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void F_Funcionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
