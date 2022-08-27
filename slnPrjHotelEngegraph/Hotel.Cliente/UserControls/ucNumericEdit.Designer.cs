
namespace Hotel.Cliente.UserControls
{
    partial class ucNumericEdit
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
            this.txtControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(3, 3);
            this.txtControl.Name = "txtControl";
            this.txtControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtControl.Size = new System.Drawing.Size(197, 20);
            this.txtControl.TabIndex = 0;
            this.txtControl.Text = "0,00";
            this.txtControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControl_KeyPress);
            this.txtControl.Leave += new System.EventHandler(this.txtControl_Leave);
            // 
            // ucNumericEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtControl);
            this.Name = "ucNumericEdit";
            this.Size = new System.Drawing.Size(203, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtControl;
    }
}
