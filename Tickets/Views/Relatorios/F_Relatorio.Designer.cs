
namespace Tickets.Views.Relatorios
{
    partial class F_Relatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.Periodo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataHoraAtual = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCabecalho.BackColor = System.Drawing.Color.Silver;
            this.pnlCabecalho.Controls.Add(this.Titulo);
            this.pnlCabecalho.Controls.Add(this.Periodo);
            this.pnlCabecalho.Controls.Add(this.pictureBox1);
            this.pnlCabecalho.Controls.Add(this.dataHoraAtual);
            this.pnlCabecalho.Location = new System.Drawing.Point(1, 1);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(615, 102);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // Periodo
            // 
            this.Periodo.AutoSize = true;
            this.Periodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periodo.Location = new System.Drawing.Point(181, 61);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(253, 17);
            this.Periodo.TabIndex = 9;
            this.Periodo.Text = "Periodo de: 18/04/2022 até 22/08/2022";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(180, 25);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(240, 22);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "Relatório Geral de Tickets";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tickets.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataHoraAtual
            // 
            this.dataHoraAtual.AutoSize = true;
            this.dataHoraAtual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataHoraAtual.Location = new System.Drawing.Point(489, 8);
            this.dataHoraAtual.Name = "dataHoraAtual";
            this.dataHoraAtual.Size = new System.Drawing.Size(108, 17);
            this.dataHoraAtual.TabIndex = 2;
            this.dataHoraAtual.Text = "15/10/2022 15:10";
            // 
            // pnlRodape
            // 
            this.pnlRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRodape.BackColor = System.Drawing.Color.Silver;
            this.pnlRodape.Controls.Add(this.lblTotalTickets);
            this.pnlRodape.Controls.Add(this.label3);
            this.pnlRodape.Controls.Add(this.lblQtdRegistros);
            this.pnlRodape.Controls.Add(this.label1);
            this.pnlRodape.Location = new System.Drawing.Point(1, 356);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(615, 67);
            this.pnlRodape.TabIndex = 1;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTickets.Location = new System.Drawing.Point(550, 42);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(47, 17);
            this.lblTotalTickets.TabIndex = 7;
            this.lblTotalTickets.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Tickets:";
            // 
            // lblQtdRegistros
            // 
            this.lblQtdRegistros.AutoSize = true;
            this.lblQtdRegistros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistros.Location = new System.Drawing.Point(550, 14);
            this.lblQtdRegistros.Name = "lblQtdRegistros";
            this.lblQtdRegistros.Size = new System.Drawing.Size(47, 17);
            this.lblQtdRegistros.TabIndex = 5;
            this.lblQtdRegistros.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Registros:";
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelatorio.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRelatorio.Location = new System.Drawing.Point(1, 101);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(615, 259);
            this.dgvRelatorio.TabIndex = 8;
            // 
            // F_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 425);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlCabecalho);
            this.Name = "F_Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.F_Relatorio_Shown);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label dataHoraAtual;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblQtdRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Periodo;
        private System.Windows.Forms.Label Titulo;
    }
}