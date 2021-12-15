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

namespace empolyee
{
    public partial class Form3 : Form
    {
        string connectionstring = @"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=form2;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select *from form2data", sqlcon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dataView1.DataSource = dt;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into employeedata values('" + txtname.Text + "','" + txtid.Text + "','" + txtcity.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert successfuly!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM[dbo].[employeedata] WHERE [id]='" + txtid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete successfuly!");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[employeedata]
   SET [employee name] = '" + txtname.Text + "',[employee id] = '" + txtid.Text + "',[city] = '" + txtcity.Text + "'WHERE [id]='" + txtid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfuly!");
            con.Close();
        }

        private void dataView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refesh_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(connection))
            {
                sqlcon.Open();
                SqlDataAdapter sqldat = new SqlDataAdapter("select *from employeedata", sqlcon);
                DataTable dats = new DataTable();
                sqldat.Fill(dats);
                dataView2.DataSource = dats;

            }
        }
    }
}
