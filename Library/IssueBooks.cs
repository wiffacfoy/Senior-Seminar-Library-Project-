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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("SELECT bName FROM NewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }

            }
            Sdr.Close();
            con.Close();
        }
        int count;
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textEnterUser.Text != "")
            {
                String uid = textEnterUser.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NewUser WHERE userid = " + uid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Limit borrowing to 3 books

                cmd.CommandText = "SELECT count (user_id) FROM IRBook WHERE user_id = " + uid + " AND book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                // Limit borrowing to 3 books

                if (ds.Tables[0].Rows.Count != 0)
                {
                    textName.Text = ds.Tables[0].Rows[0][1].ToString();
                    textContact.Text = ds.Tables[0].Rows[0][3].ToString();
                    textEmail.Text = ds.Tables[0].Rows[0][4].ToString();

                }
                else
                {
                    textName.Clear();
                    textContact.Clear();
                    textEmail.Clear();
                    MessageBox.Show("Invalid User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonIssueBook_Click(object sender, EventArgs e)
        {
            if (textName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    String userid = textEnterUser.Text;
                    String username = textName.Text;
                    String usercontact = textContact.Text;
                    String useremail = textEmail.Text;
                    String bookname = comboBoxBooks.Text;
                    String issueDate = dateTimePicker1.Text;

                    String uid = textEnterUser.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "INSERT into IRBook (user_id,user_name,user_contact,user_email,book_name,book_issue_date) values (" + userid + ",'" + username + "','" + usercontact + "','" + useremail + "','" + bookname + "','" + issueDate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book OR Maximum number of Books have been ISSUED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void textEnterUser_TextChanged(object sender, EventArgs e)
        {
            if (textEnterUser.Text == "")
            {
                textName.Clear();
                textContact.Clear();
                textEmail.Clear();

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textEnterUser.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
