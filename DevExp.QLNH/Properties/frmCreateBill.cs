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

namespace DevExp.QLNH.Properties
{
    public partial class frmCreateBill : Form
    {
        public delegate void delPassData(TextBox text);
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public frmCreateBill()
        {
            InitializeComponent();
            loadTable();
        }
        public void loadTable()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("EmptyTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["TableName"] = "--Select--";
            dt.Rows.InsertAt(dr, 0);
            cbbTable.DataSource = dt;
            cbbTable.ValueMember = "TableName";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string p_MaHD = txtMaHD.Text;
            string p_tbName = cbbTable.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("addBill", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 50).Value = p_MaHD;
            cmd.Parameters.Add("@TableName", SqlDbType.NVarChar, 50).Value = p_tbName;

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            frmNewOrder form = new frmNewOrder();
            delPassData del = new delPassData(form.funData);
            del(this.txtMaHD);
            form.Show();


        }
    }
}
