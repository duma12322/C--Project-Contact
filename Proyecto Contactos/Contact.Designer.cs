namespace Proyecto_Contactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            txtNumber = new TextBox();
            lblNumber = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblGender = new Label();
            dgvContactList = new DataGridView();
            cmbGender = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(750, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.ForeColor = Color.Black;
            lblContact.Location = new Point(39, 134);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(63, 15);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact ID";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(130, 126);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(235, 23);
            txtContact.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(38, 174);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(130, 166);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(235, 23);
            txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(39, 218);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 210);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(130, 253);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(235, 23);
            txtNumber.TabIndex = 8;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.ForeColor = Color.Black;
            lblNumber.Location = new Point(39, 261);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(75, 15);
            lblNumber.TabIndex = 9;
            lblNumber.Text = "Contact Nro.";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(39, 298);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            lblAddress.Click += label1_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(130, 295);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(235, 79);
            txtAddress.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(39, 402);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(393, 126);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.RowTemplate.Height = 25;
            dgvContactList.Size = new Size(355, 291);
            dgvContactList.TabIndex = 13;
            dgvContactList.CellContentClick += dataGridView1_CellContentClick;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Famele", "Male" });
            cmbGender.Location = new Point(130, 394);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(235, 23);
            cmbGender.TabIndex = 14;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(393, 108);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(441, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(307, 23);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Chartreuse;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(219, 439);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 48);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(340, 439);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 48);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(460, 439);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 48);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(580, 439);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 48);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(cmbGender);
            Controls.Add(dgvContactList);
            Controls.Add(lblGender);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblNumber);
            Controls.Add(txtNumber);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private TextBox txtNumber;
        private Label lblNumber;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblGender;
        private DataGridView dgvContactList;
        private ComboBox cmbGender;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}