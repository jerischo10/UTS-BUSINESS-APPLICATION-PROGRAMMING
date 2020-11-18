namespace POS_Restoran
{
    partial class Print
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewData = new System.Windows.Forms.ListView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Brush Script Std", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(70, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Edelweiss Restaurant";
            // 
            // listViewData
            // 
            this.listViewData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewData.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewData.Enabled = false;
            this.listViewData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewData.Location = new System.Drawing.Point(7, 105);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(416, 430);
            this.listViewData.TabIndex = 1;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            // 
            // labelOrder
            // 
            this.labelOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(7, 68);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(57, 20);
            this.labelOrder.TabIndex = 2;
            this.labelOrder.Text = "Order :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(243, 68);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(78, 20);
            this.labelTanggal.TabIndex = 3;
            this.labelTanggal.Text = "Tanggal : ";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrint.Location = new System.Drawing.Point(12, 603);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(153, 36);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Location = new System.Drawing.Point(279, 602);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(149, 37);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thanks for using our services";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Controls.Add(this.labelOrder);
            this.groupBox1.Controls.Add(this.labelTanggal);
            this.groupBox1.Controls.Add(this.listViewData);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 576);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(440, 651);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBox1);
            this.Name = "Print";
            this.Text = "Print";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}