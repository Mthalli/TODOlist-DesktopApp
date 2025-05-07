namespace TODOlist_forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddTask = new Button();
            lblHello = new Label();
            btnDelete = new Button();
            btnLogout = new Button();
            label1 = new Label();
            panelTasks = new Panel();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(12, 79);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(115, 50);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "ADD TASK";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHello.Location = new Point(12, 9);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(125, 50);
            lblHello.TabIndex = 2;
            lblHello.Text = "Hello ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(133, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE TASK";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnLogout.Location = new Point(681, 21);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 38);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 6;
            label1.Text = "My Tasks:";
            // 
            // panelTasks
            // 
            panelTasks.AutoScroll = true;
            panelTasks.BackColor = SystemColors.Control;
            panelTasks.Location = new Point(12, 157);
            panelTasks.Name = "panelTasks";
            panelTasks.Size = new Size(804, 319);
            panelTasks.TabIndex = 7;
            panelTasks.Paint += panelTasks_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(850, 488);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(lblHello);
            Controls.Add(btnAddTask);
            Controls.Add(panelTasks);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTask;
        private Label lblHello;
        private Button btnDelete;
        private Button btnLogout;
        private Label label1;
        private Panel panelTasks;
    }
}