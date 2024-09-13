using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Calculo_IMC
{
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();

            dtvDados.DataSource = carregaDataGrid();
            
        }


        public DataTable carregaDataGrid()
        {
            DataTable dt= new DataTable();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from funcionarios;";
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr = comm.ExecuteReader();

            dt.Load(dr);

           

             Conexao.fecharConexao();

            return dt;
        }
    }
}
