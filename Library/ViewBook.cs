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

namespace Library
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string? cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(cellValue) && int.TryParse(cellValue, out int parsedBid))
                {
                    bid = parsedBid;
                }
                else
                {
                    MessageBox.Show("Invalid book ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No value selected in the cell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM NewBook WHERE bid = " + bid;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = ds.Tables[0].Rows[0][0] != null && !string.IsNullOrEmpty(ds.Tables[0].Rows[0][0].ToString())
                ? Int64.Parse(ds.Tables[0].Rows[0][0]?.ToString() ?? throw new InvalidOperationException("Row ID is null or empty."))
                : throw new InvalidOperationException("Row ID is null or empty.");

            textBoxBName.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxBAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            textBoxBPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxPDate.Text = ds.Tables[0].Rows[0][4].ToString();
            textBoxBPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxBQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBoxBookName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBookName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM NewBook where bName LIKE '" + textBoxBookName.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxBookName.Clear();
            panel2.Visible = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this book?", "Update Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string bname = textBoxBName.Text;
            string bauthor = textBoxBAuthor.Text;
            string publication = textBoxBPublication.Text;
            string pdate = textBoxPDate.Text;
            Int64 price = Int64.Parse(textBoxBPrice.Text);
            Int64 quantity = Int64.Parse(textBoxBQuantity.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE NewBook SET bName = @bName, bAuthor = @bAuthor, bPubl = @bPubl, bPDate = @bPDate, bPrice = @bPrice, bQuan = @bQuan WHERE bid = @rowid";
            cmd.Parameters.AddWithValue("@bName", bname);
            cmd.Parameters.AddWithValue("@bAuthor", bauthor);
            cmd.Parameters.AddWithValue("@bPubl", publication);
            cmd.Parameters.AddWithValue("@bPDate", pdate);
            cmd.Parameters.AddWithValue("@bPrice", price);
            cmd.Parameters.AddWithValue("@bQuan", quantity);
            cmd.Parameters.AddWithValue("@rowid", rowid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewBook_Load(this, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (rowid == 0)
            {
                MessageBox.Show("No book selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM NewBook WHERE bid = @rowid", con))
            {
                cmd.Parameters.AddWithValue("@rowid", rowid);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView
                    DataSet ds = new DataSet();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NewBook", con))
                    {
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    panel2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Delete failed. Book may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
