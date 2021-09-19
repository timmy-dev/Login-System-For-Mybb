using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;



namespace MybbLoginSystem
{
    public partial class Form1 : MetroForm
    {
        bool username;
        bool usergroup;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            metroCheckBox1.Checked = true;
            metroTextBox1.Text = Properties.Settings.Default.Username;
            metroTextBox2.Text = Properties.Settings.Default.Password;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://siteurl/check.php?username=" + metroTextBox1.Text + "&password=" + metroTextBox2.Text);
            username = true;

            Properties.Settings.Default.Username = metroTextBox1.Text;
            Properties.Settings.Default.Password = metroTextBox2.Text;
            Properties.Settings.Default.Checked = metroCheckBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (username == true)
            {
                if (webBrowser1.DocumentText.Contains("0"))
                {
                    username = false;
                    MessageBox.Show("Password incorrect");
                }
                else if (webBrowser1.DocumentText.Contains("1"))
                {
                    usergroup = true;
                    username = false;
                    webBrowser2.Navigate("http://siteurl/group.php?username=" + metroTextBox1.Text);
                }
                else if (webBrowser2.DocumentText.Contains("2"))
                {
                    username = false;
                    MessageBox.Show("No user with that name");
                }
            }
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (usergroup == true)
            {
                if (webBrowser2.DocumentText.Contains("4") || webBrowser2.DocumentText.Contains("8"))
                {
                    usergroup = false;
                    this.Hide();
                    var form2 = new Form4();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                // General statment, if the group isn't in the list, they get thrown this
                else
                {
                    MessageBox.Show("Group incorrect");
                    usergroup = false;
                }
            }
        }

        

  

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://siteurl/member.php?action=lostpw");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://siteurl/member.php?action=register");
        }

        
    }
}
//ARMINIUS