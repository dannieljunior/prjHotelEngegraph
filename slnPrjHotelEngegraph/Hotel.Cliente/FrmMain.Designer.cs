
namespace Hotel.Cliente
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTipoUh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUh = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNovaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaOcupacao = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.toolStripMenuItem1,
            this.usuárioToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTipoUh,
            this.mnUh});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hotelToolStripMenuItem.Text = "&Hotel";
            // 
            // mnTipoUh
            // 
            this.mnTipoUh.Name = "mnTipoUh";
            this.mnTipoUh.Size = new System.Drawing.Size(133, 22);
            this.mnTipoUh.Text = "&Tipo de UH";
            this.mnTipoUh.Click += new System.EventHandler(this.mnTipoUh_Click);
            // 
            // mnUh
            // 
            this.mnUh.Name = "mnUh";
            this.mnUh.Size = new System.Drawing.Size(133, 22);
            this.mnUh.Text = "&UH";
            this.mnUh.Click += new System.EventHandler(this.mnUh_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formasDePagamentoToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.financeiroToolStripMenuItem.Text = "&Financeiro";
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de &Pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaReserva,
            this.mnNovaReserva});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "&Reservas";
            // 
            // mnConsultaReserva
            // 
            this.mnConsultaReserva.Name = "mnConsultaReserva";
            this.mnConsultaReserva.Size = new System.Drawing.Size(145, 22);
            this.mnConsultaReserva.Text = "&Consulta";
            this.mnConsultaReserva.Click += new System.EventHandler(this.mnConsultaReserva_Click);
            // 
            // mnNovaReserva
            // 
            this.mnNovaReserva.Name = "mnNovaReserva";
            this.mnNovaReserva.Size = new System.Drawing.Size(145, 22);
            this.mnNovaReserva.Text = "&Nova Reserva";
            this.mnNovaReserva.Click += new System.EventHandler(this.mnNovaReserva_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaOcupacao});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "C&onsultas";
            // 
            // mnConsultaOcupacao
            // 
            this.mnConsultaOcupacao.Name = "mnConsultaOcupacao";
            this.mnConsultaOcupacao.Size = new System.Drawing.Size(128, 22);
            this.mnConsultaOcupacao.Text = "&Ocupação";
            this.mnConsultaOcupacao.Click += new System.EventHandler(this.mnConsultaOcupacao_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // mnSobre
            // 
            this.mnSobre.Name = "mnSobre";
            this.mnSobre.Size = new System.Drawing.Size(104, 22);
            this.mnSobre.Text = "&Sobre";
            this.mnSobre.Click += new System.EventHandler(this.mnSobre_Click);
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Location = new System.Drawing.Point(0, 24);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(777, 388);
            this.tabForms.TabIndex = 1;
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraçõesToolStripMenuItem.Text = "&Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Engegraph";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnTipoUh;
        private System.Windows.Forms.ToolStripMenuItem mnUh;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaReserva;
        private System.Windows.Forms.ToolStripMenuItem mnNovaReserva;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaOcupacao;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSobre;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}