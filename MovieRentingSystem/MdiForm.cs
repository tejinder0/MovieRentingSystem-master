using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentingSystem
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers.Add obj = new Customers.Add()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers.View obj = new Customers.View()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Movies.Add obj = new Movies.Add()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void showAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Movies.View obj = new Movies.View()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movies.View obj = new Movies.View()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions.Return obj = new Transactions.Return()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void topCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.BestCustomer obj = new Reports.BestCustomer()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void topMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.BestMovies obj = new Reports.BestMovies()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are your sure to quit?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
