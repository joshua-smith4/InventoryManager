using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class AddNewPurchase : Form
    {
        public AddNewPurchase(DBContext context)
        {
            db = context;
            InitializeComponent();
            IQueryable<Product> allProducts = from prod in db.Products
                                              select prod;

            foreach (var product in allProducts.ToList<Product>())
            {
                prodSelect.Items.Add(new CBItem(product.Name, product.ProductId));
            }
        }

        private class CBItem
        {
            public string name;
            public int id;
            public CBItem(string n, int i)
            {
                name = n; id = i;
            }
            public override string ToString()
            {
                return name;
            }
        }

        private DBContext db;

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bMakePurchase_Click(object sender, EventArgs e)
        {
            bool valid = true;
            CBItem item = (CBItem)prodSelect.SelectedItem;
            var id = 0;
            string name = "";
            if (item != null)
            {
                id = item.id;
                name = item.name;
            }
            else
            {
                valid = false;
                MessageBox.Show("Must select a product from the drop down menu.");
            }
            var date = dateInput.Value;
            var quantity = Convert.ToInt32(quantityInput.Value);
            if (quantity <= 0)
            {
                valid = false;
                MessageBox.Show("Quantity must be more than zero.");
            }
            string priceStr = this.priceInput.Text;
            double price = 0.0;
            try
            {
                price = Convert.ToDouble(priceStr);
                price = price * 100.0;
                uint priceMask = Convert.ToUInt32(price);
                price = Convert.ToDouble(priceMask) / 100.0;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
                valid = false;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
                valid = false;
            }
            if (valid)
            {
                Purchase p = new Purchase();
                p.Name = name;
                p.ProductId = id;
                p.DateMade = date;
                p.Quantity = quantity;
                p.PricePerUnit = Convert.ToDecimal(price);
                db.Purchases.InsertOnSubmit(p);
                try
                {
                    db.SubmitChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid Order description. Make sure that all fields are correctly filled.");
            }
        }
    }
}
