namespace VP_15_Base_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdGO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVerb = new System.Windows.Forms.ComboBox();
            this.txtPOSTData = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboURIs = new System.Windows.Forms.ComboBox();
            this.txtAuthToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getTokenBTN = new System.Windows.Forms.Button();
            this.returnTokenTB = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.phLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(121, 277);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(903, 211);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdGO
            // 
            this.cmdGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGO.Location = new System.Drawing.Point(925, 12);
            this.cmdGO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGO.Name = "cmdGO";
            this.cmdGO.Size = new System.Drawing.Size(100, 28);
            this.cmdGO.TabIndex = 2;
            this.cmdGO.Text = "GO!";
            this.cmdGO.UseVisualStyleBackColor = true;
            this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response:";
            // 
            // cboVerb
            // 
            this.cboVerb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVerb.FormattingEnabled = true;
            this.cboVerb.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cboVerb.Location = new System.Drawing.Point(788, 14);
            this.cboVerb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboVerb.Name = "cboVerb";
            this.cboVerb.Size = new System.Drawing.Size(105, 24);
            this.cboVerb.TabIndex = 11;
            this.cboVerb.Text = "POST";
            // 
            // txtPOSTData
            // 
            this.txtPOSTData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOSTData.Location = new System.Drawing.Point(121, 164);
            this.txtPOSTData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPOSTData.Multiline = true;
            this.txtPOSTData.Name = "txtPOSTData";
            this.txtPOSTData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPOSTData.Size = new System.Drawing.Size(903, 91);
            this.txtPOSTData.TabIndex = 12;
            // 
            // cmdClear
            // 
            this.cmdClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdClear.Location = new System.Drawing.Point(121, 507);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(100, 28);
            this.cmdClear.TabIndex = 13;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCopy.Location = new System.Drawing.Point(231, 507);
            this.cmdCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(100, 28);
            this.cmdCopy.TabIndex = 14;
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Post Data";
            // 
            // cboURIs
            // 
            this.cboURIs.FormattingEnabled = true;
            this.cboURIs.Items.AddRange(new object[] {
            "https://tapi.telstra.com/v2/oauth/token",
            "https://tapi.telstra.com/v2/messages/provisioning/subscriptions",
            "https://tapi.telstra.com/v2/messages/sms"});
            this.cboURIs.Location = new System.Drawing.Point(121, 12);
            this.cboURIs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboURIs.Name = "cboURIs";
            this.cboURIs.Size = new System.Drawing.Size(411, 24);
            this.cboURIs.TabIndex = 16;
            this.cboURIs.Text = "https://tapi.telstra.com/v2/oauth/token";
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Location = new System.Drawing.Point(121, 132);
            this.txtAuthToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.Size = new System.Drawing.Size(903, 22);
            this.txtAuthToken.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Auth Token:";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(121, 100);
            this.txtClientSecret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(308, 22);
            this.txtClientSecret.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Client Secret:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(121, 68);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(308, 22);
            this.txtClientID.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Client ID:";
            // 
            // getTokenBTN
            // 
            this.getTokenBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getTokenBTN.Location = new System.Drawing.Point(433, 507);
            this.getTokenBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getTokenBTN.Name = "getTokenBTN";
            this.getTokenBTN.Size = new System.Drawing.Size(100, 28);
            this.getTokenBTN.TabIndex = 23;
            this.getTokenBTN.Text = "Token";
            this.getTokenBTN.UseVisualStyleBackColor = true;
            this.getTokenBTN.Click += new System.EventHandler(this.getTokenBTN_Click);
            // 
            // returnTokenTB
            // 
            this.returnTokenTB.Location = new System.Drawing.Point(541, 511);
            this.returnTokenTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnTokenTB.Name = "returnTokenTB";
            this.returnTokenTB.Size = new System.Drawing.Size(483, 22);
            this.returnTokenTB.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(616, 68);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(308, 22);
            this.txtPhone.TabIndex = 25;
            // 
            // phLBL
            // 
            this.phLBL.AutoSize = true;
            this.phLBL.Location = new System.Drawing.Point(533, 71);
            this.phLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phLBL.Name = "phLBL";
            this.phLBL.Size = new System.Drawing.Size(53, 17);
            this.phLBL.TabIndex = 26;
            this.phLBL.Text = "Phone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 550);
            this.Controls.Add(this.phLBL);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.returnTokenTB);
            this.Controls.Add(this.getTokenBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthToken);
            this.Controls.Add(this.cboURIs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtPOSTData);
            this.Controls.Add(this.cboVerb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGO);
            this.Controls.Add(this.txtResponse);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(583, 278);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms Companion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVerb;
        private System.Windows.Forms.TextBox txtPOSTData;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboURIs;
        private System.Windows.Forms.TextBox txtAuthToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getTokenBTN;
        private System.Windows.Forms.TextBox returnTokenTB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label phLBL;
    }
}

