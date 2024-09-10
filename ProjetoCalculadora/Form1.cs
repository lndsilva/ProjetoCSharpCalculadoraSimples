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

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
            try
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);

                if (rdbSomar.Checked == false && rdbSubtrair.Checked == false && rdbMultiplicar.Checked == false && rdbDividir.Checked == false)
                {
                    MessageBox.Show("Favor selecionar uma operação",
                            "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                }
                else
                {

                    if (rdbSomar.Checked)
                    {
                        resp = num1 + num2;
                    }
                    if (rdbSubtrair.Checked)
                    {
                        resp = num1 - num2;
                    }
                    if (rdbMultiplicar.Checked)
                    {
                        resp = num1 * num2;
                    }
                    if (rdbDividir.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossível divisão por zero.",
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                            limparCampos();
                        }
                        else
                        {
                            resp = num1 / num2;
                        }
                    }
                    lblResposta.Text = resp.ToString();
                    limparNumeros();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Favor inserir somente números.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        public void limparCampos()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResposta.Text = "";
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtNum1.Focus();
        }
        public void limparNumeros()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtNum1.Focus();
        }
    }
}
