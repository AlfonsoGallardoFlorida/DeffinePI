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
    public partial class FrmDisenyo : Form
    {
        public FrmDisenyo()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private void FrmDisenyo_Load(object sender, EventArgs e)
        {

        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

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

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form formulario = Application.OpenForms[i];

                formulario.Close();
                formulario.Dispose();
            }
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }
        }

        private void pcbBlanco_Click(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbBlanco.Image = PIDeffine.Properties.Resources.elipseblancaS;
            pcbCamiBlanca.Image = PIDeffine.Properties.Resources.camiblanca;
        }

        private void pcbNegro_Click(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbNegro.Image = PIDeffine.Properties.Resources.elipsenegraS;
            pcbCamiBlanca.BackColor = Color.White;
            pcbCamiBlanca.Image = PIDeffine.Properties.Resources.camiseta_roly_dogo_negra_1200Wx1200H_removebg_preview;
        }

        private void pcbAzul_Click(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbAzul.Image = PIDeffine.Properties.Resources.elipseazulS;
            pcbCamiBlanca.Image = PIDeffine.Properties.Resources.camiseta_m_c_roly_beagle_removebg_preview;

        }

        private void pcbVerde_Click(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbVerde.Image = PIDeffine.Properties.Resources.elipseverdeS;
            pcbCamiBlanca.Image = PIDeffine.Properties.Resources.CA6554_20_2_1_removebg_preview;

        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }
        private void DesmarcarColores()
        {
            pcbBlanco.Image = PIDeffine.Properties.Resources.elipseblanca;
            pcbAzul.Image = PIDeffine.Properties.Resources.elipseazul;
            pcbNegro.Image = PIDeffine.Properties.Resources.elipsenegra;
            pcbVerde.Image = PIDeffine.Properties.Resources.elipseverde;
            pcbCamiBlanca.BackColor = Color.Black;
        }

    }
}
