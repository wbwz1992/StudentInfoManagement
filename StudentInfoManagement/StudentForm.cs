using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoManagement
{
    public partial class StudentForm : Form
    {
        
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
            string[] classes = { "1241", "1242", "1341", "1342" };
            string major = majors[majorBox.SelectedIndex];
            classBox.Items.Clear();
            classBox.Items.AddRange(classes);

        }
    }
}
