using System.Data;
using System.Data.SqlClient;

namespace LoginRegisterApp;

public partial class LoginForm : Form
{
    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=LoginRegisterDemo;Integrated Security=True;TrustServerCertificate=True");

    public LoginForm()
    {
        InitializeComponent();
    }

    private void loginClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void goToRegister_Click(object sender, EventArgs e)
    {
        RegisterForm registerForm = new RegisterForm();
        registerForm.Show();
        this.Hide();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        if (loginUsername.Text == "" || loginPassword.Text == "")
        {
            MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                String selectData = "SELECT * FROM admin WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    cmd.Parameters.AddWithValue("@username", loginUsername.Text);
                    cmd.Parameters.AddWithValue("@password", loginPassword.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show("Logged in successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

    private void loginShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (loginShowPassword.Checked)
        {
            loginPassword.PasswordChar = '\0';
        }
        else
        {
            loginPassword.PasswordChar = '*';
        }
    }
}
