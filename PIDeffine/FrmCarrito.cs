using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmCarrito : Form
    {

        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {

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

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
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

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = Producto.carrito;
        }
        private void CargarProductos()
        {
            ConBD.AbrirConexion();

            string consulta = "SELECT * FROM Detalles_Pedido";

            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);

            DataTable dataTable = new DataTable();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                dataTable.Load(reader);
            }

            dgvCarrito.DataSource = dataTable;
            ConBD.CerrarConexion();
        }

        private void bttFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
