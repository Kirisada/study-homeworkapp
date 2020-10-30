using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Workapp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection();
        SqlDataAdapter da;
		SqlDataAdapter daM;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

		private void ShowPosition()
		{
			if (bs.Position == 0)
			{
				btFirst.Enabled = false;
				btback.Enabled = false;
				btNext.Enabled = true;
				btLast.Enabled = true;
			}
			else if (bs.Position == bs.Count - 1)
			{
				btFirst.Enabled = true;
				btback.Enabled = true;
				btNext.Enabled = false;
				btLast.Enabled = false;
			}
			else
			{
				btFirst.Enabled = true;
				btback.Enabled = true;
				btNext.Enabled = true;
				btLast.Enabled = true;
			}
			lblRecord.Text = Convert.ToString(bs.Position + 1)
				+ "/" + bs.Count.ToString();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			String strConn = "Server=.\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Register;";
			if (Conn.State == ConnectionState.Open)
			{
				Conn.Close();
			}
			Conn.ConnectionString = strConn;
			Conn.Open();
			string sqlq = "Select * from Student";
			da = new SqlDataAdapter(sqlq, Conn);
			da.Fill(ds, "Student");			
			bs.DataSource = ds.Tables["Student"];
			txtSNo.DataBindings.Add("Text", bs, "StdNo");
			txtName.DataBindings.Add("Text", bs, "StdName");
			txtAddress.DataBindings.Add("Text", bs, "Address");
			txtTel.DataBindings.Add("Text", bs, "Tel");
			txtEmail.DataBindings.Add("Text", bs, "Email");
			txtFacebook.DataBindings.Add("Text", bs, "Facebook");
			

			sqlq = "Select * from Major";
			daM = new SqlDataAdapter(sqlq, Conn);
			daM.Fill(ds, "Major");
			cbbMajor.DisplayMember = "MName";
			cbbMajor.ValueMember = "MNo";
			cbbMajor.DataSource = ds.Tables["Major"];
			cbbMajor.DataBindings.Add("SelectedValue", bs, "MNo");
			ShowPosition();
		}

		private void btFirst_Click(object sender, EventArgs e)
		{
			bs.MoveFirst();
			ShowPosition();
		}

		private void btback_Click(object sender, EventArgs e)
		{
			bs.MovePrevious();
			ShowPosition();
		}

		private void btNext_Click(object sender, EventArgs e)
		{
			bs.MoveNext();
			ShowPosition();
		}

		private void btLast_Click(object sender, EventArgs e)
		{
			bs.MoveLast();
			ShowPosition();
		}

	}
}
