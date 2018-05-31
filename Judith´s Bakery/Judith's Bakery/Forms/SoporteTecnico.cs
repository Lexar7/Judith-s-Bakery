using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Judith_s_Bakery.Forms
{
    public partial class SoporteTecnico : Form
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();
        public SoporteTecnico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_contraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña de tu correo")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.isPassword = true;
            }
        }

        private void tb_contraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña de tu correo";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.isPassword = false;
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtRutaArchivo.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }

        private void btnEnivar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espera, esto puede tomar algunos minutos...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enviarCorreo(txtEmisor.Text, txtContraseña.Text, rtbMensaje.Text, txtAsunto.Text, "soporte.bakery1@gmail.com", txtRutaArchivo.Text);
        }

        public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());

                if (ruta.Equals("") == false)
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    correos.Attachments.Add(archivo);
                }

                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                MessageBox.Show("El mensaje fue enviado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoporteTecnico_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Q))
            {

                this.Close();
            }
        }     
    }
}
