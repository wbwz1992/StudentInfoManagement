using StudentInfoMangement;
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

namespace StudentInfoManagement
{
    public partial class StudentForm : Form
    {
        SQLiteHelper helper = new SQLiteHelper("D:\Program Files (x86)\SQLiteStudio\StudentInfoManagementDB.db", null);
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void majorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] majors = {"信息与计算科学", "数学与应用数学", "应用物理" };           
            /*string connectionString = "Data Source=DESKTOP-NOTL3M1;Initial Catalog=StudentManagementDB;Integrated Security=True";
            string sql = "SELECT class_num FROM Class WHERE class_major = '" + majors[majorBox.SelectedIndex] + "'";
            DataSet dateset = SqlHelper.ExecuteDataset(connectionString, CommandType.Text, sql);
            int n = dateset.Tables[0].Rows.Count;
            classBox.Items.Clear();
            if (n != 0)
            {
                string[] classes = new string[n];
                for (int i = 0; i < n; i++)
                {
                    classes[i] = dateset.Tables[0].Rows[i][0].ToString().Trim();
                }
                classBox.Items.AddRange(classes);
            }*/


        }

        private void StudentListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
