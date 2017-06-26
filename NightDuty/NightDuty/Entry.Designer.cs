namespace NightDuty
{
    partial class Entry
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.DesgTextBox = new System.Windows.Forms.TextBox();
            this.RateOfPay = new System.Windows.Forms.TextBox();
            this.GradePayTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PfNoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainTimeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.night_DutyDataSet = new NightDuty.Night_DutyDataSet();
            this.SignOnTextBox = new System.Windows.Forms.RichTextBox();
            this.SourceStnTextBox = new System.Windows.Forms.RichTextBox();
            this.TrainNoTextBox = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trainTimeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.EmployeeNoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HQTextBox = new System.Windows.Forms.TextBox();
            this.trainInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.train_Time_DetailsTableAdapter = new NightDuty.Night_DutyDataSetTableAdapters.Train_Time_DetailsTableAdapter();
            this.EDIT = new System.Windows.Forms.Button();
            this.SnoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.night_DutyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RateofPay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESG.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GradePay ";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(176, 9);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(116, 20);
            this.EmployeeName.TabIndex = 4;
            this.EmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // DesgTextBox
            // 
            this.DesgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesgTextBox.Location = new System.Drawing.Point(176, 56);
            this.DesgTextBox.Name = "DesgTextBox";
            this.DesgTextBox.Size = new System.Drawing.Size(116, 20);
            this.DesgTextBox.TabIndex = 5;
            this.DesgTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // RateOfPay
            // 
            this.RateOfPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateOfPay.Location = new System.Drawing.Point(176, 81);
            this.RateOfPay.Name = "RateOfPay";
            this.RateOfPay.Size = new System.Drawing.Size(116, 20);
            this.RateOfPay.TabIndex = 6;
            this.RateOfPay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // GradePayTextBox
            // 
            this.GradePayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradePayTextBox.Location = new System.Drawing.Point(176, 108);
            this.GradePayTextBox.Name = "GradePayTextBox";
            this.GradePayTextBox.Size = new System.Drawing.Size(116, 20);
            this.GradePayTextBox.TabIndex = 7;
            this.GradePayTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(225, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(336, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(390, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 173);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PF.NO.";
            // 
            // PfNoTextBox
            // 
            this.PfNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PfNoTextBox.Location = new System.Drawing.Point(176, 34);
            this.PfNoTextBox.Name = "PfNoTextBox";
            this.PfNoTextBox.Size = new System.Drawing.Size(116, 20);
            this.PfNoTextBox.TabIndex = 14;
            this.PfNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.SignOnTextBox);
            this.groupBox1.Controls.Add(this.SourceStnTextBox);
            this.groupBox1.Controls.Add(this.TrainNoTextBox);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(14, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 298);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTRY FOR STATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.trainTimeDetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(50, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 164);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "SNo";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "SNo";
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            this.sNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Train_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Train_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Src_Stn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Src_Stn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SignedOn";
            this.dataGridViewTextBoxColumn3.HeaderText = "SignedOn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // trainTimeDetailsBindingSource1
            // 
            this.trainTimeDetailsBindingSource1.DataMember = "Train_Time_Details";
            this.trainTimeDetailsBindingSource1.DataSource = this.night_DutyDataSet;
            // 
            // night_DutyDataSet
            // 
            this.night_DutyDataSet.DataSetName = "Night_DutyDataSet";
            this.night_DutyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SignOnTextBox
            // 
            this.SignOnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOnTextBox.Location = new System.Drawing.Point(400, 37);
            this.SignOnTextBox.Multiline = false;
            this.SignOnTextBox.Name = "SignOnTextBox";
            this.SignOnTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SignOnTextBox.Size = new System.Drawing.Size(98, 33);
            this.SignOnTextBox.TabIndex = 10;
            this.SignOnTextBox.Text = "";
            this.SignOnTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox3_KeyDown);
            // 
            // SourceStnTextBox
            // 
            this.SourceStnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceStnTextBox.Location = new System.Drawing.Point(196, 37);
            this.SourceStnTextBox.Multiline = false;
            this.SourceStnTextBox.Name = "SourceStnTextBox";
            this.SourceStnTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SourceStnTextBox.Size = new System.Drawing.Size(116, 33);
            this.SourceStnTextBox.TabIndex = 9;
            this.SourceStnTextBox.Text = "";
            this.SourceStnTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox2_KeyDown);
            // 
            // TrainNoTextBox
            // 
            this.TrainNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainNoTextBox.Location = new System.Drawing.Point(12, 37);
            this.TrainNoTextBox.Multiline = false;
            this.TrainNoTextBox.Name = "TrainNoTextBox";
            this.TrainNoTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TrainNoTextBox.Size = new System.Drawing.Size(116, 33);
            this.TrainNoTextBox.TabIndex = 8;
            this.TrainNoTextBox.Text = "";
            this.TrainNoTextBox.TextChanged += new System.EventHandler(this.TrainNoTextBox_TextChanged);
            this.TrainNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(261, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(145, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "SUBMIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "TRAIN_NO.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "SIGNED ON TIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SOURCE STATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "EMP. NO.";
            // 
            // EmployeeNoTextBox
            // 
            this.EmployeeNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNoTextBox.Location = new System.Drawing.Point(176, 134);
            this.EmployeeNoTextBox.Name = "EmployeeNoTextBox";
            this.EmployeeNoTextBox.Size = new System.Drawing.Size(116, 20);
            this.EmployeeNoTextBox.TabIndex = 17;
            this.EmployeeNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "HQ.";
            // 
            // HQTextBox
            // 
            this.HQTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HQTextBox.Location = new System.Drawing.Point(176, 163);
            this.HQTextBox.Name = "HQTextBox";
            this.HQTextBox.Size = new System.Drawing.Size(116, 20);
            this.HQTextBox.TabIndex = 19;
            this.HQTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // train_Time_DetailsTableAdapter
            // 
            this.train_Time_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(132, 193);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(75, 34);
            this.EDIT.TabIndex = 20;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // SnoTextBox
            // 
            this.SnoTextBox.Location = new System.Drawing.Point(298, 9);
            this.SnoTextBox.Name = "SnoTextBox";
            this.SnoTextBox.Size = new System.Drawing.Size(64, 20);
            this.SnoTextBox.TabIndex = 21;
            this.SnoTextBox.Visible = false;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 543);
            this.Controls.Add(this.SnoTextBox);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.HQTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmployeeNoTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PfNoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GradePayTextBox);
            this.Controls.Add(this.RateOfPay);
            this.Controls.Add(this.DesgTextBox);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Entry";
            this.Text = "Entry";
            this.Load += new System.EventHandler(this.Entry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.night_DutyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox DesgTextBox;
        private System.Windows.Forms.TextBox RateOfPay;
        private System.Windows.Forms.TextBox GradePayTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PfNoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmployeeNoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HQTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox SignOnTextBox;
        private System.Windows.Forms.RichTextBox SourceStnTextBox;
        private System.Windows.Forms.RichTextBox TrainNoTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trainInfoBindingSource;
       
        private System.Windows.Forms.BindingSource trainTimeDetailsBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srcStnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signedOnDataGridViewTextBoxColumn;
        private Night_DutyDataSet night_DutyDataSet;
        private System.Windows.Forms.BindingSource trainTimeDetailsBindingSource1;
        private Night_DutyDataSetTableAdapters.Train_Time_DetailsTableAdapter train_Time_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.TextBox SnoTextBox;
    }
}