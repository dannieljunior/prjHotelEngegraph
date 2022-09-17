
namespace Hotel.Cliente
{
    partial class FrmCadUsuario
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
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblInfoLogin = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusOperacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucBarraBotoesPadrao1 = new Hotel.Cliente.UserControls.ucBarraBotoesPadrao();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirma Senha";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(489, 125);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(57, 20);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(53, 58);
            this.txtLogin.MaxLength = 40;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(193, 22);
            this.txtLogin.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(252, 58);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(413, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(252, 123);
            this.txtConfirmaSenha.MaxLength = 8;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(193, 22);
            this.txtConfirmaSenha.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(53, 123);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(193, 22);
            this.txtSenha.TabIndex = 7;
            // 
            // lblInfoLogin
            // 
            this.lblInfoLogin.AutoSize = true;
            this.lblInfoLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInfoLogin.Location = new System.Drawing.Point(50, 183);
            this.lblInfoLogin.Name = "lblInfoLogin";
            this.lblInfoLogin.Size = new System.Drawing.Size(75, 16);
            this.lblInfoLogin.TabIndex = 9;
            this.lblInfoLogin.Text = "Informação";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusOperacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(832, 22);
            this.statusStrip1.TabIndex = 15;
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
            this.ucBarraBotoesPadrao1.ExibirConsulta = true;
            this.ucBarraBotoesPadrao1.ExibirNovo = true;
            this.ucBarraBotoesPadrao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBarraBotoesPadrao1.Location = new System.Drawing.Point(12, 272);
            this.ucBarraBotoesPadrao1.Name = "ucBarraBotoesPadrao1";
            this.ucBarraBotoesPadrao1.Size = new System.Drawing.Size(778, 39);
            this.ucBarraBotoesPadrao1.TabIndex = 16;
            this.ucBarraBotoesPadrao1.OnNovoClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnNovoClick);
            this.ucBarraBotoesPadrao1.OnSalvarClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnSalvarClick);
            this.ucBarraBotoesPadrao1.OnConsultaClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnConsultaClick);
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 351);
            this.Controls.Add(this.ucBarraBotoesPadrao1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInfoLogin);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCadUsuario";
            this.Text = "Cadastro de Usuário";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblInfoLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOperacao;
        private UserControls.ucBarraBotoesPadrao ucBarraBotoesPadrao1;
    }
}