namespace Library
{
    partial class ViewUserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserInfo));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnUserRefresh = new Button();
            label3 = new Label();
            txtUserSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnSearchCancel = new Button();
            btnSearchDelete = new Button();
            btnSearchUpdate = new Button();
            txtSearchUserEmail = new TextBox();
            txtSearchUserPrivilege = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtSearchUserNumber = new TextBox();
            label4 = new Label();
            txtSearchUserContact = new TextBox();
            txtSearchUserName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1735, 203);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(972, 105);
            label2.Name = "label2";
            label2.Size = new Size(87, 45);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(972, 59);
            label1.Name = "label1";
            label1.Size = new Size(119, 45);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(617, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnUserRefresh
            // 
            btnUserRefresh.BackColor = SystemColors.HighlightText;
            btnUserRefresh.FlatStyle = FlatStyle.Popup;
            btnUserRefresh.Location = new Point(1076, 239);
            btnUserRefresh.Name = "btnUserRefresh";
            btnUserRefresh.Size = new Size(150, 46);
            btnUserRefresh.TabIndex = 1;
            btnUserRefresh.Text = "Refresh";
            btnUserRefresh.UseVisualStyleBackColor = false;
            btnUserRefresh.Click += btnUserRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 250);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 2;
            label3.Text = "User ID:";
            // 
            // txtUserSearch
            // 
            txtUserSearch.Location = new Point(712, 243);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(318, 39);
            txtUserSearch.TabIndex = 3;
            txtUserSearch.TextChanged += txtUserSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1716, 440);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(btnSearchCancel);
            panel2.Controls.Add(btnSearchDelete);
            panel2.Controls.Add(btnSearchUpdate);
            panel2.Controls.Add(txtSearchUserEmail);
            panel2.Controls.Add(txtSearchUserPrivilege);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtSearchUserNumber);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSearchUserContact);
            panel2.Controls.Add(txtSearchUserName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 750);
            panel2.Name = "panel2";
            panel2.Size = new Size(1716, 417);
            panel2.TabIndex = 5;
            // 
            // btnSearchCancel
            // 
            btnSearchCancel.BackColor = SystemColors.ControlLight;
            btnSearchCancel.FlatStyle = FlatStyle.Popup;
            btnSearchCancel.Location = new Point(1337, 217);
            btnSearchCancel.Name = "btnSearchCancel";
            btnSearchCancel.Size = new Size(150, 46);
            btnSearchCancel.TabIndex = 29;
            btnSearchCancel.Text = "Cancel";
            btnSearchCancel.UseVisualStyleBackColor = false;
            btnSearchCancel.Click += btnSearchCancel_Click;
            // 
            // btnSearchDelete
            // 
            btnSearchDelete.BackColor = SystemColors.ControlLight;
            btnSearchDelete.FlatStyle = FlatStyle.Popup;
            btnSearchDelete.Location = new Point(1097, 217);
            btnSearchDelete.Name = "btnSearchDelete";
            btnSearchDelete.Size = new Size(150, 46);
            btnSearchDelete.TabIndex = 28;
            btnSearchDelete.Text = "Delete";
            btnSearchDelete.UseVisualStyleBackColor = false;
            btnSearchDelete.Click += btnSearchDelete_Click;
            // 
            // btnSearchUpdate
            // 
            btnSearchUpdate.BackColor = SystemColors.ControlLight;
            btnSearchUpdate.FlatStyle = FlatStyle.Popup;
            btnSearchUpdate.Location = new Point(854, 217);
            btnSearchUpdate.Name = "btnSearchUpdate";
            btnSearchUpdate.Size = new Size(150, 46);
            btnSearchUpdate.TabIndex = 27;
            btnSearchUpdate.Text = "Update";
            btnSearchUpdate.UseVisualStyleBackColor = false;
            btnSearchUpdate.Click += btnSearchUpdate_Click;
            // 
            // txtSearchUserEmail
            // 
            txtSearchUserEmail.Location = new Point(1168, 64);
            txtSearchUserEmail.Name = "txtSearchUserEmail";
            txtSearchUserEmail.Size = new Size(319, 39);
            txtSearchUserEmail.TabIndex = 26;
            // 
            // txtSearchUserPrivilege
            // 
            txtSearchUserPrivilege.Location = new Point(1168, 149);
            txtSearchUserPrivilege.Name = "txtSearchUserPrivilege";
            txtSearchUserPrivilege.Size = new Size(319, 39);
            txtSearchUserPrivilege.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(854, 58);
            label7.Name = "label7";
            label7.Size = new Size(173, 45);
            label7.TabIndex = 24;
            label7.Text = "User Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(853, 142);
            label8.Name = "label8";
            label8.Size = new Size(227, 45);
            label8.TabIndex = 23;
            label8.Text = "Privilege Level";
            // 
            // txtSearchUserNumber
            // 
            txtSearchUserNumber.Location = new Point(386, 142);
            txtSearchUserNumber.Name = "txtSearchUserNumber";
            txtSearchUserNumber.Size = new Size(319, 39);
            txtSearchUserNumber.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 136);
            label4.Name = "label4";
            label4.Size = new Size(127, 45);
            label4.TabIndex = 21;
            label4.Text = "User ID";
            // 
            // txtSearchUserContact
            // 
            txtSearchUserContact.Location = new Point(386, 217);
            txtSearchUserContact.Name = "txtSearchUserContact";
            txtSearchUserContact.Size = new Size(319, 39);
            txtSearchUserContact.TabIndex = 20;
            // 
            // txtSearchUserName
            // 
            txtSearchUserName.Location = new Point(386, 64);
            txtSearchUserName.Name = "txtSearchUserName";
            txtSearchUserName.Size = new Size(319, 39);
            txtSearchUserName.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 211);
            label6.Name = "label6";
            label6.Size = new Size(242, 45);
            label6.TabIndex = 18;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 57);
            label5.Name = "label5";
            label5.Size = new Size(182, 45);
            label5.TabIndex = 17;
            label5.Text = "User Name";
            // 
            // ViewStudentInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1740, 1179);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(txtUserSearch);
            Controls.Add(label3);
            Controls.Add(btnUserRefresh);
            Controls.Add(panel1);
            Name = "ViewStudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInfo";
            Load += ViewStudentInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnUserRefresh;
        private Label label3;
        private TextBox txtUserSearch;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSearchUserNumber;
        private Label label4;
        private TextBox txtSearchUserContact;
        private TextBox txtSearchUserName;
        private Label label6;
        private Label label5;
        private TextBox txtSearchUserEmail;
        private TextBox txtSearchUserPrivilege;
        private Label label7;
        private Label label8;
        private Button btnSearchCancel;
        private Button btnSearchDelete;
        private Button btnSearchUpdate;
    }
}