using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InvManager : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
            System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\db.mdf") + 
            ";Integrated Security=True;";

        public InvManager()
        {
            db = new DBContext(connectionString);
            bsProducts = new BindingSource();
            bsOrders = new BindingSource();
            bsPurchases = new BindingSource();
            bsTransactions = new BindingSource();
            if ((connected = db.DatabaseExists()) == false)
            {
                connected = false;
                MessageBox.Show("Unable to connect to database.");
            }
            InitializeComponent();
            setDataSourcesOfDataGridViews();
            setDataFillGridView(dbViewProduct, 2);
            setDataFillGridView(dbViewOrder, 2);
            setDataFillGridView(dbViewPurchase, 2);
            setDataFillGridView(dbViewTransaction, 2);
        }

        private DBContext db;
        private BindingSource bsProducts;
        private BindingSource bsOrders;
        private BindingSource bsPurchases;
        private BindingSource bsTransactions;
        private bool connected;

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductForm pf = new AddProductForm(db);
            pf.ShowDialog();
            refreshAllTables();
        }

        private void setDataFillGridView(DataGridView dgv, int col)
        {
            DataGridViewColumn second = dgv.Columns[col];
            second.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void setDataSourcesOfDataGridViews()
        {
            bsProducts.DataSource = db.Products;
            dbViewProduct.DataSource = bsProducts;

            bsOrders.DataSource = db.Orders;
            dbViewOrder.DataSource = bsOrders;

            bsPurchases.DataSource = db.Purchases;
            dbViewPurchase.DataSource = bsPurchases;

            bsTransactions.DataSource = db.Transactions;
            dbViewTransaction.DataSource = bsTransactions;
        }

        private void refreshAllTables()
        {
            db = new DBContext(connectionString);
            bsProducts.DataSource = db.Products;

            bsOrders.DataSource = db.Orders;

            bsPurchases.DataSource = db.Purchases;

            bsTransactions.DataSource = db.Transactions;
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            refreshAllTables();
        }

        private void bRemoveProduct_Click(object sender, EventArgs e)
        {
            var selectedRows = dbViewProduct.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var res = MessageBox.Show("Are you sure you want to delete the selected products?", "Sure?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        IQueryable<Product> resProduct = from prod in db.Products
                                                         where prod.ProductId == Convert.ToInt32(row.Cells[0].Value)
                                                         select prod;
                        foreach (var product in resProduct.ToList<Product>())
                        {
                            IQueryable<Order> resOrder = from ord in db.Orders
                                                         where ord.ProductId == product.ProductId
                                                         select ord;
                            var orderList = resOrder.ToList<Order>();
                            IQueryable<Purchase> resPurchase = from pur in db.Purchases
                                                               where pur.ProductId == product.ProductId
                                                               select pur;
                            var purchaseList = resPurchase.ToList<Purchase>();
                            bool delete = true;
                            if(orderList.Count > 0 || purchaseList.Count > 0)
                            {
                                delete = MessageBox.Show("Active Orders and/or Purchases of this product were found. " +
                                    "If you continue with this action then these Orders and/or Purchases will be deleted as well. " +
                                    "Would you like to continue with the action?", 
                                    "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes;
                            }
                            if(delete)
                            {
                                db.Products.DeleteOnSubmit(product);
                                foreach (var order in orderList)
                                {
                                    db.Orders.DeleteOnSubmit(order);
                                }
                                foreach (var purchase in purchaseList)
                                {
                                    db.Purchases.DeleteOnSubmit(purchase);
                                }
                            }
                        }
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    refreshAllTables();
                }
            }
        }

        private void bNewOrder_Click(object sender, EventArgs e)
        {
            AddNewOrder no = new AddNewOrder(db);
            no.ShowDialog();
            refreshAllTables();
        }

        private void bFulfillOrder_Click(object sender, EventArgs e)
        {
            var selectedRows = dbViewOrder.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var resValidate = MessageBox.Show("Are you sure you want to fulfill the selected orders?", "Sure?", MessageBoxButtons.YesNo);
                if (resValidate == DialogResult.Yes)
                {
                    var productIds = new List<int>();
                    var quantities = new List<int>();
                    var orderIds = new List<int>();
                    var names = new List<string>();
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        productIds.Add(Convert.ToInt32(row.Cells[1].Value));
                        quantities.Add(Convert.ToInt32(row.Cells[3].Value));
                        orderIds.Add(Convert.ToInt32(row.Cells[0].Value));
                        names.Add(row.Cells[2].Value.ToString());
                    }
                    for (var i = 0; i < productIds.Count(); ++i)
                    {
                        IQueryable<Product> resProduct = from prod in db.Products
                                                         where prod.ProductId == productIds[i]
                                                         select prod;
                        var prodList = resProduct.ToList<Product>();
                        if(prodList.Count == 0)
                        {
                            MessageBox.Show(string.Format("Product with id {0} was not found in the products list. Aborting.", productIds[i]));
                        }
                        else
                        {
                            var inStock = prodList[0].Quantity;
                            if((inStock - quantities[i]) < 0)
                            {
                                MessageBox.Show(string.Format("Not enough of product with id {0} in stock. Can not fulfill order.", productIds[i]));
                            }
                            else
                            {
                                prodList[0].Quantity -= quantities[i];
                                IQueryable<Order> resOrder = from ord in db.Orders
                                                             where ord.OrderId == orderIds[i]
                                                             select ord;
                                db.Orders.DeleteOnSubmit(resOrder.ToList<Order>()[0]);
                                Transaction t = new Transaction();
                                t.DateMade = DateTime.Today;
                                t.Name = names[i];
                                t.ProductId = productIds[i];
                                t.Quantity = quantities[i];
                                IQueryable<double> price = from prod in db.Products
                                                                 where prod.ProductId == productIds[i]
                                                                 select prod.Price;
                                t.TransactionAmount = Convert.ToDecimal(price.ToList<double>()[0] * Convert.ToDouble(quantities[i]));
                                db.Transactions.InsertOnSubmit(t);
                            }
                        }
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    refreshAllTables();
                }
            }
        }

        private void bRemoveOrder_Click(object sender, EventArgs e)
        {
            var selectedRows = dbViewOrder.SelectedRows;
            if(selectedRows.Count > 0)
            {
                var res = MessageBox.Show("Are you sure you want to delete the selected orders?", "Sure?", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        IQueryable<Order> resOrder = from ord in db.Orders
                                                     where ord.OrderId == Convert.ToInt32(row.Cells[0].Value)
                                                     select ord;
                        foreach (var order in resOrder.ToList<Order>())
                        {
                            db.Orders.DeleteOnSubmit(order);
                        }
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    refreshAllTables();
                }
            }
        }

        private void bRemovePurchase_Click(object sender, EventArgs e)
        {
            var selectedRows = dbViewPurchase.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var res = MessageBox.Show("Are you sure you want to delete the selected purchases?", "Sure?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        IQueryable<Purchase> resPurchase = from pur in db.Purchases
                                                           where pur.PurchaseId == Convert.ToInt32(row.Cells[0].Value)
                                                           select pur;
                        foreach (var purchase in resPurchase.ToList<Purchase>())
                        {
                            db.Purchases.DeleteOnSubmit(purchase);
                        }
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    refreshAllTables();
                }
            }
        }

        private void bCompletePurchase_Click(object sender, EventArgs e)
        {
            var selectedRows = dbViewPurchase.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var resValidate = MessageBox.Show("Are you sure you want to fulfill the selected purchases?", 
                    "Sure?", MessageBoxButtons.YesNo);
                if (resValidate == DialogResult.Yes)
                {
                    var purchaseIds = new List<int>();
                    var productIds = new List<int>();
                    var quantities = new List<int>();
                    var names = new List<string>();
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        purchaseIds.Add(Convert.ToInt32(row.Cells[0].Value));
                        productIds.Add(Convert.ToInt32(row.Cells[1].Value));
                        quantities.Add(Convert.ToInt32(row.Cells[3].Value));
                        names.Add(row.Cells[2].Value.ToString());
                    }
                    for (var i = 0; i < productIds.Count(); ++i)
                    {
                        IQueryable<Product> resProduct = from prod in db.Products
                                                         where prod.ProductId == productIds[i]
                                                         select prod;
                        var prodList = resProduct.ToList<Product>();
                        if (prodList.Count == 0)
                        {
                            MessageBox.Show(string.Format("Product with id {0} was not found in the products list. Aborting.", productIds[i]));
                        }
                        else
                        {
                            prodList[0].Quantity += quantities[i];
                            IQueryable<Purchase> resPurchase = from pur in db.Purchases
                                                               where pur.PurchaseId == purchaseIds[i]
                                                               select pur;
                            db.Purchases.DeleteOnSubmit(resPurchase.ToList<Purchase>()[0]);
                            Transaction t = new Transaction();
                            t.DateMade = DateTime.Today;
                            t.Name = names[i];
                            t.ProductId = productIds[i];
                            t.Quantity = quantities[i];
                            IQueryable<decimal> price = from pur in db.Purchases
                                                       where pur.PurchaseId == purchaseIds[i]
                                                       select pur.PricePerUnit;
                            t.TransactionAmount = Convert.ToDecimal(-1.0 * Convert.ToDouble(price.ToList<decimal>()[0]) * quantities[i]);
                            db.Transactions.InsertOnSubmit(t);
                        }
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    refreshAllTables();
                }
            }
        }

        private void bNewPurchase_Click(object sender, EventArgs e)
        {
            AddNewPurchase np = new AddNewPurchase(db);
            np.ShowDialog();
            refreshAllTables();
        }

        private void bGetNetGain_Click(object sender, EventArgs e)
        {
            IQueryable<decimal> transactionAmounts = from tran in db.Transactions
                                                     select tran.TransactionAmount;

            decimal netGain = 0;
            foreach (var amount in transactionAmounts.ToList<decimal>())
            {
                netGain += amount;
            }
            MessageBox.Show(string.Format("Net Gain: {0}", netGain));
        }
    }
}
