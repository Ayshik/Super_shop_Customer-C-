namespace Super_shop_Customer.Views
{
    partial class CustomerSignup
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
            this.lblfullname = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.lblphn = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.cancelButon = new System.Windows.Forms.Button();
            this.bloodComboBox = new System.Windows.Forms.ComboBox();
            this.grpboxreg = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpboxreg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfullname
            // 
            this.lblfullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfullname.AutoSize = true;
            this.lblfullname.Location = new System.Drawing.Point(186, 61);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(57, 13);
            this.lblfullname.TabIndex = 25;
            this.lblfullname.Text = "Full Name:";
            this.lblfullname.Click += new System.EventHandler(this.lblfullname_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(180, 195);
            this.Gender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 26;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // lblphn
            // 
            this.lblphn.AutoSize = true;
            this.lblphn.Location = new System.Drawing.Point(168, 125);
            this.lblphn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblphn.Name = "lblphn";
            this.lblphn.Size = new System.Drawing.Size(81, 13);
            this.lblphn.TabIndex = 27;
            this.lblphn.Text = "Phone Number:";
            this.lblphn.Click += new System.EventHandler(this.lblphn_Click);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(214, 251);
            this.lblmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(35, 13);
            this.lblmail.TabIndex = 29;
            this.lblmail.Text = "Email:";
            this.lblmail.Click += new System.EventHandler(this.lblmail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fullNameTextBox.Location = new System.Drawing.Point(333, 61);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(494, 20);
            this.fullNameTextBox.TabIndex = 32;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.fullNameTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(333, 125);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(494, 20);
            this.phoneNumberTextBox.TabIndex = 33;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(332, 248);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(494, 20);
            this.emailTextbox.TabIndex = 34;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(332, 306);
            this.addressBox.Margin = new System.Windows.Forms.Padding(6);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(494, 55);
            this.addressBox.TabIndex = 38;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // registrationButton
            // 
            this.registrationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrationButton.Location = new System.Drawing.Point(721, 784);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(6);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(92, 43);
            this.registrationButton.TabIndex = 39;
            this.registrationButton.Text = "Register";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // cancelButon
            // 
            this.cancelButon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButon.Location = new System.Drawing.Point(622, 910);
            this.cancelButon.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButon.Name = "cancelButon";
            this.cancelButon.Size = new System.Drawing.Size(92, 43);
            this.cancelButon.TabIndex = 39;
            this.cancelButon.Text = "Cancel";
            this.cancelButon.UseVisualStyleBackColor = true;
            this.cancelButon.Click += new System.EventHandler(this.cancelButon_Click);
            // 
            // bloodComboBox
            // 
            this.bloodComboBox.FormattingEnabled = true;
            this.bloodComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.bloodComboBox.Location = new System.Drawing.Point(333, 192);
            this.bloodComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.bloodComboBox.Name = "bloodComboBox";
            this.bloodComboBox.Size = new System.Drawing.Size(181, 21);
            this.bloodComboBox.TabIndex = 42;
            this.bloodComboBox.SelectedIndexChanged += new System.EventHandler(this.bloodComboBox_SelectedIndexChanged);
            // 
            // grpboxreg
            // 
            this.grpboxreg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.grpboxreg.Controls.Add(this.textBox3);
            this.grpboxreg.Controls.Add(this.label3);
            this.grpboxreg.Controls.Add(this.textBox2);
            this.grpboxreg.Controls.Add(this.label2);
            this.grpboxreg.Controls.Add(this.textBox1);
            this.grpboxreg.Controls.Add(this.label1);
            this.grpboxreg.Controls.Add(this.button1);
            this.grpboxreg.Controls.Add(this.bloodComboBox);
            this.grpboxreg.Controls.Add(this.cancelButon);
            this.grpboxreg.Controls.Add(this.registrationButton);
            this.grpboxreg.Controls.Add(this.addressBox);
            this.grpboxreg.Controls.Add(this.emailTextbox);
            this.grpboxreg.Controls.Add(this.phoneNumberTextBox);
            this.grpboxreg.Controls.Add(this.fullNameTextBox);
            this.grpboxreg.Controls.Add(this.label4);
            this.grpboxreg.Controls.Add(this.lblmail);
            this.grpboxreg.Controls.Add(this.lblphn);
            this.grpboxreg.Controls.Add(this.Gender);
            this.grpboxreg.Controls.Add(this.lblfullname);
            this.grpboxreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpboxreg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpboxreg.Location = new System.Drawing.Point(13, 6);
            this.grpboxreg.Margin = new System.Windows.Forms.Padding(6);
            this.grpboxreg.Name = "grpboxreg";
            this.grpboxreg.Padding = new System.Windows.Forms.Padding(6);
            this.grpboxreg.Size = new System.Drawing.Size(957, 739);
            this.grpboxreg.TabIndex = 4;
            this.grpboxreg.TabStop = false;
            this.grpboxreg.Text = "Register";
            this.grpboxreg.Enter += new System.EventHandler(this.grpboxreg_Enter);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(505, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 43;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(333, 401);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Security Question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(454, 472);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 47;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(454, 543);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 20);
            this.textBox3.TabIndex = 49;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Your User Id Is------------------";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CustomerSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 749);
            this.Controls.Add(this.grpboxreg);
            this.Name = "CustomerSignup";
            this.Text = "CustomerSignup";
            this.Load += new System.EventHandler(this.CustomerSignup_Load);
            this.grpboxreg.ResumeLayout(false);
            this.grpboxreg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label lblphn;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button cancelButon;
        private System.Windows.Forms.ComboBox bloodComboBox;
        private System.Windows.Forms.GroupBox grpboxreg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}