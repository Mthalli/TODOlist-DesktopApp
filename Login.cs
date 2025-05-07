using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOlist_forms.Data;

namespace TODOlist_forms
{
    public partial class Login : Form
    {
        private readonly AppDbContext _dbContext;
        public Login()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            string login1 = txtLogin1.Text;
            string password1 = txtPassword1.Text;

            var user = _dbContext.Users.FirstOrDefault(r => r.Name == login1 && r.Password == password1);

            if (user!= null)
            {
                MessageBox.Show($"Hello {login1} :)", "Log in succesfull!");
                this.Hide();
                Main mainform = new Main(user.Id);
                mainform.ShowDialog();
                this.Close();
            }
            else if (string.IsNullOrEmpty(login1) || string.IsNullOrEmpty(password1))
            {
                MessageBox.Show("Fill Login and Password boxes correctly", "THERE ARE EMPTY BOXES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Failed to log in. Login or/and password are incorrect!", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            txtPassword1.PasswordChar = '*';
        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerform = new Register();
            registerform.ShowDialog();
            this.Close();
        }
    }
}
