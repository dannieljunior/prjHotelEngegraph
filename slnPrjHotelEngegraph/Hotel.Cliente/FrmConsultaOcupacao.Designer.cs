
namespace Hotel.Cliente
{
    partial class FrmConsultaOcupacao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaOcupacao));
            this.flwOcupacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgLstButtons = new System.Windows.Forms.ImageList(this.components);
            this.lblInformacao = new System.Windows.Forms.Label();
            this.tmrInformacao = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwOcupacoes
            // 
            this.flwOcupacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwOcupacoes.BackColor = System.Drawing.Color.White;
            this.flwOcupacoes.Location = new System.Drawing.Point(12, 53);
            this.flwOcupacoes.Name = "flwOcupacoes";
            this.flwOcupacoes.Size = new System.Drawing.Size(867, 385);
            this.flwOcupacoes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInformacao);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.ImageIndex = 5;
            this.btnFechar.ImageList = this.imgLstButtons;
            this.btnFechar.Location = new System.Drawing.Point(692, 6);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(185, 34);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // imgLstButtons
            // 
            this.imgLstButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstButtons.ImageStream")));
            this.imgLstButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstButtons.Images.SetKeyName(0, "icon_new.png");
            this.imgLstButtons.Images.SetKeyName(1, "icon_search.png");
            this.imgLstButtons.Images.SetKeyName(2, "icon_save.png");
            this.imgLstButtons.Images.SetKeyName(3, "icon_select.png");
            this.imgLstButtons.Images.SetKeyName(4, "icon_delete.png");
            this.imgLstButtons.Images.SetKeyName(5, "icon_close.png");
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblInformacao.Location = new System.Drawing.Point(28, 14);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(146, 20);
            this.lblInformacao.TabIndex = 19;
            this.lblInformacao.Text = "Ocupação em {0}";
            // 
            // tmrInformacao
            // 
            this.tmrInformacao.Interval = 1000;
            this.tmrInformacao.Tick += new System.EventHandler(this.tmrInformacao_Tick);
            // 
            // FrmConsultaOcupacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flwOcupacoes);
            this.Name = "FrmConsultaOcupacao";
            this.Text = "Consulta Ocupação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwOcupacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.ImageList imgLstButtons;
        private System.Windows.Forms.Timer tmrInformacao;
    }
}