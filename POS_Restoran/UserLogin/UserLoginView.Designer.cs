namespace POS_Restoran
{
    partial class UserLoginView
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelUsername.Location = new System.Drawing.Point(191, 128);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(88, 22);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPassword.Location = new System.Drawing.Point(191, 174);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 22);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUsername.Location = new System.Drawing.Point(324, 128);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(184, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPassword.Location = new System.Drawing.Point(324, 172);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(184, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Brush Script Std", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.Orange;
            this.buttonLogin.Location = new System.Drawing.Point(292, 222);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 36);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Brush Script Std", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Orange;
            this.labelTitle.Location = new System.Drawing.Point(149, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(394, 46);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "EdelWeiss Restaurant";
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(513, 175);
            this.checkBoxPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPass.TabIndex = 6;
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // UserLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.UserLoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxPass;
    }
}

