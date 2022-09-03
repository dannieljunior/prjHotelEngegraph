
namespace Hotel.Cliente
{
    partial class FrmNovaReserva
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoUh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtaCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtaCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numQtdeAdt = new System.Windows.Forms.NumericUpDown();
            this.numQtdeChd = new System.Windows.Forms.NumericUpDown();
            this.btnConsultaDisponibilidade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTefoneSolicitante = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailSolictante = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusOperacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.mmObservacoes = new System.Windows.Forms.TextBox();
            this.ucBarraBotoesPadrao1 = new Hotel.Cliente.UserControls.ucBarraBotoesPadrao();
            this.ucBadge4 = new Hotel.Cliente.UserControls.ucBadge();
            this.ucBadge3 = new Hotel.Cliente.UserControls.ucBadge();
            this.ucBadge2 = new Hotel.Cliente.UserControls.ucBadge();
            this.ucBadge1 = new Hotel.Cliente.UserControls.ucBadge();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeAdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeChd)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de UH:";
            // 
            // cmbTipoUh
            // 
            this.cmbTipoUh.FormattingEnabled = true;
            this.cmbTipoUh.Location = new System.Drawing.Point(194, 205);
            this.cmbTipoUh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUh.Name = "cmbTipoUh";
            this.cmbTipoUh.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoUh.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "CheckOut:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "CheckIn:";
            // 
            // dtaCheckOut
            // 
            this.dtaCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaCheckOut.Location = new System.Drawing.Point(194, 168);
            this.dtaCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtaCheckOut.Name = "dtaCheckOut";
            this.dtaCheckOut.Size = new System.Drawing.Size(265, 22);
            this.dtaCheckOut.TabIndex = 4;
            // 
            // dtaCheckIn
            // 
            this.dtaCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaCheckIn.Location = new System.Drawing.Point(194, 132);
            this.dtaCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtaCheckIn.Name = "dtaCheckIn";
            this.dtaCheckIn.Size = new System.Drawing.Size(265, 22);
            this.dtaCheckIn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Qtde Adt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Qtde Chd:";
            // 
            // numQtdeAdt
            // 
            this.numQtdeAdt.Location = new System.Drawing.Point(194, 250);
            this.numQtdeAdt.Name = "numQtdeAdt";
            this.numQtdeAdt.Size = new System.Drawing.Size(120, 22);
            this.numQtdeAdt.TabIndex = 6;
            // 
            // numQtdeChd
            // 
            this.numQtdeChd.Location = new System.Drawing.Point(194, 283);
            this.numQtdeChd.Name = "numQtdeChd";
            this.numQtdeChd.Size = new System.Drawing.Size(120, 22);
            this.numQtdeChd.TabIndex = 7;
            // 
            // btnConsultaDisponibilidade
            // 
            this.btnConsultaDisponibilidade.Location = new System.Drawing.Point(477, 198);
            this.btnConsultaDisponibilidade.Name = "btnConsultaDisponibilidade";
            this.btnConsultaDisponibilidade.Size = new System.Drawing.Size(203, 37);
            this.btnConsultaDisponibilidade.TabIndex = 18;
            this.btnConsultaDisponibilidade.TabStop = false;
            this.btnConsultaDisponibilidade.Text = "Consulta Disponibilidade";
            this.btnConsultaDisponibilidade.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Solicitante:";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(194, 57);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(265, 22);
            this.txtSolicitante.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Telefone:";
            // 
            // mskTefoneSolicitante
            // 
            this.mskTefoneSolicitante.BackColor = System.Drawing.SystemColors.Window;
            this.mskTefoneSolicitante.Location = new System.Drawing.Point(538, 57);
            this.mskTefoneSolicitante.Mask = "(99)99999-9999";
            this.mskTefoneSolicitante.Name = "mskTefoneSolicitante";
            this.mskTefoneSolicitante.Size = new System.Drawing.Size(142, 22);
            this.mskTefoneSolicitante.TabIndex = 1;
            // 
            // txtEmailSolictante
            // 
            this.txtEmailSolictante.Location = new System.Drawing.Point(194, 96);
            this.txtEmailSolictante.MaxLength = 40;
            this.txtEmailSolictante.Name = "txtEmailSolictante";
            this.txtEmailSolictante.Size = new System.Drawing.Size(348, 22);
            this.txtEmailSolictante.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 96);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "E-mail Solicitante:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusOperacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1057, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusOperacao
            // 
            this.lblStatusOperacao.Name = "lblStatusOperacao";
            this.lblStatusOperacao.Size = new System.Drawing.Size(118, 17);
            this.lblStatusOperacao.Text = "toolStripStatusLabel1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Observações:";
            // 
            // mmObservacoes
            // 
            this.mmObservacoes.Location = new System.Drawing.Point(194, 327);
            this.mmObservacoes.MaxLength = 200;
            this.mmObservacoes.Multiline = true;
            this.mmObservacoes.Name = "mmObservacoes";
            this.mmObservacoes.Size = new System.Drawing.Size(486, 57);
            this.mmObservacoes.TabIndex = 8;
            // 
            // ucBarraBotoesPadrao1
            // 
            this.ucBarraBotoesPadrao1.ExibirConsulta = false;
            this.ucBarraBotoesPadrao1.ExibirNovo = false;
            this.ucBarraBotoesPadrao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBarraBotoesPadrao1.Location = new System.Drawing.Point(51, 396);
            this.ucBarraBotoesPadrao1.Name = "ucBarraBotoesPadrao1";
            this.ucBarraBotoesPadrao1.Size = new System.Drawing.Size(778, 39);
            this.ucBarraBotoesPadrao1.TabIndex = 8;
            this.ucBarraBotoesPadrao1.OnSalvarClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnSalvarClick);
            this.ucBarraBotoesPadrao1.OnFecharClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnFecharClick);
            // 
            // ucBadge4
            // 
            this.ucBadge4.Display = "Localizador";
            this.ucBadge4.Location = new System.Drawing.Point(792, 9);
            this.ucBadge4.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.ucBadge4.Name = "ucBadge4";
            this.ucBadge4.Size = new System.Drawing.Size(208, 103);
            this.ucBadge4.TabIndex = 37;
            this.ucBadge4.Value = "------";
            // 
            // ucBadge3
            // 
            this.ucBadge3.Display = "Valor Diária";
            this.ucBadge3.Location = new System.Drawing.Point(840, 111);
            this.ucBadge3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucBadge3.Name = "ucBadge3";
            this.ucBadge3.Size = new System.Drawing.Size(160, 103);
            this.ucBadge3.TabIndex = 36;
            this.ucBadge3.Value = "0,00";
            // 
            // ucBadge2
            // 
            this.ucBadge2.Display = "Qtde Noites";
            this.ucBadge2.Location = new System.Drawing.Point(827, 221);
            this.ucBadge2.Margin = new System.Windows.Forms.Padding(5);
            this.ucBadge2.Name = "ucBadge2";
            this.ucBadge2.Size = new System.Drawing.Size(173, 110);
            this.ucBadge2.TabIndex = 35;
            this.ucBadge2.Value = "0";
            // 
            // ucBadge1
            // 
            this.ucBadge1.Display = "Valor Total";
            this.ucBadge1.Location = new System.Drawing.Point(836, 339);
            this.ucBadge1.Margin = new System.Windows.Forms.Padding(4);
            this.ucBadge1.Name = "ucBadge1";
            this.ucBadge1.Size = new System.Drawing.Size(164, 96);
            this.ucBadge1.TabIndex = 34;
            this.ucBadge1.Value = "0,00";
            // 
            // FrmNovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 479);
            this.Controls.Add(this.mmObservacoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucBarraBotoesPadrao1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucBadge4);
            this.Controls.Add(this.ucBadge3);
            this.Controls.Add(this.ucBadge2);
            this.Controls.Add(this.ucBadge1);
            this.Controls.Add(this.txtEmailSolictante);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mskTefoneSolicitante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConsultaDisponibilidade);
            this.Controls.Add(this.numQtdeChd);
            this.Controls.Add(this.numQtdeAdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoUh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaCheckOut);
            this.Controls.Add(this.dtaCheckIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNovaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeAdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeChd)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoUh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtaCheckOut;
        private System.Windows.Forms.DateTimePicker dtaCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQtdeAdt;
        private System.Windows.Forms.NumericUpDown numQtdeChd;
        private System.Windows.Forms.Button btnConsultaDisponibilidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTefoneSolicitante;
        private System.Windows.Forms.TextBox txtEmailSolictante;
        private System.Windows.Forms.Label label16;
        private UserControls.ucBadge ucBadge1;
        private UserControls.ucBadge ucBadge2;
        private UserControls.ucBadge ucBadge3;
        private UserControls.ucBadge ucBadge4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOperacao;
        private UserControls.ucBarraBotoesPadrao ucBarraBotoesPadrao1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mmObservacoes;
    }
}