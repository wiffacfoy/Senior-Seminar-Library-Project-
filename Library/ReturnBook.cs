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
    public partial class ReturnBook : Form
    {


        public ReturnBook()
        {
            InitializeComponent();
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM IRBook WHERE user_id = @userid AND book_return_date IS NULL";
            cmd.Parameters.AddWithValue("@userid", Convert.ToInt32(textEnterUser.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid User ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void ReturnBook_Load(object sender, EventArgs? e)
        {
            panel2.Visible = false;
            textEnterUser.Clear();
        }

        String bname;
        String bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }

            textBookName.Text = bname;
            textBookIssueDate.Text = bdate;
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE IRBook SET book_return_date ='" + dateTimePicker1.Text + "' where user_id = '" + textEnterUser.Text + "' and id =" + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textEnterUser.Clear();
        }

        private void textEnterUser_TextChanged(object sender, EventArgs e)
        {
            if (textEnterUser.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textEnterUser.Clear();
        }
    }
}