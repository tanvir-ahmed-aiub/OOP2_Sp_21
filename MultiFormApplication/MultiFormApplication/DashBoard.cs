using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFormApplication
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            var data = GetAllProducts();
            dtproducts.DataSource = data;
        }

        private List<Product> GetAllProducts() {
            var conn = Database.COnnectDB();
            conn.Open();
            string query = @"select p.id,p.name,c.name as 'category_name' from products p left join categories c on p.category_id = c.id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read()) {
                Product p = new Product();
                p.Id = reader.GetInt32(reader.GetOrdinal("id"));
                p.Name = reader.GetString(reader.GetOrdinal("Name"));
                p.Category = reader.GetString(reader.GetOrdinal("category_name"));
                products.Add(p);
            }
            return products;
        }

    }
}
