using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                string bname = txtBookName.Text;
                string bauthor = txtAuthor.Text;
                string bpublication = txtPublication.Text;
                string bdate = dateTimePicker1.Text;
                Int64 price, quantity;

                if (!Int64.TryParse(txtPrice.Text, out price) || !Int64.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("Please enter valid numbers for Price and Quantity.");
                    return;
                }

                // ✅ Consistent SQL Server connection string from ViewBook
                string connStr = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

                // SQL insert query
                string query = @"INSERT INTO NewBook (bName, bAuthor, bPubl, bPDate, bPrice, bQuan)
                                 VALUES (@bname, @bauthor, @bpublication, @bdate, @price, @quantity)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@bname", bname);
                            cmd.Parameters.AddWithValue("@bauthor", bauthor);
                            cmd.Parameters.AddWithValue("@bpublication", bpublication);
                            cmd.Parameters.AddWithValue("@bdate", bdate);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@quantity", quantity);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Book inserted successfully.");

                    // Clear form
                    txtBookName.Clear();
                    txtAuthor.Clear();
                    txtPublication.Clear();
                    txtPrice.Clear();
                    txtQuantity.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
