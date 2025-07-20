namespace Library
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            buttonExit = new Button();
            buttonRefresh = new Button();
            buttonSearch = new Button();
            textEnterUser = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            comboBoxBooks = new ComboBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonIssueBook = new Button();
            textEmail = new TextBox();
            textContact = new TextBox();
            textName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(440, 42);
            label1.Name = "label1";
            label1.Size = new Size(164, 36);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(196, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(buttonRefresh);
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(textEnterUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 368);
            panel2.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Silver;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Location = new Point(136, 255);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.Silver;
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Location = new Point(21, 255);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Silver;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.ControlText;
            buttonSearch.Location = new Point(70, 191);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(125, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search User";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textEnterUser
            // 
            textEnterUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textEnterUser.Location = new Point(37, 155);
            textEnterUser.Name = "textEnterUser";
            textEnterUser.Size = new Size(205, 30);
            textEnterUser.TabIndex = 2;
            textEnterUser.TextChanged += textEnterUser_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 128);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 1;
            label2.Text = "Enter User ID";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(comboBoxBooks);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(buttonIssueBook);
            panel3.Controls.Add(textEmail);
            panel3.Controls.Add(textContact);
            panel3.Controls.Add(textName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(277, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(492, 368);
            panel3.TabIndex = 2;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(189, 187);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(276, 28);
            comboBoxBooks.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(18, 192);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 12;
            label7.Text = "Book Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(189, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // buttonIssueBook
            // 
            buttonIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonIssueBook.BackColor = Color.Silver;
            buttonIssueBook.FlatStyle = FlatStyle.Popup;
            buttonIssueBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIssueBook.Location = new Point(344, 294);
            buttonIssueBook.Name = "buttonIssueBook";
            buttonIssueBook.Size = new Size(121, 39);
            buttonIssueBook.TabIndex = 10;
            buttonIssueBook.Text = "Issue Book";
            buttonIssueBook.UseVisualStyleBackColor = false;
            buttonIssueBook.Click += buttonIssueBook_Click;
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textEmail.Location = new Point(189, 136);
            textEmail.Name = "textEmail";
            textEmail.ReadOnly = true;
            textEmail.Size = new Size(276, 27);
            textEmail.TabIndex = 7;
            // 
            // textContact
            // 
            textContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textContact.Location = new Point(189, 87);
            textContact.Name = "textContact";
            textContact.ReadOnly = true;
            textContact.Size = new Size(276, 27);
            textContact.TabIndex = 6;
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textName.Location = new Point(189, 39);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(276, 27);
            textName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(18, 233);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 3;
            label6.Text = "Book Issue Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(18, 137);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 2;
            label5.Text = "User Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(18, 87);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 1;
            label4.Text = "User Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(18, 40);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 0;
            label3.Text = "User Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(781, 544);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button buttonExit;
        private Button buttonRefresh;
        private Button buttonSearch;
        private TextBox textEnterUser;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonIssueBook;
        private TextBox textEmail;
        private TextBox textContact;
        private TextBox textName;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxBooks;
        private Label label7;
    }
}