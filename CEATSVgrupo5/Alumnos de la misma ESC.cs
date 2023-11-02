using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEATSVgrupo5
{
    public partial class Alumnos_de_la_misma_ESC : Form
    {
        public Alumnos_de_la_misma_ESC()
        {
            InitializeComponent();
        }

        private void btnAgrAlum_Click(object sender, EventArgs e)
        {
            FrmRegistroMatrícula rm = new FrmRegistroMatrícula();
            rm.Show();
        }

      

     
      
        
    }
}
