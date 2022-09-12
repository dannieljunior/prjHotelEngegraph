
namespace Hotel.Cliente
{
    partial class FrmCheckOut
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
            this.dtgOcupacao = new System.Windows.Forms.DataGridView();
            this.dtgHospedes = new System.Windows.Forms.DataGridView();
            this.lblDataCheckOut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFPagtoDiarias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFPagtoConsumo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numVlrConsumo = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.numVlrTotalDiarias = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.numVlrDiaria = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.numQtdeDiarias = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOcupacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHospedes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOcupacao
            // 
            this.dtgOcupacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOcupacao.Location = new System.Drawing.Point(12, 35);
            this.dtgOcupacao.Name = "dtgOcupacao";
            this.dtgOcupacao.Size = new System.Drawing.Size(1036, 72);
            this.dtgOcupacao.TabIndex = 0;
            // 
            // dtgHospedes
            // 
            this.dtgHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHospedes.Location = new System.Drawing.Point(12, 144);
            this.dtgHospedes.Name = "dtgHospedes";
            this.dtgHospedes.Size = new System.Drawing.Size(404, 275);
            this.dtgHospedes.TabIndex = 1;
            // 
            // lblDataCheckOut
            // 
            this.lblDataCheckOut.AutoSize = true;
            this.lblDataCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDataCheckOut.Location = new System.Drawing.Point(522, 167);
            this.lblDataCheckOut.Name = "lblDataCheckOut";
            this.lblDataCheckOut.Size = new System.Drawing.Size(163, 20);
            this.lblDataCheckOut.TabIndex = 3;
            this.lblDataCheckOut.Text = "Data de Check-Out";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFPagtoConsumo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbFPagtoDiarias);
            this.groupBox1.Controls.Add(this.numVlrConsumo);
            this.groupBox1.Controls.Add(this.numVlrTotalDiarias);
            this.groupBox1.Controls.Add(this.numVlrDiaria);
            this.groupBox1.Controls.Add(this.numQtdeDiarias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(422, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo da estadia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtde Diárias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Diária:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Total Diárias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Total Consumo:";
            // 
            // cmbFPagtoDiarias
            // 
            this.cmbFPagtoDiarias.FormattingEnabled = true;
            this.cmbFPagtoDiarias.Location = new System.Drawing.Point(405, 101);
            this.cmbFPagtoDiarias.Name = "cmbFPagtoDiarias";
            this.cmbFPagtoDiarias.Size = new System.Drawing.Size(207, 24);
            this.cmbFPagtoDiarias.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "F. Pagto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "F. Pagto:";
            // 
            // cmbFPagtoConsumo
            // 
            this.cmbFPagtoConsumo.FormattingEnabled = true;
            this.cmbFPagtoConsumo.Location = new System.Drawing.Point(405, 137);
            this.cmbFPagtoConsumo.Name = "cmbFPagtoConsumo";
            this.cmbFPagtoConsumo.Size = new System.Drawing.Size(207, 24);
            this.cmbFPagtoConsumo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hóspedes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Dados da Ocupação";
            // 
            // numVlrConsumo
            // 
            this.numVlrConsumo.Location = new System.Drawing.Point(162, 142);
            this.numVlrConsumo.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.numVlrConsumo.Name = "numVlrConsumo";
            this.numVlrConsumo.Size = new System.Drawing.Size(160, 27);
            this.numVlrConsumo.TabIndex = 12;
            this.numVlrConsumo.Value = 0D;
            // 
            // numVlrTotalDiarias
            // 
            this.numVlrTotalDiarias.Enabled = false;
            this.numVlrTotalDiarias.Location = new System.Drawing.Point(160, 104);
            this.numVlrTotalDiarias.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numVlrTotalDiarias.Name = "numVlrTotalDiarias";
            this.numVlrTotalDiarias.Size = new System.Drawing.Size(162, 39);
            this.numVlrTotalDiarias.TabIndex = 11;
            this.numVlrTotalDiarias.Value = 0D;
            // 
            // numVlrDiaria
            // 
            this.numVlrDiaria.Enabled = false;
            this.numVlrDiaria.Location = new System.Drawing.Point(157, 70);
            this.numVlrDiaria.Margin = new System.Windows.Forms.Padding(5);
            this.numVlrDiaria.Name = "numVlrDiaria";
            this.numVlrDiaria.Size = new System.Drawing.Size(165, 32);
            this.numVlrDiaria.TabIndex = 10;
            this.numVlrDiaria.Value = 0D;
            // 
            // numQtdeDiarias
            // 
            this.numQtdeDiarias.Enabled = false;
            this.numQtdeDiarias.Location = new System.Drawing.Point(157, 35);
            this.numQtdeDiarias.Margin = new System.Windows.Forms.Padding(4);
            this.numQtdeDiarias.Name = "numQtdeDiarias";
            this.numQtdeDiarias.Size = new System.Drawing.Size(165, 40);
            this.numQtdeDiarias.TabIndex = 9;
            this.numQtdeDiarias.Value = 1230D;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Confirmar Check-Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataCheckOut);
            this.Controls.Add(this.dtgHospedes);
            this.Controls.Add(this.dtgOcupacao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dtgOcupacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHospedes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOcupacao;
        private System.Windows.Forms.DataGridView dtgHospedes;
        private System.Windows.Forms.Label lblDataCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFPagtoConsumo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFPagtoDiarias;
        private UserControls.ucNumericEdit numVlrConsumo;
        private UserControls.ucNumericEdit numVlrTotalDiarias;
        private UserControls.ucNumericEdit numVlrDiaria;
        private UserControls.ucNumericEdit numQtdeDiarias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}