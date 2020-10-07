namespace CapaPresentacion
{
    partial class FrmAcercaDe
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
            this.lklLinkedIn = new System.Windows.Forms.LinkLabel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lklGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lklLinkedIn
            // 
            this.lklLinkedIn.AutoSize = true;
            this.lklLinkedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklLinkedIn.LinkColor = System.Drawing.Color.Black;
            this.lklLinkedIn.Location = new System.Drawing.Point(86, 166);
            this.lklLinkedIn.Name = "lklLinkedIn";
            this.lklLinkedIn.Size = new System.Drawing.Size(56, 13);
            this.lklLinkedIn.TabIndex = 0;
            this.lklLinkedIn.TabStop = true;
            this.lklLinkedIn.Text = "LinkedIn";
            this.lklLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLinkedIn_LinkClicked);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(12, 54);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(395, 96);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Facturacion Clientes: Es un sistema de ventas sencillo que permite gestionar clie" +
    "ntes, proveedores, pedidos e ingresos a almacen.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acerca de Facturación Clientes";
            // 
            // lklGitHub
            // 
            this.lklGitHub.AutoSize = true;
            this.lklGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklGitHub.LinkColor = System.Drawing.Color.Black;
            this.lklGitHub.Location = new System.Drawing.Point(179, 166);
            this.lklGitHub.Name = "lklGitHub";
            this.lklGitHub.Size = new System.Drawing.Size(46, 13);
            this.lklGitHub.TabIndex = 6;
            this.lklGitHub.TabStop = true;
            this.lklGitHub.Text = "GitHub";
            this.lklGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklGitHub_LinkClicked);
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 212);
            this.Controls.Add(this.lklGitHub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lklLinkedIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de FacturaciónClientes";
            this.Load += new System.EventHandler(this.FrmAcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklLinkedIn;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklGitHub;
    }
}