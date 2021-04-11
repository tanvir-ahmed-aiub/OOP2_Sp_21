using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace db_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string c_code = tbCCode.Text;
            string c_name = tbCName.Text;
            //do validation
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into courses values ('{0}','{1}')",c_code,c_name);
            SqlCommand cmd = new SqlCommand(query,conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Data Inserted");
            }
            else {
                MessageBox.Show("Could not insert data");
            }
            conn.Close();
            //loading courses after insertion
            var list = GetCourses();
            dtCourses.DataSource = list;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var list = GetCourses();
            dtCourses.DataSource = list;
        }


        private List<Course> GetCourses() {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "select * from courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //dtCourses.DataSource
            //ArrayList list = new ArrayList();
            List<Course> list = new List<Course>();
            while (reader.Read())
            {
                Course c = new Course();
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));

                list.Add(c);
            }
            conn.Close();
            return list;
        }

        private void LoadData(object sender, EventArgs e)
        {
            var list = GetCourses();
            dtCourses.DataSource = list;
        }

        private void SearchCourse(object sender, EventArgs e)
        {
            int cId = Int32.Parse(tbCId.Text);
            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("select * from courses where id={0}",cId);
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Course c = new Course();
            while (reader.Read()) {
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            }
            tbCCodeEdit.Text = c.CourseCode;
            tbCNameEdit.Text = c.CourseName;
            conn.Close();
        }

        private void UpdateCourse_Click(object sender, EventArgs e)
        {
            int cId = Int32.Parse(tbCId.Text);
            string cCode = tbCCodeEdit.Text;
            string cName = tbCNameEdit.Text;

            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("update courses set CourseCode='{0}', CourseName='{1}' where Id={2}", cCode,cName,cId);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            var list = GetCourses();
            dtCourses.DataSource = list;


        }

    }
}
