using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace facturacion_con_base_de_datos
{
    public partial class RevisarTicketForm : Form
    {
        public RevisarTicketForm()
        {
            InitializeComponent();
        }
        string tipooperacion = string.Empty;
        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            DialogResult dialogResult = Dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                fotopictureBox.Image = Image.FromFile(Dialog.FileName);
            }
        }
        private void HabilitarControles()
        {
            usuariotextBox.Enabled = true;
            clientetextBox.Enabled = true;
            tiposoportecomboBox.Enabled = true;
            buscarimagenbutton.Enabled = false;
            cancelarbutton.Enabled = true;
            solicitudtextBox.Enabled = true;
            respuestatextBox.Enabled = true;
            preciotextBox.Enabled = true;
            impuestotextBox.Enabled = false;
            descuentotextBox.Enabled = false;
            totaltextBox.Enabled = false;
        }
        private void DeshabilitarControles()
        {
            usuariotextBox.Enabled = false;
            clientetextBox.Enabled = false;
            tiposoportecomboBox.Enabled = false;
            buscarimagenbutton.Enabled = false;
            cancelarbutton.Enabled = false;
            solicitudtextBox.Enabled = false;
            respuestatextBox.Enabled = false;
            preciotextBox.Enabled = false;
            impuestotextBox.Enabled = false;
            descuentotextBox.Enabled = false;
            totaltextBox.Enabled = false;
        }
        private void LimpiarControles()
        {
            usuariotextBox.Clear();
            clientetextBox.Clear();
            tiposoportecomboBox.Text = "";
            solicitudtextBox.Clear();
            respuestatextBox.Clear();
            preciotextBox.Clear();
            impuestotextBox.Clear();
            descuentotextBox.Clear();
            totaltextBox.Clear();
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
                if (string.IsNullOrEmpty(usuariotextBox.Text))
                {
                    errorProvider1.SetError(usuariotextBox, "Ingrese el Código");
                    usuariotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(clientetextBox.Text))
                {
                    errorProvider1.SetError(clientetextBox, "Ingrese un Nombre");
                    clientetextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(tiposoportecomboBox.Text))
                {
                    errorProvider1.SetError(tiposoportecomboBox, "Seleccione un Rol");
                    tiposoportecomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Usuario user = new Usuario();

                user.CodigoUsuario = usuariotextBox.Text;
                user.Nombre = clientetextBox.Text;
                user.Contraseña = contraseñatextBox.Text;
                user.Correo = correotextBox.Text;
                user.Rol = tiposoportecomboBox.Text;

                if (fotopictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    fotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    user.Foto = ms.GetBuffer();
                }
            }
        }

        private void usuariotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preciotextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(preciotextBox, "Ingrese valores numéricos");
            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
