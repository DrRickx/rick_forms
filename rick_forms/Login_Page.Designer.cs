namespace rick_forms
{
    partial class Login_Page
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
            components = new System.ComponentModel.Container();
            EmailLabel = new Label();
            EmailInputBox = new TextBox();
            SubmitBtn = new Button();
            PasswordLabel = new Label();
            PasswordInputBox = new TextBox();
            ErrorProviderUsername = new ErrorProvider(components);
            ErrorProviderPassword = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorProviderUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderPassword).BeginInit();
            SuspendLayout();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(268, 133);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(87, 20);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Username:";
            // 
            // EmailInputBox
            // 
            EmailInputBox.Location = new Point(268, 156);
            EmailInputBox.Name = "EmailInputBox";
            EmailInputBox.Size = new Size(239, 27);
            EmailInputBox.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitBtn.Location = new Point(344, 275);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 2;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += submitButton_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(268, 201);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password: ";
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(268, 224);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(239, 27);
            PasswordInputBox.TabIndex = 4;
            // 
            // ErrorProviderUsername
            // 
            ErrorProviderUsername.ContainerControl = this;
            // 
            // ErrorProviderPassword
            // 
            ErrorProviderPassword.ContainerControl = this;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordInputBox);
            Controls.Add(PasswordLabel);
            Controls.Add(SubmitBtn);
            Controls.Add(EmailInputBox);
            Controls.Add(EmailLabel);
            Name = "Login_Page";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ErrorProviderUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmailLabel;
        private TextBox EmailInputBox;
        private Button SubmitBtn;
        private Label PasswordLabel;
        private TextBox PasswordInputBox;
        private ErrorProvider ErrorProviderUsername;
        private ErrorProvider ErrorProviderPassword;
    }
}
