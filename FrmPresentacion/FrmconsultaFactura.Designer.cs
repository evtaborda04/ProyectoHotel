namespace FrmPresentacion
{
    partial class FrmconsultaFactura
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
            this.grillaconsulta = new System.Windows.Forms.DataGridView();
            this.txtbuscarfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaconsulta
            // 
            this.grillaconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaconsulta.Location = new System.Drawing.Point(31, 49);
            this.grillaconsulta.Name = "grillaconsulta";
            this.grillaconsulta.Size = new System.Drawing.Size(1136, 251);
            this.grillaconsulta.TabIndex = 0;
            // 
            // txtbuscarfactura
            // 
            this.txtbuscarfactura.Location = new System.Drawing.Point(154, 23);
            this.txtbuscarfactura.Name = "txtbuscarfactura";
            this.txtbuscarfactura.Size = new System.Drawing.Size(100, 20);
            this.txtbuscarfactura.TabIndex = 1;
            this.txtbuscarfactura.TextChanged += new System.EventHandler(this.buscarfactura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // FrmconsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmPresentacion.Properties.Resources.logofondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscarfactura);
            this.Controls.Add(this.grillaconsulta);
            this.Name = "FrmconsultaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaFactura";
            this.Load += new System.EventHandler(this.FrmconsultaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaconsulta;
        private System.Windows.Forms.TextBox txtbuscarfactura;
        private System.Windows.Forms.Label label1;
    }
}