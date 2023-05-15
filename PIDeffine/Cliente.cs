using PIDeffine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data.SqlClient;

namespace PIDeffine
{
    internal class Cliente
    {
        int idCliente;
        string nombre;
        string apellidos;
        string correo;
        string clave;
        bool administrador;

        public Cliente(string nom, string ape, string corr, string clav, bool admin)
        {
            nombre = nom;
            apellidos = ape;
            correo = corr;
            clave = clav;
            administrador = admin;
        }

        public static bool ComprobarExistencia(string correo)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT idCliente FROM Clientes WHERE correo = '{0}'", correo);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                ConBD.CerrarConexion();
                return true;
            }
            else
            {
                reader.Close();
                ConBD.CerrarConexion();
                return false;
            }
        }

        public static bool ComprobarClave(string correo, string clave)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT idCliente FROM Clientes WHERE correo = '{0}' AND contraseña = '{1}'", correo, clave);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                ConBD.CerrarConexion();
                return true;
            }
            else
            {
                reader.Close();
                ConBD.CerrarConexion();
                return false;
            }
        }

        public static bool ComprobarAdmin(string correo)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT idCliente FROM Clientes WHERE correo = '{0}' AND administrador = true", correo);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                ConBD.CerrarConexion();
                return true;
            }
            else
            {
                reader.Close();
                ConBD.CerrarConexion();
                return false;
            }
        }

        public static void AgregarCliente(string nombre, string apellidos, string correo, string clave, bool admin)
        {
            ConBD.AbrirConexion();
            Cliente nuevoCliente = new Cliente(nombre, apellidos, correo, clave, admin);
            string consulta = "INSERT INTO Clientes (Nombre, Apellidos, Correo, Clave, Administrador) VALUES (@nombre, @apellidos, @correo, @clave, @admin)";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("@nombre", nuevoCliente.nombre);
            comando.Parameters.AddWithValue("@apellido", nuevoCliente.apellidos);
            comando.Parameters.AddWithValue("@correo", nuevoCliente.correo);
            comando.Parameters.AddWithValue("@clave", nuevoCliente.clave);
            comando.Parameters.AddWithValue("@admin", nuevoCliente.administrador ? 1 : 0);
            comando.ExecuteNonQuery();
            ConBD.CerrarConexion();
        }

        public static void BorrarCliente(int idCliente)
        {

        }
    }
}
