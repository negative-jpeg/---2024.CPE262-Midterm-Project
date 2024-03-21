namespace WinFormsApp7___Midterms_Practical
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
            btnTestConnection = new Button();
            dgvStudentInfo = new DataGridView();
            btnLoad = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbxAge = new TextBox();
            tbxGender = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tbxMajor = new TextBox();
            tbxYearInSchool = new TextBox();
            tbxHousing = new TextBox();
            tbxTuition = new TextBox();
            tbxFinancialAid = new TextBox();
            tbxMonthlyIncome = new TextBox();
            tbxMisc = new TextBox();
            tbxHealthAndWellness = new TextBox();
            tbxTechnology = new TextBox();
            tbxPersonalCare = new TextBox();
            tbxEntertainment = new TextBox();
            tbxBookSupplies = new TextBox();
            tbxTransportation = new TextBox();
            tbxFood = new TextBox();
            label17 = new Label();
            tbxMOP = new TextBox();
            label18 = new Label();
            tbxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            SuspendLayout();
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(12, 146);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(136, 23);
            btnTestConnection.TabIndex = 0;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += button1_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(12, 254);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.Size = new Size(1017, 426);
            dgvStudentInfo.TabIndex = 1;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 117);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(136, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button2_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 12);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(136, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 70);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 41);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 99);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Year in School";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 128);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Major";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 157);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 10;
            label5.Text = "Monthly Income";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 186);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 11;
            label6.Text = "Financial Aid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 215);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Tuition";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(434, 12);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 13;
            label8.Text = "Housing";
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(299, 38);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(129, 23);
            tbxAge.TabIndex = 14;
            // 
            // tbxGender
            // 
            tbxGender.Location = new Point(299, 67);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(129, 23);
            tbxGender.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 38);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 16;
            label9.Text = "Food";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(434, 67);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 17;
            label10.Text = "Transportation";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(434, 96);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 18;
            label11.Text = "Book Supplies";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(434, 125);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 19;
            label12.Text = "Entertainment";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(434, 154);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 20;
            label13.Text = "Personal Care";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(434, 183);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 21;
            label14.Text = "Technology";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(434, 212);
            label15.Name = "label15";
            label15.Size = new Size(114, 15);
            label15.TabIndex = 22;
            label15.Text = "Health and Wellness";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(689, 12);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 23;
            label16.Text = "Miscellaneous";
            // 
            // tbxMajor
            // 
            tbxMajor.Location = new Point(299, 125);
            tbxMajor.Name = "tbxMajor";
            tbxMajor.Size = new Size(129, 23);
            tbxMajor.TabIndex = 25;
            // 
            // tbxYearInSchool
            // 
            tbxYearInSchool.Location = new Point(299, 96);
            tbxYearInSchool.Name = "tbxYearInSchool";
            tbxYearInSchool.Size = new Size(129, 23);
            tbxYearInSchool.TabIndex = 24;
            // 
            // tbxHousing
            // 
            tbxHousing.Location = new Point(554, 10);
            tbxHousing.Name = "tbxHousing";
            tbxHousing.Size = new Size(129, 23);
            tbxHousing.TabIndex = 29;
            // 
            // tbxTuition
            // 
            tbxTuition.Location = new Point(299, 212);
            tbxTuition.Name = "tbxTuition";
            tbxTuition.Size = new Size(129, 23);
            tbxTuition.TabIndex = 28;
            // 
            // tbxFinancialAid
            // 
            tbxFinancialAid.Location = new Point(299, 183);
            tbxFinancialAid.Name = "tbxFinancialAid";
            tbxFinancialAid.Size = new Size(129, 23);
            tbxFinancialAid.TabIndex = 27;
            // 
            // tbxMonthlyIncome
            // 
            tbxMonthlyIncome.Location = new Point(299, 154);
            tbxMonthlyIncome.Name = "tbxMonthlyIncome";
            tbxMonthlyIncome.Size = new Size(129, 23);
            tbxMonthlyIncome.TabIndex = 26;
            // 
            // tbxMisc
            // 
            tbxMisc.Location = new Point(848, 12);
            tbxMisc.Name = "tbxMisc";
            tbxMisc.Size = new Size(129, 23);
            tbxMisc.TabIndex = 37;
            // 
            // tbxHealthAndWellness
            // 
            tbxHealthAndWellness.Location = new Point(554, 212);
            tbxHealthAndWellness.Name = "tbxHealthAndWellness";
            tbxHealthAndWellness.Size = new Size(129, 23);
            tbxHealthAndWellness.TabIndex = 36;
            // 
            // tbxTechnology
            // 
            tbxTechnology.Location = new Point(554, 183);
            tbxTechnology.Name = "tbxTechnology";
            tbxTechnology.Size = new Size(129, 23);
            tbxTechnology.TabIndex = 35;
            // 
            // tbxPersonalCare
            // 
            tbxPersonalCare.Location = new Point(554, 154);
            tbxPersonalCare.Name = "tbxPersonalCare";
            tbxPersonalCare.Size = new Size(129, 23);
            tbxPersonalCare.TabIndex = 34;
            // 
            // tbxEntertainment
            // 
            tbxEntertainment.Location = new Point(554, 125);
            tbxEntertainment.Name = "tbxEntertainment";
            tbxEntertainment.Size = new Size(129, 23);
            tbxEntertainment.TabIndex = 33;
            // 
            // tbxBookSupplies
            // 
            tbxBookSupplies.Location = new Point(554, 96);
            tbxBookSupplies.Name = "tbxBookSupplies";
            tbxBookSupplies.Size = new Size(129, 23);
            tbxBookSupplies.TabIndex = 32;
            // 
            // tbxTransportation
            // 
            tbxTransportation.Location = new Point(554, 67);
            tbxTransportation.Name = "tbxTransportation";
            tbxTransportation.Size = new Size(129, 23);
            tbxTransportation.TabIndex = 31;
            // 
            // tbxFood
            // 
            tbxFood.Location = new Point(554, 39);
            tbxFood.Name = "tbxFood";
            tbxFood.Size = new Size(129, 23);
            tbxFood.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(689, 41);
            label17.Name = "label17";
            label17.Size = new Size(153, 15);
            label17.TabIndex = 38;
            label17.Text = "Preffered Mode of Payment";
            // 
            // tbxMOP
            // 
            tbxMOP.Location = new Point(848, 38);
            tbxMOP.Name = "tbxMOP";
            tbxMOP.Size = new Size(129, 23);
            tbxMOP.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(199, 10);
            label18.Name = "label18";
            label18.Size = new Size(18, 15);
            label18.TabIndex = 41;
            label18.Text = "ID";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(299, 9);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(128, 23);
            tbxID.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 692);
            Controls.Add(tbxID);
            Controls.Add(label18);
            Controls.Add(tbxMOP);
            Controls.Add(label17);
            Controls.Add(tbxMisc);
            Controls.Add(tbxHealthAndWellness);
            Controls.Add(tbxTechnology);
            Controls.Add(tbxPersonalCare);
            Controls.Add(tbxEntertainment);
            Controls.Add(tbxBookSupplies);
            Controls.Add(tbxTransportation);
            Controls.Add(tbxFood);
            Controls.Add(tbxHousing);
            Controls.Add(tbxTuition);
            Controls.Add(tbxFinancialAid);
            Controls.Add(tbxMonthlyIncome);
            Controls.Add(tbxMajor);
            Controls.Add(tbxYearInSchool);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tbxGender);
            Controls.Add(tbxAge);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnLoad);
            Controls.Add(dgvStudentInfo);
            Controls.Add(btnTestConnection);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestConnection;
        private DataGridView dgvStudentInfo;
        private Button btnLoad;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbxAge;
        private TextBox tbxGender;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tbxMajor;
        private TextBox tbxYearInSchool;
        private TextBox tbxHousing;
        private TextBox tbxTuition;
        private TextBox tbxFinancialAid;
        private TextBox tbxMonthlyIncome;
        private TextBox tbxMisc;
        private TextBox tbxHealthAndWellness;
        private TextBox tbxTechnology;
        private TextBox tbxPersonalCare;
        private TextBox tbxEntertainment;
        private TextBox tbxBookSupplies;
        private TextBox tbxTransportation;
        private TextBox tbxFood;
        private Label label17;
        private TextBox tbxMOP;
        private Label label18;
        private TextBox tbxID;
    }
}
