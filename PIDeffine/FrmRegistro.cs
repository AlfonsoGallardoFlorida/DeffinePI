﻿using System;
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
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
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

        private void pcbOjoAbierto2_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto.Hide();
            pcbOjoCerrado.Show();
            txtContra.PasswordChar = '\0';
        }

        private void pcbOjoCerrado2_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado.Hide();
            pcbOjoAbierto.Show();
            txtContra.PasswordChar = '●';
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }


        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            this.Close();
        }
    }
}
