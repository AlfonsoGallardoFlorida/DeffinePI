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
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private bool maximizar = true;

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }


        private void pcbspain_Click_1(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }
        private void pcbingle_Click(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();
        }

        private void IdiomaIngles()
        {
            lblDatos.Text = "LOGIN DATA";
            lblCorreo.Text = "E-Mail";
            lblContra.Text = "Password";
            lblConfirmContra.Text = "Confirm Password";
            lblDatosPers.Text = "PERSONAL DATA";
            lblNombre.Text = "Name";
            lblPrimerApe.Text = "First Surname";
            lblSegundoApe.Text = "Second Surname ";
            bttRegistrarse.Text = "Sign in";
            lblIdioma.Text = "Language";
        }
        private void IdiomaSpanish()
        {
            lblDatos.Text = "DATOS DE ACCESO";
            lblCorreo.Text = "Correo Electrónico";
            lblContra.Text = "Contraseña";
            lblConfirmContra.Text = "Confirmar Contraseña";
            lblDatosPers.Text = "DATOS PERSONALES";
            lblNombre.Text = "Nombre";
            lblPrimerApe.Text = "Primer Apellido";
            lblSegundoApe.Text = "Segundo Apellido";
            bttRegistrarse.Text = "Registrarse";
            lblIdioma.Text = "Idioma";

        }
        private void pcbOjoAbierto_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto.Hide();
            pcbOjoCerrado.Show();
            txtContra.PasswordChar = '\0';
        }
        private void pcbOjoCerrado_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado.Hide();
            pcbOjoAbierto.Show();
            txtContra.PasswordChar = '●';
        }
        private void pcbOjoCerradoConfirm_Click(object sender, EventArgs e)
        {
            pcbOjoCerradoConfirm.Hide();
            pcbOjoAbiertoConfirm.Show();
            txtConfirmContra.PasswordChar = '●';
        }
        private void pcbOjoAbiertoConfirm_Click(object sender, EventArgs e)
        {
            pcbOjoAbiertoConfirm.Hide();
            pcbOjoCerradoConfirm.Show();
            txtConfirmContra.PasswordChar = '\0';
        }

        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Estas seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Form formulario = Application.OpenForms[i];

                    formulario.Close();
                    formulario.Dispose();
                }
            }
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbMaximizar_Click(object sender, EventArgs e)
        {
            if (maximizar)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizar = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizar = true;
            }
        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }

        private void bttRegistrarse_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
            
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmInicio frm = new FrmInicio();
            frm.Show();
            this.Hide();
        }
    }
}
