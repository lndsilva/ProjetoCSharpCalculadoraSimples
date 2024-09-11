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
    public partial class frmCalculaIMC : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCalculaIMC()
        {
            InitializeComponent();
        }

        private void frmCalculaIMC_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc = 0;
            int grau = 0;
            string classificacao = "";
            try
            {
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);

                imc = peso / (altura * altura);

                if (imc <= 18.5)
                {
                    grau = 0;
                    classificacao = "Magreza";
                    lblClassificacao.ForeColor = Color.Green;
                }
                if (imc > 18.5 && imc < 24.9)
                {
                    grau = 0;
                    classificacao = "Normal";
                    lblClassificacao.ForeColor = Color.DarkGreen;
                }
                if (imc >= 25 && imc < 29.9)
                {
                    grau = 1;
                    classificacao = "Sobrepeso";
                    lblClassificacao.ForeColor = Color.DarkGoldenrod;
                }
                if (imc >= 30 && imc < 39.9)
                {
                    grau = 2;
                    classificacao = "Obesidade";
                    lblClassificacao.ForeColor = Color.Red;
                }
                if (imc >= 40)
                {
                    grau = 3;
                    classificacao = "Obesidade grave";
                    lblClassificacao.ForeColor = Color.DarkRed;
                }

                txtIMC.Text = string.Format("{0:n2}", imc);

                lblClassificacao.Text = classificacao;
                lblGrau.Text = grau.ToString();
                limparText();
            }
            catch (Exception)
            {

                MessageBox.Show("Insira somente números", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparText();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            txtAltura.Clear();
            txtIMC.Clear();
            txtPeso.Clear();
            lblClassificacao.Text = "";
            lblGrau.Text = "";
            txtAltura.Focus();
        }
        public void limparText()
        {
            txtAltura.Clear();
            txtIMC.Clear();
            txtPeso.Clear();
            txtAltura.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }
    }
}
