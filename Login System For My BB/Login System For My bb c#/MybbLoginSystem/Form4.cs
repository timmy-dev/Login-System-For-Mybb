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
using System.Threading;
using System.Net;
using System.Security;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// 284, 261

namespace MybbLoginSystem
{
    public partial class Form4 : MetroForm
    {
        private WebClient wb;
        


        public Form4()
        {
            this.wb = new WebClient();
            InitializeComponent();
        }

        private Form1 otherForm = new Form1();

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Temp\skeletonid.txt");
            sw.WriteLine(Properties.Settings.Default.Username);
            sw.Close();
            webBrowser1.Navigate("http://siteurl/group.php?username=" + Properties.Settings.Default.Username);
            
            this.Text = ("Welcome " + Properties.Settings.Default.Username);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            

            Thread.Sleep(1000);
            timer1.Stop();
        }

        
        }

        
        
    }
