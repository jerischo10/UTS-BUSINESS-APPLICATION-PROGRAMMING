namespace POS_Restoran
{
    partial class EditUserRecordView
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(570, 203);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(22, 21);
            this.checkBoxPass.TabIndex = 12;
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(213, 259);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 45);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Action";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPassword.Location = new System.Drawing.Point(357, 199);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(206, 26);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUsername.Location = new System.Drawing.Point(357, 144);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(206, 26);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPassword.Location = new System.Drawing.Point(208, 202);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 27);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelUsername.Location = new System.Drawing.Point(208, 144);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(108, 27);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Orange;
            this.labelTitle.Location = new System.Drawing.Point(222, 66);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(322, 55);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Add/Edit User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Orange;
            this.buttonBack.Location = new System.Drawing.Point(430, 259);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 45);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EditUserRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "EditUserRecordView";
            this.Text = "Add/Edit User";
            this.Load += new System.EventHandler(this.AddUserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonBack;
    }
}