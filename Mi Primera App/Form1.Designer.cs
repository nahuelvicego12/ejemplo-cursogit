namespace Mi_Primera_App
{
    partial class FrmPrimerApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRun = new System.Windows.Forms.Button();
            this.lblpreparate = new System.Windows.Forms.Label();
            this.txtPrimeraapp = new System.Windows.Forms.TextBox();
            this.txtprimerapp2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Location = new System.Drawing.Point(253, 124);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(102, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblpreparate
            // 
            this.lblpreparate.AutoSize = true;
            this.lblpreparate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpreparate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreparate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblpreparate.Location = new System.Drawing.Point(158, 133);
            this.lblpreparate.Name = "lblpreparate";
            this.lblpreparate.Size = new System.Drawing.Size(80, 17);
            this.lblpreparate.TabIndex = 1;
            this.lblpreparate.Text = "Preparate y";
            this.lblpreparate.MouseLeave += new System.EventHandler(this.lblpreparate_MouseLeave);
            this.lblpreparate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblpreparate_MouseMove);
            // 
            // txtPrimeraapp
            // 
            this.txtPrimeraapp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrimeraapp.Location = new System.Drawing.Point(395, 133);
            this.txtPrimeraapp.MaxLength = 777;
            this.txtPrimeraapp.Name = "txtPrimeraapp";
            this.txtPrimeraapp.Size = new System.Drawing.Size(256, 20);
            this.txtPrimeraapp.TabIndex = 2;
            this.txtPrimeraapp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimeraapp_KeyPress);
            // 
            // txtprimerapp2
            // 
            this.txtprimerapp2.Location = new System.Drawing.Point(395, 180);
            this.txtprimerapp2.Multiline = true;
            this.txtprimerapp2.Name = "txtprimerapp2";
            this.txtprimerapp2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtprimerapp2.Size = new System.Drawing.Size(256, 20);
            this.txtprimerapp2.TabIndex = 3;
            this.txtprimerapp2.Leave += new System.EventHandler(this.txtprimerapp2_Leave);
            // 
            // FrmPrimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtprimerapp2);
            this.Controls.Add(this.txtPrimeraapp);
            this.Controls.Add(this.lblpreparate);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrimerApp";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer Aplicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrimerApp_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrimerApp_Load);
            this.Click += new System.EventHandler(this.FrmPrimerApp_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblpreparate;
        private System.Windows.Forms.TextBox txtPrimeraapp;
        private System.Windows.Forms.TextBox txtprimerapp2;
    }
}

