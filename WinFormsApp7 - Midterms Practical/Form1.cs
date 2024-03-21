using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace WinFormsApp7___Midterms_Practical
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\L23Y08W29\\Downloads\\Delgado_CPE262 Calculator Project\\database\\DatabaseX.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\L23Y08W29\\Downloads\\Delgado_CPE262 Calculator Project\\database\\DatabaseX.accdb");


            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            //or da = new OleDbDataAdapter("SELECT Student.LastName, Student.FirstName, 
            //Student.Course, SubjectsEnrolled.*, FinalGrade.StudentID\r\nFROM (Student 
            //INNER JOIN SubjectsEnrolled ON Student.StudentID = 
            //SubjectsEnrolled.StudentID) INNER JOIN FinalGrade ON Student.StudentID = 
            //FinalGrade.StudentID", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (Age, Gender, Year_in_School, Major, Monthly_Income,@Financial_Aid, Tuition, Housing, Food, Transportation, Book_Supplies, Entertainment, Personal_Care, Technology, Health_and_Wellness, Miscellaneous, Preferred_Method_of_Payment) values (@Age, @Gender, @Year_in_School, @Major, @Monthly_Income, @Financial_Aid, @Tuition, @Housing, @Food, @Transportation, @Book_Supplies, @Entertainment, @Personal_Care, @Technology, @Health_and_Wellness, @Miscellaneous, @Preferred_Method_of_Payment)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@Age", tbxAge.Text);
            cmd.Parameters.AddWithValue("@Gender", tbxGender.Text);
            cmd.Parameters.AddWithValue("@Year_in_School", tbxYearInSchool.Text);
            cmd.Parameters.AddWithValue("@Major", tbxMajor.Text);
            cmd.Parameters.AddWithValue("@Monthly_Income", tbxMonthlyIncome.Text);
            cmd.Parameters.AddWithValue("@Financial_Aid", tbxFinancialAid.Text);
            cmd.Parameters.AddWithValue("@Tuition", tbxTuition.Text);
            cmd.Parameters.AddWithValue("@Housing", tbxHousing.Text);
            cmd.Parameters.AddWithValue("@Food", tbxFood.Text);
            cmd.Parameters.AddWithValue("@Transportation", tbxTransportation.Text);
            cmd.Parameters.AddWithValue("@Book_Supplies", tbxBookSupplies.Text);
            cmd.Parameters.AddWithValue("@Entertainment", tbxEntertainment.Text);
            cmd.Parameters.AddWithValue("@Personal_Care", tbxPersonalCare.Text);
            cmd.Parameters.AddWithValue("@Technology", tbxTechnology.Text);
            cmd.Parameters.AddWithValue("@Health_and_Wellness", tbxHealthAndWellness.Text);
            cmd.Parameters.AddWithValue("@Miscellaneous", tbxMisc.Text);
            cmd.Parameters.AddWithValue("@Preferred_Method_of_Payment", tbxMOP.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxID.Text = row.Cells[0].Value.ToString();
            tbxAge.Text = row.Cells[1].Value.ToString();
            tbxGender.Text = row.Cells[2].Value.ToString();
            tbxYearInSchool.Text = row.Cells[3].Value.ToString();
            tbxMajor.Text = row.Cells[4].Value.ToString();
            tbxMonthlyIncome.Text = row.Cells[5].Value.ToString();
            tbxFinancialAid.Text = row.Cells[6].Value.ToString();
            tbxTuition.Text = row.Cells[7].Value.ToString();
            tbxHousing.Text = row.Cells[8].Value.ToString();
            tbxFood.Text = row.Cells[9].Value.ToString();
            tbxTransportation.Text = row.Cells[10].Value.ToString();
            tbxBookSupplies.Text = row.Cells[11].Value.ToString();
            tbxEntertainment.Text = row.Cells[12].Value.ToString();
            tbxPersonalCare.Text = row.Cells[13].Value.ToString();
            tbxTechnology.Text = row.Cells[14].Value.ToString();
            tbxHealthAndWellness.Text = row.Cells[15].Value.ToString();
            tbxMisc.Text = row.Cells[16].Value.ToString();
            tbxMOP.Text = row.Cells[17].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dgvStudentInfo.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set Age = @Age, Gender = @Gender, Year_in_School = @Year_in_School Where ID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(tbxAge.Text));
            cmd.Parameters.AddWithValue("@Gender", tbxGender.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}
