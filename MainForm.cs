using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PandoraStandalone
{
    public partial class uxMainForm : Form
    {
        WebBrowser webBrowser;
        public uxMainForm()
        {
            InitializeComponent();
            webBrowser = new WebBrowser();
            this.Controls.Add(webBrowser);
            webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            webBrowser.Location = new System.Drawing.Point(0, 0);
            webBrowser.TabIndex = 0;
            webBrowser.AllowWebBrowserDrop = false;
            webBrowser.IsWebBrowserContextMenuEnabled = false;
            webBrowser.WebBrowserShortcutsEnabled = false;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.ScrollBarsEnabled = false;
        }

        private void uxMainForm_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://internal-tuner.pandora.com/windowsgadget/gadget.jsp");
        }
    }
}
