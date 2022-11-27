namespace FrmPresentacion
{
    partial class PaginaPrincipal
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
            this.PanelPadre = new System.Windows.Forms.MenuStrip();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelPadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPadre
            // 
            this.PanelPadre.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.PanelPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.habitacionesToolStripMenuItem1,
            this.reservasToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.listarFacturasToolStripMenuItem,
            this.saalirToolStripMenuItem});
            this.PanelPadre.Location = new System.Drawing.Point(0, 0);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.PanelPadre.Size = new System.Drawing.Size(980, 29);
            this.PanelPadre.TabIndex = 4;
            this.PanelPadre.Text = "PanelPadre";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.agendaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.agendaToolStripMenuItem.Text = "Clientes";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem1
            // 
            this.habitacionesToolStripMenuItem1.BackColor = System.Drawing.Color.Turquoise;
            this.habitacionesToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitacionesToolStripMenuItem1.Name = "habitacionesToolStripMenuItem1";
            this.habitacionesToolStripMenuItem1.Size = new System.Drawing.Size(118, 25);
            this.habitacionesToolStripMenuItem1.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem1.Click += new System.EventHandler(this.habitacionesToolStripMenuItem1_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.reservasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.facturaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click_1);
            // 
            // listarFacturasToolStripMenuItem
            // 
            this.listarFacturasToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.listarFacturasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarFacturasToolStripMenuItem.Name = "listarFacturasToolStripMenuItem";
            this.listarFacturasToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.listarFacturasToolStripMenuItem.Text = "Listar Facturas";
            this.listarFacturasToolStripMenuItem.Click += new System.EventHandler(this.listarFacturasToolStripMenuItem_Click);
            // 
            // saalirToolStripMenuItem
            // 
            this.saalirToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.saalirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saalirToolStripMenuItem.Name = "saalirToolStripMenuItem";
            this.saalirToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.saalirToolStripMenuItem.Text = "Salir";
            this.saalirToolStripMenuItem.Click += new System.EventHandler(this.saalirToolStripMenuItem_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::FrmPresentacion.Properties.Resources.hotel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 526);
            this.Controls.Add(this.PanelPadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaPrincipal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelPadre.ResumeLayout(false);
            this.PanelPadre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip PanelPadre;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saalirToolStripMenuItem;
    }
}