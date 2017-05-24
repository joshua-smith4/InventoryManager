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
    public partial class AddProductForm : Form
    {
        public AddProductForm(DBContext context)
        {
            db = context;
            InitializeComponent();
        }

        private DBContext db;

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string name = this.nameInput.Text;
            if (name == "")
            {
                valid = false;
                MessageBox.Show("Name can not be empty or more than 100 characters.");
            }
            string desc = this.descInput.Text;
            if (desc == "" || desc.Length > 100)
            {
                valid = false;
                MessageBox.Show("Description can not be empty or more than 100 characters.");
            }
            string priceStr = this.priceInput.Text;
            decimal quantity = this.quantityInput.Value;
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
            if(valid)
            {
                Product p = new Product();
                p.Name = name;
                p.Description = desc;
                p.Price = price;
                p.Quantity = Convert.ToInt32(quantity);
                db.Products.InsertOnSubmit(p);
                try
                {
                    db.SubmitChanges();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid product description");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
