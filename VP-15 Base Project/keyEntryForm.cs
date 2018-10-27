using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using System.IO;

namespace VP_15_Base_Project
{

    public partial class keyEntryForm : MetroForm
    {
        public keyEntryForm()
        {
            InitializeComponent();
        }

        private void keyEntryForm_Load(object sender, EventArgs e)
        {
            if(txtIdEntry.Text != null)
            {
                if (txtSecretEntry.Text != null)
                {
                    injectKeysBTN.Enabled = true;
                    injectKeysBTN.Visible = true;
                }
            }
        }

        private void injectKeysBTN_Click(object sender, EventArgs e)
        {
            updateKeysFile();
        }
        public void updateKeysFile()
        {
            System.IO.StreamWriter SW;
            SW = File.CreateText;
            SW.WriteLine(txtIdEntry.Text+":"+txtSecretEntry.Text);
            SW.Close();
            
        }
    }
}
