
namespace Calculo_IMC
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.gpbDadosSalariais = new System.Windows.Forms.GroupBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.lblIR = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.txtDemSB = new System.Windows.Forms.TextBox();
            this.lblSB = new System.Windows.Forms.Label();
            this.rdbClasseC = new System.Windows.Forms.RadioButton();
            this.rdbClasseB = new System.Windows.Forms.RadioButton();
            this.rdbClasseA = new System.Windows.Forms.RadioButton();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbCooperativa = new System.Windows.Forms.GroupBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.gpbDemostrarivo = new System.Windows.Forms.GroupBox();
            this.gpbDadosSalariais.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.gpbCooperativa.SuspendLayout();
            this.gpbDemostrarivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosSalariais
            // 
            this.gpbDadosSalariais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbDadosSalariais.Controls.Add(this.gpbDemostrarivo);
            this.gpbDadosSalariais.Controls.Add(this.gpbCooperativa);
            this.gpbDadosSalariais.Controls.Add(this.label2);
            this.gpbDadosSalariais.Controls.Add(this.txtSalarioBruto);
            this.gpbDadosSalariais.Controls.Add(this.lblSalarioBruto);
            this.gpbDadosSalariais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosSalariais.Location = new System.Drawing.Point(40, 27);
            this.gpbDadosSalariais.Name = "gpbDadosSalariais";
            this.gpbDadosSalariais.Size = new System.Drawing.Size(766, 398);
            this.gpbDadosSalariais.TabIndex = 0;
            this.gpbDadosSalariais.TabStop = false;
            this.gpbDadosSalariais.Text = "Dados Salariais";
            // 
            // txtIR
            // 
            this.txtIR.Enabled = false;
            this.txtIR.Location = new System.Drawing.Point(65, 215);
            this.txtIR.MaxLength = 10;
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(136, 26);
            this.txtIR.TabIndex = 8;
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Location = new System.Drawing.Point(65, 187);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(26, 20);
            this.lblIR.TabIndex = 10;
            this.lblIR.Text = "IR";
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(65, 143);
            this.txtINSS.MaxLength = 10;
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(136, 26);
            this.txtINSS.TabIndex = 7;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(65, 110);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(47, 20);
            this.lblINSS.TabIndex = 8;
            this.lblINSS.Text = "INSS";
            // 
            // txtDemSB
            // 
            this.txtDemSB.Enabled = false;
            this.txtDemSB.Location = new System.Drawing.Point(65, 71);
            this.txtDemSB.MaxLength = 10;
            this.txtDemSB.Name = "txtDemSB";
            this.txtDemSB.Size = new System.Drawing.Size(136, 26);
            this.txtDemSB.TabIndex = 6;
            // 
            // lblSB
            // 
            this.lblSB.AutoSize = true;
            this.lblSB.Location = new System.Drawing.Point(65, 38);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(99, 20);
            this.lblSB.TabIndex = 6;
            this.lblSB.Text = "Salário bruto";
            // 
            // rdbClasseC
            // 
            this.rdbClasseC.AutoSize = true;
            this.rdbClasseC.Location = new System.Drawing.Point(25, 116);
            this.rdbClasseC.Name = "rdbClasseC";
            this.rdbClasseC.Size = new System.Drawing.Size(227, 24);
            this.rdbClasseC.TabIndex = 5;
            this.rdbClasseC.TabStop = true;
            this.rdbClasseC.Text = "Classe C - 10% de desconto";
            this.rdbClasseC.UseVisualStyleBackColor = true;
            // 
            // rdbClasseB
            // 
            this.rdbClasseB.AutoSize = true;
            this.rdbClasseB.Location = new System.Drawing.Point(25, 80);
            this.rdbClasseB.Name = "rdbClasseB";
            this.rdbClasseB.Size = new System.Drawing.Size(227, 24);
            this.rdbClasseB.TabIndex = 4;
            this.rdbClasseB.TabStop = true;
            this.rdbClasseB.Text = "Classe B - 20% de desconto";
            this.rdbClasseB.UseVisualStyleBackColor = true;
            // 
            // rdbClasseA
            // 
            this.rdbClasseA.AutoSize = true;
            this.rdbClasseA.Location = new System.Drawing.Point(25, 47);
            this.rdbClasseA.Name = "rdbClasseA";
            this.rdbClasseA.Size = new System.Drawing.Size(227, 24);
            this.rdbClasseA.TabIndex = 3;
            this.rdbClasseA.TabStop = true;
            this.rdbClasseA.Text = "Classe A - 30% de desconto";
            this.rdbClasseA.UseVisualStyleBackColor = true;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(29, 74);
            this.txtSalarioBruto.MaxLength = 10;
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(136, 26);
            this.txtSalarioBruto.TabIndex = 1;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(29, 41);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(99, 20);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário bruto";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.Location = new System.Drawing.Point(553, 9);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(200, 75);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Tag = "Sair";
            this.btnVoltar.Text = "&Sair";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(7, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 75);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(306, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 75);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlMenu.Controls.Add(this.btnCalcular);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnLimpar);
            this.pnlMenu.Location = new System.Drawing.Point(40, 431);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(766, 94);
            this.pnlMenu.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // gpbCooperativa
            // 
            this.gpbCooperativa.Controls.Add(this.rdbClasseA);
            this.gpbCooperativa.Controls.Add(this.rdbClasseB);
            this.gpbCooperativa.Controls.Add(this.rdbClasseC);
            this.gpbCooperativa.Location = new System.Drawing.Point(29, 149);
            this.gpbCooperativa.Name = "gpbCooperativa";
            this.gpbCooperativa.Size = new System.Drawing.Size(273, 164);
            this.gpbCooperativa.TabIndex = 2;
            this.gpbCooperativa.TabStop = false;
            this.gpbCooperativa.Text = "Cooperativa";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(65, 265);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(107, 20);
            this.lblSalarioLiquido.TabIndex = 13;
            this.lblSalarioLiquido.Text = "Salário liquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(65, 293);
            this.txtSalarioLiquido.MaxLength = 10;
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(136, 26);
            this.txtSalarioLiquido.TabIndex = 9;
            // 
            // gpbDemostrarivo
            // 
            this.gpbDemostrarivo.Controls.Add(this.lblSB);
            this.gpbDemostrarivo.Controls.Add(this.lblSalarioLiquido);
            this.gpbDemostrarivo.Controls.Add(this.txtDemSB);
            this.gpbDemostrarivo.Controls.Add(this.txtSalarioLiquido);
            this.gpbDemostrarivo.Controls.Add(this.lblINSS);
            this.gpbDemostrarivo.Controls.Add(this.lblIR);
            this.gpbDemostrarivo.Controls.Add(this.txtINSS);
            this.gpbDemostrarivo.Controls.Add(this.txtIR);
            this.gpbDemostrarivo.Location = new System.Drawing.Point(470, 42);
            this.gpbDemostrarivo.Name = "gpbDemostrarivo";
            this.gpbDemostrarivo.Size = new System.Drawing.Size(270, 335);
            this.gpbDemostrarivo.TabIndex = 14;
            this.gpbDemostrarivo.TabStop = false;
            this.gpbDemostrarivo.Text = "Demonstrativo";
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 547);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.gpbDadosSalariais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.gpbDadosSalariais.ResumeLayout(false);
            this.gpbDadosSalariais.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.gpbCooperativa.ResumeLayout(false);
            this.gpbCooperativa.PerformLayout();
            this.gpbDemostrarivo.ResumeLayout(false);
            this.gpbDemostrarivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosSalariais;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rdbClasseC;
        private System.Windows.Forms.RadioButton rdbClasseB;
        private System.Windows.Forms.RadioButton rdbClasseA;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.TextBox txtDemSB;
        private System.Windows.Forms.Label lblSB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox gpbCooperativa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.GroupBox gpbDemostrarivo;
    }
}