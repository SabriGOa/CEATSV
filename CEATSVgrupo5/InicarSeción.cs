using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace CEATSVgrupo5
{
    public partial class InicarSeción : Form
    {
        public InicarSeción()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
            {

                try
                {
                    Clase_BaseDatos bd = new Clase_BaseDatos();
                    Boolean res = bd.InicarSesión(txtUsuario.Text, txtContraseña.Text);
                    if (res)
                    {
                        General general = new General();
                        general.Show();
                    }

                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
               
               
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los datos");            
            }

           
           
        }
        

    }
}
