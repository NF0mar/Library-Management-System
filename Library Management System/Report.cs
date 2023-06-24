using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
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

namespace Library_Management_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            
        }

        SqlConnection con = new SqlConnection("Data Source = NUR-FARAH\\SQLEXPRESS; database = LibraryManagementSystem;integrated security =True");
        //SqlConnection con = new SqlConnection("Data Source=NUR-FARAH\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from NewBook", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rdr = new ReportDataSource("DataSet1", dtb);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\nuurf\\Downloads\\Library Management System\\LibraryManagementSystem\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rdr);
            reportViewer1.RefreshReport();

        }
    }
}
