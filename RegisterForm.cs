using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginRegisterApp;

public partial class RegisterForm : Form
{
    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMBIJMP;Initial Catalog=LoginRegisterDemo;Integrated Security=True;TrustServerCertificate=True");

    public RegisterForm()
    {
        InitializeComponent();
    }

    private void registerClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void goToLogin_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        loginForm.Show();
        this.Hide();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        if (registerEmail.Text == "" || registerUsername.Text == "" || registerPassword.Text == "")
        {
            MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    String checkUsername = "SELECT * FROM admin WHERE username  = '" + registerUsername.Text.Trim() + "'";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(registerUsername.Text + "is already exist.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO admin (email, username, password, date_created) VALUES (@email, @username, @password, @date)";

                            DateTime date = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, conn))
                            {
                                cmd.Parameters.AddWithValue("@email", registerEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", registerUsername.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", registerPassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }

    private void registerShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (registerShowPassword.Checked)
        {
            registerPassword.PasswordChar = '\0';
        } else
        {
            registerPassword.PasswordChar = '*';
        }
    }
}
