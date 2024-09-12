using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculo_IMC
{
    public partial class frmCalculaCombustivel : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCalculaCombustivel()
        {
            InitializeComponent();
        }

        private void frmCalculaCombustivel_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precoTotal = 0;
            try
            {


                precoCombustivel = Convert.ToDouble(txtPreco.Text);

                precoTotal = consLComb * precoCombustivel;

                txtPrecoTotal.Text = "R$ " + string.Format("{0:n2}", precoTotal);
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inseir valores", "Sistema",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1);
                txtDistancia.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            txtQuilometragem.Text = txtDistancia.Text;
        }
        public double consumo, litro, consLComb = 0, precoCombustivel;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            txtConsumo.Clear();
            txtConsumoLitro.Clear();
            txtDistancia.Clear();
            txtPreco.Clear();
            txtPrecoTotal.Clear();
            txtQuilometragem.Clear();
            txtDistancia.Focus();
        }

        private void txtConsumo_TextChanged(object sender, EventArgs e)
        {
            try
            {

                consumo = Convert.ToDouble(txtDistancia.Text);


                litro = Convert.ToDouble(txtConsumo.Text);

                consLComb = consumo / litro;

                txtConsumoLitro.Text = consLComb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inseir valores", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
