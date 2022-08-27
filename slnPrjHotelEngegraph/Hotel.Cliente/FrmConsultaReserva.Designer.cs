
namespace Hotel.Cliente
{
    partial class FrmConsultaReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaReserva));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtaCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtaCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoUh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.imgLstButtons = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblContRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeAdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeChd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUhDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEstadiaPrevisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solicitante,
            this.Estadia,
            this.QtdeAdt,
            this.QtdeChd,
            this.TipoUhDescricao,
            this.ValorEstadiaPrevisto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(876, 362);
            this.dataGridView1.TabIndex = 1;
            // 
            // dtaCheckIn
            // 
            this.dtaCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaCheckIn.Location = new System.Drawing.Point(24, 38);
            this.dtaCheckIn.Name = "dtaCheckIn";
            this.dtaCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtaCheckIn.TabIndex = 2;
            // 
            // dtaCheckOut
            // 
            this.dtaCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaCheckOut.Location = new System.Drawing.Point(230, 38);
            this.dtaCheckOut.Name = "dtaCheckOut";
            this.dtaCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtaCheckOut.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CheckIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CheckOut";
            // 
            // cmbTipoUh
            // 
            this.cmbTipoUh.FormattingEnabled = true;
            this.cmbTipoUh.Location = new System.Drawing.Point(436, 38);
            this.cmbTipoUh.Name = "cmbTipoUh";
            this.cmbTipoUh.Size = new System.Drawing.Size(228, 21);
            this.cmbTipoUh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de UH";
            // 
            // btnConsulta
            // 
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.ImageIndex = 1;
            this.btnConsulta.ImageList = this.imgLstButtons;
            this.btnConsulta.Location = new System.Drawing.Point(687, 30);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(144, 34);
            this.btnConsulta.TabIndex = 16;
            this.btnConsulta.Text = "&Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblContRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "Registros encontrados:";
            // 
            // lblContRegistros
            // 
            this.lblContRegistros.Name = "lblContRegistros";
            this.lblContRegistros.Size = new System.Drawing.Size(13, 17);
            this.lblContRegistros.Text = "0";
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "Solicitante";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.ReadOnly = true;
            this.Solicitante.Width = 200;
            // 
            // Estadia
            // 
            this.Estadia.DataPropertyName = "Estadia";
            this.Estadia.HeaderText = "Estadia";
            this.Estadia.Name = "Estadia";
            this.Estadia.ReadOnly = true;
            this.Estadia.Width = 225;
            // 
            // QtdeAdt
            // 
            this.QtdeAdt.DataPropertyName = "QtdeAdt";
            this.QtdeAdt.HeaderText = "Adultos";
            this.QtdeAdt.Name = "QtdeAdt";
            this.QtdeAdt.ReadOnly = true;
            this.QtdeAdt.Width = 50;
            // 
            // QtdeChd
            // 
            this.QtdeChd.DataPropertyName = "QtdeChd";
            this.QtdeChd.HeaderText = "Crianças";
            this.QtdeChd.Name = "QtdeChd";
            this.QtdeChd.ReadOnly = true;
            this.QtdeChd.Width = 50;
            // 
            // TipoUhDescricao
            // 
            this.TipoUhDescricao.DataPropertyName = "TipoUhDescricao";
            this.TipoUhDescricao.HeaderText = "Tipo de UH";
            this.TipoUhDescricao.Name = "TipoUhDescricao";
            this.TipoUhDescricao.ReadOnly = true;
            this.TipoUhDescricao.Width = 200;
            // 
            // ValorEstadiaPrevisto
            // 
            this.ValorEstadiaPrevisto.DataPropertyName = "ValorEstadiaPrevisto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorEstadiaPrevisto.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorEstadiaPrevisto.HeaderText = "Valor Total";
            this.ValorEstadiaPrevisto.Name = "ValorEstadiaPrevisto";
            this.ValorEstadiaPrevisto.ReadOnly = true;
            this.ValorEstadiaPrevisto.Width = 125;
            // 
            // FrmConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoUh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaCheckOut);
            this.Controls.Add(this.dtaCheckIn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsultaReserva";
            this.Text = "Consulta Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtaCheckIn;
        private System.Windows.Forms.DateTimePicker dtaCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoUh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ImageList imgLstButtons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblContRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeAdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeChd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUhDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEstadiaPrevisto;
    }
}