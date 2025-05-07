namespace TODOlist_forms
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegister = new Label();
            txtLogin = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRedirect = new Button();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.Top;
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblRegister.Location = new Point(244, 32);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(368, 65);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "REGISTRATION";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtLogin.Location = new Point(295, 146);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(264, 29);
            txtLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(295, 124);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Login: ";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPassword.Location = new Point(295, 194);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 29);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(295, 173);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(224, 224, 224);
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRegister.Location = new Point(295, 273);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(263, 31);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtConfirmPassword.Location = new Point(295, 243);
            txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(264, 29);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(295, 222);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Repeat Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(295, 306);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 9;
            label4.Text = "Do you have an acoount?";
            // 
            // btnRedirect
            // 
            btnRedirect.BackColor = Color.FromArgb(224, 224, 224);
            btnRedirect.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRedirect.Location = new Point(295, 327);
            btnRedirect.Margin = new Padding(3, 2, 3, 2);
            btnRedirect.Name = "btnRedirect";
            btnRedirect.Size = new Size(263, 31);
            btnRedirect.TabIndex = 10;
            btnRedirect.Text = "Login";
            btnRedirect.UseVisualStyleBackColor = false;
            btnRedirect.Click += btnRedirect_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 488);
            Controls.Add(btnRedirect);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(lblRegister);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            Text = "TODO List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private TextBox txtLogin;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button btnRegister;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Label label4;
        private Button btnRedirect;
    }
}
