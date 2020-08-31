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
    public partial class ucDrink : DevExpress.XtraEditors.XtraUserControl
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private static ucDrink _instance;
        public static ucDrink Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDrink();
                return _instance;
            }
        }
        public ucDrink()
        {
            InitializeComponent();
            loadGridView();
        }

        public void loadGridView()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("loadDrink", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDrink.DataSource = dt;
            dgvDrink.Refresh();
        }
        private void ucDrink_Load(object sender, EventArgs e)
        {

        }
    }
}
