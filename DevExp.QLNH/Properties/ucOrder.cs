using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DevExp.QLNH.Properties
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private static ucOrder _instance;
        public static ucOrder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucOrder();
                return _instance;
            }
        }
        public ucOrder()
        {
            InitializeComponent();
            load_gridview();
            
        }
        public void load_gridview()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("loadgrvHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvHoaDon.DataSource = dt;
            dgvHoaDon.Refresh();
        }

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            frmCreateBill form = new frmCreateBill();
            form.Show();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
            txtBan.Text = dgvHoaDon.CurrentRow.Cells["TableName"].Value.ToString();

            //txtBan.Enabled = false;
            //txtMaHD.Enabled = false;

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Tinhtien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 50).Value = txtMaHD.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDetail.DataSource = dt;
            dgvDetail.Refresh();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
