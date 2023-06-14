using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchEnrollment.Text !="")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:/Users/nuurf/Downloads/Liberay Management System Icon and Images/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
            }
            else
            {
                label1.Visible=true;
                Image image = Image.FromFile("C:/Users/nuurf/Downloads/Liberay Management System Icon and Images/Liberay Management System/search.gif");
                pictureBox1.Image = image;
            }
        }
    }
}
