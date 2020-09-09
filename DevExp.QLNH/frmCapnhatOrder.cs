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

namespace DevExp.QLNH
{
    
    public partial class frmCapnhatOrder : Form
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public frmCapnhatOrder()
        {
            InitializeComponent();
            loadcbb();
        }
        public void funData(TextBox txtForm1)
        {
            lbHoaDon.Text = txtForm1.Text;
          
        }
        public void funData2(TextBox txtForm2)
        {
            lbTable.Text = txtForm2.Text;

        }

        public void loadcbb()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("selectFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            DataRow dr = dt.NewRow();
         
            dr["Name"] = " ";
            dt.Rows.InsertAt(dr, 0);
            cbbFood.DataSource = dt;
            cbbFood.ValueMember = "idFood";
            cbbFood.DisplayMember = "Name";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string p_mahd = lbHoaDon.Text;
            string p_food = cbbFood.SelectedValue.ToString();
            int p_soluong = Int16.Parse(txtSoluong.Text);
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("addBillDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 50).Value = p_mahd;
            cmd.Parameters.Add("@idFood", SqlDbType.NVarChar, 50).Value = p_food;
            cmd.Parameters.Add("@Soluong", SqlDbType.NVarChar, 50).Value = p_soluong;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.Close();
        }
    }
}
