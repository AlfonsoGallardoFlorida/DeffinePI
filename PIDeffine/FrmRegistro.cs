using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void bttRegistrarse_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string clave = txtContra.Text;
            string confClave = txtConfirmContra.Text;
            bool admin = false;

            if (correo != "" && nombre != "" && apellidos != "" && clave != "" && confClave != "")
            {
                if (confClave == clave)
                {
                    if (Cliente.ComprobarExistencia(correo))
                    {
                        MessageBox.Show("Ya existe un usuario con ese correo");
                    }
                    else
                    {
                        Cliente.AgregarCliente(nombre, apellidos, clave, correo, admin);
                        MessageBox.Show("Cliente registado");
                        txtCorreo.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        txtContra.Text = "";
                        txtConfirmContra.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El campo confirmar contraseña y contraseña deben contener la misma contraseña");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void pcbOjoAbierto_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado.Hide();
            pcbOjoAbierto.Show();
            txtContra.PasswordChar = '●';
        }

        private void pcbOjoCerrado_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto.Hide();
            pcbOjoCerrado.Show();
            txtContra.PasswordChar = '\0';
        }

        private void pcbOjoAbierto2_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado.Hide();
            pcbOjoAbierto.Show();
            txtConfirmContra.PasswordChar = '●';
        }

        private void pcbOjoCerrado2_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto.Hide();
            pcbOjoCerrado.Show();
            txtConfirmContra.PasswordChar = '\0';
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form formulario = Application.OpenForms[i];

                formulario.Close();
                formulario.Dispose();
            }
        }
    }
}
