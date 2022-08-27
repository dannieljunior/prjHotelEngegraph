
namespace Hotel.Cliente
{
    partial class FrmCadTipoUh
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
            this.txtValorAdicional = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.txtValorDiaria = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.numQtdeAdt = new System.Windows.Forms.NumericUpDown();
            this.numQtdeChd = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusOperacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucBarraBotoesPadrao1 = new Hotel.Cliente.UserControls.ucBarraBotoesPadrao();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeAdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeChd)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Adultos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de Crianças:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorAdicional);
            this.groupBox1.Controls.Add(this.txtValorDiaria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(671, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores de Diárias";
            // 
            // txtValorAdicional
            // 
            this.txtValorAdicional.Location = new System.Drawing.Point(83, 81);
            this.txtValorAdicional.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(270, 32);
            this.txtValorAdicional.TabIndex = 6;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(84, 33);
            this.txtValorDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(269, 26);
            this.txtValorDiaria.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adicional:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Normal:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(195, 35);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.MaxLength = 40;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(499, 22);
            this.txtDescricao.TabIndex = 0;
            // 
            // numQtdeAdt
            // 
            this.numQtdeAdt.Location = new System.Drawing.Point(195, 91);
            this.numQtdeAdt.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdeAdt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQtdeAdt.Name = "numQtdeAdt";
            this.numQtdeAdt.Size = new System.Drawing.Size(160, 22);
            this.numQtdeAdt.TabIndex = 1;
            // 
            // numQtdeChd
            // 
            this.numQtdeChd.Location = new System.Drawing.Point(195, 146);
            this.numQtdeChd.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdeChd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQtdeChd.Name = "numQtdeChd";
            this.numQtdeChd.Size = new System.Drawing.Size(160, 22);
            this.numQtdeChd.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusOperacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.TabIndex = 8;
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
            this.ucBarraBotoesPadrao1.Location = new System.Drawing.Point(23, 391);
            this.ucBarraBotoesPadrao1.Name = "ucBarraBotoesPadrao1";
            this.ucBarraBotoesPadrao1.Size = new System.Drawing.Size(778, 39);
            this.ucBarraBotoesPadrao1.TabIndex = 9;
            this.ucBarraBotoesPadrao1.OnNovoClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnNovoClick);
            this.ucBarraBotoesPadrao1.OnSalvarClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnSalvarClick);
            this.ucBarraBotoesPadrao1.OnConsultaClick += new System.EventHandler(this.ucBarraBotoesPadrao1_OnConsultaClick);
            this.ucBarraBotoesPadrao1.Load += new System.EventHandler(this.ucBarraBotoesPadrao1_Load);
            // 
            // FrmCadTipoUh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 577);
            this.Controls.Add(this.ucBarraBotoesPadrao1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numQtdeChd);
            this.Controls.Add(this.numQtdeAdt);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadTipoUh";
            this.Text = "Cadastro de Tipo de UH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeAdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeChd)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown numQtdeAdt;
        private System.Windows.Forms.NumericUpDown numQtdeChd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOperacao;
        private UserControls.ucBarraBotoesPadrao ucBarraBotoesPadrao1;
        private UserControls.ucNumericEdit txtValorAdicional;
        private UserControls.ucNumericEdit txtValorDiaria;
    }
}