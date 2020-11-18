namespace POS_Restoran
{
    partial class OrderRecordView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRecordView));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Orange;
            this.labelTitle.Location = new System.Drawing.Point(208, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(0, 45);
            this.labelTitle.TabIndex = 30;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.Orange;
            this.buttonSave.Location = new System.Drawing.Point(32, 574);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 36);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(28, 39);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(60, 17);
            this.labelTanggal.TabIndex = 34;
            this.labelTanggal.Text = "Tanggal";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(92, 35);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(261, 22);
            this.dateTimePickerTanggal.TabIndex = 35;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.Color.Orange;
            this.buttonRemove.Location = new System.Drawing.Point(353, 413);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(117, 36);
            this.buttonRemove.TabIndex = 39;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(32, 70);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(439, 323);
            this.listViewOrder.TabIndex = 38;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(32, 413);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(187, 413);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Orange;
            this.buttonBack.Location = new System.Drawing.Point(161, 574);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 36);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 640);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // OrderRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(508, 638);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderRecordView";
            this.Text = "OrderRecordView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}