using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentingSystem.Movies
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            dataGridView1.DataSource = new Database().GetMovies();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add edit = new Add(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            edit.ShowDialog();
            dataGridView1.DataSource = new Database().GetMovies();
        }

        private void issueMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Copies = new Database().CheckAvaliableCopies(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            if(Copies > 0)
            {
                Transactions.Issue issue = new Transactions.Issue(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                issue.ShowDialog();
            }
            else
            {
                MessageBox.Show("No copies available to issue");
            }
        }

        private void View_Load(object sender, EventArgs e)
        {

        }
    }
}
