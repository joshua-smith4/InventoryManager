using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    [Database (Name="db")]
    public class DBContext : DataContext
    {
        public DBContext(string conn) : base(conn)
        {
        }

        public Table<Order> Orders;
        public Table<Product> Products;
        public Table<Purchase> Purchases;
        public Table<Transaction> Transactions;
    }
}
