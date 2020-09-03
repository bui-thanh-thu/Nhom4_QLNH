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
            load_listview();
        }
        public void load_listview()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("loadListview", conn);
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
            txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBan.Text = dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtBan.Enabled = false;
            txtMaHD.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
