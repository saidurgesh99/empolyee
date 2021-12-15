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
    public partial class Form4 : Form
    {
        string connectionstring = @"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=form2;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=ITCLABD30\SQLEXPRESS;Initial Catalog=form4;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into form4data values ('" + txtname.Text + "','" + txtfeed.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("send successfuly!");
            con.Close();

        }
    }
}
