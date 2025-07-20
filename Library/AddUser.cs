using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace Library
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserContact.Text != "" && txtUserEmail.Text != "" && txtUserPrivilege.Text != "" && txtUserNumber.Text != "")
            {
                string uname = txtUserName.Text;
                string unumber = txtUserNumber.Text;
                string ucontact = txtUserContact.Text;
                string uemail = txtUserEmail.Text;
                string uprivilege = txtUserPrivilege.Text;

                string connStr = "Data Source=DESKTOP-62TBGIQ\\MSSQLSERVER01; Initial Catalog=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "INSERT INTO NewUser (userName, userNumber, userContact, userEmail, userPrivilege) " +
                                   "VALUES (@uname, @unumber, @ucontact, @uemail, @uprivilege)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uname", uname);
                        cmd.Parameters.AddWithValue("@unumber", unumber);
                        cmd.Parameters.AddWithValue("@ucontact", ucontact);
                        cmd.Parameters.AddWithValue("@uemail", uemail);
                        cmd.Parameters.AddWithValue("@uprivilege", uprivilege);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Account Created successfully.");

                        txtUserName.Clear();
                        txtUserNumber.Clear();
                        txtUserContact.Clear();
                        txtUserEmail.Clear();
                        txtUserPrivilege.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" || txtUserContact.Text != "" || txtUserEmail.Text != "" || txtUserPrivilege.Text != "" || txtUserNumber.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to clear all fields?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtUserName.Clear();
                    txtUserNumber.Clear();
                    txtUserContact.Clear();
                    txtUserEmail.Clear();
                    txtUserPrivilege.Clear();
                }
            }
            else
            {
                MessageBox.Show("All fields are already clear.");
            }
        }
    }
}
