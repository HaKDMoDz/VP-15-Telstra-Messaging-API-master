using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using Selenium.WebDriver;
using OpenQA.Selenium.Support.UI;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Fonts;


namespace VP_15_Base_Project
{

    public partial class keyEntryForm : MetroForm
    {
        
        public keyEntryForm()
        {
            this.Size = new Size(673, 263);
            InitializeComponent();
            DialogResult dialogResult = MetroMessageBox.Show(this,"\r\n\r\nSms Companion Requires 2 KEYS!\r\nDo YOU have a Client ID & Client Secret ?", "Access Activation Keys Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                metroPanel1.Visible = false;
                metroPanel1.Enabled = false;
                
                txtIdEntry.Select();
            }
            else
            {
                this.Size = new Size(618, 434);
                this.registerWB.Navigate("https://dev.telstra.com/telstra_ui/nojs/register");
                registerWB.Dock = DockStyle.Fill;                               
            }

        }
        
        private void keyEntryForm_Load(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Please Enter Client ID && Secret\r\nSwitch 'ON' to use existing keys", "Key Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtIdEntry.Select();
        }

        private void injectKeysBTN_Click(object sender, EventArgs e)
        {
            updateKeysFile();
        }
        public void updateKeysFile()
        {
            System.IO.StreamWriter SW;
            SW = File.CreateText("..\\clientKeys.txt");
            SW.WriteLine(txtIdEntry.Text+":"+txtSecretEntry.Text);
            SW.Close();
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
            

        }

        private void txtIdEntry_Enter(object sender, EventArgs e)
        {
            injectKeysBTN.Visible = true;
        }

        private void txtSecretEntry_Leave(object sender, EventArgs e)
        {
            injectKeysBTN.Enabled = true;
        }

        private void txtIdEntry_ButtonClick(object sender, EventArgs e)
        {
            txtIdEntry.Text=Clipboard.GetText();
        }

        private void txtSecretEntry_ButtonClick(object sender, EventArgs e)
        {
            txtSecretEntry.Text = Clipboard.GetText();
        }
        
        private void registerWB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string path = registerWB.Url.AbsoluteUri;
            if (registerWB.Url.ToString() == "https://dev.telstra.com/telstra_ui/nojs/register")
            {
                MetroMessageBox.Show(this, "Register to get your free client credentials", "Client Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (registerWB.Url.ToString() == "https://dev.telstra.com/user/me/apps")
            {
                MetroMessageBox.Show(this,"Copy your new Application Keys\r\n\r\nPaste client key into box\r\nPaste Client Secret in second box\r\nPress Save", "User Key Configuration", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void useOldKeysTS_CheckedChanged(object sender, EventArgs e)
        {
            if(useOldKeysTS.Checked == true)
            {
                txtIdEntry.Select();
                txtIdEntry.Clear();
                txtSecretEntry.Select();
                txtSecretEntry.Clear();
                Form1 f = new Form1();
                f.Show();
                
            }
        }
    }
}
