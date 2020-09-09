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
        public delegate void delPassData(TextBox text);
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

        public void TongTien()
        {
            int row = dgvDetail.Rows.Count;
            float tongtien = 0;
            for(int i = 0; i<row - 1; i++)
            {
                tongtien += float.Parse(dgvDetail.Rows[i].Cells["Thành Tiền"].Value.ToString());
            }
            txtThanhTien.Text = tongtien.ToString();
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
            TinhTien();
            TongTien();

        }
        public void TinhTien()
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
            txtBan.Text = dgvHoaDon.CurrentRow.Cells["TableName"].Value.ToString();

            txtBan.Enabled = false;
            txtMaHD.Enabled = false;

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

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            frmCapnhatOrder frm = new frmCapnhatOrder();
            delPassData del = new delPassData(frm.funData);
            del(this.txtMaHD);
            delPassData del2 = new delPassData(frm.funData2);
            del2(this.txtBan);
            frm.Show();
            TinhTien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          int p_soluong = Int16.Parse(dgvDetail.CurrentRow.Cells["Soluong"].Value.ToString());
            string p_mahd = txtMaHD.Text;
            string p_idFood = dgvDetail.CurrentRow.Cells["idFood"].Value.ToString();

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("EditBillDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 50).Value = p_mahd;
            cmd.Parameters.Add("@idFood", SqlDbType.NVarChar, 50).Value =p_idFood;
            cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = p_soluong;
            cmd.ExecuteNonQuery();
            dgvDetail.Refresh();
            cmd.Dispose();

            TinhTien();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string p_idFood = dgvDetail.CurrentRow.Cells["idFood"].Value.ToString();
            string p_mhd = txtMaHD.Text;
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("deleteFood_BillDetail ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MaHD", SqlDbType.NVarChar, 50).Value = p_mhd;
            cmd.Parameters.Add("idFood", SqlDbType.NVarChar, 50).Value = p_idFood;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Đã xóa dữ liệu!", "Thông báo");
            TinhTien();
            
        }
    }
}
