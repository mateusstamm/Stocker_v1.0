namespace WindowsApp.Forms
{
    partial class ProductRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegisterForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvSearchProduct = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txbProductCategory = new System.Windows.Forms.TextBox();
            this.txbProductDescription = new System.Windows.Forms.TextBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductUnitPrice = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.txbProductQuantity = new System.Windows.Forms.TextBox();
            this.txbProductUnitPrice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvSearchProduct
            // 
            this.dgvSearchProduct.AllowUserToAddRows = false;
            this.dgvSearchProduct.AllowUserToDeleteRows = false;
            this.dgvSearchProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvSearchProduct, "dgvSearchProduct");
            this.dgvSearchProduct.Name = "dgvSearchProduct";
            this.dgvSearchProduct.ReadOnly = true;
            this.dgvSearchProduct.RowTemplate.Height = 25;
            this.dgvSearchProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchProduct_RowEnter);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txbProductCategory
            // 
            resources.ApplyResources(this.txbProductCategory, "txbProductCategory");
            this.txbProductCategory.Name = "txbProductCategory";
            // 
            // txbProductDescription
            // 
            resources.ApplyResources(this.txbProductDescription, "txbProductDescription");
            this.txbProductDescription.Name = "txbProductDescription";
            // 
            // txbProductName
            // 
            resources.ApplyResources(this.txbProductName, "txbProductName");
            this.txbProductName.Name = "txbProductName";
            // 
            // lblProductCategory
            // 
            resources.ApplyResources(this.lblProductCategory, "lblProductCategory");
            this.lblProductCategory.Name = "lblProductCategory";
            // 
            // lblProductDescription
            // 
            resources.ApplyResources(this.lblProductDescription, "lblProductDescription");
            this.lblProductDescription.Name = "lblProductDescription";
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // lblProductUnitPrice
            // 
            resources.ApplyResources(this.lblProductUnitPrice, "lblProductUnitPrice");
            this.lblProductUnitPrice.Name = "lblProductUnitPrice";
            // 
            // lblProductQuantity
            // 
            resources.ApplyResources(this.lblProductQuantity, "lblProductQuantity");
            this.lblProductQuantity.Name = "lblProductQuantity";
            // 
            // txbProductQuantity
            // 
            resources.ApplyResources(this.txbProductQuantity, "txbProductQuantity");
            this.txbProductQuantity.Name = "txbProductQuantity";
            // 
            // txbProductUnitPrice
            // 
            resources.ApplyResources(this.txbProductUnitPrice, "txbProductUnitPrice");
            this.txbProductUnitPrice.Name = "txbProductUnitPrice";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProductRegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbProductUnitPrice);
            this.Controls.Add(this.txbProductQuantity);
            this.Controls.Add(this.lblProductUnitPrice);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvSearchProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txbProductCategory);
            this.Controls.Add(this.txbProductDescription);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductRegisterForm";
            this.Shown += new System.EventHandler(this.ProductRegisterForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnRemove;
        private DataGridView dgvSearchProduct;
        private PictureBox pictureBox1;
        private Button btnInsert;
        private TextBox txbProductCategory;
        private TextBox txbProductDescription;
        private TextBox txbProductName;
        private Label lblProductCategory;
        private Label lblProductDescription;
        private Label lblProductName;
        private Label lblProductUnitPrice;
        private Label lblProductQuantity;
        private TextBox txbProductQuantity;
        private TextBox txbProductUnitPrice;
        private Button btnUpdate;
    }
}