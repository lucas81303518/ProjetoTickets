
namespace Tickets
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioPorFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.btnRelatórios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuncionarios,
            this.btnTickets});
            this.funcionáriosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(156, 22);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(156, 22);
            this.btnTickets.Text = "Tickets";
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioGeralToolStripMenuItem,
            this.relatórioPorFuncionárioToolStripMenuItem});
            this.btnRelatórios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(83, 21);
            this.btnRelatórios.Text = "Relatórios";
            // 
            // relatórioGeralToolStripMenuItem
            // 
            this.relatórioGeralToolStripMenuItem.Name = "relatórioGeralToolStripMenuItem";
            this.relatórioGeralToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.relatórioGeralToolStripMenuItem.Text = "Relatório Geral";
            // 
            // relatórioPorFuncionárioToolStripMenuItem
            // 
            this.relatórioPorFuncionárioToolStripMenuItem.Name = "relatórioPorFuncionárioToolStripMenuItem";
            this.relatórioPorFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.relatórioPorFuncionárioToolStripMenuItem.Text = "Relatório por Funcionário";
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 302);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem btnTickets;
        private System.Windows.Forms.ToolStripMenuItem btnRelatórios;
        private System.Windows.Forms.ToolStripMenuItem relatórioGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioPorFuncionárioToolStripMenuItem;
    }
}

