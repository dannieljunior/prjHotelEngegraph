
namespace Hotel.Cliente
{
    partial class FrmCheckIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgVwReserva = new System.Windows.Forms.DataGridView();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeAdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeChd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUhDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEstadiaPrevisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmObervacoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbUhs = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgVwHospedes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVwReserva)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVwHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgVwReserva);
            this.groupBox1.Controls.Add(this.mmObervacoes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1017, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Reserva";
            // 
            // dtgVwReserva
            // 
            this.dtgVwReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVwReserva.BackgroundColor = System.Drawing.Color.White;
            this.dtgVwReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVwReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solicitante,
            this.Estadia,
            this.Situacao,
            this.QtdeAdt,
            this.QtdeChd,
            this.TipoUhDescricao,
            this.ValorEstadiaPrevisto});
            this.dtgVwReserva.Location = new System.Drawing.Point(7, 22);
            this.dtgVwReserva.Name = "dtgVwReserva";
            this.dtgVwReserva.ReadOnly = true;
            this.dtgVwReserva.RowTemplate.ReadOnly = true;
            this.dtgVwReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVwReserva.ShowCellErrors = false;
            this.dtgVwReserva.ShowEditingIcon = false;
            this.dtgVwReserva.ShowRowErrors = false;
            this.dtgVwReserva.Size = new System.Drawing.Size(993, 79);
            this.dtgVwReserva.TabIndex = 12;
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "Solicitante";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.ReadOnly = true;
            this.Solicitante.Width = 200;
            // 
            // Estadia
            // 
            this.Estadia.DataPropertyName = "Estadia";
            this.Estadia.HeaderText = "Estadia";
            this.Estadia.Name = "Estadia";
            this.Estadia.ReadOnly = true;
            this.Estadia.Width = 225;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "SituacaoReservaDescricao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // QtdeAdt
            // 
            this.QtdeAdt.DataPropertyName = "QtdeAdt";
            this.QtdeAdt.HeaderText = "Adultos";
            this.QtdeAdt.Name = "QtdeAdt";
            this.QtdeAdt.ReadOnly = true;
            this.QtdeAdt.Width = 50;
            // 
            // QtdeChd
            // 
            this.QtdeChd.DataPropertyName = "QtdeChd";
            this.QtdeChd.HeaderText = "Crianças";
            this.QtdeChd.Name = "QtdeChd";
            this.QtdeChd.ReadOnly = true;
            this.QtdeChd.Width = 50;
            // 
            // TipoUhDescricao
            // 
            this.TipoUhDescricao.DataPropertyName = "TipoUhDescricao";
            this.TipoUhDescricao.HeaderText = "Tipo de UH";
            this.TipoUhDescricao.Name = "TipoUhDescricao";
            this.TipoUhDescricao.ReadOnly = true;
            this.TipoUhDescricao.Width = 200;
            // 
            // ValorEstadiaPrevisto
            // 
            this.ValorEstadiaPrevisto.DataPropertyName = "ValorEstadiaPrevisto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorEstadiaPrevisto.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorEstadiaPrevisto.HeaderText = "Valor Total";
            this.ValorEstadiaPrevisto.Name = "ValorEstadiaPrevisto";
            this.ValorEstadiaPrevisto.ReadOnly = true;
            this.ValorEstadiaPrevisto.Width = 125;
            // 
            // mmObervacoes
            // 
            this.mmObervacoes.Location = new System.Drawing.Point(11, 131);
            this.mmObervacoes.Multiline = true;
            this.mmObervacoes.Name = "mmObervacoes";
            this.mmObervacoes.ReadOnly = true;
            this.mmObervacoes.Size = new System.Drawing.Size(989, 51);
            this.mmObervacoes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observações";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Selecione a UH:";
            // 
            // cmbUhs
            // 
            this.cmbUhs.FormattingEnabled = true;
            this.cmbUhs.Location = new System.Drawing.Point(160, 226);
            this.cmbUhs.Name = "cmbUhs";
            this.cmbUhs.Size = new System.Drawing.Size(186, 24);
            this.cmbUhs.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtgVwHospedes);
            this.groupBox2.Location = new System.Drawing.Point(16, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 187);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóspedes";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgVwHospedes
            // 
            this.dtgVwHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVwHospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Classe,
            this.GeneroDescricao});
            this.dtgVwHospedes.Location = new System.Drawing.Point(98, 21);
            this.dtgVwHospedes.Name = "dtgVwHospedes";
            this.dtgVwHospedes.ReadOnly = true;
            this.dtgVwHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVwHospedes.Size = new System.Drawing.Size(910, 155);
            this.dtgVwHospedes.TabIndex = 14;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NomeCompleto";
            this.Nome.HeaderText = "Hóspede";
            this.Nome.Name = "Nome";
            this.Nome.Width = 250;
            // 
            // Classe
            // 
            this.Classe.DataPropertyName = "ClassiFicacaoHospede";
            this.Classe.HeaderText = "Classificação";
            this.Classe.Name = "Classe";
            this.Classe.Width = 150;
            // 
            // GeneroDescricao
            // 
            this.GeneroDescricao.DataPropertyName = "GeneroDescricao";
            this.GeneroDescricao.HeaderText = "Genero";
            this.GeneroDescricao.Name = "GeneroDescricao";
            this.GeneroDescricao.Width = 150;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbUhs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCheckIn";
            this.Text = "Check-In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVwReserva)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVwHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbUhs;
        private System.Windows.Forms.TextBox mmObervacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgVwReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeAdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeChd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUhDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEstadiaPrevisto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgVwHospedes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroDescricao;
    }
}