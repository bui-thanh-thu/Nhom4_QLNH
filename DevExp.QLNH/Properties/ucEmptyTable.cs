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
    public partial class ucEmptyTable : DevExpress.XtraEditors.XtraUserControl
    {
        private Button tableName;
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private static ucEmptyTable _instance;
        public static ucEmptyTable Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEmptyTable();
                return _instance;
            }
        }
        public ucEmptyTable()
        {
            InitializeComponent();
            getData();
        }

        
        public void getData()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("EmptyTable ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tableName = new Button();
                tableName.Text = dr["TableName"].ToString();
                tableName.Width = 100;
                tableName.Height = 100;
                tableName.BackColor = Color.FromArgb(255, 232, 232);
                flpTable.Controls.Add(tableName);
            }
            // set màu của button: nếu trạng thái là trống thì ko set màu, nếu đã có khách thì set màu đỏ
            //
            //
        }
    }
}
