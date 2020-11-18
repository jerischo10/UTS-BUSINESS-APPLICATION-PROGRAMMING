namespace POS_Restoran
{
    partial class AddMenuToOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenuToOrderView));
            this.groupBoxAddMenu = new System.Windows.Forms.GroupBox();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.labelQty = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxAddMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddMenu
            // 
            this.groupBoxAddMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAddMenu.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxAddMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxAddMenu.BackgroundImage")));
            this.groupBoxAddMenu.Controls.Add(this.checkBoxShow);
            this.groupBoxAddMenu.Controls.Add(this.labelTotal);
            this.groupBoxAddMenu.Controls.Add(this.textBoxSearch);
            this.groupBoxAddMenu.Controls.Add(this.labelSearch);
            this.groupBoxAddMenu.Controls.Add(this.dataGridViewMenu);
            this.groupBoxAddMenu.Location = new System.Drawing.Point(41, 45);
            this.groupBoxAddMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddMenu.Name = "groupBoxAddMenu";
            this.groupBoxAddMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddMenu.Size = new System.Drawing.Size(783, 383);
            this.groupBoxAddMenu.TabIndex = 38;
            this.groupBoxAddMenu.TabStop = false;
            this.groupBoxAddMenu.Text = "Menu";
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(624, 22);
            this.checkBoxShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(83, 21);
            this.checkBoxShow.TabIndex = 39;
            this.checkBoxShow.Text = "Show All";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(664, 357);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(103, 17);
            this.labelTotal.TabIndex = 38;
            this.labelTotal.Text = "Total Menu = 0";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(220, 20);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(399, 22);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(162, 22);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 17);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(165, 47);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 62;
            this.dataGridViewMenu.RowTemplate.Height = 28;
            this.dataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu.Size = new System.Drawing.Size(478, 318);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // labelQty
            // 
            this.labelQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(308, 491);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(0, 17);
            this.labelQty.TabIndex = 38;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(206, 530);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNamaMenu.AutoSize = true;
            this.labelNamaMenu.Location = new System.Drawing.Point(203, 462);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(96, 17);
            this.labelNamaMenu.TabIndex = 42;
            this.labelNamaMenu.Text = "Nama Menu : ";
            // 
            // labelMenu
            // 
            this.labelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(308, 462);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(32, 17);
            this.labelMenu.TabIndex = 43;
            this.labelMenu.Text = ". . . ";
            // 
            // labelQ
            // 
            this.labelQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(203, 491);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(97, 17);
            this.labelQ.TabIndex = 44;
            this.labelQ.Text = "Quantity        :";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownQty.Location = new System.Drawing.Point(308, 491);
            this.numericUpDownQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownQty.TabIndex = 45;
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Orange;
            this.buttonBack.Location = new System.Drawing.Point(321, 530);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 36);
            this.buttonBack.TabIndex = 46;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AddMenuToOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(859, 674);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.labelNamaMenu);
            this.Controls.Add(this.groupBoxAddMenu);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.buttonAdd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMenuToOrderView";
            this.Text = "AddMenuToOrder";
            this.Load += new System.EventHandler(this.AddMenuToOrderView_Load);
            this.groupBoxAddMenu.ResumeLayout(false);
            this.groupBoxAddMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddMenu;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Label labelNamaMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckBox checkBoxShow;
    }
}