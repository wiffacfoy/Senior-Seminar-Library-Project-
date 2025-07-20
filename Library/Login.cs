using Microsoft.Data.SqlClient;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPass_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = string.Empty;
                txtPass.ForeColor = Color.White;
                txtPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

            try
            {
                con.Open();
                string query = "SELECT * FROM loginTable WHERE username=@username AND pass=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username or password.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
