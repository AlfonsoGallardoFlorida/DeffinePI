using PIDeffine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Microsoft.SqlServer.Server;

namespace PIDeffine
{
    internal class Cliente
    {
        int idCliente;
        string nombre;
        string apellidos;
        string clave;
        string correo;
        bool administrador;

        public Cliente(string nom, string ape,  string clav, string corr, bool admin)
        {
            nombre = nom;
            apellidos = ape;
            clave = clav;
            correo = corr;
            administrador = admin;
        }

        public Cliente(int id, string nom, string ape, string clav, string corr, bool admin)
        {
            idCliente = id;
            nombre = nom;
            apellidos = ape;
            clave = clav;
            correo = corr;
            administrador = admin;
        }

        public static bool ComprobarExistencia(string correo)
        {
            MySqlConnection conexion = ConBD.Conexion;
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

        public static void AgregarCliente(string nombre, string apellidos, string clave, string correo, bool admin)
        {
            ConBD.AbrirConexion();
            Cliente nuevoCliente = new Cliente(nombre, apellidos, clave, correo, admin);
            string consulta = "INSERT INTO Clientes (Nombre, Apellido, Contraseña, Correo, Administrador) VALUES (@nombre, @apellidos,  @clave, @correo, @admin)";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("@nombre", nuevoCliente.nombre);
            comando.Parameters.AddWithValue("@apellidos", nuevoCliente.apellidos);
            comando.Parameters.AddWithValue("@correo", nuevoCliente.correo);
            comando.Parameters.AddWithValue("@clave", nuevoCliente.clave);
            comando.Parameters.AddWithValue("@admin", nuevoCliente.administrador ? 1 : 0);
            comando.ExecuteNonQuery();
            ConBD.CerrarConexion();
        }

        public static void BorrarCliente(string correo)
        {
            MySqlConnection conexion = ConBD.Conexion;
            ConBD.AbrirConexion();
            string consulta = string.Format("DELETE FROM Clientes WHERE Correo = '{0}'", correo);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.ExecuteNonQuery();
            ConBD.CerrarConexion();
        }

        public static string DevolverClave(string correo)
        {
            string contra = "";
            MySqlConnection conexion = ConBD.Conexion;
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT contraseña FROM Clientes WHERE correo = '{0}'", correo);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                contra = reader.GetString(0);
            }
            reader.Close();
            ConBD.CerrarConexion();
            return contra;
        }

        public static List<Cliente> clienteLogeado(string correo)
        {
           
            List<Cliente> clienteLog = new List<Cliente>();
            MySqlConnection conexion = ConBD.Conexion;
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT * FROM Clientes WHERE correo = '{0}'", correo);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("IdCliente");
                string nombre = (string)reader["Nombre"];
                string apellidos = (string)reader["Apellido"];
                string contraseña = (string)reader["Contraseña"];
                bool admin = (bool)reader["Administrador"];

                Cliente clienteLogeado = new Cliente(id, nombre, apellidos, contraseña, correo, admin);
                clienteLog.Add(clienteLogeado);
            }
                return clienteLog;
        }
    }
}
