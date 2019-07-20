using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int account;

        public Form1(int account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void bookRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_registration book_reg = new book_registration();
            book_reg.Show();
        }

        private void memberRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bookIssuanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_issuance issue = new book_issuance();
            issue.Show();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_return book = new book_return();
            book.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bookRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_request br = new book_request();
            br.Show();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void allMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            member_view mView = new member_view(account);
            mView.Show();
        }

        private void bookRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (account == 2)
            {
                accountsSettingToolStripMenuItem.Enabled = false;
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login l = new login();
            l.Show();
        }

        private void accountsSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account_manage acc = new account_manage();
            acc.Show();
        }

        private void memberRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            member_registration member = new member_registration();
            member.Show();
        }

        private void viewBookRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBookRequest req = new viewBookRequest(account);
            req.Show();
        }

        private void viewAllBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_book viewBook = new view_book(account);
            viewBook.Show();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }
    }
}