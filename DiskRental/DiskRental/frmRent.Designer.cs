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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboTittle = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.customer_ComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            cashLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            customer_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            invoiceNoLabel.Location = new System.Drawing.Point(14, 22);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(47, 13);
            invoiceNoLabel.TabIndex = 21;
            invoiceNoLabel.Text = "Rent ID:";
            // 
            // customer_Label
            // 
            customer_Label.AutoSize = true;
            customer_Label.Location = new System.Drawing.Point(15, 55);
            customer_Label.Name = "customer_Label";
            customer_Label.Size = new System.Drawing.Size(68, 13);
            customer_Label.TabIndex = 23;
            customer_Label.Text = "CustomerID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 13);
            label1.TabIndex = 37;
            label1.Text = "Customer Name :";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(373, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 13);
            label2.TabIndex = 40;
            label2.Text = "Tittle : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(372, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 13);
            label3.TabIndex = 42;
            label3.Text = "Return Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(374, 82);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 43;
            label4.Text = "Cost :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(536, 82);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 13);
            label5.TabIndex = 45;
            label5.Text = "Per 1 Disk";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(6, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 10);
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
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.cboTittle);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.customer_ComboBox);
            this.groupBox1.Controls.Add(invoiceNoLabel);
            this.groupBox1.Controls.Add(customer_Label);
            this.groupBox1.Controls.Add(this.invoiceNoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(281, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 106);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(447, 79);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(83, 20);
            this.txtCost.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 48);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 11, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // cboTittle
            // 
            this.cboTittle.FormattingEnabled = true;
            this.cboTittle.Location = new System.Drawing.Point(446, 14);
            this.cboTittle.Margin = new System.Windows.Forms.Padding(2);
            this.cboTittle.Name = "cboTittle";
            this.cboTittle.Size = new System.Drawing.Size(231, 21);
            this.cboTittle.TabIndex = 39;
            this.cboTittle.SelectedIndexChanged += new System.EventHandler(this.cboTittle_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(107, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 38;
            // 
            // customer_ComboBox
            // 
            this.customer_ComboBox.DisplayMember = "Customer#";
            this.customer_ComboBox.FormattingEnabled = true;
            this.customer_ComboBox.Location = new System.Drawing.Point(107, 52);
            this.customer_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer_ComboBox.Name = "customer_ComboBox";
            this.customer_ComboBox.Size = new System.Drawing.Size(160, 21);
            this.customer_ComboBox.TabIndex = 36;
            this.customer_ComboBox.ValueMember = "Customer#";
            this.customer_ComboBox.SelectedIndexChanged += new System.EventHandler(this.customer_ComboBox_SelectedIndexChanged);
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.Location = new System.Drawing.Point(107, 20);
            this.invoiceNoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceNoTextBox.TabIndex = 22;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Location = new System.Drawing.Point(12, 146);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieDataGridView.Size = new System.Drawing.Size(543, 358);
            this.movieDataGridView.TabIndex = 127;
            this.movieDataGridView.Visible = false;
            this.movieDataGridView.SelectionChanged += new System.EventHandler(this.movieDataGridView_SelectionChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(681, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 358);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.Visible = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(561, 284);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(114, 90);
            this.btnChon.TabIndex = 129;
            this.btnChon.Text = "Select";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Visible = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(1037, 71);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(138, 48);
            this.btnNewInvoice.TabIndex = 130;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(577, 322);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 131;
            this.textBox1.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(273, 51);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(62, 22);
            this.btnCheck.TabIndex = 132;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 665);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRent";
            this.Text = "frmRent";
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox customer_ComboBox;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboTittle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheck;
    }
}