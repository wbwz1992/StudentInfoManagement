using StudentInfoMangement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoManagement
{
    public partial class StudentForm : Form
    {
        //SQLiteHelper helper = new SQLiteHelper(AppDomain.CurrentDomain.BaseDirectory+"/StudentInfoManagementDB.db", null);
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
            string sql = "SELECT class_num FROM Class_List WHERE class_major = '" + majors[majorBox.SelectedIndex] + "'";
            DbHelperSQLite.connectionString = "Data Source = " + Environment.CurrentDirectory + "\\StudentInfoManagementDB.db";
            DataSet ds = DbHelperSQLite.Query(sql);
            int n = ds.Tables[0].Rows.Count;
            classBox.Items.Clear();
            if (n != 0)
            {
                string[] classes = new string[n];
                for (int i = 0; i < n; i++)
                {
                    classes[i] = ds.Tables[0].Rows[i][0].ToString().Trim();
                }
                classBox.Items.AddRange(classes);
            }
        }

        private void StudentListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
