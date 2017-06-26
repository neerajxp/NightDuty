using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
namespace NightDuty
{
    public partial class Report : Form
    {
       
        //string PfNo;
        public Report( string PfNo)        {
            InitializeComponent();
            label1.Text = PfNo;
         
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.ReportDataSet.DataTable1, int.Parse(label1.Text));
            // TODO: This line of code loads data into the 'EmployeeDataReportDataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.FillByEmployeeData(this.EmployeeDataReportDataSet.DataTable1, int.Parse(label1.Text));
            // TODO: This line of code loads data into the 'EmployeeDataReport.DataTable1' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {

        }
        Bitmap bmp;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
           
        }

        private void Print_Click_1(object sender, EventArgs e)
        {
            
            Graphics g = reportViewer1.CreateGraphics();    //this.CreateGraphics();
            bmp = new Bitmap(reportViewer1.Size.Width, reportViewer1.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(reportViewer1.Location.X, reportViewer1.Location.Y, 0, 0, reportViewer1.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}