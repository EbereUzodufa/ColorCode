using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Color_Coder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim()=="")
            {
                MessageBox.Show("Input your name");
                return;
            }
            else if (richTxtSug.Text.Trim() == "")
            {
                MessageBox.Show("Input your Message");
                return;
            }
            else
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead("http://www.google.com"))
                        {
                            try
                            {
                                MailMessage message = new MailMessage();
                                SmtpClient smtp = new SmtpClient();

                                message.From = new MailAddress("app email");
                                message.To.Add(new MailAddress("receipent email"));
                                message.Subject = "Color Code Suggestions";
                                message.Body = "Category: Desktop Application" + "\r\n" + "Name: Color Code" + "\r\n" + "From: " + txtName.Text + "\r\n" +" "+"\r\n" + "Message"+"\r\n"+richTxtSug.Text;

                                smtp.Port = 587;
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("app email", "app email password");
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.Send(message);

                                MessageBox.Show("Successful");
                                txtName.Clear();
                                richTxtSug.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("err: " + ex.Message);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("No Internet Connection");
                    return;
                }
            }
        }

        private void linkClicked(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            link.LinkVisited = true;
            System.Diagnostics.Process.Start(link.Text);
        }
    }
}
