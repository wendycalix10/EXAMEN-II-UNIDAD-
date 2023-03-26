using System;
using System.Windows.Forms;

namespace facturacion_con_base_de_datos
{
    public partial class GenerarTicketForm : Form
    {
        public GenerarTicketForm()
        {
            InitializeComponent();
        }
        string Operacion;
        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void preciotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HabilitarControles()
        {
            usuariotextBox.Enabled = true;
            clientetextBox.Enabled = true;
            tiposoportecomboBox.Enabled = true;
            solicitudtextBox.Enabled = true;
            preciotextBox.Enabled = false;
            respuestatextBox.Enabled = false;
            impuestotextBox.Enabled = false;
            descuentotextBox.Enabled = false;
            totaltextBox.Enabled = false;
            guardarbutton.Enabled = true;
            cancelarbutton.Enabled = true;
            nuevobutton.Enabled = false;
        }
        private void DeshabilitarControles()
        {
            usuariotextBox.Enabled = false;
            clientetextBox.Enabled = false;
            tiposoportecomboBox.Enabled = false;
            solicitudtextBox.Enabled = false;
            preciotextBox.Enabled = false;
            respuestatextBox.Enabled = false;
            impuestotextBox.Enabled = false;
            descuentotextBox.Enabled = false;
            totaltextBox.Enabled = false;
            guardarbutton.Enabled = false;
            cancelarbutton.Enabled = false;
            nuevobutton.Enabled = true;
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

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
        }

        private void modificarbutton_Click(object sender, EventArgs e)
        {
            Operacion = "Modificar";
            HabilitarControles();
        }

        private void usuariotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelarbutton_Click_1(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            cancelarbutton.Enabled = false;
        }

        private void nuevobutton_Click_1(object sender, EventArgs e)
        {
            HabilitarControles();
            guardarbutton.Enabled = true;
            Operacion = "Nuevo";
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            if (Operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(usuariotextBox.Text))
                {
                    errorProvider1.SetError(usuariotextBox, "Ingrese un Código de Usuario");
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(clientetextBox.Text))
                {
                    errorProvider1.SetError(clientetextBox, "Ingrese un Nombre de Cliente");
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(tiposoportecomboBox.Text))
                {
                    errorProvider1.SetError(tiposoportecomboBox, "Seleccione el tipo de soporte que necesita");
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(solicitudtextBox.Text))
                {
                    errorProvider1.SetError(solicitudtextBox, "Especifique qué pasa con su equipo");
                    return;
                }
                errorProvider1.Clear();

            }
        }

        private void preciotextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buscarimagenbutton_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
