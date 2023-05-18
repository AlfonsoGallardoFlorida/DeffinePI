using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void bttInsertarUser_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string clave = txtContra.Text;
            string correo = txtCorreo.Text;
            string confContra = txtConfContra.Text;
            bool admin;
            if (chkAdmin.Checked)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            if (correo != "" && nombre != "" && apellidos != "" && clave != "" && confContra != "")
            {
                if (confContra == clave)
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
                        txtConfContra.Text = "";
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

        private void bttEliminarUser_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;

            if (correo != "")
            {
                Cliente.BorrarCliente(correo);
                txtCorreo.Text = "";
                MessageBox.Show("Usuario borrado correctamente");
            }
            else
            {
                MessageBox.Show("Debe especificar un correo");
            }
        }

        private void bttInsertarProd_Click(object sender, EventArgs e, Producto prod)
        {
            string descripcion = txtDescripcion.Text;
            int stock = Convert.ToInt32(nudStock.Value);
            decimal precio = Convert.ToDecimal(nudPrecio.Value);
            string talla = cmbTalla.Text;
            string color = cmbColor.Text;
            string genero = cmbGenero.Text;
            byte[] img = pcbFotoCamiseta;
            Producto.AgregarProducto(descripcion, talla, genero, color, precio, stock, img);
        }

        private void bttAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = @"C:\";
            if (cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pcbFotoCamiseta.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
