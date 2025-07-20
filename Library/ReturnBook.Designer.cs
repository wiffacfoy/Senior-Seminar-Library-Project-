
namespace Library
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel1 = new Panel();
            buttonExit = new Button();
            buttonRefresh = new Button();
            buttonSearchUser = new Button();
            textEnterUser = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            buttonCancel = new Button();
            buttonReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBookIssueDate = new TextBox();
            textBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonSearchUser);
            panel1.Controls.Add(textEnterUser);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 384);
            panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonExit.Location = new Point(153, 340);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonRefresh.Location = new Point(34, 340);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSearchUser
            // 
            buttonSearchUser.FlatStyle = FlatStyle.Popup;
            buttonSearchUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchUser.Location = new Point(76, 259);
            buttonSearchUser.Name = "buttonSearchUser";
            buttonSearchUser.Size = new Size(143, 35);
            buttonSearchUser.TabIndex = 3;
            buttonSearchUser.Text = "Search User";
            buttonSearchUser.UseVisualStyleBackColor = true;
            buttonSearchUser.Click += buttonSearchUser_Click;
            // 
            // textEnterUser
            // 
            textEnterUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEnterUser.Location = new Point(34, 216);
            textEnterUser.Name = "textEnterUser";
            textEnterUser.Size = new Size(227, 30);
            textEnterUser.TabIndex = 2;
            textEnterUser.TextChanged += textEnterUser_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 185);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(328, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(690, 384);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(buttonCancel);
            panel2.Controls.Add(buttonReturn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBookIssueDate);
            panel2.Controls.Add(textBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(328, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 173);
            panel2.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(505, 60);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReturn.Location = new Point(505, 22);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(94, 29);
            buttonReturn.TabIndex = 6;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBookIssueDate
            // 
            textBookIssueDate.Location = new Point(149, 66);
            textBookIssueDate.Name = "textBookIssueDate";
            textBookIssueDate.Size = new Size(125, 27);
            textBookIssueDate.TabIndex = 4;
            // 
            // textBookName
            // 
            textBookName.Location = new Point(149, 19);
            textBookName.Name = "textBookName";
            textBookName.Size = new Size(125, 27);
            textBookName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 123);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 2;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 69);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 1;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 22);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1022, 630);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

     

        #endregion

        private Panel panel1;
        private TextBox textEnterUser;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button buttonExit;
        private Button buttonRefresh;
        private Button buttonSearchUser;
        private Button buttonCancel;
        private Button buttonReturn;
        private DateTimePicker dateTimePicker1;
        private TextBox textBookIssueDate;
        private TextBox textBookName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}