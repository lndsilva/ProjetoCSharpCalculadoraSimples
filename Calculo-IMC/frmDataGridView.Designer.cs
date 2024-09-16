
namespace Calculo_IMC
{
    partial class frmDataGridView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataGridView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpClientes = new System.Windows.Forms.TabPage();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.tbpCreditos = new System.Windows.Forms.TabPage();
            this.tbpVendas = new System.Windows.Forms.TabPage();
            this.imgListaImagens = new System.Windows.Forms.ImageList(this.components);
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpClientes);
            this.tabControl1.Controls.Add(this.tbpCreditos);
            this.tabControl1.Controls.Add(this.tbpVendas);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imgListaImagens;
            this.tabControl1.Location = new System.Drawing.Point(47, 43);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpClientes
            // 
            this.tbpClientes.Controls.Add(this.txtNomeCli);
            this.tbpClientes.Controls.Add(this.lblNomeCli);
            this.tbpClientes.Controls.Add(this.txtCodCli);
            this.tbpClientes.Controls.Add(this.lblCodigo);
            this.tbpClientes.Controls.Add(this.dgvClientes);
            this.tbpClientes.Controls.Add(this.btnListarClientes);
            this.tbpClientes.ImageKey = "cliente_48.png";
            this.tbpClientes.Location = new System.Drawing.Point(4, 55);
            this.tbpClientes.Name = "tbpClientes";
            this.tbpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClientes.Size = new System.Drawing.Size(797, 400);
            this.tbpClientes.TabIndex = 0;
            this.tbpClientes.Text = "Clientes";
            this.tbpClientes.UseVisualStyleBackColor = true;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(20, 48);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 26);
            this.txtCodCli.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(295, 25);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(496, 312);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(20, 286);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(174, 51);
            this.btnListarClientes.TabIndex = 3;
            this.btnListarClientes.Text = "&Listar";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            // 
            // tbpCreditos
            // 
            this.tbpCreditos.ImageKey = "credito_48.png";
            this.tbpCreditos.Location = new System.Drawing.Point(4, 55);
            this.tbpCreditos.Name = "tbpCreditos";
            this.tbpCreditos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCreditos.Size = new System.Drawing.Size(797, 400);
            this.tbpCreditos.TabIndex = 1;
            this.tbpCreditos.Text = "Créditos";
            this.tbpCreditos.UseVisualStyleBackColor = true;
            // 
            // tbpVendas
            // 
            this.tbpVendas.ImageKey = "vendas_48.png";
            this.tbpVendas.Location = new System.Drawing.Point(4, 55);
            this.tbpVendas.Name = "tbpVendas";
            this.tbpVendas.Size = new System.Drawing.Size(797, 400);
            this.tbpVendas.TabIndex = 2;
            this.tbpVendas.Text = "Vendas";
            this.tbpVendas.UseVisualStyleBackColor = true;
            // 
            // imgListaImagens
            // 
            this.imgListaImagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListaImagens.ImageStream")));
            this.imgListaImagens.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListaImagens.Images.SetKeyName(0, "cliente_48.png");
            this.imgListaImagens.Images.SetKeyName(1, "credito_48.png");
            this.imgListaImagens.Images.SetKeyName(2, "vendas_48.png");
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(20, 119);
            this.txtNomeCli.MaxLength = 50;
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(256, 26);
            this.txtNomeCli.TabIndex = 1;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(20, 96);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(51, 20);
            this.lblNomeCli.TabIndex = 4;
            this.lblNomeCli.Text = "Nome";
            // 
            // frmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 542);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDataGridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados - DataGridView";
            this.tabControl1.ResumeLayout(false);
            this.tbpClientes.ResumeLayout(false);
            this.tbpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpClientes;
        private System.Windows.Forms.TabPage tbpCreditos;
        private System.Windows.Forms.TabPage tbpVendas;
        private System.Windows.Forms.ImageList imgListaImagens;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblNomeCli;
    }
}