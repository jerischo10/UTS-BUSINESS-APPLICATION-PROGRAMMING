namespace POS_Restoran
{
    partial class MenuDataView
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
            this.labelInfoLogin = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoLogin
            // 
            this.labelInfoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoLogin.AutoSize = true;
            this.labelInfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInfoLogin.Location = new System.Drawing.Point(457, 330);
            this.labelInfoLogin.Name = "labelInfoLogin";
            this.labelInfoLogin.Size = new System.Drawing.Size(0, 25);
            this.labelInfoLogin.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Brush Script Std", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Orange;
            this.labelTitle.Location = new System.Drawing.Point(150, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(0, 46);
            this.labelTitle.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(592, 328);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(119, 17);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total Menu = 000";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Location = new System.Drawing.Point(392, 316);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 40);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(195, 316);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 40);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Location = new System.Drawing.Point(1, 316);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 40);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(70, 5);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(640, 22);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 5);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 17);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Search";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(1, 34);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 62;
            this.dataGridViewData.RowTemplate.Height = 28;
            this.dataGridViewData.Size = new System.Drawing.Size(708, 278);
            this.dataGridViewData.TabIndex = 7;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // MenuDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInfoLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuDataView";
            this.Text = "Menu Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfoLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridViewData;
    }
}