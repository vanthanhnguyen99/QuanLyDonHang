using DevExpress.XtraEditors;
using QuanLyBanHang.QUANNLYDONHANGDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    enum TrangThai
    {
        NONE,
        ADD,
        DELETE,
        EDIT
    }
    public partial class KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        TrangThai trangThai = TrangThai.NONE;
        public KhachHang()
        {
            trangThai = TrangThai.NONE;
            InitializeComponent();
        }

        String layMaKH()
        {
            String MaKH = "0";
            foreach(DataRow dataRow in qUANNLYDONHANGDataSet.KHACHHANG.Rows)
            {
                String idKH = dataRow["ID"].ToString();

                idKH = idKH.Substring(2);
                if (Int32.Parse(idKH) > Int32.Parse(MaKH))
                    MaKH = idKH;
            }
            
            return "KH" + (Int32.Parse(MaKH) + 1);
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            qUANNLYDONHANGDataSet.EnforceConstraints = true;
            kHACHHANGTableAdapter.Fill(qUANNLYDONHANGDataSet.KHACHHANG);
            gridView_KhachHang.Focus();

            gridView_KhachHang.Columns["ID"].Caption = "Mã khách hàng";
            gridView_KhachHang.Columns["TENKH"].Caption = "Tên khách hàng";
            gridView_KhachHang.Columns["SDT"].Caption = "Số điện thoại";
            gridView_KhachHang.Columns["GHICHU"].Caption = "Ghi chú";

            panelControl1.Enabled = false;

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;
            iDTextEdit.Enabled = false;

            
        }

        private void barButtonItem_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai = TrangThai.ADD;
            qUANNLYDONHANGDataSet.EnforceConstraints = false;

            barButtonItem_Them.Enabled = false;
            barButtonItem_Xoa.Enabled = false;
            barButtonItem_Sua.Enabled = false;
            barButtonItem_Ghi.Enabled = true;
            barButtonItem_Thoat.Enabled = true;

            gridControl1.Enabled = false;
            panelControl1.Enabled = true;

            kHACHHANGBindingSource.AddNew();
            iDTextEdit.Text = layMaKH();
            ((DataRowView)kHACHHANGBindingSource[kHACHHANGBindingSource.Position])["ID"] = iDTextEdit.Text;
            gridView_KhachHang.RefreshData();
            kHACHHANGBindingSource.ResetCurrentItem();
            tENKHTextEdit.Focus();

        }

        private void barButtonItem_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (tENKHTextEdit.Focused)
            //{
            //    ((DataRowView)kHACHHANGBindingSource[kHACHHANGBindingSource.Position])["TENKH"] = tENKHTextEdit.Text;
            //}    

            //if (sDTTextEdit.Focused)
            //{
            //    ((DataRowView)kHACHHANGBindingSource[kHACHHANGBindingSource.Position])["SDT"] = sDTTextEdit.Text;
            //}

            //if (gHICHURichTextBox.Focused)
            //{
            //    ((DataRowView)kHACHHANGBindingSource[kHACHHANGBindingSource.Position])["GHICHU"] = gHICHURichTextBox.Text;
            //}

            String hoTen = tENKHTextEdit.Text.Trim();
            String sdt = sDTTextEdit.Text.Trim();

            if (hoTen.Length == 0)
            {
                MessageBox.Show("Không bỏ trống họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Program.isPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại trống hoặc không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            trangThai = TrangThai.NONE;

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;

            gridControl1.Enabled = true;
            panelControl1.Enabled = false;

            kHACHHANGBindingSource.EndEdit();
            kHACHHANGBindingSource.ResetCurrentItem();
            kHACHHANGTableAdapter.Update(qUANNLYDONHANGDataSet.KHACHHANG);
            qUANNLYDONHANGDataSet.EnforceConstraints = true;

        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThai == TrangThai.ADD)
            {
                kHACHHANGBindingSource.RemoveCurrent();
            }
            
            if (trangThai == TrangThai.EDIT)
            {
                kHACHHANGBindingSource.CancelEdit();
            }    

            

            trangThai = TrangThai.NONE;
            qUANNLYDONHANGDataSet.EnforceConstraints = true;

            gridControl1.Enabled = true;
            panelControl1.Enabled = false;

            barButtonItem_Them.Enabled = true;
            barButtonItem_Xoa.Enabled = true;
            barButtonItem_Sua.Enabled = true;
            barButtonItem_Ghi.Enabled = false;
            barButtonItem_Thoat.Enabled = false;


        }

        private void barButtonItem_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThai = TrangThai.EDIT;

            barButtonItem_Them.Enabled = false;
            barButtonItem_Xoa.Enabled = false;
            barButtonItem_Sua.Enabled = false;
            barButtonItem_Ghi.Enabled = true;
            barButtonItem_Thoat.Enabled = true;

            gridControl1.Enabled = false;
            panelControl1.Enabled = true;

            qUANNLYDONHANGDataSet.EnforceConstraints = false;
            tENKHTextEdit.Focus();
        }

        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắc muốn khách hàng '" + tENKHTextEdit.Text + "'", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                kHACHHANGBindingSource.RemoveCurrent();
                kHACHHANGTableAdapter.Update(qUANNLYDONHANGDataSet.KHACHHANG);
            }
        }
    }
}
