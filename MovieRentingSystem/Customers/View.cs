using System;
using System.Windows.Forms;

namespace MovieRentingSystem.Customers
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetCustomers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add edit = new Add(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            edit.ShowDialog();
            dataGridView1.DataSource = new Database().GetCustomers();
        }
    }
}
