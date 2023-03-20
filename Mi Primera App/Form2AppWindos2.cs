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
    public partial class Form2AppWindos2 : Form
    {
        public Form2AppWindos2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (txtApellido.Text == "")

                txtApellido.BackColor = Color.Red;
                
             if (txtNombre.Text == "")
            
            txtNombre.BackColor = Color.Red;

             if (txtEdad.Text == "")

            txtEdad.BackColor = Color.Red;

             if (txtdireccion.Text == "")

                txtdireccion.BackColor = Color.Red;

    
            string apellido = txtApellido.Text;
            string nombre = txtApellido.Text;
            string edad = txtEdad.Text;
            string direccion = txtdireccion.Text;
            rtxtResultado.Text = "Apellido y Nombre: " + apellido + nombre + " Edad:" + edad +" Direccion: " + direccion;
            
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.FindForm().Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }



        }
    }
}
