using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExp.QLNH.Properties
{
    public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

       

        private void aceOrder_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucOrder.Instance))
            {
                container.Controls.Add(ucOrder.Instance);
                ucOrder.Instance.Dock = DockStyle.Fill;
                ucOrder.Instance.BringToFront();
            }
            ucOrder.Instance.BringToFront();
        }

        private void aceFood_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucFood.Instance))
            {
                container.Controls.Add(ucFood.Instance);
                ucFood.Instance.Dock = DockStyle.Fill;
                ucFood.Instance.BringToFront();
            }
            ucFood.Instance.BringToFront();
        }

        private void aceDrink_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucDrink.Instance))
            {
                container.Controls.Add(ucDrink.Instance);
                ucDrink.Instance.Dock = DockStyle.Fill;
                ucDrink.Instance.BringToFront();
            }
            ucDrink.Instance.BringToFront();
        }

        private void aceEmptyTable_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucEmptyTable.Instance))
            {
                container.Controls.Add(ucEmptyTable.Instance);
                ucEmptyTable.Instance.Dock = DockStyle.Fill;
                ucEmptyTable.Instance.BringToFront();
            }
            ucEmptyTable.Instance.BringToFront();
        }

        private void aceNonEmpty_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucNonEmptyTable.Instance))
            {
                container.Controls.Add(ucNonEmptyTable.Instance);
                ucNonEmptyTable.Instance.Dock = DockStyle.Fill;
                ucNonEmptyTable.Instance.BringToFront();
            }
            ucNonEmptyTable.Instance.BringToFront();
        }
    }
}
