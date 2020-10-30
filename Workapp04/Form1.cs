using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Workapp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection();
        SqlDataAdapter daMj;
        DataSet ds = new DataSet();
        string SaveStatus;

        private void ConnectDB()
        {
            string strConn = "Server=.\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Register;";
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();
        }

        private void Form_Enabled()
        {
            txtSNo.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtTel.Enabled = true;
            cbbMajor.Enabled = true;
            txtEmail.Enabled = true;
            txtFacebook.Enabled = true;
            txtSearch.Enabled = true;
        }

        private void Form_Disabled()
        {
            txtSNo.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtTel.Enabled = false;
            cbbMajor.Enabled = false;
            txtEmail.Enabled = false;
            txtFacebook.Enabled = false;
            txtSearch.Enabled = true;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDB();
            string sqlMajor = "Select * from Major";
            daMj = new SqlDataAdapter(sqlMajor, Conn);
            daMj.Fill(ds, "Major");
            cbbMajor.DisplayMember = "MName";
            cbbMajor.ValueMember = "MNo";
            cbbMajor.DataSource = ds.Tables["Major"];
            Form_Disabled();
            btAdd.Enabled = true;
            btEdit.Enabled = false;
            btSave.Enabled = false;
            btDel.Enabled = false;
            txtSearch.Enabled = true;
        }
        private void Clear_Form()
        {
            txtSNo.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            cbbMajor.SelectedIndex = 0;
            txtEmail.Text = "";
            txtFacebook.Text = "";
            txtSearch.Text = "";
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Form_Enabled();
            Clear_Form();
            txtSNo.Focus();
            SaveStatus = "Add";
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btSave.Enabled = true;
            btDel.Enabled = false;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Form_Enabled();
            txtSNo.Enabled = false;
            txtName.Focus();
            SaveStatus = "Edit";
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btSave.Enabled = true;
            btDel.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (SaveStatus == "Add")
                {
                    if (txtSNo.Text == "")
                    {
                        MessageBox.Show("Pls Input Data", "Warnings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSNo.Focus();
                    }
                    else
                    {
                        sb.Remove(0, sb.Length);
                        sb.Append("INSERT into Student values('" + txtSNo.Text + "',");
                        sb.Append("'" + txtName.Text + "'," + "'" + txtAddress.Text + "',");
                        sb.Append("'" + txtTel.Text + "'," + "'" + txtEmail.Text + "',");
                        sb.Append("'" + txtFacebook.Text + "'," + "'" + cbbMajor.SelectedValue + "')");

                        string sqlAdd = sb.ToString();
                        SqlCommand comAdd = new SqlCommand();
                        comAdd.CommandType = CommandType.Text;
                        comAdd.CommandText = sqlAdd;
                        comAdd.Connection = Conn;
                        comAdd.ExecuteNonQuery();
                        SaveStatus = "";
                        Form_Disabled();
                        MessageBox.Show("Success", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btAdd.Enabled = true;
                        btEdit.Enabled = false;
                        btSave.Enabled = false;
                        btDel.Enabled = true;
                    }
                }
                else if (SaveStatus == "Edit")
                {
                    sb.Remove(0, sb.Length);
                    sb.Append("UPDATE Student set  StdName='" + txtName.Text + "',");
                    sb.Append("Address='" + txtAddress.Text + "',Tel='" + txtTel.Text + "',");
                    sb.Append("Email='" + txtEmail.Text + "',Facebook='" + txtFacebook.Text + "',");
                    sb.Append("MNo='" + cbbMajor.SelectedValue + "'");
                    sb.Append("  where (StdNo='" + txtSNo.Text + "')");
                    string sqlEdit = sb.ToString();

                    SqlCommand comEdit = new SqlCommand();
                    comEdit.CommandType = CommandType.Text;
                    comEdit.CommandText = sqlEdit;
                    comEdit.Connection = Conn;
                    comEdit.ExecuteNonQuery();
                    SaveStatus = "";
                    Form_Disabled();
                    MessageBox.Show("Success", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btAdd.Enabled = true;
                    btEdit.Enabled = false;
                    btSave.Enabled = false;
                    btDel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "catch");
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you went delete data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string sqlDelete = "DELETE from Student  where StdNo ='" + txtSNo.Text.Trim() + "'";

                    SqlCommand comDelete = new SqlCommand();
                    comDelete.CommandType = CommandType.Text;
                    comDelete.CommandText = sqlDelete;
                    comDelete.Connection = Conn;
                    comDelete.ExecuteNonQuery();
                    Clear_Form();
                    MessageBox.Show("Success", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btAdd.Enabled = true;
                    btEdit.Enabled = false;
                    btSave.Enabled = false;
                    btDel.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "catch");
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Pls Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sqlEmp = "Select * from Student where StdNo = '" + txtSearch.Text.Trim() + "'";
            SqlCommand com = new SqlCommand();
            SqlDataReader dr;
            DataTable dt;
            com.CommandType = CommandType.Text;
            com.CommandText = sqlEmp;
            com.Connection = Conn;
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);
                txtSNo.Text = dt.Rows[0]["StdNo"].ToString();
                txtName.Text = dt.Rows[0]["StdName"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtTel.Text = dt.Rows[0]["Tel"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtFacebook.Text = dt.Rows[0]["Facebook"].ToString();
                cbbMajor.SelectedValue = dt.Rows[0]["MNo"].ToString();
                btAdd.Enabled = true;
                btEdit.Enabled = true;
                btSave.Enabled = false;
                btDel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Form();
                txtSearch.Focus();
                txtSearch.SelectAll();
            }
            dr.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
