namespace Eclerx.ADO.Day16.Ex
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
            this.LblRegistration = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblEmailId = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtEmailId = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.DTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRegistration
            // 
            this.LblRegistration.AutoSize = true;
            this.LblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistration.Location = new System.Drawing.Point(311, 9);
            this.LblRegistration.Name = "LblRegistration";
            this.LblRegistration.Size = new System.Drawing.Size(95, 20);
            this.LblRegistration.TabIndex = 0;
            this.LblRegistration.Text = "Registration";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(171, 64);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(171, 101);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(58, 13);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Last Name";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(171, 135);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.LblBirthDate.TabIndex = 3;
            this.LblBirthDate.Text = "Birth Date";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(171, 167);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(40, 13);
            this.LblGender.TabIndex = 4;
            this.LblGender.Text = "gender";
            // 
            // LblEmailId
            // 
            this.LblEmailId.AutoSize = true;
            this.LblEmailId.Location = new System.Drawing.Point(171, 203);
            this.LblEmailId.Name = "LblEmailId";
            this.LblEmailId.Size = new System.Drawing.Size(44, 13);
            this.LblEmailId.TabIndex = 5;
            this.LblEmailId.Text = "Email Id";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(171, 240);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Password";
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Location = new System.Drawing.Point(171, 279);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.LblConfirmPassword.TabIndex = 7;
            this.LblConfirmPassword.Text = "Confirm Password";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(294, 61);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(175, 20);
            this.TxtFirstName.TabIndex = 9;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(294, 98);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(175, 20);
            this.TxtLastName.TabIndex = 10;
            // 
            // TxtEmailId
            // 
            this.TxtEmailId.Location = new System.Drawing.Point(294, 200);
            this.TxtEmailId.Name = "TxtEmailId";
            this.TxtEmailId.Size = new System.Drawing.Size(175, 20);
            this.TxtEmailId.TabIndex = 11;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(294, 237);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(175, 20);
            this.TxtPassword.TabIndex = 12;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(294, 276);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(175, 20);
            this.TxtConfirmPassword.TabIndex = 13;
            // 
            // ComboGender
            // 
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboGender.Location = new System.Drawing.Point(294, 164);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(175, 21);
            this.ComboGender.TabIndex = 14;
            // 
            // DTPBirthDate
            // 
            this.DTPBirthDate.Location = new System.Drawing.Point(294, 129);
            this.DTPBirthDate.Name = "DTPBirthDate";
            this.DTPBirthDate.Size = new System.Drawing.Size(175, 20);
            this.DTPBirthDate.TabIndex = 15;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnSignIn.Location = new System.Drawing.Point(174, 337);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(75, 23);
            this.BtnSignIn.TabIndex = 16;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnReset.Location = new System.Drawing.Point(456, 337);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 17;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Red;
            this.BtnSignUp.Location = new System.Drawing.Point(315, 337);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUp.TabIndex = 18;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(245, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "To SIGN IN Enter Email and Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.DTPBirthDate);
            this.Controls.Add(this.ComboGender);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmailId);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmailId);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblRegistration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistration;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblEmailId;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtEmailId;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.ComboBox ComboGender;
        private System.Windows.Forms.DateTimePicker DTPBirthDate;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label label1;
    }
}

