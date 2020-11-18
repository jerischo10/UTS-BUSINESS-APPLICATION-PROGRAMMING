namespace POS_Restoran
{
    partial class OrderDataView
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInfoLogin = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(667, 410);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 20);
            this.labelTotal.TabIndex = 22;
            this.labelTotal.Text = "Total Order = 000";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(2, 42);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 62;
            this.dataGridViewData.RowTemplate.Height = 28;
            this.dataGridViewData.Size = new System.Drawing.Size(797, 347);
            this.dataGridViewData.TabIndex = 16;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Orange;
            this.labelTitle.Location = new System.Drawing.Point(170, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(0, 55);
            this.labelTitle.TabIndex = 15;
            // 
            // labelInfoLogin
            // 
            this.labelInfoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoLogin.AutoSize = true;
            this.labelInfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInfoLogin.Location = new System.Drawing.Point(515, 412);
            this.labelInfoLogin.Name = "labelInfoLogin";
            this.labelInfoLogin.Size = new System.Drawing.Size(0, 29);
            this.labelInfoLogin.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(413, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Status";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(12, 9);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(66, 20);
            this.labelTanggal.TabIndex = 24;
            this.labelTanggal.Text = "Tanggal";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(86, 5);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(300, 26);
            this.dateTimePickerOrder.TabIndex = 25;
            this.dateTimePickerOrder.ValueChanged += new System.EventHandler(this.dateTime_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(475, 6);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(161, 28);
            this.comboBoxStatus.TabIndex = 26;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(671, 8);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(96, 24);
            this.checkBoxShow.TabIndex = 28;
            this.checkBoxShow.Text = "Show All";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrint.Location = new System.Drawing.Point(475, 395);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(161, 50);
            this.buttonPrint.TabIndex = 29;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Location = new System.Drawing.Point(322, 395);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 50);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(166, 395);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 50);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNew.Location = new System.Drawing.Point(2, 395);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(158, 50);
            this.buttonNew.TabIndex = 19;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // OrderDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInfoLogin);
            this.Name = "OrderDataView";
            this.Text = "OrderDataView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInfoLogin;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
    }
}