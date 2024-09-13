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
    public partial class frmFolhaPagamento : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public double salarioBruto = 0;
        public string inss = "";
        public double ir = 0;

        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double vSalarioINSS = 0, vSalarioIR = 0;

                salarioBruto = double.Parse(txtSalarioBruto.Text);

                vSalarioINSS = calculaINSS(salarioBruto);
                vSalarioIR = calculaIR(salarioBruto);

                txtINSS.Text = vSalarioINSS.ToString();
                txtIR.Text = vSalarioIR.ToString();

                salarioBruto = vSalarioINSS - vSalarioIR;

                txtSalarioLiquido.Text = salarioBruto.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Insira somente números", "Sistema",
                   MessageBoxButtons.OK, MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        public void limparCampos()
        {
            txtSalarioBruto.Clear();
            txtSalarioBruto.Focus();
            txtDemSB.Clear();
            txtINSS.Clear();
            txtIR.Clear();
            txtSalarioLiquido.Clear();
            rdbClasseA.Checked = false;
            rdbClasseB.Checked = false;
            rdbClasseC.Checked = false;
        }

        public double calculaINSS(double salario)
        {
            if (salario <= 1412)
            {

            }
            if (salario >= 1412.01 && salario <= 2666.68)
            {
                salarioBruto = salario - (salario * 9 / 100);

            }
            if (salario >= 2666.69 && salario <= 4000.03)
            {
                salarioBruto = salario - (salario * 12 / 100);

            }
            if (salario >= 4000.04 && salario <= 7786.02)
            {
                salarioBruto = salario - (salario * 14 / 100);

            }

            return salarioBruto;
        }
        public double calculaIR(double salario)
        {
            if (salario <= 2112)
            {
                ir = 0;
            }
            if (salario >= 2112.01 && salario <= 2826.65)
            {
                salarioBruto = salario - (salario * 7.5 / 100);

            }
            if (salario >= 2826.66 && salario <= 3751.05)
            {
                salarioBruto = salario - (salario * 15 / 100);

            }
            if (salario >= 3751.06 && salario <= 4664.68)
            {
                salarioBruto = salario - (salario * 22.5 / 100);

            }
            if (salario >= 4664.69)
            {
                salarioBruto = salario - (salario * 27.5 / 100);

            }

            return salarioBruto;
        }
    }
}
