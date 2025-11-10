using MimeKit;
using MailKit.Net.Smtp;
using MimeKit.Utils;

namespace MySimpleMailpitApplication
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var msg = new MimeMessage();

            msg.From.Add(new MailboxAddress("Edward from tech support", "no-reply@rnicfrosoft"));
            msg.To.Add(new MailboxAddress("Potential victim", "user@example.com"));
            msg.Subject = "Definitely not spam!";

            var bb = new BodyBuilder();
            bb.TextBody = "No formatting, no colors, no fonts, no images. Just plain text.";
            bb.HtmlBody = "<h1>Some header</h1><p>This is the <b>HTML</b> body of the e-mail.</p>";

            var img = bb.LinkedResources.Add("trust-me-i-am-a-dolphin.png");
            img.ContentId = MimeUtils.GenerateMessageId();
            bb.HtmlBody += $"<img src=\"cid:{img.ContentId}\">";

            msg.Body = bb.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("localhost", 1025, false);
            await smtp.SendAsync(msg);
            await smtp.DisconnectAsync(true);
        }
    }
}
