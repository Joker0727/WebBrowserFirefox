using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gecko;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        GeckoWebBrowser browser;
        public Form1()
        {
            InitializeComponent();
           
            var app_dir = Path.GetDirectoryName(Application.ExecutablePath);
            Xpcom.Initialize(Path.Combine(app_dir, "xulrunner"));

            browser = new GeckoWebBrowser();

            browser.Dock = DockStyle.Fill;
            this.browser.Name = "browser";

            this.Controls.Add(browser);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser.Navigate("https://www.dianping.com/");
        }
    }
}
