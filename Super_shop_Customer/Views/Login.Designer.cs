namespace Super_shop_Customer
{
    partial class Login
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
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.fogotPaasLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.loginBox.Controls.Add(this.linkLabel1);
            this.loginBox.Controls.Add(this.txtID);
            this.loginBox.Controls.Add(this.fogotPaasLinkLabel);
            this.loginBox.Controls.Add(this.loginButton);
            this.loginBox.Controls.Add(this.txtpass);
            this.loginBox.Controls.Add(this.idLabel);
            this.loginBox.Controls.Add(this.passLabel);
            this.loginBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBox.Location = new System.Drawing.Point(33, 28);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBox.Name = "loginBox";
            this.loginBox.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBox.Size = new System.Drawing.Size(504, 497);
            this.loginBox.TabIndex = 8;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 129);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 29);
            this.txtID.TabIndex = 2;
            // 
            // fogotPaasLinkLabel
            // 
            this.fogotPaasLinkLabel.AutoSize = true;
            this.fogotPaasLinkLabel.LinkColor = System.Drawing.Color.Silver;
            this.fogotPaasLinkLabel.Location = new System.Drawing.Point(60, 324);
            this.fogotPaasLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fogotPaasLinkLabel.Name = "fogotPaasLinkLabel";
            this.fogotPaasLinkLabel.Size = new System.Drawing.Size(104, 21);
            this.fogotPaasLinkLabel.TabIndex = 4;
            this.fogotPaasLinkLabel.TabStop = true;
            this.fogotPaasLinkLabel.Text = "Forgot Pass?";
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(256, 256);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 44);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(227, 199);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(177, 29);
            this.txtpass.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.idLabel.Location = new System.Drawing.Point(109, 129);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(90, 19);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Employee ID:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passLabel.Location = new System.Drawing.Point(132, 199);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(71, 19);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(296, 324);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dont Have Account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(571, 553);
            this.Controls.Add(this.loginBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.LinkLabel fogotPaasLinkLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

