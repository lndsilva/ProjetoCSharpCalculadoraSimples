
namespace Calculo_IMC
{
    partial class frmCalculaCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaCombustivel));
            this.gpbCalcComb = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.gpbCalculo = new System.Windows.Forms.GroupBox();
            this.txtConsumoLitro = new System.Windows.Forms.TextBox();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.ConsumoLitro = new System.Windows.Forms.Label();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbCalcComb.SuspendLayout();
            this.gpbCalculo.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCalcComb
            // 
            this.gpbCalcComb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbCalcComb.Controls.Add(this.txtPreco);
            this.gpbCalcComb.Controls.Add(this.txtConsumo);
            this.gpbCalcComb.Controls.Add(this.txtDistancia);
            this.gpbCalcComb.Controls.Add(this.lblPreco);
            this.gpbCalcComb.Controls.Add(this.lblConsumo);
            this.gpbCalcComb.Controls.Add(this.lblDistancia);
            this.gpbCalcComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCalcComb.Location = new System.Drawing.Point(10, 7);
            this.gpbCalcComb.Name = "gpbCalcComb";
            this.gpbCalcComb.Size = new System.Drawing.Size(780, 191);
            this.gpbCalcComb.TabIndex = 0;
            this.gpbCalcComb.TabStop = false;
            this.gpbCalcComb.Text = "Calculadora de consumo de combustível";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(565, 126);
            this.txtPreco.MaxLength = 5;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(195, 26);
            this.txtPreco.TabIndex = 3;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(565, 78);
            this.txtConsumo.MaxLength = 5;
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(195, 26);
            this.txtConsumo.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(565, 32);
            this.txtDistancia.MaxLength = 5;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(195, 26);
            this.txtDistancia.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(97, 132);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(462, 20);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Adicione o preço do combustível onde você abastece ( ex: 4,15)*";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(293, 84);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(266, 20);
            this.lblConsumo.TabIndex = 1;
            this.lblConsumo.Text = "Insira o consumo do veículo por litro*";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(254, 38);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(305, 20);
            this.lblDistancia.TabIndex = 0;
            this.lblDistancia.Text = "Insira a distância que irá percorrer em km*";
            // 
            // gpbCalculo
            // 
            this.gpbCalculo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbCalculo.Controls.Add(this.txtConsumoLitro);
            this.gpbCalculo.Controls.Add(this.txtQuilometragem);
            this.gpbCalculo.Controls.Add(this.ConsumoLitro);
            this.gpbCalculo.Controls.Add(this.lblQuilometragem);
            this.gpbCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCalculo.Location = new System.Drawing.Point(10, 204);
            this.gpbCalculo.Name = "gpbCalculo";
            this.gpbCalculo.Size = new System.Drawing.Size(780, 132);
            this.gpbCalculo.TabIndex = 4;
            this.gpbCalculo.TabStop = false;
            this.gpbCalculo.Text = "Cálculo";
            // 
            // txtConsumoLitro
            // 
            this.txtConsumoLitro.Location = new System.Drawing.Point(565, 78);
            this.txtConsumoLitro.MaxLength = 5;
            this.txtConsumoLitro.Name = "txtConsumoLitro";
            this.txtConsumoLitro.Size = new System.Drawing.Size(195, 26);
            this.txtConsumoLitro.TabIndex = 6;
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.Location = new System.Drawing.Point(565, 32);
            this.txtQuilometragem.MaxLength = 5;
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.Size = new System.Drawing.Size(195, 26);
            this.txtQuilometragem.TabIndex = 5;
            // 
            // ConsumoLitro
            // 
            this.ConsumoLitro.AutoSize = true;
            this.ConsumoLitro.Location = new System.Drawing.Point(317, 84);
            this.ConsumoLitro.Name = "ConsumoLitro";
            this.ConsumoLitro.Size = new System.Drawing.Size(242, 20);
            this.ConsumoLitro.TabIndex = 1;
            this.ConsumoLitro.Text = "Consumo por litro de combustível";
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Location = new System.Drawing.Point(367, 38);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(192, 20);
            this.lblQuilometragem.TabIndex = 0;
            this.lblQuilometragem.Text = "Quilometragem percorrida";
            // 
            // gpbResultado
            // 
            this.gpbResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbResultado.Controls.Add(this.txtPrecoTotal);
            this.gpbResultado.Controls.Add(this.lblPrecoTotal);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(12, 342);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(780, 85);
            this.gpbResultado.TabIndex = 7;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(565, 32);
            this.txtPrecoTotal.MaxLength = 5;
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(195, 26);
            this.txtPrecoTotal.TabIndex = 8;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Location = new System.Drawing.Point(472, 38);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(85, 20);
            this.lblPrecoTotal.TabIndex = 0;
            this.lblPrecoTotal.Text = "Preço total";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnCalcular);
            this.pnlBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBotoes.Location = new System.Drawing.Point(12, 441);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(777, 97);
            this.pnlBotoes.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(529, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(231, 73);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(273, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(231, 73);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(17, 13);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(231, 73);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalculaCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbCalculo);
            this.Controls.Add(this.gpbCalcComb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculaCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula Combustível";
            this.Load += new System.EventHandler(this.frmCalculaCombustivel_Load);
            this.gpbCalcComb.ResumeLayout(false);
            this.gpbCalcComb.PerformLayout();
            this.gpbCalculo.ResumeLayout(false);
            this.gpbCalculo.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCalcComb;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox gpbCalculo;
        private System.Windows.Forms.TextBox txtConsumoLitro;
        private System.Windows.Forms.TextBox txtQuilometragem;
        private System.Windows.Forms.Label ConsumoLitro;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
    }
}