using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RG_Tickets
{
    public partial class Novo_ticket : Form
    {
        public Novo_ticket()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nt_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar e fechar a Tela?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            this.Close();
			


		}

        private void btn_nt_gravar_Click(object sender, EventArgs e)
        {
			try
			{
				using (SqlConnection cn = new SqlConnection(Conexão.StrConn))
				{
					cn.Open();

					var sql = "INSERT INTO tbl_rg_ticket" + "(ticket, data_de_abertura, municipio_cliente, descriçao_ticket, status_ticket, setor_de_criaçao)" + "VALUES" + "(@ticket, @data_de_abertura, @municipio_cliente, @descriçao_ticket, @status_ticket, @setor_de_criaçao)";

					using (SqlCommand cmd = new SqlCommand(sql, cn))
					{
						

						cmd.Parameters.AddWithValue("@ticket", txb_nt_nticket.Text);
						cmd.Parameters.AddWithValue("@data_de_abertura", txb_data_nt.Text);
						cmd.Parameters.AddWithValue("@municipio_cliente", txb_nt_municipio.Text);
						cmd.Parameters.AddWithValue("@descriçao_ticket", txb_nt_descricao.Text);
						cmd.Parameters.AddWithValue("@status_ticket", lst_status.Text);
						cmd.Parameters.AddWithValue("@setor_de_criaçao", lst_nt_setor.Text);
						cmd.ExecuteNonQuery();
					}



					MessageBox.Show("Dados Gravados com sucesso!!!");


				}
			}
			catch (Exception ex)
			{
				
				MessageBox.Show("Dados não inseridos no Banco de Dados!\n\n" + ex.Message);
			}
		}

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
