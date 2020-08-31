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
    public partial class ucNonEmptyTable : DevExpress.XtraEditors.XtraUserControl
    {
        private Button tableName;
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        private static ucNonEmptyTable _instance;
        public static ucNonEmptyTable Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNonEmptyTable();
                return _instance;
            }
        }
        public ucNonEmptyTable()
        {
            InitializeComponent();
            getData();
        }

        private void ucNonEmptyTable_Load(object sender, EventArgs e)
        {

        }
        private void getData()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("NonEmptyTable", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tableName = new Button();
                tableName.Text = dr["TableName"].ToString();
                tableName.Width = 100;
                tableName.Height = 100;
                tableName.BackColor = Color.FromArgb(255, 0, 0);
                flpNonEmpty.Controls.Add(tableName);
            }

        }
    }
}
