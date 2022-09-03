
namespace Hotel.Cliente
{
    partial class FrmCadUh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoUh = new System.Windows.Forms.ComboBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusOperacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucBarraBotoesPadrao1 = new Hotel.Cliente.UserControls.ucBarraBotoesPadrao();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(163, 79);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 15;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(280, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // txtBloco
            // 
            this.txtBloco.Location = new System.Drawing.Point(163, 123);
            this.txtBloco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloco.MaxLength = 15;
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(280, 22);
            this.txtBloco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bloco:";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(163, 170);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNivel.MaxLength = 15;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(280, 22);
            this.txtNivel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nível:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de UH:";
            // 
            // cmbTipoUh
            // 
            this.cmbTipoUh.FormattingEnabled = true;
            this.cmbTipoUh.Location = new System.Drawing.Point(163, 218);
            this.cmbTipoUh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUh.Name = "cmbTipoUh";
            this.cmbTipoUh.Size = new System.Drawing.Size(280, 24);
            this.cmbTipoUh.TabIndex = 7;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(163, 265);
            this.cmbSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(280, 24);
            this.cmbSituacao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Situação:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusOperacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(835, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusOperacao
            // 
            this.lblStatusOperacao.Name = "lblStatusOperacao";
            this.lblStatusOperacao.Size = new System.Drawing.Size(118, 17);
            this.lblStatusOperacao.Text = "toolStripStatusLabel2";
            // 
            // ucBarraBotoesPadrao1
            // 
            this.ucBarraBotoesPadrao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBarraBotoesPadrao1.Location = new System.Drawing.Point(30, 361);
            this.ucBarraBotoesPadrao1.Name = "ucBarraBotoesPadrao1";
            this.ucBarraBotoesPadrao1.Size = new System.Drawing.Size(778, 39);
            this.ucBarraBotoesPadrao1.TabIndex = 15;
            this.ucBarraBotoesPadrao1.OnNovoClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnNovoClick);
            this.ucBarraBotoesPadrao1.OnSalvarClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnSalvarClick);
            this.ucBarraBotoesPadrao1.OnConsultaClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnConsultaClick);
            // 
            // FrmCadUh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 554);
            this.Controls.Add(this.ucBarraBotoesPadrao1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoUh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBloco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadUh";
            this.Text = "Cadstro de UH";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoUh;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOperacao;
        private UserControls.ucBarraBotoesPadrao ucBarraBotoesPadrao1;
    }
}