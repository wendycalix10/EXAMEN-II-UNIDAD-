using Entidades;
using System;
using System.Windows.Forms;

namespace facturacion_con_base_de_datos
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        string tipooperacion = string.Empty;
        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void HabilitarControles()
        {
            codigotextBox.Enabled = true;
            nombretextBox.Enabled = true;
            contraseñatextBox.Enabled = true;
            correotextBox.Enabled = true;
            rolcomboBox.Enabled = true;
            estaactivocheckBox.Enabled = true;
            buscarimagenbutton.Enabled = true;
            cancelarbutton.Enabled = true;

        }
        private void DeshabilitarControles()
        {
            codigotextBox.Enabled = false;
            nombretextBox.Enabled = false;
            contraseñatextBox.Enabled = false;
            correotextBox.Enabled = false;
            rolcomboBox.Enabled = false;
            estaactivocheckBox.Enabled = false;
            buscarimagenbutton.Enabled = false;
            cancelarbutton.Enabled = false;
        }
        private void LimpiarControles()
        {
            codigotextBox.Clear();
            nombretextBox.Clear();
            contraseñatextBox.Clear();
            correotextBox.Clear();
            rolcomboBox.Text = "";
            estaactivocheckBox.Checked = false;
            fotopictureBox.Image = null;
        }
        private void nuevobutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            guardarbutton.Enabled = true;
            tipooperacion = "Nuevo";
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            cancelarbutton.Enabled = false;
        }

        private void modificarbutton_Click(object sender, EventArgs e)
        {
            tipooperacion = "Modificar";
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            if (tipooperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(codigotextBox.Text))
                {
                    errorProvider1.SetError(codigotextBox, "Ingrese el Código");
                    codigotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(nombretextBox.Text))
                {
                    errorProvider1.SetError(nombretextBox, "Ingrese un Nombre");
                    nombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(contraseñatextBox.Text))
                {
                    errorProvider1.SetError(contraseñatextBox, "Ingrese una Contraseña");
                    contraseñatextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(correotextBox.Text))
                {
                    errorProvider1.SetError(correotextBox, "Ingrese un Correo Electrónico");
                    correotextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(rolcomboBox.Text))
                {
                    errorProvider1.SetError(rolcomboBox, "Seleccione un Rol");
                    rolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Usuario user = new Usuario();

                user.CodigoUsuario = codigotextBox.Text;
                user.Nombre = nombretextBox.Text;
                user.Contraseña = contraseñatextBox.Text;
                user.Correo = correotextBox.Text;
                user.Rol = rolcomboBox.Text;
                user.EstaActivo = estaactivocheckBox.Checked;

            }
        }
    }
}
