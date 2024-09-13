
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
            this.dtvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvDados
            // 
            this.dtvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDados.Location = new System.Drawing.Point(43, 117);
            this.dtvDados.Name = "dtvDados";
            this.dtvDados.Size = new System.Drawing.Size(811, 410);
            this.dtvDados.TabIndex = 0;
            // 
            // frmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 542);
            this.Controls.Add(this.dtvDados);
            this.Name = "frmDataGridView";
            this.Text = "frmDataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dtvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvDados;
    }
}