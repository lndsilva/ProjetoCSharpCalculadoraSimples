﻿using System;
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
    public partial class frmMenu : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            frmCalculaIMC abrir = new frmCalculaIMC();
            abrir.Show();
            this.Hide();
        }

        private void btnCombustivel_Click(object sender, EventArgs e)
        {
            frmCalculaCombustivel abrir = new frmCalculaCombustivel();
            abrir.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFolhaPagamento abrir = new frmFolhaPagamento();
            abrir.Show();
            this.Hide();
        }
    }
}
