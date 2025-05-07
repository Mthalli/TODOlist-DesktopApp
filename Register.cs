using Microsoft.EntityFrameworkCore;
using TODOlist_forms.Data;
using TODOlist_forms.Models;

namespace TODOlist_forms
{
    public partial class Register : Form
    {
        private readonly AppDbContext _dbContext;
        public Register()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            string re_password = txtConfirmPassword.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill Login and Password boxes correctly", "RegistrationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != re_password)
            {
                MessageBox.Show("Passwords don't match!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(_dbContext.Users.Any(r=> r.Name == login))
            {
                MessageBox.Show("USER ALREADY EXIST", "User Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (login!=null && password!=null && password ==re_password) 
            {
                _dbContext.Users.Add(new User { Name = login, Password = password });
                _dbContext.SaveChanges();
                MessageBox.Show($"Registred user: {login}", "Succesfull user registration!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login formlogin = new Login();
                formlogin.ShowDialog();
                this.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '*';
        }


        private void btnRedirect_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formlogin = new Login();
            formlogin.ShowDialog();
            this.Close();
        }
    }
}
