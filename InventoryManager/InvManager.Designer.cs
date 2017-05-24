using System.Windows.Forms;

namespace InventoryManager
{
    partial class InvManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productTab = new System.Windows.Forms.TabPage();
            this.bRemoveProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.dbViewProduct = new System.Windows.Forms.DataGridView();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.bRemoveOrder = new System.Windows.Forms.Button();
            this.bFulfillOrder = new System.Windows.Forms.Button();
            this.bNewOrder = new System.Windows.Forms.Button();
            this.dbViewOrder = new System.Windows.Forms.DataGridView();
            this.purchaseTab = new System.Windows.Forms.TabPage();
            this.bRemovePurchase = new System.Windows.Forms.Button();
            this.bCompletePurchase = new System.Windows.Forms.Button();
            this.bNewPurchase = new System.Windows.Forms.Button();
            this.dbViewPurchase = new System.Windows.Forms.DataGridView();
            this.transactionTab = new System.Windows.Forms.TabPage();
            this.dbViewTransaction = new System.Windows.Forms.DataGridView();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bGetNetGain = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.productTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewProduct)).BeginInit();
            this.orderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewOrder)).BeginInit();
            this.purchaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewPurchase)).BeginInit();
            this.transactionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.productTab);
            this.tabControl1.Controls.Add(this.orderTab);
            this.tabControl1.Controls.Add(this.purchaseTab);
            this.tabControl1.Controls.Add(this.transactionTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // productTab
            // 
            this.productTab.Controls.Add(this.bRemoveProduct);
            this.productTab.Controls.Add(this.addProduct);
            this.productTab.Controls.Add(this.dbViewProduct);
            this.productTab.Location = new System.Drawing.Point(4, 22);
            this.productTab.Name = "productTab";
            this.productTab.Padding = new System.Windows.Forms.Padding(3);
            this.productTab.Size = new System.Drawing.Size(749, 590);
            this.productTab.TabIndex = 0;
            this.productTab.Text = "Product List";
            this.productTab.UseVisualStyleBackColor = true;
            // 
            // bRemoveProduct
            // 
            this.bRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemoveProduct.Location = new System.Drawing.Point(387, 549);
            this.bRemoveProduct.Name = "bRemoveProduct";
            this.bRemoveProduct.Size = new System.Drawing.Size(154, 23);
            this.bRemoveProduct.TabIndex = 3;
            this.bRemoveProduct.Text = "Remove Selected Rows";
            this.bRemoveProduct.UseVisualStyleBackColor = true;
            this.bRemoveProduct.Click += new System.EventHandler(this.bRemoveProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProduct.Location = new System.Drawing.Point(571, 549);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(100, 23);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Add Product...";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // dbViewProduct
            // 
            this.dbViewProduct.AllowUserToAddRows = false;
            this.dbViewProduct.AllowUserToResizeRows = false;
            this.dbViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewProduct.Location = new System.Drawing.Point(6, 6);
            this.dbViewProduct.Name = "dbViewProduct";
            this.dbViewProduct.ReadOnly = true;
            this.dbViewProduct.Size = new System.Drawing.Size(735, 518);
            this.dbViewProduct.TabIndex = 0;
            // 
            // orderTab
            // 
            this.orderTab.Controls.Add(this.bRemoveOrder);
            this.orderTab.Controls.Add(this.bFulfillOrder);
            this.orderTab.Controls.Add(this.bNewOrder);
            this.orderTab.Controls.Add(this.dbViewOrder);
            this.orderTab.Location = new System.Drawing.Point(4, 22);
            this.orderTab.Name = "orderTab";
            this.orderTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderTab.Size = new System.Drawing.Size(749, 590);
            this.orderTab.TabIndex = 1;
            this.orderTab.Text = "Orders";
            this.orderTab.UseVisualStyleBackColor = true;
            // 
            // bRemoveOrder
            // 
            this.bRemoveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemoveOrder.Location = new System.Drawing.Point(315, 547);
            this.bRemoveOrder.Name = "bRemoveOrder";
            this.bRemoveOrder.Size = new System.Drawing.Size(144, 23);
            this.bRemoveOrder.TabIndex = 3;
            this.bRemoveOrder.Text = "Remove Selected Orders";
            this.bRemoveOrder.UseVisualStyleBackColor = true;
            this.bRemoveOrder.Click += new System.EventHandler(this.bRemoveOrder_Click);
            // 
            // bFulfillOrder
            // 
            this.bFulfillOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFulfillOrder.Location = new System.Drawing.Point(475, 547);
            this.bFulfillOrder.Name = "bFulfillOrder";
            this.bFulfillOrder.Size = new System.Drawing.Size(128, 23);
            this.bFulfillOrder.TabIndex = 2;
            this.bFulfillOrder.Text = "Fulfill Selected Orders";
            this.bFulfillOrder.UseVisualStyleBackColor = true;
            this.bFulfillOrder.Click += new System.EventHandler(this.bFulfillOrder_Click);
            // 
            // bNewOrder
            // 
            this.bNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNewOrder.Location = new System.Drawing.Point(619, 547);
            this.bNewOrder.Name = "bNewOrder";
            this.bNewOrder.Size = new System.Drawing.Size(117, 23);
            this.bNewOrder.TabIndex = 1;
            this.bNewOrder.Text = "Enter New Order...";
            this.bNewOrder.UseVisualStyleBackColor = true;
            this.bNewOrder.Click += new System.EventHandler(this.bNewOrder_Click);
            // 
            // dbViewOrder
            // 
            this.dbViewOrder.AllowUserToAddRows = false;
            this.dbViewOrder.AllowUserToDeleteRows = false;
            this.dbViewOrder.AllowUserToResizeRows = false;
            this.dbViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewOrder.Location = new System.Drawing.Point(6, 6);
            this.dbViewOrder.Name = "dbViewOrder";
            this.dbViewOrder.ReadOnly = true;
            this.dbViewOrder.Size = new System.Drawing.Size(737, 520);
            this.dbViewOrder.TabIndex = 0;
            // 
            // purchaseTab
            // 
            this.purchaseTab.Controls.Add(this.bRemovePurchase);
            this.purchaseTab.Controls.Add(this.bCompletePurchase);
            this.purchaseTab.Controls.Add(this.bNewPurchase);
            this.purchaseTab.Controls.Add(this.dbViewPurchase);
            this.purchaseTab.Location = new System.Drawing.Point(4, 22);
            this.purchaseTab.Name = "purchaseTab";
            this.purchaseTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.purchaseTab.Size = new System.Drawing.Size(749, 590);
            this.purchaseTab.TabIndex = 2;
            this.purchaseTab.Text = "Purchases";
            this.purchaseTab.UseVisualStyleBackColor = true;
            // 
            // bRemovePurchase
            // 
            this.bRemovePurchase.Location = new System.Drawing.Point(211, 546);
            this.bRemovePurchase.Name = "bRemovePurchase";
            this.bRemovePurchase.Size = new System.Drawing.Size(165, 23);
            this.bRemovePurchase.TabIndex = 3;
            this.bRemovePurchase.Text = "Remove Selected Purchases";
            this.bRemovePurchase.UseVisualStyleBackColor = true;
            this.bRemovePurchase.Click += new System.EventHandler(this.bRemovePurchase_Click);
            // 
            // bCompletePurchase
            // 
            this.bCompletePurchase.Location = new System.Drawing.Point(398, 546);
            this.bCompletePurchase.Name = "bCompletePurchase";
            this.bCompletePurchase.Size = new System.Drawing.Size(165, 23);
            this.bCompletePurchase.TabIndex = 2;
            this.bCompletePurchase.Text = "Complete Selected Purchases";
            this.bCompletePurchase.UseVisualStyleBackColor = true;
            this.bCompletePurchase.Click += new System.EventHandler(this.bCompletePurchase_Click);
            // 
            // bNewPurchase
            // 
            this.bNewPurchase.Location = new System.Drawing.Point(589, 546);
            this.bNewPurchase.Name = "bNewPurchase";
            this.bNewPurchase.Size = new System.Drawing.Size(130, 23);
            this.bNewPurchase.TabIndex = 1;
            this.bNewPurchase.Text = "Make New Purchase...";
            this.bNewPurchase.UseVisualStyleBackColor = true;
            this.bNewPurchase.Click += new System.EventHandler(this.bNewPurchase_Click);
            // 
            // dbViewPurchase
            // 
            this.dbViewPurchase.AllowUserToAddRows = false;
            this.dbViewPurchase.AllowUserToDeleteRows = false;
            this.dbViewPurchase.AllowUserToResizeRows = false;
            this.dbViewPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewPurchase.Location = new System.Drawing.Point(6, 3);
            this.dbViewPurchase.Name = "dbViewPurchase";
            this.dbViewPurchase.ReadOnly = true;
            this.dbViewPurchase.Size = new System.Drawing.Size(740, 519);
            this.dbViewPurchase.TabIndex = 0;
            // 
            // transactionTab
            // 
            this.transactionTab.Controls.Add(this.bGetNetGain);
            this.transactionTab.Controls.Add(this.dbViewTransaction);
            this.transactionTab.Location = new System.Drawing.Point(4, 22);
            this.transactionTab.Name = "transactionTab";
            this.transactionTab.Size = new System.Drawing.Size(749, 590);
            this.transactionTab.TabIndex = 3;
            this.transactionTab.Text = "Transactions";
            this.transactionTab.UseVisualStyleBackColor = true;
            // 
            // dbViewTransaction
            // 
            this.dbViewTransaction.AllowUserToAddRows = false;
            this.dbViewTransaction.AllowUserToDeleteRows = false;
            this.dbViewTransaction.AllowUserToResizeRows = false;
            this.dbViewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewTransaction.Location = new System.Drawing.Point(6, 3);
            this.dbViewTransaction.Name = "dbViewTransaction";
            this.dbViewTransaction.ReadOnly = true;
            this.dbViewTransaction.Size = new System.Drawing.Size(736, 520);
            this.dbViewTransaction.TabIndex = 0;
            // 
            // bRefresh
            // 
            this.bRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRefresh.Location = new System.Drawing.Point(765, 12);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(64, 23);
            this.bRefresh.TabIndex = 1;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bGetNetGain
            // 
            this.bGetNetGain.Location = new System.Drawing.Point(571, 546);
            this.bGetNetGain.Name = "bGetNetGain";
            this.bGetNetGain.Size = new System.Drawing.Size(111, 23);
            this.bGetNetGain.TabIndex = 1;
            this.bGetNetGain.Text = "Get Net Gain";
            this.bGetNetGain.UseVisualStyleBackColor = true;
            this.bGetNetGain.Click += new System.EventHandler(this.bGetNetGain_Click);
            // 
            // InvManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 618);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bRefresh);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "InvManager";
            this.Text = " Inventory Manager";
            this.tabControl1.ResumeLayout(false);
            this.productTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewProduct)).EndInit();
            this.orderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewOrder)).EndInit();
            this.purchaseTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewPurchase)).EndInit();
            this.transactionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbViewTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage productTab;
        private TabPage orderTab;
        private TabPage purchaseTab;
        private TabPage transactionTab;
        private DataGridView dbViewProduct;
        private Button bRefresh;
        private Button addProduct;
        private Button bRemoveProduct;
        private DataGridView dbViewOrder;
        private Button bNewOrder;
        private Button bRemoveOrder;
        private Button bFulfillOrder;
        private DataGridView dbViewPurchase;
        private Button bRemovePurchase;
        private Button bCompletePurchase;
        private Button bNewPurchase;
        private DataGridView dbViewTransaction;
        private Button bGetNetGain;
    }
}

