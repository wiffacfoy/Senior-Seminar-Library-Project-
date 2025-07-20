using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class ViewUserInfo : Form
    {
        public ViewUserInfo()
        {
            InitializeComponent();
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            if (txtUserSearch.Text != "")
            {
                string sunumber = txtUserSearch.Text;

                Image searchingimage1 = Image.FromFile("C:/Users/Tevin/Desktop/School/Liberay Management System/search1.gif");
                pictureBox1.Image = searchingimage1;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM NewUser WHERE userNumber LIKE @sunumber";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sunumber", "%" + sunumber + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            else
            {
                Image searchingimage2 = Image.FromFile("C:/Users/Tevin/Desktop/School/Liberay Management System/search.gif");
                pictureBox1.Image = searchingimage2;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM NewUser";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
        }

        private void ViewStudentInfo_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string connectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NewUser";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        int bid;
        int rowIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid row and column indices
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out bid)) // Safely parse the value
                {
                    panel2.Visible = true;
                    string connectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM NewUser WHERE userid = @bid";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@bid", bid);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value && ds.Tables[0].Rows[0][0] != null)
                            {
                                rowIndex = int.TryParse(ds.Tables[0].Rows[0][0].ToString(), out int parsedValue) ? parsedValue : 0;
                                txtSearchUserName.Text = ds.Tables[0].Rows[0][1]?.ToString() ?? string.Empty;
                                txtSearchUserNumber.Text = ds.Tables[0].Rows[0][2]?.ToString() ?? string.Empty;
                                txtSearchUserContact.Text = ds.Tables[0].Rows[0][3]?.ToString() ?? string.Empty;
                                txtSearchUserEmail.Text = ds.Tables[0].Rows[0][4]?.ToString() ?? string.Empty;
                                txtSearchUserPrivilege.Text = ds.Tables[0].Rows[0][5]?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("No data found for the selected user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid cell value. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            string suname = txtSearchUserName.Text;
            string sunumber = txtSearchUserNumber.Text;
            string sucontact = txtSearchUserContact.Text;
            string suemail = txtSearchUserEmail.Text;
            string suprivilege = txtSearchUserPrivilege.Text;

            string connectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (MessageBox.Show("Data will be updated, are you sure?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "UPDATE NewUser SET userName = @suname, userNumber = @sunumber, userContact = @sucontact, userEmail = @suemail, userPrivilege = @suprivilege WHERE userid = @rowIndex";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@suname", suname);
                        cmd.Parameters.AddWithValue("@sunumber", sunumber);
                        cmd.Parameters.AddWithValue("@sucontact", sucontact);
                        cmd.Parameters.AddWithValue("@suemail", suemail);
                        cmd.Parameters.AddWithValue("@suprivilege", suprivilege);
                        cmd.Parameters.AddWithValue("@rowIndex", rowIndex);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewStudentInfo_Load(this, EventArgs.Empty);
                }
            }
        }

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInfo_Load(this, EventArgs.Empty);
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted, are you sure?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM NewUser WHERE userid = @rowIndex";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rowIndex", rowIndex);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pass EventArgs.Empty instead of null to avoid the CS8625 error
                    ViewStudentInfo_Load(this, EventArgs.Empty);
                }
            }
        }
    }
}
