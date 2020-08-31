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
    public partial class ucFood : DevExpress.XtraEditors.XtraUserControl
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private static ucFood _instance;
        public static ucFood Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucFood();
                return _instance;
            }
        }
        public ucFood()
        {
            InitializeComponent();
            LoadGridView();
        }

        

        private void LoadGridView()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("loadFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvFood.DataSource = dt;
            dgvFood.Refresh();

        }
       

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucFood_Load(object sender, EventArgs e)
        {

        }
    }
}
