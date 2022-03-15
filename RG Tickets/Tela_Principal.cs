using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;





namespace RG_Tickets
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
          


        {
            InitializeComponent();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rg_TicketsDataSet_rg_tickets.tbl_rg_ticket'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_rg_ticketTableAdapter1.Fill(this.rg_TicketsDataSet_rg_tickets.tbl_rg_ticket);
            // TODO: esta linha de código carrega dados na tabela 'rg_TicketsDataSet1.tbl_rg_ticket'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_rg_ticketTableAdapter.Fill(this.rg_TicketsDataSet1.tbl_rg_ticket);
            try
            {
                using (SqlConnection con= new SqlConnection(Conexão.StrConn))
                {
                    con.Open();
                    MessageBox.Show("Conectado ao Banco de Dados!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha na conexão com o Banco de Dados!\n\n" + ex.Message);
            }
        
        }

         

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar o Sistema?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

       

        private void abrirFormInPainel(object Form2)
        {
            if (this.painel_contenedor.Controls.Count > 0)
                this.painel_contenedor.Controls.RemoveAt(0);
            Form f2 = Form2 as Form;
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            this.painel_contenedor.Controls.Add(f2);
            this.painel_contenedor.Tag = f2;
            f2.Show();
        }

        private void btn_tickes_Click(object sender, EventArgs e)
        {
            abrirFormInPainel(new Novo_ticket());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gpx_contenedor_Enter(object sender, EventArgs e)
        {

        }
    }
}


















