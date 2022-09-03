
namespace Hotel.Cliente
{
    partial class FrmHospede
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkEstrangeiro = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.dtaNascimento = new System.Windows.Forms.DateTimePicker();
            this.mmEndereco = new System.Windows.Forms.TextBox();
            this.ucBarraBotoesPadrao1 = new Hotel.Cliente.UserControls.ucBarraBotoesPadrao();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusOperacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SobreNome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dt. Nascimento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(358, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(208, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(113, 28);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(81, 20);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            this.rbFeminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(15, 28);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(87, 20);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço:";
            // 
            // mskTefone
            // 
            this.mskTefone.BackColor = System.Drawing.SystemColors.Window;
            this.mskTefone.Location = new System.Drawing.Point(143, 112);
            this.mskTefone.Margin = new System.Windows.Forms.Padding(4);
            this.mskTefone.Mask = "(99)99999-9999";
            this.mskTefone.Name = "mskTefone";
            this.mskTefone.Size = new System.Drawing.Size(196, 22);
            this.mskTefone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefone:";
            // 
            // chkEstrangeiro
            // 
            this.chkEstrangeiro.AutoSize = true;
            this.chkEstrangeiro.Location = new System.Drawing.Point(470, 124);
            this.chkEstrangeiro.Margin = new System.Windows.Forms.Padding(4);
            this.chkEstrangeiro.Name = "chkEstrangeiro";
            this.chkEstrangeiro.Size = new System.Drawing.Size(96, 20);
            this.chkEstrangeiro.TabIndex = 6;
            this.chkEstrangeiro.Text = "Estrangeiro";
            this.chkEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(444, 12);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(196, 22);
            this.txtSobreNome.TabIndex = 1;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(143, 76);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(196, 22);
            this.txtDocumento.TabIndex = 4;
            // 
            // dtaNascimento
            // 
            this.dtaNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaNascimento.Location = new System.Drawing.Point(143, 42);
            this.dtaNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtaNascimento.Name = "dtaNascimento";
            this.dtaNascimento.Size = new System.Drawing.Size(196, 22);
            this.dtaNascimento.TabIndex = 2;
            // 
            // mmEndereco
            // 
            this.mmEndereco.Location = new System.Drawing.Point(143, 151);
            this.mmEndereco.Multiline = true;
            this.mmEndereco.Name = "mmEndereco";
            this.mmEndereco.Size = new System.Drawing.Size(423, 50);
            this.mmEndereco.TabIndex = 7;
            // 
            // ucBarraBotoesPadrao1
            // 
            this.ucBarraBotoesPadrao1.ExibirConsulta = false;
            this.ucBarraBotoesPadrao1.ExibirNovo = false;
            this.ucBarraBotoesPadrao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBarraBotoesPadrao1.Location = new System.Drawing.Point(12, 220);
            this.ucBarraBotoesPadrao1.Name = "ucBarraBotoesPadrao1";
            this.ucBarraBotoesPadrao1.Size = new System.Drawing.Size(771, 39);
            this.ucBarraBotoesPadrao1.TabIndex = 8;
            this.ucBarraBotoesPadrao1.OnSalvarClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnSalvarClick);
            this.ucBarraBotoesPadrao1.OnFecharClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnFecharClick);
            this.ucBarraBotoesPadrao1.Load += new System.EventHandler(this.ucBarraBotoesPadrao1_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusOperacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 275);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusOperacao
            // 
            this.lblStatusOperacao.Name = "lblStatusOperacao";
            this.lblStatusOperacao.Size = new System.Drawing.Size(118, 17);
            this.lblStatusOperacao.Text = "toolStripStatusLabel1";
            // 
            // FrmHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 297);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucBarraBotoesPadrao1);
            this.Controls.Add(this.mmEndereco);
            this.Controls.Add(this.dtaNascimento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.chkEstrangeiro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospede";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkEstrangeiro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.DateTimePicker dtaNascimento;
        private System.Windows.Forms.TextBox mmEndereco;
        private UserControls.ucBarraBotoesPadrao ucBarraBotoesPadrao1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOperacao;
    }
}