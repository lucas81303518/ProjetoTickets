
namespace Tickets.Views.Relatorios
{
    partial class F_FiltroRelatorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIncluirOuEditar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoAgrupar = new System.Windows.Forms.RadioButton();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.cbFuncionarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblIncluirOuEditar);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 38);
            this.panel1.TabIndex = 36;
            // 
            // lblIncluirOuEditar
            // 
            this.lblIncluirOuEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIncluirOuEditar.AutoSize = true;
            this.lblIncluirOuEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirOuEditar.Location = new System.Drawing.Point(82, 8);
            this.lblIncluirOuEditar.Name = "lblIncluirOuEditar";
            this.lblIncluirOuEditar.Size = new System.Drawing.Size(121, 19);
            this.lblIncluirOuEditar.TabIndex = 0;
            this.lblIncluirOuEditar.Text = "Filtrar Relatório";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbFuncionarios);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataFim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataInicio);
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 231);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(146, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 29);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.rbNaoAgrupar);
            this.groupBox1.Controls.Add(this.rbFuncionario);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 29);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // rbNaoAgrupar
            // 
            this.rbNaoAgrupar.AutoSize = true;
            this.rbNaoAgrupar.Checked = true;
            this.rbNaoAgrupar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rbNaoAgrupar.Location = new System.Drawing.Point(7, 2);
            this.rbNaoAgrupar.Name = "rbNaoAgrupar";
            this.rbNaoAgrupar.Size = new System.Drawing.Size(101, 21);
            this.rbNaoAgrupar.TabIndex = 1;
            this.rbNaoAgrupar.TabStop = true;
            this.rbNaoAgrupar.Text = "Não agrupar";
            this.rbNaoAgrupar.UseVisualStyleBackColor = true;
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rbFuncionario.Location = new System.Drawing.Point(121, 2);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(95, 21);
            this.rbFuncionario.TabIndex = 0;
            this.rbFuncionario.Text = "Funcionário";
            this.rbFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(19, 196);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(95, 29);
            this.btnFiltrar.TabIndex = 54;
            this.btnFiltrar.Text = "Exibir";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Agrupar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Data início";
            // 
            // dataFim
            // 
            this.dataFim.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFim.Location = new System.Drawing.Point(146, 153);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(95, 22);
            this.dataFim.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Data início";
            // 
            // dataInicio
            // 
            this.dataInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(19, 153);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(95, 22);
            this.dataInicio.TabIndex = 48;
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionarios.FormattingEnabled = true;
            this.cbFuncionarios.Items.AddRange(new object[] {
            "Todos."});
            this.cbFuncionarios.Location = new System.Drawing.Point(19, 37);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(222, 25);
            this.cbFuncionarios.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Funcionário";
            // 
            // F_FiltroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "F_FiltroRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.F_FiltroRelatorio_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIncluirOuEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbNaoAgrupar;
        public System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFuncionarios;
    }
}