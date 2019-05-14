using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote frmAddQuote = new AddQuote(this);
           // frmAddQuote.Tag = this;
            frmAddQuote.Show(this);
            Hide();
        }
        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes frmViewAllQuotes = new ViewAllQuotes(this);
            frmViewAllQuotes.Show();
            Hide();
        }
        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes frmSearchQuotes = new SearchQuotes(this);
            frmSearchQuotes.Show();
            Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnButton4_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddNewQuote_Click_1(object sender, EventArgs e)
        {
            AddQuote frmAddQuote = new AddQuote(this);
            // frmAddQuote.Tag = this;
            frmAddQuote.Show(this);
            Hide();
        }
    }
}
