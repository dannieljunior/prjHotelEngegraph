
namespace Hotel.Cliente.UserControls
{
    partial class ucItemDeConfiguracao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dateTimeValor = new System.Windows.Forms.DateTimePicker();
            this.boolValor = new System.Windows.Forms.CheckBox();
            this.stringValor = new System.Windows.Forms.TextBox();
            this.DoubleValor = new Hotel.Cliente.UserControls.ucNumericEdit();
            this.intValor = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 6);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // dateTimeValor
            // 
            this.dateTimeValor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeValor.Location = new System.Drawing.Point(534, 30);
            this.dateTimeValor.Name = "dateTimeValor";
            this.dateTimeValor.Size = new System.Drawing.Size(177, 20);
            this.dateTimeValor.TabIndex = 1;
            // 
            // boolValor
            // 
            this.boolValor.AutoSize = true;
            this.boolValor.Location = new System.Drawing.Point(696, 86);
            this.boolValor.Name = "boolValor";
            this.boolValor.Size = new System.Drawing.Size(15, 14);
            this.boolValor.TabIndex = 2;
            this.boolValor.UseVisualStyleBackColor = true;
            // 
            // stringValor
            // 
            this.stringValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stringValor.Location = new System.Drawing.Point(235, 3);
            this.stringValor.Name = "stringValor";
            this.stringValor.Size = new System.Drawing.Size(476, 20);
            this.stringValor.TabIndex = 3;
            // 
            // DoubleValor
            // 
            this.DoubleValor.Location = new System.Drawing.Point(568, 59);
            this.DoubleValor.Name = "DoubleValor";
            this.DoubleValor.Size = new System.Drawing.Size(143, 21);
            this.DoubleValor.TabIndex = 4;
            this.DoubleValor.Value = 0D;
            // 
            // intValor
            // 
            this.intValor.Location = new System.Drawing.Point(591, 109);
            this.intValor.Name = "intValor";
            this.intValor.Size = new System.Drawing.Size(120, 20);
            this.intValor.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(718, 1);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ucItemDeConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.intValor);
            this.Controls.Add(this.DoubleValor);
            this.Controls.Add(this.stringValor);
            this.Controls.Add(this.boolValor);
            this.Controls.Add(this.dateTimeValor);
            this.Controls.Add(this.lblDescricao);
            this.Name = "ucItemDeConfiguracao";
            this.Size = new System.Drawing.Size(802, 24);
            ((System.ComponentModel.ISupportInitialize)(this.intValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DateTimePicker dateTimeValor;
        private System.Windows.Forms.CheckBox boolValor;
        private System.Windows.Forms.TextBox stringValor;
        private ucNumericEdit DoubleValor;
        private System.Windows.Forms.NumericUpDown intValor;
        private System.Windows.Forms.Button btnSalvar;
    }
}
