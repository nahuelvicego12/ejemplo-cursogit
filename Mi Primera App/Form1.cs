using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Primera_App
{
    public partial class FrmPrimerApp : Form
    {
        public FrmPrimerApp()
        {
            InitializeComponent();
        }

        private void FrmPrimerApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C# ...");
        }

        private void FrmPrimerApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se dispaparo el vento clikc ", "Atencion");
            //this.BackColor = Color.Blue;
            if (txtPrimeraapp.Text == "")
                txtPrimeraapp.BackColor = Color.Red;
            else
                txtPrimeraapp.BackColor = System.Drawing.SystemColors.Control;
           


        }

        private void FrmPrimerApp_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Se presiono el boton izquierdo ", "Atencion");

            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Se presiono el boton derecho ", "Atencion");

            else if (click.Button == MouseButtons.Middle) 
                MessageBox.Show("Se presiono el boton del medio ", "Atencion");





            
                
            
        }

        private void lblpreparate_MouseMove(object sender, MouseEventArgs e)
        {
            lblpreparate.BackColor = Color.Cyan;
            lblpreparate.Cursor = Cursors.Hand;
        }

        private void lblpreparate_MouseLeave(object sender, EventArgs e)
        {
            lblpreparate.BackColor = System.Drawing.SystemColors.Control;
            lblpreparate.Cursor = Cursors.Arrow;
        }

        private void txtPrimeraapp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;





        }

        private void txtprimerapp2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("tiene " + txtprimerapp2.Text.Length + "caracteres");
        }
    }
}
