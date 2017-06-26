using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace NightDuty
{
    public partial class Entry : Form
    {
        private int tempid;
        private SqlDataReader dr;
        private string cat;

        public Entry()
        {
            InitializeComponent();
            PfNoTextBox.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (EmployeeName.Text == "" || PfNoTextBox.Text == "")
            {
                MessageBox.Show("Insufficient values to Delete!");
            }
            else
            {
                string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                SqlConnection cn = new SqlConnection(_connectionstring);
                cn.Open();
                string sqldel = "delete from EmpDetails where [PfNo]= (" + PfNoTextBox.Text + ")";
                SqlCommand cmd = new SqlCommand(sqldel, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Data Deleted!");
                cn.Open();
                string _sql1 = "(SELECT Name FROM [EmpDetails] )";
                SqlCommand _command1 = new SqlCommand(_sql1, cn);
                dr = _command1.ExecuteReader();
                listBox1.Items.Clear();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Name"]);
                }
                cn.Close();
                EmployeeName.Text = DesgTextBox.Text = RateOfPay.Text = GradePayTextBox.Text = PfNoTextBox.Text = EmployeeNoTextBox.Text = HQTextBox.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PfNoTextBox.Text == "" && EmployeeName.Text == "")
                MessageBox.Show("Enter Values");
            else
            {
                string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                SqlConnection cn = new SqlConnection(_connectionstring);
                cn.Open();
                string _sql = "(SELECT PfNo FROM [EmpDetails] where PfNo=" + PfNoTextBox.Text + " )";
                SqlCommand _command = new SqlCommand(_sql, cn);
                dr = _command.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("PfNo already exist!");
                    EmployeeName.Text = DesgTextBox.Text = RateOfPay.Text = GradePayTextBox.Text = PfNoTextBox.Text = EmployeeNoTextBox.Text = HQTextBox.Text = "";
                }
                else
                {
                    cn.Close();
                    string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                    SqlConnection cn1 = new SqlConnection(_connectionstring);
                    cn.Open();
                    string sqlins = "insert into EmpDetails VALUES (" + PfNoTextBox.Text + ",'" + EmployeeName.Text + "','" + DesgTextBox.Text + "','" + RateOfPay.Text + "','" + GradePayTextBox.Text + "','" + EmployeeNoTextBox.Text + "','" + HQTextBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(sqlins, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Saved!");
                    cn.Open();
                    string _sql1 = "(SELECT Name FROM [EmpDetails] )";
                    SqlCommand _command1 = new SqlCommand(_sql, cn);
                    dr = _command.ExecuteReader();
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr["Name"]);
                    }
                    cn.Close();
                    EmployeeName.Text = DesgTextBox.Text = RateOfPay.Text = GradePayTextBox.Text = PfNoTextBox.Text = EmployeeNoTextBox.Text = HQTextBox.Text = SnoTextBox.Text = "";
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DesgTextBox.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PfNoTextBox.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RateOfPay.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GradePayTextBox.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmployeeNoTextBox.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HQTextBox.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.Focus();
            }
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'night_DutyDataSet.Train_Time_Details' table. You can move, or remove it, as needed.
            this.train_Time_DetailsTableAdapter.Fill(this.night_DutyDataSet.Train_Time_Details);
            // TODO: This line of code loads data into the 'trainTimeInfo.Train_Time_Details' table. You can move, or remove it, as needed.

            string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn = new SqlConnection(_connectionstring);
            cn.Open();
            string _sql = "(SELECT Name FROM [EmpDetails] )";
            SqlCommand _command = new SqlCommand(_sql, cn);
            dr = _command.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Name"]);
            }
            cn.Close();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn = new SqlConnection(_connectionstring);
            cn.Open();
            string _sql = "(SELECT * FROM [EmpDetails] where Name ='" + listBox1.Text + "')";
            SqlCommand _command = new SqlCommand(_sql, cn);
            dr = _command.ExecuteReader();
            if (dr.Read())
            {
                SnoTextBox.Text = dr["Sno"].ToString();
                EmployeeName.Text = dr["Name"].ToString();
                PfNoTextBox.Text = dr["PfNo"].ToString();
                DesgTextBox.Text = dr["Desg"].ToString();
                RateOfPay.Text = dr["RateofPay"].ToString();
                GradePayTextBox.Text = dr["GradePay"].ToString();
                EmployeeNoTextBox.Text = dr["EmployeeNo"].ToString();
                HQTextBox.Text = dr["Hq"].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TrainNoTextBox.Text = TrainNoTextBox.Text.Replace("\n", "");
            SourceStnTextBox.Text = SourceStnTextBox.Text.Replace("\n", "");
            SignOnTextBox.Text = SignOnTextBox.Text.Replace("\n", "");
            string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn = new SqlConnection(_connectionstring);
            cn.Open();
            string sqlins = "insert into Train_Time_Details VALUES (" + TrainNoTextBox.Text + ",'" + SourceStnTextBox.Text + "','" + SignOnTextBox.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlins, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Data Saved!");
            TrainNoTextBox.Text = "";
            SourceStnTextBox.Text = "";
            SignOnTextBox.Text = "";

            this.train_Time_DetailsTableAdapter.Fill(this.night_DutyDataSet.Train_Time_Details);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string _connectionstring2 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn4 = new SqlConnection(_connectionstring2);
            cn4.Open();
            string _sql3 = "Delete FROM [Train_Time_Details] WHERE SNo=" + tempid + "";
            SqlCommand _command3 = new SqlCommand(_sql3, cn4);
            _command3.ExecuteNonQuery();
            cn4.Close();
            MessageBox.Show("Data Deleted!");
            this.train_Time_DetailsTableAdapter.Fill(this.night_DutyDataSet.Train_Time_Details);
        }

        private void richTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //double tym= double.Parse(richTextBox4.Text);

                int i = int.Parse(SignOnTextBox.Text);
                string kl = SignOnTextBox.Text;
                int c = i.ToString().Length;
                {
                    if (c == 1)
                    {
                        kl = kl.PadRight(3, '0');
                        kl = kl.PadLeft(4, '0');
                    }
                    if (c == 2)
                    {
                        kl = kl.PadRight(4, '0');
                    }
                    if (c == 3)
                    {
                        kl = kl.PadLeft(4, '0');
                    }
                    cat = kl + "H";
                }

                var timeSpan = TimeSpan.ParseExact(cat, @"hhmm\H", CultureInfo.InvariantCulture);
                string s = timeSpan.ToString(@"hh\:mm");

                SignOnTextBox.Text = s.ToString();
                button5.Focus();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SourceStnTextBox.Focus();
            }
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignOnTextBox.Focus();
            }
        }

        private void TrainNoTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tempid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["snoDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            EmployeeName.Text = EmployeeName.Text.Replace("\n", "");
            PfNoTextBox.Text = PfNoTextBox.Text.Replace("\n", "");
            DesgTextBox.Text = DesgTextBox.Text.Replace("\n", "");
            RateOfPay.Text = RateOfPay.Text.Replace("\n", "");
            GradePayTextBox.Text = GradePayTextBox.Text.Replace("\n", "");
            EmployeeNoTextBox.Text = EmployeeNoTextBox.Text.Replace("\n", "");
            HQTextBox.Text = HQTextBox.Text.Replace("\n", "");
            string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(_connectionstring1);
            cn1.Open();
            string sqlins = "update EmpDetails set Name= '" + EmployeeName.Text + "',PfNo='" + PfNoTextBox.Text + "',Desg='" + DesgTextBox.Text + "',RateofPay='" + RateOfPay.Text + "',GradePay='" + GradePayTextBox.Text + "',EmployeeNo='" + EmployeeNoTextBox.Text + "',Hq='" + HQTextBox.Text + "' where Sno=" + SnoTextBox.Text + "";
            SqlCommand cmd = new SqlCommand(sqlins, cn1);
            cmd.ExecuteNonQuery();
            cn1.Close();
            MessageBox.Show("Data Updated!");
            cn1.Open();
            string _sql1 = "(SELECT Name FROM [EmpDetails] )";
            SqlCommand _command1 = new SqlCommand(_sql1, cn1);
            listBox1.Items.Clear();
            dr = _command1.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Name"]);
            }
            cn1.Close();
            EmployeeName.Text = DesgTextBox.Text = RateOfPay.Text = GradePayTextBox.Text = PfNoTextBox.Text = EmployeeNoTextBox.Text = HQTextBox.Text = "";
        }
    }
}