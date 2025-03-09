using System.Windows.Forms;

namespace rick_forms
{
    public partial class Login_Page : Form
    {

        int failedAttempts = 0;
        int maxedAttempts = 5;

        public Login_Page()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = "drricx";
            string password = "123";


            if (username == EmailInputBox.Text && password == PasswordInputBox.Text)
            {
                failedAttempts = 0;
                Form student_page = new Student_Page_Ricky();
                student_page.Show();
            }
            else
            {
                failedAttempts++;

                if (string.IsNullOrEmpty(EmailInputBox.Text))
                {
                    ErrorProviderUsername.SetError(EmailInputBox, "Username required");
                    EmailInputBox.Focus();
                }
                else if (string.IsNullOrEmpty(PasswordInputBox.Text))
                {
                    ErrorProviderPassword.SetError(PasswordInputBox, "Password Required");
                    PasswordInputBox.Focus();
                }

                if(failedAttempts >= maxedAttempts)
                {
                    MessageBox.Show("Too many failed attemps. Please reset password here \nhttps://www.example.com/reset-password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
