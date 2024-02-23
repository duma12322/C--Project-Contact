using System.Data.SqlClient;
using System.Data;
using Proyecto_Contactos.contactClasses;
using System.Configuration;

namespace Proyecto_Contactos

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();


        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Data on Data dgvContactList

            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ContactNo = txtNumber.Text;
            c.Address = txtAddress.Text;
            c.Gender = cmbGender.Text;


            //Inserting Data into Database using the method we created in previous episode
            bool success = c.Insert(c);

            if (success == true)
            {
                //successfully Inserted
                MessageBox.Show("New Contact Successfully Inserted");
                //Call the clear method here
                Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add New Contact. Try Again.");
            }
            //Load Data on Data dgvContactList

            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to clear fields

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNumber.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            txtContact.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textBoxes
            c.ContactID = int.Parse(txtContact.Text);
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ContactNo = txtNumber.Text;
            c.Address = txtAddress.Text;
            c.Gender = cmbGender.Text;

            //UPDATE DATA IN DATABASE

            bool success = c.Update(c);
            if (success == true)
            {
                //Updated successfully
                MessageBox.Show("Contact has been successfully Updated.");
                //Load Data on Data dgvContactList
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call Clear Method
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Contact. Try Again.");
            }

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from data grid view and load it to the textboxes respectively
            //identify the row on which mouse is clicked

            int rowIndex = e.RowIndex;
            txtContact.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call clear method here
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //GetHashCode data from the textboxes
            c.ContactID = Convert.ToInt32(txtContact.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Contact successfully deleted");
                //Load Data on Data dgvContactList
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call the clear method here
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete contact. Try Again.");
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get value from next text box
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%'", conn);
        DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource= dt;
        }
    }
}