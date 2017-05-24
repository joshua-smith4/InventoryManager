namespace InventoryManager
{
    partial class AddProductForm
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
            this.descInput = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.MaskedTextBox();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.bAddProduct = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(114, 56);
            this.descInput.Multiline = true;
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(316, 56);
            this.descInput.TabIndex = 0;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(28, 56);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(60, 13);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Description";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(28, 128);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(114, 128);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 3;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(114, 174);
            this.quantityInput.Maximum = 1000000;
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(120, 20);
            this.quantityInput.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(28, 174);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(73, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Initial Quantity";
            // 
            // bAddProduct
            // 
            this.bAddProduct.Location = new System.Drawing.Point(355, 223);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(75, 23);
            this.bAddProduct.TabIndex = 6;
            this.bAddProduct.Text = "Add Product";
            this.bAddProduct.UseVisualStyleBackColor = true;
            this.bAddProduct.Click += new System.EventHandler(this.bAddProduct_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(262, 223);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Product Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(114, 21);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(316, 20);
            this.nameInput.TabIndex = 9;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAddProduct);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.descInput);
            this.Name = "AddProductForm";
            this.Text = "Add Product...";
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.MaskedTextBox priceInput;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button bAddProduct;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
    }
}