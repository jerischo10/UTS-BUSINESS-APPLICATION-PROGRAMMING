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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Orange;
            this.buttonBack.Location = new System.Drawing.Point(181, 717);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 45);
            this.buttonBack.TabIndex = 31;
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
            this.labelTitle.Location = new System.Drawing.Point(234, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(0, 55);
            this.labelTitle.TabIndex = 30;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.Orange;
            this.buttonSave.Location = new System.Drawing.Point(36, 717);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 45);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(32, 49);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(66, 20);
            this.labelTanggal.TabIndex = 34;
            this.labelTanggal.Text = "Tanggal";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(104, 44);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(293, 26);
            this.dateTimePickerTanggal.TabIndex = 35;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.Color.Orange;
            this.buttonRemove.Location = new System.Drawing.Point(397, 516);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 45);
            this.buttonRemove.TabIndex = 39;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.Location = new System.Drawing.Point(36, 88);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(493, 403);
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
            this.buttonAdd.Location = new System.Drawing.Point(36, 516);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 45);
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
            this.buttonEdit.Location = new System.Drawing.Point(210, 516);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 45);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // OrderRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(571, 798);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.Name = "OrderRecordView";
            this.Text = "OrderRecordView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
    }
}