using System;
using System.Net.Mail;
using UtilidadesLibreria.Cliente;
/// <summary>
/// Clase para enviar correo de confirmación
/// </summary>
public class Correo
{
    public Correo(){}
    public string enviarCorreo(Cliente cliente)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpSever = new SmtpClient("smtp.gmail.com");
            //Especificamos el correo desde el que se enviará el Email y el nombre de la persona
            string asunto = "Cliente registrado satisfactoriamente";
            mail.From = new MailAddress("sjohanamq@gmail.com", asunto);
            SmtpSever.Host = "smtp.gmail.com";
            //Aqui ponemos el asunto del correo
            mail.Subject = asunto;
            mail.Body = "../login/CorreoDiseño.html";
            //Aqui ponemos el mensaje que incluira el correo
          
           
            mail.Body = "Se ha registrado el usuario: "+ cliente.Nombre+ " con el correo: "+cliente.Email;


            //especficar
            mail.To.Add("fgarcia@processoft.com.co");
            mail.To.Add("sjohanamq@gmail.com");
            
            //mail.atachment.add(new Attachment(@"Destino")) agregar una cosa
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            //Configuracion del SMTP
            SmtpSever.Port = 587;
            //Especificamos la credecial
            SmtpSever.Credentials = new System.Net.NetworkCredential("correoServicioPersonal@gmail.com", "Correo.servicio123.");
            SmtpSever.EnableSsl = true;
            SmtpSever.Send(mail);
            return "ok";
        }
        catch(Exception e)
        {
            return e.ToString();
        }
    }
}