
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
            this.btnRelatorioGeral = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.btnRelatórios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuncionarios,
            this.btnTickets});
            this.funcionáriosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(180, 26);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(180, 26);
            this.btnTickets.Text = "Tickets";
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelatorioGeral});
            this.btnRelatórios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(97, 25);
            this.btnRelatórios.Text = "Relatórios";
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(230, 26);
            this.btnRelatorioGeral.Text = "Relatório de Tickets";
            this.btnRelatorioGeral.Click += new System.EventHandler(this.btnRelatorioGeral_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 28);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(754, 374);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 403);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem btnRelatorioGeral;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}

