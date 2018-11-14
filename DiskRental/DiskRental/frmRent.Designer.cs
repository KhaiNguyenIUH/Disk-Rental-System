namespace DiskRental
{
    partial class frmRent
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
            System.Windows.Forms.Label cashLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label customer_Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.txtDiskID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCheckDisk = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            cashLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            customer_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashLabel
            // 
            cashLabel.AutoSize = true;
            cashLabel.Location = new System.Drawing.Point(77, 22);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new System.Drawing.Size(37, 13);
            cashLabel.TabIndex = 2;
            cashLabel.Text = "Total :";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Location = new System.Drawing.Point(5, 24);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(59, 17);
            invoiceNoLabel.TabIndex = 21;
            invoiceNoLabel.Text = "Rent ID:";
            // 
            // customer_Label
            // 
            customer_Label.AutoSize = true;
            customer_Label.Location = new System.Drawing.Point(6, 57);
            customer_Label.Name = "customer_Label";
            customer_Label.Size = new System.Drawing.Size(93, 17);
            customer_Label.TabIndex = 23;
            customer_Label.Text = "Customer ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 90);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 17);
            label1.TabIndex = 37;
            label1.Text = "Customer Name :";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 17);
            label2.TabIndex = 40;
            label2.Text = "Tittle : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(372, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 17);
            label3.TabIndex = 42;
            label3.Text = "Return Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 17);
            label4.TabIndex = 43;
            label4.Text = "Cost :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(195, 106);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 17);
            label5.TabIndex = 45;
            label5.Text = "Per Disk";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 10);
            this.panel2.TabIndex = 126;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(cashLabel);
            this.groupBox2.Controls.Add(this.cashTextBox);
            this.groupBox2.Location = new System.Drawing.Point(459, 540);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 113);
            this.groupBox2.TabIndex = 125;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 132;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashTextBox
            // 
            this.cashTextBox.Enabled = false;
            this.cashTextBox.Location = new System.Drawing.Point(130, 19);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashTextBox.TabIndex = 3;
            this.cashTextBox.Text = "0.00";
            this.cashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCusID);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(invoiceNoLabel);
            this.groupBox1.Controls.Add(customer_Label);
            this.groupBox1.Controls.Add(this.invoiceNoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 127);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(138, 53);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(100, 23);
            this.txtCusID.TabIndex = 133;
            this.txtCusID.TextChanged += new System.EventHandler(this.txtCusID_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(252, 53);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(62, 24);
            this.btnCheck.TabIndex = 132;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(95, 102);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(83, 23);
            this.txtCost.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 49);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 11, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 23);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(138, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 38;
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.Location = new System.Drawing.Point(138, 23);
            this.invoiceNoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 23);
            this.invoiceNoTextBox.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(589, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 346);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.Visible = false;
            // 
            // btnChon
            // 
            this.btnChon.Enabled = false;
            this.btnChon.Location = new System.Drawing.Point(429, 60);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(114, 90);
            this.btnChon.TabIndex = 129;
            this.btnChon.Text = "Select";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Enabled = false;
            this.btnNewInvoice.Location = new System.Drawing.Point(776, 72);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(138, 48);
            this.btnNewInvoice.TabIndex = 130;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // txtDiskID
            // 
            this.txtDiskID.Location = new System.Drawing.Point(95, 30);
            this.txtDiskID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiskID.Name = "txtDiskID";
            this.txtDiskID.Size = new System.Drawing.Size(87, 23);
            this.txtDiskID.TabIndex = 131;
            this.txtDiskID.TextChanged += new System.EventHandler(this.txtDiskID_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDes);
            this.groupBox3.Controls.Add(label7);
            this.groupBox3.Controls.Add(this.btnCheckDisk);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(label5);
            this.groupBox3.Controls.Add(this.txtDiskID);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(this.btnChon);
            this.groupBox3.Controls.Add(this.txtCost);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 346);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 132;
            this.label6.Text = "Disk ID :";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(95, 66);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(203, 23);
            this.txtTitle.TabIndex = 133;
            // 
            // btnCheckDisk
            // 
            this.btnCheckDisk.Location = new System.Drawing.Point(198, 30);
            this.btnCheckDisk.Name = "btnCheckDisk";
            this.btnCheckDisk.Size = new System.Drawing.Size(75, 23);
            this.btnCheckDisk.TabIndex = 133;
            this.btnCheckDisk.Text = "Check";
            this.btnCheckDisk.UseVisualStyleBackColor = true;
            this.btnCheckDisk.Click += new System.EventHandler(this.btnCheckDisk_Click);
            // 
            // txtDes
            // 
            this.txtDes.Enabled = false;
            this.txtDes.Location = new System.Drawing.Point(95, 138);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(270, 62);
            this.txtDes.TabIndex = 135;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 141);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 17);
            label7.TabIndex = 134;
            label7.Text = "Description:";
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRent";
            this.Text = "frmRent";
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDiskID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnCheckDisk;
        private System.Windows.Forms.TextBox txtDes;
    }
}