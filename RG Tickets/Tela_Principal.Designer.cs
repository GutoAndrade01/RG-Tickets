
namespace RG_Tickets
{
    partial class Tela_Principal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.painel_superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_configurações = new System.Windows.Forms.Button();
            this.btn_tickes = new System.Windows.Forms.Button();
            this.painel_contenedor = new System.Windows.Forms.Panel();
            this.date_view = new System.Windows.Forms.DateTimePicker();
            this.gpx_contenedor = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rg_TicketsDataSet = new RG_Tickets.Rg_TicketsDataSet();
            this.tblticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ticketTableAdapter = new RG_Tickets.Rg_TicketsDataSetTableAdapters.tbl_ticketTableAdapter();
            this.rg_TicketsDataSet1 = new RG_Tickets.Rg_TicketsDataSet1();
            this.tblrgticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_rg_ticketTableAdapter = new RG_Tickets.Rg_TicketsDataSet1TableAdapters.tbl_rg_ticketTableAdapter();
            this.rgTicketsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rgTicketsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rg_TicketsDataSet_rg_tickets = new RG_Tickets.Rg_TicketsDataSet_rg_tickets();
            this.tblrgticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_rg_ticketTableAdapter1 = new RG_Tickets.Rg_TicketsDataSet_rg_ticketsTableAdapters.tbl_rg_ticketTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeaberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçaoticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setordecriaçaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.pn_menu.SuspendLayout();
            this.painel_contenedor.SuspendLayout();
            this.gpx_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_TicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_TicketsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrgticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTicketsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTicketsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_TicketsDataSet_rg_tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrgticketBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_superior
            // 
            this.painel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.painel_superior.Controls.Add(this.label1);
            this.painel_superior.Controls.Add(this.btn_minimizar);
            this.painel_superior.Controls.Add(this.btn_fechar);
            this.painel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_superior.Location = new System.Drawing.Point(0, 0);
            this.painel_superior.Name = "painel_superior";
            this.painel_superior.Size = new System.Drawing.Size(813, 37);
            this.painel_superior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "RG Ticket";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(743, 9);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(31, 22);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(780, 9);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(26, 22);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.TabStop = false;
            // 
            // pn_menu
            // 
            this.pn_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pn_menu.Controls.Add(this.btn_sair);
            this.pn_menu.Controls.Add(this.btn_configurações);
            this.pn_menu.Controls.Add(this.btn_tickes);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.ForeColor = System.Drawing.Color.SeaShell;
            this.pn_menu.Location = new System.Drawing.Point(0, 37);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(177, 403);
            this.pn_menu.TabIndex = 1;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(3, 350);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(174, 33);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_configurações
            // 
            this.btn_configurações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_configurações.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_configurações.FlatAppearance.BorderSize = 0;
            this.btn_configurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configurações.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configurações.ForeColor = System.Drawing.Color.White;
            this.btn_configurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configurações.Location = new System.Drawing.Point(1, 100);
            this.btn_configurações.Name = "btn_configurações";
            this.btn_configurações.Size = new System.Drawing.Size(176, 33);
            this.btn_configurações.TabIndex = 4;
            this.btn_configurações.Text = "Configurações";
            this.btn_configurações.UseVisualStyleBackColor = false;
            // 
            // btn_tickes
            // 
            this.btn_tickes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_tickes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tickes.FlatAppearance.BorderSize = 0;
            this.btn_tickes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tickes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tickes.ForeColor = System.Drawing.Color.White;
            this.btn_tickes.Location = new System.Drawing.Point(1, 61);
            this.btn_tickes.Name = "btn_tickes";
            this.btn_tickes.Size = new System.Drawing.Size(176, 33);
            this.btn_tickes.TabIndex = 3;
            this.btn_tickes.Text = "Ticket";
            this.btn_tickes.UseVisualStyleBackColor = false;
            this.btn_tickes.Click += new System.EventHandler(this.btn_tickes_Click);
            // 
            // painel_contenedor
            // 
            this.painel_contenedor.BackColor = System.Drawing.Color.White;
            this.painel_contenedor.Controls.Add(this.date_view);
            this.painel_contenedor.Controls.Add(this.gpx_contenedor);
            this.painel_contenedor.Location = new System.Drawing.Point(177, 38);
            this.painel_contenedor.Name = "painel_contenedor";
            this.painel_contenedor.Size = new System.Drawing.Size(636, 402);
            this.painel_contenedor.TabIndex = 2;
            // 
            // date_view
            // 
            this.date_view.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_view.Location = new System.Drawing.Point(3, 379);
            this.date_view.Name = "date_view";
            this.date_view.Size = new System.Drawing.Size(241, 21);
            this.date_view.TabIndex = 1;
            // 
            // gpx_contenedor
            // 
            this.gpx_contenedor.Controls.Add(this.dataGridView1);
            this.gpx_contenedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpx_contenedor.Location = new System.Drawing.Point(7, 7);
            this.gpx_contenedor.Name = "gpx_contenedor";
            this.gpx_contenedor.Size = new System.Drawing.Size(617, 368);
            this.gpx_contenedor.TabIndex = 1;
            this.gpx_contenedor.TabStop = false;
            this.gpx_contenedor.Text = "Informações";
            this.gpx_contenedor.Enter += new System.EventHandler(this.gpx_contenedor_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ticketDataGridViewTextBoxColumn,
            this.datadeaberturaDataGridViewTextBoxColumn,
            this.municipioclienteDataGridViewTextBoxColumn,
            this.descriçaoticketDataGridViewTextBoxColumn,
            this.statusticketDataGridViewTextBoxColumn,
            this.setordecriaçaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblrgticketBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rg_TicketsDataSet
            // 
            this.rg_TicketsDataSet.DataSetName = "Rg_TicketsDataSet";
            this.rg_TicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblticketBindingSource
            // 
            this.tblticketBindingSource.DataMember = "tbl_ticket";
            this.tblticketBindingSource.DataSource = this.rg_TicketsDataSet;
            // 
            // tbl_ticketTableAdapter
            // 
            this.tbl_ticketTableAdapter.ClearBeforeFill = true;
            // 
            // rg_TicketsDataSet1
            // 
            this.rg_TicketsDataSet1.DataSetName = "Rg_TicketsDataSet1";
            this.rg_TicketsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrgticketBindingSource
            // 
            this.tblrgticketBindingSource.DataMember = "tbl_rg_ticket";
            this.tblrgticketBindingSource.DataSource = this.rg_TicketsDataSet1;
            // 
            // tbl_rg_ticketTableAdapter
            // 
            this.tbl_rg_ticketTableAdapter.ClearBeforeFill = true;
            // 
            // rgTicketsDataSet1BindingSource
            // 
            this.rgTicketsDataSet1BindingSource.DataSource = this.rg_TicketsDataSet1;
            this.rgTicketsDataSet1BindingSource.Position = 0;
            // 
            // rgTicketsDataSetBindingSource
            // 
            this.rgTicketsDataSetBindingSource.DataSource = this.rg_TicketsDataSet;
            this.rgTicketsDataSetBindingSource.Position = 0;
            // 
            // rg_TicketsDataSet_rg_tickets
            // 
            this.rg_TicketsDataSet_rg_tickets.DataSetName = "Rg_TicketsDataSet_rg_tickets";
            this.rg_TicketsDataSet_rg_tickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrgticketBindingSource1
            // 
            this.tblrgticketBindingSource1.DataMember = "tbl_rg_ticket";
            this.tblrgticketBindingSource1.DataSource = this.rg_TicketsDataSet_rg_tickets;
            // 
            // tbl_rg_ticketTableAdapter1
            // 
            this.tbl_rg_ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketDataGridViewTextBoxColumn
            // 
            this.ticketDataGridViewTextBoxColumn.DataPropertyName = "ticket";
            this.ticketDataGridViewTextBoxColumn.HeaderText = "ticket";
            this.ticketDataGridViewTextBoxColumn.Name = "ticketDataGridViewTextBoxColumn";
            // 
            // datadeaberturaDataGridViewTextBoxColumn
            // 
            this.datadeaberturaDataGridViewTextBoxColumn.DataPropertyName = "data_de_abertura";
            this.datadeaberturaDataGridViewTextBoxColumn.HeaderText = "data_de_abertura";
            this.datadeaberturaDataGridViewTextBoxColumn.Name = "datadeaberturaDataGridViewTextBoxColumn";
            // 
            // municipioclienteDataGridViewTextBoxColumn
            // 
            this.municipioclienteDataGridViewTextBoxColumn.DataPropertyName = "municipio_cliente";
            this.municipioclienteDataGridViewTextBoxColumn.HeaderText = "municipio_cliente";
            this.municipioclienteDataGridViewTextBoxColumn.Name = "municipioclienteDataGridViewTextBoxColumn";
            // 
            // descriçaoticketDataGridViewTextBoxColumn
            // 
            this.descriçaoticketDataGridViewTextBoxColumn.DataPropertyName = "descriçao_ticket";
            this.descriçaoticketDataGridViewTextBoxColumn.HeaderText = "descriçao_ticket";
            this.descriçaoticketDataGridViewTextBoxColumn.Name = "descriçaoticketDataGridViewTextBoxColumn";
            // 
            // statusticketDataGridViewTextBoxColumn
            // 
            this.statusticketDataGridViewTextBoxColumn.DataPropertyName = "status_ticket";
            this.statusticketDataGridViewTextBoxColumn.HeaderText = "status_ticket";
            this.statusticketDataGridViewTextBoxColumn.Name = "statusticketDataGridViewTextBoxColumn";
            // 
            // setordecriaçaoDataGridViewTextBoxColumn
            // 
            this.setordecriaçaoDataGridViewTextBoxColumn.DataPropertyName = "setor_de_criaçao";
            this.setordecriaçaoDataGridViewTextBoxColumn.HeaderText = "setor_de_criaçao";
            this.setordecriaçaoDataGridViewTextBoxColumn.Name = "setordecriaçaoDataGridViewTextBoxColumn";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 440);
            this.Controls.Add(this.painel_contenedor);
            this.Controls.Add(this.pn_menu);
            this.Controls.Add(this.painel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.painel_superior.ResumeLayout(false);
            this.painel_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.pn_menu.ResumeLayout(false);
            this.painel_contenedor.ResumeLayout(false);
            this.gpx_contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_TicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_TicketsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrgticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTicketsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTicketsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_TicketsDataSet_rg_tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrgticketBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_superior;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.Panel pn_menu;
        
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_configurações;
        private System.Windows.Forms.Button btn_tickes;
        private System.Windows.Forms.Panel painel_contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_view;
        private System.Windows.Forms.GroupBox gpx_contenedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Rg_TicketsDataSet rg_TicketsDataSet;
        private System.Windows.Forms.BindingSource tblticketBindingSource;
        private Rg_TicketsDataSetTableAdapters.tbl_ticketTableAdapter tbl_ticketTableAdapter;
        private Rg_TicketsDataSet1 rg_TicketsDataSet1;
        private System.Windows.Forms.BindingSource tblrgticketBindingSource;
        private Rg_TicketsDataSet1TableAdapters.tbl_rg_ticketTableAdapter tbl_rg_ticketTableAdapter;
        private System.Windows.Forms.BindingSource rgTicketsDataSetBindingSource;
        private System.Windows.Forms.BindingSource rgTicketsDataSet1BindingSource;
        private Rg_TicketsDataSet_rg_tickets rg_TicketsDataSet_rg_tickets;
        private System.Windows.Forms.BindingSource tblrgticketBindingSource1;
        private Rg_TicketsDataSet_rg_ticketsTableAdapters.tbl_rg_ticketTableAdapter tbl_rg_ticketTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeaberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçaoticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setordecriaçaoDataGridViewTextBoxColumn;
    }
}

