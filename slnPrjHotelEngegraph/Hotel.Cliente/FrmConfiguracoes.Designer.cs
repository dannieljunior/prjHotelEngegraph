
namespace Hotel.Cliente
{
    partial class FrmConfiguracoes
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
            this.flwConfiguracoes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flwConfiguracoes
            // 
            this.flwConfiguracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.flwConfiguracoes.Name = "flwConfiguracoes";
            this.flwConfiguracoes.Size = new System.Drawing.Size(1057, 437);
            this.flwConfiguracoes.TabIndex = 0;
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 437);
            this.Controls.Add(this.flwConfiguracoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConfiguracoes";
            this.Text = "Configurações do sistema";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwConfiguracoes;
    }
}