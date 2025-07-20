namespace Library
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxBookName = new TextBox();
            buttonRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            textBoxPDate = new TextBox();
            button4 = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            textBoxBQuantity = new TextBox();
            textBoxBPrice = new TextBox();
            textBoxBPublication = new TextBox();
            textBoxBAuthor = new TextBox();
            textBoxBName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 136);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(299, 40);
            label1.Name = "label1";
            label1.Size = new Size(312, 59);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(973, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 170);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // textBoxBookName
            // 
            textBoxBookName.Font = new Font("Segoe UI", 10F);
            textBoxBookName.Location = new Point(333, 170);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(236, 30);
            textBoxBookName.TabIndex = 2;
            textBoxBookName.TextChanged += textBoxBookName_TextChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRefresh.Location = new Point(575, 169);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 31);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 340);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(textBoxPDate);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(textBoxBQuantity);
            panel2.Controls.Add(textBoxBPrice);
            panel2.Controls.Add(textBoxBPublication);
            panel2.Controls.Add(textBoxBAuthor);
            panel2.Controls.Add(textBoxBName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel2.Location = new Point(12, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 448);
            panel2.TabIndex = 5;
            // 
            // textBoxPDate
            // 
            textBoxPDate.Location = new Point(680, 83);
            textBoxPDate.Name = "textBoxPDate";
            textBoxPDate.Size = new Size(250, 34);
            textBoxPDate.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(813, 343);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 13;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(664, 343);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 39);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(524, 343);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 39);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxBQuantity
            // 
            textBoxBQuantity.Location = new Point(680, 270);
            textBoxBQuantity.Name = "textBoxBQuantity";
            textBoxBQuantity.Size = new Size(250, 34);
            textBoxBQuantity.TabIndex = 10;
            // 
            // textBoxBPrice
            // 
            textBoxBPrice.Location = new Point(680, 175);
            textBoxBPrice.Name = "textBoxBPrice";
            textBoxBPrice.Size = new Size(250, 34);
            textBoxBPrice.TabIndex = 9;
            textBoxBPrice.TextChanged += textBox5_TextChanged;
            // 
            // textBoxBPublication
            // 
            textBoxBPublication.Location = new Point(196, 270);
            textBoxBPublication.Name = "textBoxBPublication";
            textBoxBPublication.Size = new Size(217, 34);
            textBoxBPublication.TabIndex = 8;
            // 
            // textBoxBAuthor
            // 
            textBoxBAuthor.Location = new Point(196, 171);
            textBoxBAuthor.Name = "textBoxBAuthor";
            textBoxBAuthor.Size = new Size(217, 34);
            textBoxBAuthor.TabIndex = 7;
            // 
            // textBoxBName
            // 
            textBoxBName.Location = new Point(196, 83);
            textBoxBName.Name = "textBoxBName";
            textBoxBName.Size = new Size(217, 34);
            textBoxBName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(487, 272);
            label8.Name = "label8";
            label8.Size = new Size(149, 28);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(511, 170);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(445, 83);
            label6.Name = "label6";
            label6.Size = new Size(208, 28);
            label6.TabIndex = 3;
            label6.Text = "Book  Purchase Date";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 265);
            label5.Name = "label5";
            label5.Size = new Size(173, 28);
            label5.TabIndex = 2;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 166);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 1;
            label4.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 81);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(968, 1034);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRefresh);
            Controls.Add(textBoxBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBook";
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Add desired functionality here
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Handle the text change event, if necessary.
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxBookName;
        private Button buttonRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button4;
        private Button buttonDelete;
        private Button buttonUpdate;
        private TextBox textBoxBQuantity;
        private TextBox textBoxBPrice;
        private TextBox textBoxBPublication;
        private TextBox textBoxBAuthor;
        private TextBox textBoxBName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxPDate;
    }
}