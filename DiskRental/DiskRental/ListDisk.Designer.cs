namespace DiskRental
{
    partial class ListDisk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDisk));
            this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.movieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.cboTittle = new System.Windows.Forms.ComboBox();
            this.diskRentalDataSet = new DiskRental.DiskRentalDataSet();
            this.diskRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
            this.movieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movieBindingNavigator
            // 
            this.movieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movieBindingNavigator.CountItem = null;
            this.movieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movieBindingNavigator.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.movieBindingNavigatorSaveItem,
            this.btn_Refresh,
            this.btn_Edit});
            this.movieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movieBindingNavigator.MoveFirstItem = null;
            this.movieBindingNavigator.MoveLastItem = null;
            this.movieBindingNavigator.MoveNextItem = null;
            this.movieBindingNavigator.MovePreviousItem = null;
            this.movieBindingNavigator.Name = "movieBindingNavigator";
            this.movieBindingNavigator.PositionItem = null;
            this.movieBindingNavigator.Size = new System.Drawing.Size(1009, 25);
            this.movieBindingNavigator.TabIndex = 5;
            this.movieBindingNavigator.Text = "bindingNavigator1";
            this.movieBindingNavigator.RefreshItems += new System.EventHandler(this.movieBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(77, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(65, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // movieBindingNavigatorSaveItem
            // 
            this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
            this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
            this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(86, 22);
            this.movieBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(72, 22);
            this.btn_Refresh.Text = "&Refresh";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(49, 22);
            this.btn_Edit.Text = "&Edit";
            // 
            // cboTittle
            // 
            this.cboTittle.FormattingEnabled = true;
            this.cboTittle.Location = new System.Drawing.Point(643, 2);
            this.cboTittle.Margin = new System.Windows.Forms.Padding(2);
            this.cboTittle.Name = "cboTittle";
            this.cboTittle.Size = new System.Drawing.Size(364, 21);
            this.cboTittle.TabIndex = 6;
            this.cboTittle.SelectedIndexChanged += new System.EventHandler(this.cboTittle_SelectedIndexChanged);
            // 
            // diskRentalDataSet
            // 
            this.diskRentalDataSet.DataSetName = "DiskRentalDataSet";
            this.diskRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diskRentalDataSetBindingSource
            // 
            this.diskRentalDataSetBindingSource.DataSource = this.diskRentalDataSet;
            this.diskRentalDataSetBindingSource.Position = 0;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Location = new System.Drawing.Point(0, 28);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(1007, 565);
            this.movieDataGridView.TabIndex = 7;
            // 
            // ListDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 593);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.cboTittle);
            this.Controls.Add(this.movieBindingNavigator);
            this.Name = "ListDisk";
            this.Text = "ListDisk";
            this.Load += new System.EventHandler(this.ListDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
            this.movieBindingNavigator.ResumeLayout(false);
            this.movieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator movieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ComboBox cboTittle;
        private DiskRentalDataSet diskRentalDataSet;
        private System.Windows.Forms.BindingSource diskRentalDataSetBindingSource;
        private System.Windows.Forms.DataGridView movieDataGridView;
    }
}