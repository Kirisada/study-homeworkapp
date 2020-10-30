using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Workapp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		MySqlConnection Conn = new MySqlConnection();
		MySqlDataAdapter da;
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
			String strConn = "datasource=localhost;username=root;password=;database=student;";
			string sqlEmp = "Select * from Student";
			if (Conn.State == ConnectionState.Open)
			{
				Conn.Close();
			}
			Conn.ConnectionString = strConn;
			MySqlCommand cmd = new MySqlCommand(sqlEmp, Conn);
			Conn.Open();

			
			da = new MySqlDataAdapter(sqlEmp, Conn);
			da.Fill(ds, "Student");
			bs.DataSource = ds.Tables["Student"];
			txtSNo.DataBindings.Add("Text", bs, "StdNo");
			txtName.DataBindings.Add("Text", bs, "StdName");
			txtTel.DataBindings.Add("Text", bs, "Tel");
			txtEmail.DataBindings.Add("Text", bs, "Email");
			txtMajor.DataBindings.Add("Text", bs, "Major");
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
