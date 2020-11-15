using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmMain : Form // hereda de la clase formulario
    {
        public frmMain() // metodo constructor para inicializar la clase
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == this.btnGuardar.Name)
            {
                this.txtText.Text = "Boto Guardar" + this.txtText.Text;
            }
            else
            {
                this.txtText.Text = "Boto Guardar2" + this.txtText.Text;
            }


            this.lblDatos.Text = this.txtText.Text;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           this.lblDatos.Text = "";
           this.txtText.Text = "";
        }

    }
}
