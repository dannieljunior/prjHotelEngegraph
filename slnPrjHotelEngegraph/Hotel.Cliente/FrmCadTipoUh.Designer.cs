
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.numQtdeAdt = new System.Windows.Forms.NumericUpDown();
            this.numQtdeChd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mnVlrDiariaAdicional = new Hotel.Cliente.UserControls.ucMoneyTextBox();
            this.mnVlrDiariaNormal = new Hotel.Cliente.UserControls.ucMoneyTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeAdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeChd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(140, 40);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(356, 22);
            this.txtDescricao.TabIndex = 0;
            // 
            // numQtdeAdt
            // 
            this.numQtdeAdt.Location = new System.Drawing.Point(140, 85);
            this.numQtdeAdt.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdeAdt.Name = "numQtdeAdt";
            this.numQtdeAdt.Size = new System.Drawing.Size(160, 22);
            this.numQtdeAdt.TabIndex = 2;
            // 
            // numQtdeChd
            // 
            this.numQtdeChd.Location = new System.Drawing.Point(140, 124);
            this.numQtdeChd.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdeChd.Name = "numQtdeChd";
            this.numQtdeChd.Size = new System.Drawing.Size(160, 22);
            this.numQtdeChd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtde. Adultos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qtde. Adultos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mnVlrDiariaAdicional);
            this.groupBox1.Controls.Add(this.mnVlrDiariaNormal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores de Diárias";
            // 
            // mnVlrDiariaAdicional
            // 
            this.mnVlrDiariaAdicional.Location = new System.Drawing.Point(106, 70);
            this.mnVlrDiariaAdicional.Margin = new System.Windows.Forms.Padding(5);
            this.mnVlrDiariaAdicional.Name = "mnVlrDiariaAdicional";
            this.mnVlrDiariaAdicional.Prefixo = "R$";
            this.mnVlrDiariaAdicional.Size = new System.Drawing.Size(253, 31);
            this.mnVlrDiariaAdicional.TabIndex = 10;
            this.mnVlrDiariaAdicional.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // mnVlrDiariaNormal
            // 
            this.mnVlrDiariaNormal.Location = new System.Drawing.Point(106, 36);
            this.mnVlrDiariaNormal.Margin = new System.Windows.Forms.Padding(4);
            this.mnVlrDiariaNormal.Name = "mnVlrDiariaNormal";
            this.mnVlrDiariaNormal.Prefixo = "R$";
            this.mnVlrDiariaNormal.Size = new System.Drawing.Size(253, 25);
            this.mnVlrDiariaNormal.TabIndex = 9;
            this.mnVlrDiariaNormal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adicional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Normal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCadTipoUh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numQtdeChd);
            this.Controls.Add(this.numQtdeAdt);
            this.Controls.Add(this.txtDescricao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadTipoUh";
            this.Text = "Cadastro de Tipo de UH";
            this.Load += new System.EventHandler(this.FrmCadTipoUh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeAdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeChd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown numQtdeAdt;
        private System.Windows.Forms.NumericUpDown numQtdeChd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private UserControls.ucMoneyTextBox mnVlrDiariaNormal;
        private UserControls.ucMoneyTextBox mnVlrDiariaAdicional;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}