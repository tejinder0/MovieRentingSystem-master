using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentingSystem.Reports
{
    public partial class BestCustomer : Form
    {
        public BestCustomer()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetTopCustomers();
        }
    }
}
