using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    class Correo
    {
        Messengers sms = new Messengers();
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();

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

                envios.Host = "smtp.live.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                //sms.textolb.Text = "Mensaje Enviado";
                //MessageBox.Show("El mensaje fue enviado correctamente");
                string message = "El Mensaje Fue Enviado Correctamente.";
                string caption = "HECHO";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                { // Closes the parent form.
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se Envio el Correo Correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
