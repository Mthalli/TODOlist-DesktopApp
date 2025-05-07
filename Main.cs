using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOlist_forms.Data;
using TODOlist_forms.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TODOlist_forms
{
    public partial class Main : Form
    {
        private int taskCount = 1;
        private readonly AppDbContext _dbContext;
        private readonly User _user;

        public Main(int id)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _user = _dbContext.Users.FirstOrDefault(r => r.Id == id);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            lblHello.Text += $"{_user.Name}!";
            LoadTasks();


        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LoadTasks()
        {
            var existingLabels = panelTasks.Controls.OfType<Label>().Where(l => l.Tag?.ToString() == "taskLabel").ToList();
            foreach (var label in existingLabels)
            {
                panelTasks.Controls.Remove(label);
            }

            taskCount = 0;
            var tasks = _dbContext.TodoTasks.Where(r => r.UserId == _user.Id).ToList();

            foreach (var task in tasks)
            {
                Label lblTask = new Label();
                lblTask.Text = $"{task.Id}) {task.Name} | {task.dateTime}";
                lblTask.Location = new Point(0, 0+ taskCount * 30);
                lblTask.AutoSize = true;
                lblTask.Font = new Font("Segoe UI", 11f);
                lblTask.Tag = "taskLabel";

                panelTasks.Controls.Add(lblTask);
                taskCount++;
            }
        }



        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskDescription = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the task title:",
                "Add New Task",
                "");
            if (!string.IsNullOrWhiteSpace(taskDescription))
            {
                _dbContext.TodoTasks.Add(new TodoTask { UserId = _user.Id, Name = taskDescription, dateTime = DateTime.Now });
                _dbContext.SaveChanges();//adding task
                LoadTasks();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the ID of the task to delete:",
                "Delete Task",
                "");

            if (!int.TryParse(input, out int taskId))
            {
                MessageBox.Show("Please enter a valid task number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idtoremove = _dbContext.TodoTasks.FirstOrDefault(r => r.Id == taskId && r.UserId == _user.Id);
            if (idtoremove == null)
            {
                MessageBox.Show("There is no task with this ID assigned to you.", "Deleting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dbContext.TodoTasks.Remove(idtoremove);
            _dbContext.SaveChanges();
            LoadTasks();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User has been logged out", "Logout in succesfull!");
            this.Hide();
            Login mainform = new Login();
            mainform.ShowDialog();
            this.Close();
        }

        private void panelTasks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
