namespace InventoryManager
{
    partial class AddNewPurchase
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
            this.prodSelect = new System.Windows.Forms.ComboBox();
            this.prodLabel = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.bMakePurchase = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.dateMadeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // prodSelect
            // 
            this.prodSelect.FormattingEnabled = true;
            this.prodSelect.Location = new System.Drawing.Point(91, 31);
            this.prodSelect.Name = "prodSelect";
            this.prodSelect.Size = new System.Drawing.Size(121, 21);
            this.prodSelect.TabIndex = 0;
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Location = new System.Drawing.Point(32, 34);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(44, 13);
            this.prodLabel.TabIndex = 1;
            this.prodLabel.Text = "Product";
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(464, 31);
            this.quantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(120, 20);
            this.quantityInput.TabIndex = 2;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(298, 33);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            // 
            // bMakePurchase
            // 
            this.bMakePurchase.Location = new System.Drawing.Point(464, 156);
            this.bMakePurchase.Name = "bMakePurchase";
            this.bMakePurchase.Size = new System.Drawing.Size(116, 23);
            this.bMakePurchase.TabIndex = 4;
            this.bMakePurchase.Text = "Make New Purchase";
            this.bMakePurchase.UseVisualStyleBackColor = true;
            this.bMakePurchase.Click += new System.EventHandler(this.bMakePurchase_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(365, 156);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(384, 66);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(200, 20);
            this.dateInput.TabIndex = 6;
            // 
            // dateMadeLabel
            // 
            this.dateMadeLabel.AutoSize = true;
            this.dateMadeLabel.Location = new System.Drawing.Point(298, 72);
            this.dateMadeLabel.Name = "dateMadeLabel";
            this.dateMadeLabel.Size = new System.Drawing.Size(60, 13);
            this.dateMadeLabel.TabIndex = 7;
            this.dateMadeLabel.Text = "Date Made";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(298, 115);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(480, 108);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 9;
            // 
            // AddNewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 206);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dateMadeLabel);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bMakePurchase);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.prodSelect);
            this.MinimumSize = new System.Drawing.Size(617, 230);
            this.Name = "AddNewPurchase";
            this.Text = "Enter New Purchase...";
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prodSelect;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button bMakePurchase;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label dateMadeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.MaskedTextBox priceInput;
    }
}