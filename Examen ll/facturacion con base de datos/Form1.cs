using System;
using System.Windows.Forms;

namespace facturacion_con_base_de_datos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CodigoUsuariotextBox.Focus();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.Text == "")
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Ingrese Usuario");
                return;
            }
            errorProvider1.Clear();
            if (ContraseñatextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese Contraseña");
                return;
            }
            errorProvider1.Clear();
            Menu menuFormulario = new Menu();
            this.Hide();
            menuFormulario.Show();

        }

    }
}
