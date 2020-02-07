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

namespace View
{
   public partial class frmPesquisar : Form
   {
      SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=BDRotulagem;User ID=sa;Password=sa");
      public frmPesquisar()
      {
         InitializeComponent();

      }

      private void btnPesquisar_Click(object sender, EventArgs e)
      {
         string query;

         if (String.IsNullOrWhiteSpace(txtFiltro.Text))
         {
            query = "SELECT * FROM TBLTACO ORDER BY descricao";
         }
         else
         {
            query = "SELECT * FROM TBLTACO  WHERE descricao LIKE '" + txtFiltro.Text + "%' ORDER BY descricao";
         }
         try
         {
            conexao.Open();

            SqlCommand command = new SqlCommand(query, conexao);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResultado.DataSource = dt;
         }
         catch (Exception erro)
         {
            MessageBox.Show("Detalhes: " + erro.Message);

         }
         finally
         {
            conexao.Close();
         }


      }
   }
}
