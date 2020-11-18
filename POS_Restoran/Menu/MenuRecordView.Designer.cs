namespace POS_Restoran
{
    partial class MenuRecordView
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelTipe = new System.Windows.Forms.Label();
            this.comboBoxTipe = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Orange;
            this.buttonBack.Location = new System.Drawing.Point(430, 322);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 45);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Orange;
            this.labelTitle.Location = new System.Drawing.Point(222, 91);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(344, 55);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Add/Edit Menu";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(213, 322);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 45);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Action";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHarga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxHarga.Location = new System.Drawing.Point(357, 201);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(206, 26);
            this.textBoxHarga.TabIndex = 18;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNama.Location = new System.Drawing.Point(357, 169);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(206, 26);
            this.textBoxNama.TabIndex = 17;
            this.textBoxNama.Click += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelHarga
            // 
            this.labelHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelHarga.Location = new System.Drawing.Point(208, 204);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(132, 27);
            this.labelHarga.TabIndex = 16;
            this.labelHarga.Text = "Harga Menu";
            // 
            // labelNama
            // 
            this.labelNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelNama.Location = new System.Drawing.Point(208, 169);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(131, 27);
            this.labelNama.TabIndex = 15;
            this.labelNama.Text = "Nama Menu";
            // 
            // labelTipe
            // 
            this.labelTipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTipe.AutoSize = true;
            this.labelTipe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelTipe.Location = new System.Drawing.Point(208, 236);
            this.labelTipe.Name = "labelTipe";
            this.labelTipe.Size = new System.Drawing.Size(116, 27);
            this.labelTipe.TabIndex = 23;
            this.labelTipe.Text = "Tipe Menu";
            // 
            // comboBoxTipe
            // 
            this.comboBoxTipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTipe.FormattingEnabled = true;
            this.comboBoxTipe.Location = new System.Drawing.Point(357, 233);
            this.comboBoxTipe.Name = "comboBoxTipe";
            this.comboBoxTipe.Size = new System.Drawing.Size(206, 28);
            this.comboBoxTipe.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MenuRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTipe);
            this.Controls.Add(this.labelTipe);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNama);
            this.Name = "MenuRecordView";
            this.Text = "Menu Record";
            this.Load += new System.EventHandler(this.MenuRecordView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelTipe;
        private System.Windows.Forms.ComboBox comboBoxTipe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}