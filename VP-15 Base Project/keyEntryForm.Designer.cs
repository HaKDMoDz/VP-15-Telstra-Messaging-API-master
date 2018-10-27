namespace VP_15_Base_Project
{
    partial class keyEntryForm
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
            this.injectKeysBTN = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtIdEntry = new MetroFramework.Controls.MetroTextBox();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.txtSecretEntry = new MetroFramework.Controls.MetroTextBox();
            this.idLBL = new MetroFramework.Controls.MetroLabel();
            this.secretLBL = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // injectKeysBTN
            // 
            this.injectKeysBTN.Enabled = false;
            this.injectKeysBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.injectKeysBTN.Image = null;
            this.injectKeysBTN.Location = new System.Drawing.Point(304, 204);
            this.injectKeysBTN.Name = "injectKeysBTN";
            this.injectKeysBTN.Size = new System.Drawing.Size(75, 23);
            this.injectKeysBTN.Style = MetroFramework.MetroColorStyle.White;
            this.injectKeysBTN.TabIndex = 0;
            this.injectKeysBTN.Text = "Add Keys";
            this.injectKeysBTN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.injectKeysBTN.UseSelectable = true;
            this.injectKeysBTN.UseStyleColors = true;
            this.injectKeysBTN.UseVisualStyleBackColor = true;
            this.injectKeysBTN.Visible = false;
            this.injectKeysBTN.Click += new System.EventHandler(this.injectKeysBTN_Click);
            // 
            // txtIdEntry
            // 
            // 
            // 
            // 
            this.txtIdEntry.CustomButton.Image = null;
            this.txtIdEntry.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtIdEntry.CustomButton.Name = "";
            this.txtIdEntry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdEntry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdEntry.CustomButton.TabIndex = 1;
            this.txtIdEntry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdEntry.CustomButton.UseSelectable = true;
            this.txtIdEntry.CustomButton.Visible = false;
            this.txtIdEntry.Lines = new string[0];
            this.txtIdEntry.Location = new System.Drawing.Point(185, 113);
            this.txtIdEntry.MaxLength = 32767;
            this.txtIdEntry.Name = "txtIdEntry";
            this.txtIdEntry.PasswordChar = '\0';
            this.txtIdEntry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdEntry.SelectedText = "";
            this.txtIdEntry.SelectionLength = 0;
            this.txtIdEntry.SelectionStart = 0;
            this.txtIdEntry.Size = new System.Drawing.Size(194, 23);
            this.txtIdEntry.Style = MetroFramework.MetroColorStyle.White;
            this.txtIdEntry.TabIndex = 1;
            this.txtIdEntry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtIdEntry.UseSelectable = true;
            this.txtIdEntry.UseStyleColors = true;
            this.txtIdEntry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdEntry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(185, 207);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 21);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggle1.TabIndex = 2;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.UseStyleColors = true;
            // 
            // txtSecretEntry
            // 
            // 
            // 
            // 
            this.txtSecretEntry.CustomButton.Image = null;
            this.txtSecretEntry.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtSecretEntry.CustomButton.Name = "";
            this.txtSecretEntry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSecretEntry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSecretEntry.CustomButton.TabIndex = 1;
            this.txtSecretEntry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSecretEntry.CustomButton.UseSelectable = true;
            this.txtSecretEntry.CustomButton.Visible = false;
            this.txtSecretEntry.Lines = new string[0];
            this.txtSecretEntry.Location = new System.Drawing.Point(185, 142);
            this.txtSecretEntry.MaxLength = 32767;
            this.txtSecretEntry.Name = "txtSecretEntry";
            this.txtSecretEntry.PasswordChar = '\0';
            this.txtSecretEntry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecretEntry.SelectedText = "";
            this.txtSecretEntry.SelectionLength = 0;
            this.txtSecretEntry.SelectionStart = 0;
            this.txtSecretEntry.Size = new System.Drawing.Size(194, 23);
            this.txtSecretEntry.Style = MetroFramework.MetroColorStyle.White;
            this.txtSecretEntry.TabIndex = 3;
            this.txtSecretEntry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSecretEntry.UseSelectable = true;
            this.txtSecretEntry.UseStyleColors = true;
            this.txtSecretEntry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSecretEntry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idLBL
            // 
            this.idLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.idLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.idLBL.Location = new System.Drawing.Point(23, 113);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(156, 23);
            this.idLBL.Style = MetroFramework.MetroColorStyle.Teal;
            this.idLBL.TabIndex = 4;
            this.idLBL.Text = "Client ID:";
            this.idLBL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.idLBL.UseStyleColors = true;
            // 
            // secretLBL
            // 
            this.secretLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.secretLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.secretLBL.Location = new System.Drawing.Point(23, 145);
            this.secretLBL.Name = "secretLBL";
            this.secretLBL.Size = new System.Drawing.Size(140, 20);
            this.secretLBL.Style = MetroFramework.MetroColorStyle.Yellow;
            this.secretLBL.TabIndex = 5;
            this.secretLBL.Text = "Client Secret:";
            this.secretLBL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.secretLBL.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 207);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Client Secret:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // keyEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 278);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.secretLBL);
            this.Controls.Add(this.idLBL);
            this.Controls.Add(this.txtSecretEntry);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.txtIdEntry);
            this.Controls.Add(this.injectKeysBTN);
            this.MaximizeBox = false;
            this.Name = "keyEntryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENT KEY ENTRY";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.keyEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton injectKeysBTN;
        private MetroFramework.Controls.MetroTextBox txtIdEntry;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroTextBox txtSecretEntry;
        private MetroFramework.Controls.MetroLabel idLBL;
        private MetroFramework.Controls.MetroLabel secretLBL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}