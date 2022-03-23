using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new frmClientes());
        }
        private Form activoForm = null;
        private void abrirForm(Form formHijo)
        {
            if (activoForm != null)

                activoForm.Close();
            activoForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            //rellenar panel contenedor
            formHijo.Dock = DockStyle.Fill;
            //agregamos al panel seleccionado
            pnlPrincipal.Controls.Add(formHijo);
            //asociamos el panel contenedor
            pnlPrincipal.Tag = formHijo;
            //Traer formulario al frente 
            formHijo.BringToFront();
            formHijo.Show();


        }
    }
}
