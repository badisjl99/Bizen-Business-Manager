using AppTest.AppLogin;
using AppTest.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AppTest.SignUp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            SetButtonStyle();
        }

        private void SetButtonStyle()
        {
            VerifyButton.BackColor = Color.Transparent;
            VerifyButton.FlatStyle = FlatStyle.Flat;
            VerifyButton.FlatAppearance.BorderSize = 0;
            VerifyButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            VerifyButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            VerifyButton.BackgroundImage = GetGradientImage();


            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, VerifyButton.Width - 1, VerifyButton.Height - 1);
            VerifyButton.Region = new Region(path);
        }


        public static void SendVerifyMail(Admin admin)
        {
            string emailSender = "syst.mailer.manager@gmail.com";
            string emailPassword = "ayybwnlbyztcbdnb";
            string subject = "Test 1 Is Working !";
            string body = $@"Dear [New Staff's Name],

                        Welcome aboard! We're thrilled to have you join [Company Name]. Below are your credentials to access our systems:

                        Employee ID: {admin.id}
                        Password: {admin.password}

                        Please keep these credentials confidential. If you have any questions, contact our IT support at [IT Support Email/Phone].

                        We have an orientation on [Orientation Date/Time]. Dress code: [Dress Code], Working hours: [Working Hours].

                        Looking forward to your success!

                        Best regards,
                        {admin.name} {admin.lastname}
                        Staff Manager
                        syst.mailer.manager@gmail.com
                        +21624571421";

            string[] recipients = { admin.email };

            foreach (string emailReceiver in recipients)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailSender);
                mail.To.Add(emailReceiver);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(emailSender, emailPassword);
                smtpClient.EnableSsl = true;

                // Handle SSL certificate validation (for Gmail)
                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(ValidateServerCertificate);

                try
                {
                    smtpClient.Send(mail);
                    MessageBox.Show("Email Sent Successfully!");
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show($"Error occurred while sending email to {emailReceiver}: {ex.Message}");
                }
            }
        }

        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Accept all certificates (for testing purposes only)
            return true;
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string reference = ReferenceBox.Text;
            string key = "#CMP0129NSXYM7S";

            if (reference.Equals(key))
            {
                SignUpUC signUp = new SignUpUC();
                signUp.Dock = DockStyle.Fill; 
                panel1.Controls.Clear();
                panel1.Controls.Add(signUp);

                
                signUp.Anchor = AnchorStyles.None;

            }
            else
            {
                MessageBox.Show("No Company Found With That Key !");
            }

        }

        private Image GetGradientImage()
        {
            // Replace these colors with the colors you want for your gradient
            Color startColor = Color.FromArgb(41, 169, 110); // Example: Pink
            Color endColor = Color.FromArgb(22, 156, 216);    // Example: Blue

            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(VerifyButton.Width, VerifyButton.Height),
                startColor,
                endColor
            );

            Bitmap image = new Bitmap(VerifyButton.Width, VerifyButton.Height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(brush, new Rectangle(0, 0, VerifyButton.Width, VerifyButton.Height));

            return image;
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
