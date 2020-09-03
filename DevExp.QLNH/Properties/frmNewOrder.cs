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
    public partial class frmNewOrder : Form
    {
        
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        
        
        
        private List<FoodItem> listFI = new List<FoodItem>();
       
        public frmNewOrder()
        {
            InitializeComponent();
            
            loadFood();
            
        }

        public void funData(TextBox txtForm1)
        {
            txtMaHD.Text = txtForm1.Text;
        }
        public void loadFood()
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
         
            dr["Name"] = "---- ";
            dt.Rows.InsertAt(dr, 0);
            cbbFood.DataSource = dt;
            cbbFood.ValueMember = "idFood";
            cbbFood.DisplayMember = "Name";
            
        }
        public void load_gridview()
        {
            FoodItem fi = new FoodItem()
            {
                idFood = cbbFood.Text,
                
                Soluong = Convert.ToInt32(txtSoluong.Text)
            };

            listFI.Add(fi);
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = listFI;
            cbbFood.SelectedIndex = -1;
            txtSoluong.Clear();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string p_mahd = txtMaHD.Text;
            string p_food = cbbFood.SelectedValue.ToString();
            int p_soluong = Convert.ToInt32(txtSoluong.Text);

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("addBillDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 50).Value = p_mahd;
            cmd.Parameters.Add("@idFood", SqlDbType.NVarChar, 50).Value = p_food;
            cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = p_soluong;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            load_gridview();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
