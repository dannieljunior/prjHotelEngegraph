
namespace Hotel.Cliente.UserControls
{
    partial class ucBarraBotoesPadrao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBarraBotoesPadrao));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.imgLstButtons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.ImageIndex = 5;
            this.btnFechar.ImageList = this.imgLstButtons;
            this.btnFechar.Location = new System.Drawing.Point(589, 3);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(185, 34);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageIndex = 2;
            this.btnSalvar.ImageList = this.imgLstButtons;
            this.btnSalvar.Location = new System.Drawing.Point(394, 3);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(185, 34);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.ImageIndex = 1;
            this.btnConsulta.ImageList = this.imgLstButtons;
            this.btnConsulta.Location = new System.Drawing.Point(199, 3);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(185, 34);
            this.btnConsulta.TabIndex = 15;
            this.btnConsulta.Text = "&Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.imgLstButtons;
            this.btnNovo.Location = new System.Drawing.Point(4, 3);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(185, 34);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            // ucBarraBotoesPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnNovo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucBarraBotoesPadrao";
            this.Size = new System.Drawing.Size(778, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ImageList imgLstButtons;
    }
}
