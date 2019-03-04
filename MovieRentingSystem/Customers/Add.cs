using System;
using System.Data;
using System.Windows.Forms;

namespace MovieRentingSystem.Customers
{
    public partial class Add : Form
    {
        private string CustId;

        public Add()
        {
            InitializeComponent();
        }

        public Add(string CustId)
        {
            this.CustId = CustId;
            InitializeComponent();
            button1.Text = "Update Customer";
            DataTable table = new Database().GetCustomer(CustId);
            FirstName.Text = table.Rows[0]["FirstName"].ToString();
            LastName.Text = table.Rows[0]["LastName"].ToString();
            Address.Text = table.Rows[0]["Address"].ToString();
            PhoneNo.Text = table.Rows[0]["Phone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "" || LastName.Text == "" || Address.Text == "" || PhoneNo.Text == "")
            {
                MessageBox.Show("All fields are mandatory.");
            }
            else
            {
                Customer customer = new Customer()
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Address = Address.Text,
                    Phone = PhoneNo.Text
                };
                Database database = new Database();
                if (button1.Text.ToLower() == "add customer")
                {
                    database.AddCustomer(customer);
                    MessageBox.Show("Customer added successfully");
                }
                else
                {
                    customer.CustID = Convert.ToInt32(CustId);
                    database.UpdateCustomer(customer);
                    MessageBox.Show("Customer updated successfully");
                    Dispose();
                }
            }
        }
    }
}
