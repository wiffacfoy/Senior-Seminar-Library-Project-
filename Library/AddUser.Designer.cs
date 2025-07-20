namespace Library
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtUserEmail = new TextBox();
            txtUserContact = new TextBox();
            txtUserPrivilege = new TextBox();
            txtUserName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserNumber = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 156);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(627, 62);
            label1.Name = "label1";
            label1.Size = new Size(182, 50);
            label1.TabIndex = 2;
            label1.Text = "Add User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(442, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(513, 569);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtUserNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtUserEmail);
            panel2.Controls.Add(txtUserContact);
            panel2.Controls.Add(txtUserPrivilege);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(516, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 560);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(496, 505);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button3_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonHighlight;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(313, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(132, 505);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(373, 292);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(319, 39);
            txtUserEmail.TabIndex = 11;
            // 
            // txtUserContact
            // 
            txtUserContact.Location = new Point(373, 205);
            txtUserContact.Name = "txtUserContact";
            txtUserContact.Size = new Size(319, 39);
            txtUserContact.TabIndex = 10;
            // 
            // txtUserPrivilege
            // 
            txtUserPrivilege.Location = new Point(373, 376);
            txtUserPrivilege.Name = "txtUserPrivilege";
            txtUserPrivilege.Size = new Size(319, 39);
            txtUserPrivilege.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(373, 52);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(319, 39);
            txtUserName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(59, 286);
            label7.Name = "label7";
            label7.Size = new Size(173, 45);
            label7.TabIndex = 5;
            label7.Text = "User Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 199);
            label6.Name = "label6";
            label6.Size = new Size(242, 45);
            label6.TabIndex = 4;
            label6.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 370);
            label4.Name = "label4";
            label4.Size = new Size(227, 45);
            label4.TabIndex = 2;
            label4.Text = "Privilege Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 45);
            label2.Name = "label2";
            label2.Size = new Size(182, 45);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 124);
            label3.Name = "label3";
            label3.Size = new Size(127, 45);
            label3.TabIndex = 15;
            label3.Text = "User ID";
            // 
            // txtUserNumber
            // 
            txtUserNumber.Location = new Point(373, 130);
            txtUserNumber.Name = "txtUserNumber";
            txtUserNumber.Size = new Size(319, 39);
            txtUserNumber.TabIndex = 16;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 721);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txtUserEmail;
        private TextBox txtUserContact;
        private TextBox txtUserPrivilege;
        private TextBox txtUserName;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
        private TextBox txtUserNumber;
        private Label label3;
    }
}