using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Judith_s_Bakery.Forms
{
    public partial class RecuperarContraseña : Form
    {

        Encriptar_Desencriptar enc = new Encriptar_Desencriptar();
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No puede dejar el campo vacio, escriba un correo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection cn = DataBase.Conexion();
                SqlCommand cmd = new SqlCommand("ValidarCorreo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                try
                {
                    // cn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();
                    if (lector.Read())
                    {

                        GenerarNuevaContrasena(txtCorreo.Text);
                    }
                    else
                    {
                        MessageBox.Show("Correo no encontrado");

                    }

                    DataBase.Conexion().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        public void GenerarNuevaContrasena(string email)
        {
          Random obj = new Random();
          string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
          int longitud = posibles.Length;

          char letra;

          int longitudnuevacadena = 5;

          string nuevacadena = "";
          for (int i = 0; i < longitudnuevacadena; i++)

          {

            letra = posibles[obj.Next(longitud)];

            nuevacadena += letra.ToString();

          }

            SqlConnection cn = DataBase.Conexion();
            SqlCommand cmd = new SqlCommand("NuevaContra", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@correo", email);
            cmd.Parameters.AddWithValue("@contrasena", enc.EncryptKey(nuevacadena));
            try
            {
                // cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevacadena, email);
                }
            }
            catch
            {

            }


        }

        private void EnviarCorreoContrasena(string contrasenaNueva, string correo)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "soporte.bakery1@gmail.com";
            string asunto = "Nueva contraseña - Judith Bakery";
            string cuerpoDelMesaje = "Su nueva contraseña es" + " " + Convert.ToString(contrasenaNueva) +  " Por favor ponerse en contacto con el administrador despues de recibir este correo.";
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("soporte.bakery1@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, por favor revisar su correo","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBase.Conexion().Close();
            this.Close();
        }

         public string Contrasena
        {
            get
            { return "bakery1234"; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecuperarContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }
    }

    }

