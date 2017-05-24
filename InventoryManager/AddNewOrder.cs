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
    public partial class AddNewOrder : Form
    {
        public AddNewOrder(DBContext context)
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

        private void bMakeOrder_Click(object sender, EventArgs e)
        {
            bool valid = true;
            CBItem item = (CBItem)prodSelect.SelectedItem;
            var id = 0;
            string name = "";
            if(item != null)
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
            if (quantity <= 0) valid = false;
            if(valid)
            {
                Order o = new Order();
                o.Name = name;
                o.ProductId = id;
                o.DateMade = date;
                o.Quantity = quantity;
                db.Orders.InsertOnSubmit(o);
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
