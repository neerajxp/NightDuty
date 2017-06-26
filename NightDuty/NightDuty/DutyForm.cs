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
    public partial class DutyForm : Form
    {
        private SqlDataReader dr;
        private int minlim = 1;
        private int maxlim = 9;
        private int tempid;
        private int id;
        private TimeSpan rt;
        private TimeSpan kt;
        private DateTime txtbox5;
        private TimeSpan kdate;
        private string Date1;
        private string Date2;
        private DateTime dt_new;
        private string mindt, StartDate, TrainNo, Fromstn, SignedOn;
        private string l;
        private string cat;
        private string start_date;
        private DateTime starttime;
        private string grid_rowindex;
        private string Row;
        private int ID;
        private int Selrow;

        public DutyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'night_DutyDataSet2.Data' table. You can move, or remove it, as needed.
            //this.dataTableAdapter.Fill(this.night_DutyDataSet2.Data);
            string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(_connectionstring1);
            cn1.Open();
            string _sql1 = "(SELECT Name FROM [EmpDetails] )";
            SqlCommand _command1 = new SqlCommand(_sql1, cn1);
            dr = _command1.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Name"]);
            }
            cn1.Close();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PfNoTextBox.Text == "")
            {
                MessageBox.Show("Enter Pf number");
            }
            else
            {
                string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                SqlConnection cn1 = new SqlConnection(_connectionstring1);
                cn1.Open();
                string _sql1 = "(SELECT TotalTime FROM [Data] )";
                SqlCommand _command1 = new SqlCommand(_sql1, cn1);
                TimeSpan spare = new TimeSpan(00, 00, 00);
                string Total = "";
                dr = _command1.ExecuteReader();
                while (dr.Read())
                {
                    string sum = dr["TotalTime"].ToString();
                    TimeSpan Adding_sum = TimeSpan.Parse(sum);
                    spare = spare.Add(Adding_sum);
                    Total = spare.ToString();
                }

                PfNoTextBox.Text = PfNoTextBox.Text.Replace("\n", "");
                Report rs = new Report(PfNoTextBox.Text);
                rs.Show();
                //}
            }
        }

        private void richTextBox5_Leave(object sender, EventArgs e)
        {
            string kl = DateTextBox.Text;
            int c = DateTextBox.Text.Length;
            if (c == 1)
            {
                kl = kl.PadLeft(2, '0');
                DateTextBox.Text = kl;
                DateTextBox.Text = DateTextBox.Text + "/" + dateTimePicker1.Value.Month.ToString();
                DateTextBox.Text = DateTextBox.Text + "/" + dateTimePicker1.Value.Year.ToString();
            }
        }

        private void richTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TrainNoTextBox.Focus();
            }
        }

        private void richTextBox6_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SrcStnTextBox.Focus();
            }
        }

        private void richTextBox7_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DestStnTextBox.Focus();
            }
        }

        private void richTextBox8_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SignOnTextBox.Text != "")
            {
                SignOffTextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter && SignOnTextBox.Text == "")
            {
                SignOnTextBox.Focus();
            }
        }

        private void richTextBox4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string val_rec = SignOnTextBox.Text;

                {
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

                    SignOffTextBox.Focus();
                }
            }
        }

        private void richTextBox9_KeyDown_1(object sender, KeyEventArgs e)
        {
            CalcTimeTextBox.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                SignOffTextBox.Text = SignOffTextBox.Text.Replace("\n", "");
                int i = int.Parse(SignOffTextBox.Text);
                string kl = SignOffTextBox.Text;
                int c = i.ToString().Length;
                PfNoTextBox.Text = PfNoTextBox.Text.Replace("\n", "");
                DateTextBox.Text = DateTextBox.Text.Replace("\n", "");
                TrainNoTextBox.Text = TrainNoTextBox.Text.Replace("\n", "");
                SrcStnTextBox.Text = SrcStnTextBox.Text.Replace("\n", "");
                DestStnTextBox.Text = DestStnTextBox.Text.Replace("\n", "");
                SignOnTextBox.Text = SignOnTextBox.Text.Replace("\n", "");
                SignOffTextBox.Text = SignOffTextBox.Text.Replace("\n", "");
                CalcTimeTextBox.Text = CalcTimeTextBox.Text.Replace("\n", "");
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
                SignOffTextBox.Text = s.ToString();
                TrainNoTextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if ((DateTextBox.Text == "" || DateTextBox.Text == "\n") && (TrainNoTextBox.Text == "" || TrainNoTextBox.Text == "\n") && (SrcStnTextBox.Text == "" || SrcStnTextBox.Text == "\n") && (DestStnTextBox.Text == "" || DestStnTextBox.Text == "\n") && (SignOnTextBox.Text == "" || SignOnTextBox.Text == "\n") && (PfNoTextBox.Text == "" || PfNoTextBox.Text == "\n"))
                {
                    MessageBox.Show("Please Fill Complete values!");
                }
                else
                {
                    txtbox5 = DateTime.Parse(DateTextBox.Text);
                    Date1 = txtbox5.ToShortDateString();

                    TimeSpan StartCmp = new TimeSpan(00, 00, 00);
                    TimeSpan EndCmp = new TimeSpan(12, 00, 00);
                    TimeSpan Endday = new TimeSpan(06, 00, 00);

                    if (TimeSpan.Parse(SignOnTextBox.Text) >= StartCmp && TimeSpan.Parse(SignOnTextBox.Text) <= EndCmp && TimeSpan.Parse(SignOffTextBox.Text) >= StartCmp && TimeSpan.Parse(SignOffTextBox.Text) <= EndCmp)
                    {
                        PfNoTextBox.Text = PfNoTextBox.Text.Replace("\n", "");
                        DateTextBox.Text = DateTextBox.Text.Replace("\n", "");
                        TrainNoTextBox.Text = TrainNoTextBox.Text.Replace("\n", "");
                        SrcStnTextBox.Text = SrcStnTextBox.Text.Replace("\n", "");
                        DestStnTextBox.Text = DestStnTextBox.Text.Replace("\n", "");
                        SignOnTextBox.Text = SignOnTextBox.Text.Replace("\n", "");
                        SignOffTextBox.Text = SignOffTextBox.Text.Replace("\n", "");

                        if (TimeSpan.Parse(SignOffTextBox.Text) > Endday)
                        {
                            Date2 = DateTextBox.Text;
                            TimeSpan span = TimeSpan.Parse(SignOnTextBox.Text).Subtract(Endday);
                            CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                        }
                        else
                        {
                            Date2 = DateTextBox.Text;
                            TimeSpan span = TimeSpan.Parse(SignOnTextBox.Text).Subtract(TimeSpan.Parse(SignOffTextBox.Text));
                            CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                        }
                    }
                    else
                        if (StartCmp >= TimeSpan.Parse(SignOffTextBox.Text) || TimeSpan.Parse(SignOffTextBox.Text) <= EndCmp)
                    {
                        Date2 = txtbox5.AddDays(1).ToShortDateString();
                        TimeSpan StartCmp4 = new TimeSpan(13, 00, 00);
                        TimeSpan EndCmp4 = new TimeSpan(22, 00, 00);
                        if (StartCmp4 >= TimeSpan.Parse(SignOnTextBox.Text) || TimeSpan.Parse(SignOnTextBox.Text) <= EndCmp4)
                        {
                            var mintym = "22:00:00";
                            mindt = Date1 + " " + mintym;
                            starttime = DateTime.Parse(mindt);//startdate
                            TimeSpan span; // EndDate
                                           //DateTime starttime = DateTime.Parse(start_date);//startdate

                            if (TimeSpan.Parse(SignOffTextBox.Text) > Endday)
                            {
                                string end_date = Date2 + " " + Endday;
                                DateTime endtime = DateTime.Parse(end_date);
                                //DateTime endtime = DateTime.Parse(end_date);
                                span = endtime.Subtract(starttime);
                            }
                            else
                            {
                                string end_date = Date2 + " " + SignOffTextBox.Text;
                                DateTime endtime = DateTime.Parse(end_date);
                                span = endtime.Subtract(starttime);
                            }
                            CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                        }
                        else
                        {
                            SignOnTextBox.Text = SignOnTextBox.Text.Replace("\n", "");

                            start_date = Date1 + " " + SignOnTextBox.Text;
                            starttime = DateTime.Parse(start_date);
                            if (TimeSpan.Parse(SignOffTextBox.Text) > Endday)
                            {
                                string end_date = Date2 + " " + (Endday.ToString());// EndDate

                                DateTime endtime = DateTime.Parse(end_date);
                                TimeSpan span = endtime.Subtract(starttime);
                                CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                            }
                            else
                            {
                                string end_date = Date2 + " " + SignOffTextBox.Text;// EndDate
                                                                                    //DateTime starttime = DateTime.Parse(start_date);//startdate
                                DateTime endtime = DateTime.Parse(end_date);
                                TimeSpan span = endtime.Subtract(starttime);
                                CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                            }
                        }
                    }
                    else
                    {
                        Date2 = txtbox5.ToShortDateString();
                        TimeSpan StartCmp4 = new TimeSpan(13, 00, 00);
                        TimeSpan EndCmp4 = new TimeSpan(22, 00, 00);
                        if (StartCmp4 >= TimeSpan.Parse(SignOnTextBox.Text) || TimeSpan.Parse(SignOnTextBox.Text) <= EndCmp4)
                        {
                            var mintym = "22:00:00";
                            mindt = Date1 + " " + mintym;
                            starttime = DateTime.Parse(mindt);//startdate
                            string end_date = Date2 + " " + SignOffTextBox.Text;// EndDate
                                                                                //DateTime starttime = DateTime.Parse(start_date);//startdate

                            DateTime endtime = DateTime.Parse(end_date);
                            //TimeSpan endtym = TimeSpan.Parse(endtime.ToString());
                            if (TimeSpan.Parse(SignOffTextBox.Text) <= EndCmp4)
                            {
                            }
                            else
                            {
                                TimeSpan span = endtime.Subtract(starttime);
                                CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                            }
                        }
                        else
                        {
                            start_date = Date1 + " " + SignOnTextBox.Text;// StartDate
                            starttime = DateTime.Parse(start_date);//startdate
                            string end_date = Date2 + " " + SignOffTextBox.Text;// EndDate
                            DateTime endtime = DateTime.Parse(end_date);
                            TimeSpan span = endtime.Subtract(starttime);
                            CalcTimeTextBox.Text = span.ToString("hh\\:mm");
                        }
                    }

                    try
                    {
                        PfNoTextBox.Text = PfNoTextBox.Text.Replace("\n", "");
                        DateTextBox.Text = DateTextBox.Text.Replace("\n", "");
                        TrainNoTextBox.Text = TrainNoTextBox.Text.Replace("\n", "");
                        SrcStnTextBox.Text = SrcStnTextBox.Text.Replace("\n", "");
                        DestStnTextBox.Text = DestStnTextBox.Text.Replace("\n", "");
                        SignOnTextBox.Text = SignOnTextBox.Text.Replace("\n", "");
                        SignOffTextBox.Text = SignOffTextBox.Text.Replace("\n", "");

                        string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                        SqlConnection cn = new SqlConnection(_connectionstring);
                        cn.Open();
                        string sqlins = "insert into Data values (" + PfNoTextBox.Text + ",'" + DateTextBox.Text + "','" + Date2 + "','" + TrainNoTextBox.Text + "','" + SrcStnTextBox.Text + "','" + DestStnTextBox.Text + "','" + SignOnTextBox.Text + "','" + SignOffTextBox.Text + "','" + CalcTimeTextBox.Text + "')";
                        SqlCommand cmd = new SqlCommand(sqlins, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        cn.Open();
                        string _sql = "(SELECT * FROM [Data] WHERE PfNo=" + PfNoTextBox.Text + ")";
                        SqlCommand _command = new SqlCommand(_sql, cn);
                        SqlDataAdapter _adapter = new SqlDataAdapter(_command);
                        DataTable _table = new DataTable();
                        _adapter.Fill(_table);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = _table;

                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    DateTextBox.Focus();

                    TrainNoTextBox.Text = "";
                    SrcStnTextBox.Text = "";
                    DestStnTextBox.Text = "";
                    SignOnTextBox.Text = "";
                    SignOffTextBox.Text = "";
                    SignOffTextBox.Text = "";
                    DateTextBox.Text = "";
                    CalcTimeTextBox.Text = "";
                }
            }
        }

        private void richTextBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateTextBox.Focus();
            }
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
                richTextBox1.Text = dr["Name"].ToString();
                PfNoTextBox.Text = dr["PfNo"].ToString();
                richTextBox12.Text = dr["Desg"].ToString();
                richTextBox2.Text = dr["RateofPay"].ToString();
                richTextBox3.Text = dr["GradePay"].ToString();
            }
            cn.Close();
            string _connectionstring2 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn2 = new SqlConnection(_connectionstring2);
            cn2.Open();
            string _sql2 = "(SELECT * FROM [Data] where PfNo='" + PfNoTextBox.Text + "')";
            SqlCommand _command2 = new SqlCommand(_sql2, cn2);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command2);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _table;
            cn2.Close();
            DateTextBox.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTextBox.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void richTextBox7_Leave(object sender, EventArgs e)
        {
            TrainNoTextBox.Text = TrainNoTextBox.Text.Replace("\n", "");
            SrcStnTextBox.Text = SrcStnTextBox.Text.Replace("\n", "");
            string _connectionstring = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn = new SqlConnection(_connectionstring);
            cn.Open();
            string _sql = "(SELECT * FROM [Train_Time_Details] where [Train_No] = ('" + TrainNoTextBox.Text + "') and [Src_Stn]=('" + SrcStnTextBox.Text + "'))";
            SqlCommand _command = new SqlCommand(_sql, cn);
            dr = _command.ExecuteReader();
            if (dr.Read())
            {
                SignOnTextBox.Text = dr["SignedOn"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn3 = new SqlConnection(_connectionstring1);
            cn3.Open();
            string _sql3 = "UPDATE Data SET StartDate='" + DateTextBox.Text + "',TrainNo='" + TrainNoTextBox.Text + "',Frmstn = '" + SrcStnTextBox.Text + "', ToStn='" + DestStnTextBox.Text + "',SignedOn='" + SignOnTextBox.Text + "' where Sno=" + tempid + "";
            SqlCommand _command3 = new SqlCommand(_sql3, cn3);
            _command3.ExecuteNonQuery();
            cn3.Close();
            string _connectionstring2 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn2 = new SqlConnection(_connectionstring2);
            cn2.Open();
            string _sql2 = "(SELECT * FROM [Data] where PfNo='" + PfNoTextBox.Text + "')";
            SqlCommand _command2 = new SqlCommand(_sql2, cn2);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command2);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _table;
            cn2.Close();
            MessageBox.Show("Values Updated!");
            DateTextBox.Text = "";
            TrainNoTextBox.Text = "";
            SrcStnTextBox.Text = "";
            DestStnTextBox.Text = "";
            SignOnTextBox.Text = "";
            SignOffTextBox.Text = "";
            CalcTimeTextBox.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tempid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["snoDataGridViewTextBoxColumn"].Value.ToString());
            string _connectionstring2 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn4 = new SqlConnection(_connectionstring2);
            cn4.Open();
            string _sql3 = "(SELECT * FROM [Data] WHERE Sno=(" + tempid + "))";
            SqlCommand _command3 = new SqlCommand(_sql3, cn4);
            dr = _command3.ExecuteReader();
            while (dr.Read())
            {
                DateTextBox.Text = dr["StartDate"].ToString();
                TrainNoTextBox.Text = dr["TrainNo"].ToString();
                SrcStnTextBox.Text = dr["FrmStn"].ToString();
                DestStnTextBox.Text = dr["ToStn"].ToString();
                SignOnTextBox.Text = dr["SignedOn"].ToString();
            }
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Sure you want to Delete Table?", "", MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.OK)
            {
                string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                SqlConnection cn3 = new SqlConnection(_connectionstring1);
                cn3.Open();
                string _sql3 = "Delete from Data where PfNo=" + PfNoTextBox.Text + "";
                SqlCommand _command3 = new SqlCommand(_sql3, cn3);
                _command3.ExecuteNonQuery();
                cn3.Close();
                MessageBox.Show("Data Deleted");
                string _connectionstring2 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
                SqlConnection cn2 = new SqlConnection(_connectionstring2);
                cn2.Open();
                string _sql2 = "(SELECT * FROM [Data] where PfNo='" + PfNoTextBox.Text + "')";
                SqlCommand _command2 = new SqlCommand(_sql2, cn2);
                SqlDataAdapter _adapter = new SqlDataAdapter(_command2);
                DataTable _table = new DataTable();
                _adapter.Fill(_table);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = _table;
                cn2.Close();
                DateTextBox.Text = "";
                TrainNoTextBox.Text = "";
                SrcStnTextBox.Text = "";
                DestStnTextBox.Text = "";
                SignOnTextBox.Text = "";
                SignOffTextBox.Text = "";
                CalcTimeTextBox.Text = "";
            }
            else
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _connectionstring1 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn3 = new SqlConnection(_connectionstring1);
            cn3.Open();
            string _sql3 = "Delete from Data where Sno=" + tempid + "";
            SqlCommand _command3 = new SqlCommand(_sql3, cn3);
            _command3.ExecuteNonQuery();
            cn3.Close();
            string _connectionstring2 = module.constr;// @"Data Source=(local);Initial Catalog=Night Duty;Integrated Security=True";
            SqlConnection cn2 = new SqlConnection(_connectionstring2);
            cn2.Open();
            string _sql2 = "(SELECT * FROM [Data] where PfNo='" + PfNoTextBox.Text + "')";
            SqlCommand _command2 = new SqlCommand(_sql2, cn2);
            SqlDataAdapter _adapter = new SqlDataAdapter(_command2);
            DataTable _table = new DataTable();
            _adapter.Fill(_table);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _table;
            cn2.Close();
            MessageBox.Show("Data Deleted");
            DateTextBox.Text = "";
            TrainNoTextBox.Text = "";
            SrcStnTextBox.Text = "";
            DestStnTextBox.Text = "";
            SignOnTextBox.Text = "";
            SignOffTextBox.Text = "";
            CalcTimeTextBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}