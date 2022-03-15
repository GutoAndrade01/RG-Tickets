
namespace RG_Tickets
{
    partial class Novo_ticket
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
            this.btn_nt_cancelar = new System.Windows.Forms.Button();
            this.btn_nt_gravar = new System.Windows.Forms.Button();
            this.lbl_nt_municipio = new System.Windows.Forms.Label();
            this.txb_nt_municipio = new System.Windows.Forms.TextBox();
            this.lbl_nt_nticket = new System.Windows.Forms.Label();
            this.txb_nt_nticket = new System.Windows.Forms.TextBox();
            this.lbl_nt_status = new System.Windows.Forms.Label();
            this.lst_status = new System.Windows.Forms.ComboBox();
            this.lbl_nt_setor = new System.Windows.Forms.Label();
            this.lst_nt_setor = new System.Windows.Forms.ComboBox();
            this.gpx_nt_componentes = new System.Windows.Forms.GroupBox();
            this.gbx_nt_descricao = new System.Windows.Forms.GroupBox();
            this.txb_nt_descricao = new System.Windows.Forms.RichTextBox();
            this.lbl_nt_titulo = new System.Windows.Forms.Label();
            this.lbl_nt_data = new System.Windows.Forms.Label();
            this.txb_data_nt = new System.Windows.Forms.MaskedTextBox();
            this.gpx_nt_componentes.SuspendLayout();
            this.gbx_nt_descricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nt_cancelar
            // 
            this.btn_nt_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_nt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nt_cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nt_cancelar.Location = new System.Drawing.Point(527, 339);
            this.btn_nt_cancelar.Name = "btn_nt_cancelar";
            this.btn_nt_cancelar.Size = new System.Drawing.Size(83, 30);
            this.btn_nt_cancelar.TabIndex = 0;
            this.btn_nt_cancelar.Text = "Cancelar";
            this.btn_nt_cancelar.UseVisualStyleBackColor = true;
            this.btn_nt_cancelar.Click += new System.EventHandler(this.btn_nt_cancelar_Click);
            // 
            // btn_nt_gravar
            // 
            this.btn_nt_gravar.FlatAppearance.BorderSize = 0;
            this.btn_nt_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nt_gravar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_nt_gravar.Location = new System.Drawing.Point(438, 339);
            this.btn_nt_gravar.Name = "btn_nt_gravar";
            this.btn_nt_gravar.Size = new System.Drawing.Size(83, 30);
            this.btn_nt_gravar.TabIndex = 1;
            this.btn_nt_gravar.Text = "Gravar";
            this.btn_nt_gravar.UseVisualStyleBackColor = true;
            this.btn_nt_gravar.Click += new System.EventHandler(this.btn_nt_gravar_Click);
            // 
            // lbl_nt_municipio
            // 
            this.lbl_nt_municipio.AutoSize = true;
            this.lbl_nt_municipio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_nt_municipio.Location = new System.Drawing.Point(12, 22);
            this.lbl_nt_municipio.Name = "lbl_nt_municipio";
            this.lbl_nt_municipio.Size = new System.Drawing.Size(70, 17);
            this.lbl_nt_municipio.TabIndex = 2;
            this.lbl_nt_municipio.Text = "Município";
            // 
            // txb_nt_municipio
            // 
            this.txb_nt_municipio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_nt_municipio.Location = new System.Drawing.Point(88, 19);
            this.txb_nt_municipio.MaxLength = 50;
            this.txb_nt_municipio.Name = "txb_nt_municipio";
            this.txb_nt_municipio.Size = new System.Drawing.Size(221, 23);
            this.txb_nt_municipio.TabIndex = 3;
            // 
            // lbl_nt_nticket
            // 
            this.lbl_nt_nticket.AutoSize = true;
            this.lbl_nt_nticket.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_nt_nticket.Location = new System.Drawing.Point(340, 22);
            this.lbl_nt_nticket.Name = "lbl_nt_nticket";
            this.lbl_nt_nticket.Size = new System.Drawing.Size(122, 17);
            this.lbl_nt_nticket.TabIndex = 4;
            this.lbl_nt_nticket.Text = "Numero do Ticket";
            // 
            // txb_nt_nticket
            // 
            this.txb_nt_nticket.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txb_nt_nticket.Location = new System.Drawing.Point(468, 19);
            this.txb_nt_nticket.MaxLength = 10;
            this.txb_nt_nticket.Name = "txb_nt_nticket";
            this.txb_nt_nticket.Size = new System.Drawing.Size(109, 23);
            this.txb_nt_nticket.TabIndex = 5;
            // 
            // lbl_nt_status
            // 
            this.lbl_nt_status.AutoSize = true;
            this.lbl_nt_status.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_nt_status.Location = new System.Drawing.Point(28, 68);
            this.lbl_nt_status.Name = "lbl_nt_status";
            this.lbl_nt_status.Size = new System.Drawing.Size(46, 17);
            this.lbl_nt_status.TabIndex = 7;
            this.lbl_nt_status.Text = "Status";
            // 
            // lst_status
            // 
            this.lst_status.FormattingEnabled = true;
            this.lst_status.Items.AddRange(new object[] {
            "Em Andamento",
            "Parado",
            "Concluído/Aguardando Validação",
            "Validado"});
            this.lst_status.Location = new System.Drawing.Point(88, 67);
            this.lst_status.MaxLength = 50;
            this.lst_status.Name = "lst_status";
            this.lst_status.Size = new System.Drawing.Size(221, 25);
            this.lst_status.TabIndex = 8;
            this.lst_status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_nt_setor
            // 
            this.lbl_nt_setor.AutoSize = true;
            this.lbl_nt_setor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_nt_setor.Location = new System.Drawing.Point(340, 68);
            this.lbl_nt_setor.Name = "lbl_nt_setor";
            this.lbl_nt_setor.Size = new System.Drawing.Size(40, 17);
            this.lbl_nt_setor.TabIndex = 9;
            this.lbl_nt_setor.Text = "Setor";
            // 
            // lst_nt_setor
            // 
            this.lst_nt_setor.FormattingEnabled = true;
            this.lst_nt_setor.Items.AddRange(new object[] {
            "suporte interno",
            "suporte externo",
            "outros setores"});
            this.lst_nt_setor.Location = new System.Drawing.Point(388, 67);
            this.lst_nt_setor.MaxLength = 50;
            this.lst_nt_setor.Name = "lst_nt_setor";
            this.lst_nt_setor.Size = new System.Drawing.Size(189, 25);
            this.lst_nt_setor.TabIndex = 10;
            // 
            // gpx_nt_componentes
            // 
            this.gpx_nt_componentes.Controls.Add(this.txb_data_nt);
            this.gpx_nt_componentes.Controls.Add(this.lbl_nt_data);
            this.gpx_nt_componentes.Controls.Add(this.lst_nt_setor);
            this.gpx_nt_componentes.Controls.Add(this.lbl_nt_setor);
            this.gpx_nt_componentes.Controls.Add(this.lst_status);
            this.gpx_nt_componentes.Controls.Add(this.lbl_nt_status);
            this.gpx_nt_componentes.Controls.Add(this.txb_nt_nticket);
            this.gpx_nt_componentes.Controls.Add(this.lbl_nt_nticket);
            this.gpx_nt_componentes.Controls.Add(this.txb_nt_municipio);
            this.gpx_nt_componentes.Controls.Add(this.lbl_nt_municipio);
            this.gpx_nt_componentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpx_nt_componentes.Location = new System.Drawing.Point(10, 46);
            this.gpx_nt_componentes.Name = "gpx_nt_componentes";
            this.gpx_nt_componentes.Size = new System.Drawing.Size(597, 138);
            this.gpx_nt_componentes.TabIndex = 11;
            this.gpx_nt_componentes.TabStop = false;
            this.gpx_nt_componentes.Text = "Informações";
            // 
            // gbx_nt_descricao
            // 
            this.gbx_nt_descricao.Controls.Add(this.txb_nt_descricao);
            this.gbx_nt_descricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_nt_descricao.Location = new System.Drawing.Point(12, 190);
            this.gbx_nt_descricao.Name = "gbx_nt_descricao";
            this.gbx_nt_descricao.Size = new System.Drawing.Size(594, 143);
            this.gbx_nt_descricao.TabIndex = 12;
            this.gbx_nt_descricao.TabStop = false;
            this.gbx_nt_descricao.Text = "Descrição";
            // 
            // txb_nt_descricao
            // 
            this.txb_nt_descricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nt_descricao.Location = new System.Drawing.Point(6, 15);
            this.txb_nt_descricao.MaxLength = 3000;
            this.txb_nt_descricao.Name = "txb_nt_descricao";
            this.txb_nt_descricao.Size = new System.Drawing.Size(582, 122);
            this.txb_nt_descricao.TabIndex = 0;
            this.txb_nt_descricao.Text = "";
            // 
            // lbl_nt_titulo
            // 
            this.lbl_nt_titulo.AutoSize = true;
            this.lbl_nt_titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nt_titulo.Location = new System.Drawing.Point(230, 9);
            this.lbl_nt_titulo.Name = "lbl_nt_titulo";
            this.lbl_nt_titulo.Size = new System.Drawing.Size(118, 23);
            this.lbl_nt_titulo.TabIndex = 13;
            this.lbl_nt_titulo.Text = "Novo Ticket";
            // 
            // lbl_nt_data
            // 
            this.lbl_nt_data.AutoSize = true;
            this.lbl_nt_data.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lbl_nt_data.Location = new System.Drawing.Point(221, 104);
            this.lbl_nt_data.Name = "lbl_nt_data";
            this.lbl_nt_data.Size = new System.Drawing.Size(41, 17);
            this.lbl_nt_data.TabIndex = 11;
            this.lbl_nt_data.Text = "Data";
            // 
            // txb_data_nt
            // 
            this.txb_data_nt.Location = new System.Drawing.Point(268, 101);
            this.txb_data_nt.Mask = "00/00/0000";
            this.txb_data_nt.Name = "txb_data_nt";
            this.txb_data_nt.Size = new System.Drawing.Size(100, 23);
            this.txb_data_nt.TabIndex = 12;
            this.txb_data_nt.ValidatingType = typeof(System.DateTime);
            // 
            // Novo_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 381);
            this.Controls.Add(this.lbl_nt_titulo);
            this.Controls.Add(this.gbx_nt_descricao);
            this.Controls.Add(this.gpx_nt_componentes);
            this.Controls.Add(this.btn_nt_gravar);
            this.Controls.Add(this.btn_nt_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Novo_ticket";
            this.Text = "Form1";
            this.gpx_nt_componentes.ResumeLayout(false);
            this.gpx_nt_componentes.PerformLayout();
            this.gbx_nt_descricao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nt_cancelar;
        private System.Windows.Forms.Button btn_nt_gravar;
        private System.Windows.Forms.Label lbl_nt_municipio;
        private System.Windows.Forms.TextBox txb_nt_municipio;
        private System.Windows.Forms.Label lbl_nt_nticket;
        private System.Windows.Forms.TextBox txb_nt_nticket;
        private System.Windows.Forms.Label lbl_nt_status;
        private System.Windows.Forms.ComboBox lst_status;
        private System.Windows.Forms.Label lbl_nt_setor;
        private System.Windows.Forms.ComboBox lst_nt_setor;
        private System.Windows.Forms.GroupBox gpx_nt_componentes;
        private System.Windows.Forms.GroupBox gbx_nt_descricao;
        private System.Windows.Forms.RichTextBox txb_nt_descricao;
        private System.Windows.Forms.Label lbl_nt_titulo;
        private System.Windows.Forms.MaskedTextBox txb_data_nt;
        private System.Windows.Forms.Label lbl_nt_data;
    }
}