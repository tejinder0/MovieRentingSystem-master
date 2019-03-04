using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentingSystem.Transactions
{
    public partial class Issue : Form
    {
        private string Id;

        public Issue()
        {
            InitializeComponent();
        }

        public Issue(string Id)
        {
            this.Id = Id;
            InitializeComponent();
            MovieId.Text = Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = database.GetCustomer(CustomerId.Text);

            if (table.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("Do you wish to issue this movie to {0} {1}", table.Rows[0]["FirstName"].ToString(), table.Rows[0]["LastName"].ToString()), "Issue Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                    database.InsertRental(Id, CustomerId.Text, Date);

                    MessageBox.Show("Movie Rented");
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Enter valid customer id");
            }
        }
    }
}
