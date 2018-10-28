using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace VP_15_Base_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers

        private void cmdGO_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = cboURIs.Text;

            switch(cboVerb.Text)
            {
                case "POST":
                    rClient.httpMethod = httpVerb.POST;
                    rClient.postData = txtPOSTData.Text;
                    rClient.authToken = txtAuthToken.Text;
                    rClient.clientID = txtClientID.Text;
                    rClient.clientSecret = txtClientSecret.Text;

                    break;
                default:
                    rClient.httpMethod = httpVerb.GET;
                    break;
            }



            

            debugOutput("REST Client Created");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtResponse.Text = string.Empty;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtResponse.Text);
        }

        #endregion
        
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        private void getTokenBTN_Click(object sender, EventArgs e)
        {
            //String xmlfile = txtResponse["XML_File"];
            token();
        }

        void token()
        {
            
            if(txtResponse.Text != null)
            {
                string[] tokenString = txtResponse.Text.Split('"');
                returnTokenTB.Text = tokenString[3];
            }
            else
            {
                MessageBox.Show("Attain A Token First", "Execution Error!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("..//clientKeys.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if(line.Contains(':'))
                    {
                        line.Replace(':', '\r');
                    }
                    string[] keys = line.Split(':');
                    txtClientID.Text = keys[0];
                    txtClientSecret.Text = keys[1];
                }
            }
            cmdGO.PerformClick();    // Process line
            //txtResponse.Text.Substring()
        }
    }
}



