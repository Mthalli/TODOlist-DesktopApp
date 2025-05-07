namespace TODOlist_forms
{
    partial class Login
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
            lblLogin = new Label();
            lbllog = new Label();
            label1 = new Label();
            label2 = new Label();
            txtLogin1 = new TextBox();
            txtPassword1 = new TextBox();
            btnLogin1 = new Button();
            btnRegister1 = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLogin.Location = new Point(276, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(309, 65);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGGING IN";
            // 
            // lbllog
            // 
            lbllog.AutoSize = true;
            lbllog.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbllog.Location = new Point(295, 124);
            lbllog.Name = "lbllog";
            lbllog.Size = new Size(53, 20);
            lbllog.TabIndex = 4;
            lbllog.Text = "Login: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(295, 173);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(295, 257);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 6;
            label2.Text = "Want to create an account?";
            // 
            // txtLogin1
            // 
            txtLogin1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtLogin1.Location = new Point(295, 146);
            txtLogin1.Margin = new Padding(3, 2, 3, 2);
            txtLogin1.Name = "txtLogin1";
            txtLogin1.Size = new Size(264, 29);
            txtLogin1.TabIndex = 7;
            // 
            // txtPassword1
            // 
            txtPassword1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPassword1.Location = new Point(295, 194);
            txtPassword1.Margin = new Padding(3, 2, 3, 2);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(264, 29);
            txtPassword1.TabIndex = 8;
            txtPassword1.TextChanged += txtPassword1_TextChanged;
            // 
            // btnLogin1
            // 
            btnLogin1.BackColor = Color.FromArgb(224, 224, 224);
            btnLogin1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnLogin1.Location = new Point(295, 224);
            btnLogin1.Margin = new Padding(3, 2, 3, 2);
            btnLogin1.Name = "btnLogin1";
            btnLogin1.Size = new Size(263, 31);
            btnLogin1.TabIndex = 11;
            btnLogin1.Text = "Login";
            btnLogin1.UseVisualStyleBackColor = false;
            btnLogin1.Click += btnLogin1_Click;
            // 
            // btnRegister1
            // 
            btnRegister1.BackColor = Color.FromArgb(224, 224, 224);
            btnRegister1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRegister1.Location = new Point(295, 278);
            btnRegister1.Margin = new Padding(3, 2, 3, 2);
            btnRegister1.Name = "btnRegister1";
            btnRegister1.Size = new Size(263, 31);
            btnRegister1.TabIndex = 12;
            btnRegister1.Text = "Register";
            btnRegister1.UseVisualStyleBackColor = false;
            btnRegister1.Click += btnRegister1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 488);
            Controls.Add(btnRegister1);
            Controls.Add(btnLogin1);
            Controls.Add(txtPassword1);
            Controls.Add(txtLogin1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbllog);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lbllog;
        private Label label1;
        private Label label2;
        private TextBox txtLogin1;
        private TextBox txtPassword1;
        private Button btnLogin1;
        private Button btnRegister1;
    }
}