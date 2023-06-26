using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text!="" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            { 
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= NUR-FARAH\\SQLEXPRESS; database = LibraryManagementSystem;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values('"+bname+ "', '"+bauthor+ "', '"+publication+ "', '"+pdate+"',"+price+", "+quan+")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data saved", "Guul", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty field not allowed","Digniin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text == "" && txtAuthor.Text == "" && txtPublication.Text == "" && txtPrice.Text == "" && txtQuantity.Text == "")
            {
                this.Close();
            }
            else if (MessageBox.Show("Your unsaved data will be removed.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }


        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
