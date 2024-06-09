namespace WinFormsStarter
{
    partial class LoginForm
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
            btn_Login = new Button();
            input_Username = new TextBox();
            input_Password = new TextBox();
            label_Password = new Label();
            label_Username = new Label();
            label_Error = new Label();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 12F);
            btn_Login.Location = new Point(12, 197);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(211, 33);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // input_Username
            // 
            input_Username.Font = new Font("Segoe UI", 12F);
            input_Username.Location = new Point(12, 49);
            input_Username.Name = "input_Username";
            input_Username.PlaceholderText = "Usuário";
            input_Username.Size = new Size(211, 29);
            input_Username.TabIndex = 1;
            // 
            // input_Password
            // 
            input_Password.Font = new Font("Segoe UI", 12F);
            input_Password.Location = new Point(12, 122);
            input_Password.Name = "input_Password";
            input_Password.PlaceholderText = "Senha";
            input_Password.Size = new Size(211, 29);
            input_Password.TabIndex = 2;
            input_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(12, 104);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(39, 15);
            label_Password.TabIndex = 3;
            label_Password.Text = "Senha";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(12, 31);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(47, 15);
            label_Username.TabIndex = 4;
            label_Username.Text = "Usuário";
            // 
            // label_Error
            // 
            label_Error.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Error.AutoSize = true;
            label_Error.Font = new Font("Segoe UI", 12F);
            label_Error.ForeColor = Color.Red;
            label_Error.Location = new Point(57, 164);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(123, 21);
            label_Error.TabIndex = 5;
            label_Error.Text = "Usuário Inválido";
            label_Error.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 242);
            Controls.Add(label_Error);
            Controls.Add(label_Username);
            Controls.Add(label_Password);
            Controls.Add(input_Password);
            Controls.Add(input_Username);
            Controls.Add(btn_Login);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private TextBox input_Username;
        private TextBox input_Password;
        private Label label_Password;
        private Label label_Username;
        private Label label_Error;
    }
}
