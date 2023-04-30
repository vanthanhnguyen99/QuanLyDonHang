using DevExpress.XtraBars;
using QuanLyBanHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class mainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public mainForm()
        {
            InitializeComponent();
            fluentFormDefaultManager1.CloseMenus();
        }

        private void Item_KhachHang_Click(object sender, EventArgs e)
        {
            
            fluentDesignFormContainer1.Controls.Add(new KhachHang() { Dock = DockStyle.Fill});
        }
    }
}
