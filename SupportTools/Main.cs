﻿using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTools
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        XtraUserControl _Control1,_Control2, _Control3,_Control4,_Control5,_Control6,_Control7,_Control8,_Control9,_Control10,_Control11,_Control12;
        XtraUserControl _Control13, _Control14, _Control15, _Control16;
        string suadonkyduyet = "Sửa đơn ký duyệt";
        string kiemtraluutrinh = "Kiểm tra lưu trình";
        string capnhatmavattu = "Cập nhật mã vật tư";
        string capnhatQCMPQ = "Cập nhật QC MPQ";
        string dongmodonhang = "Đóng mở đơn hàng";
        string dangxuatITS = "Đăng xuất ITS";
        string laymatkhaumoi = "Lấy mật khẩu mới";
        string khuvucbaove = "Khu vực bảo vệ";
        string xoaPPAsieuthi = "Xóa PPA siêu thị";
        string thoigianlamviec = "Thời gian làm việc";
        string thietlapquyenhan = "Thiết lập quyền hạn";
        string xoainputchuyenmay = "Xóa input chuyền may";
        string khovai = "Kho vải";
        string khophulieu = "Kho phụ liệu";
        string khothanhpham = "Kho thành phẩm";
        string catsieuthi = "Cắt siêu thị";
        public Main()
        {
            InitializeComponent();
            _Control1 = OpenControl1(suadonkyduyet);
            _Control2 = OpenControl2(kiemtraluutrinh);
            _Control3 = OpenControl3(capnhatmavattu);
            _Control4 = OpenControl4(capnhatQCMPQ);
            _Control5 = OpenControl5(dongmodonhang);
            _Control6 = OpenControl6(dangxuatITS);
            _Control7 = OpenControl7(laymatkhaumoi); 
            _Control8 = OpenControl8(khuvucbaove);
            _Control9 = OpenControl9(xoaPPAsieuthi);
            _Control10 = OpenControl10(thoigianlamviec);
            _Control11 = OpenControl11(thietlapquyenhan);
            _Control12 = OpenControl12(xoainputchuyenmay);
            _Control13 = OpenControl13(khovai);
            _Control14 = OpenControl14(khophulieu);
            _Control15 = OpenControl15(khothanhpham);
            _Control16 = OpenControl16(catsieuthi);

        }
        XtraUserControl OpenControl1(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl1 xtra = new XtraControl1();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl2(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl2 xtra = new XtraControl2();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl3(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl3 xtra = new XtraControl3();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl4(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl4 xtra = new XtraControl4();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }

        XtraUserControl OpenControl5(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl5 xtra = new XtraControl5();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl6(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl6 xtra = new XtraControl6();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl7(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl7 xtra = new XtraControl7();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl8(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl8 xtra = new XtraControl8();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl9(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl9 xtra = new XtraControl9();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl10(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl10 xtra = new XtraControl10();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl11(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl11 xtra = new XtraControl11();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl12(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl12 xtra = new XtraControl12();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl13(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl13 xtra = new XtraControl13();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl14(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl14 xtra = new XtraControl14();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl15(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl15 xtra = new XtraControl15();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl16(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XtraControl16 xtra = new XtraControl16();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        private void accordionControl_SelectedElementChanged(object sender, DevExpress.XtraBars.Navigation.SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            if (e.Element.Text == suadonkyduyet)
            {
                tabbedView.AddDocument(_Control1);
                tabbedView.ActivateDocument(_Control1);
            }
            if (e.Element.Text == kiemtraluutrinh)
            {
                tabbedView.AddDocument(_Control2);
                tabbedView.ActivateDocument(_Control2);
            }
            if (e.Element.Text == capnhatmavattu)
            {
                tabbedView.AddDocument(_Control3);
                tabbedView.ActivateDocument(_Control3);
            }
            if (e.Element.Text == capnhatQCMPQ)
            {
                tabbedView.AddDocument(_Control4);
                tabbedView.ActivateDocument(_Control4);
            }
            if (e.Element.Text == dongmodonhang)
            {
                tabbedView.AddDocument(_Control5);
                tabbedView.ActivateDocument(_Control5);
            }
            if (e.Element.Text == dangxuatITS)
            {
                tabbedView.AddDocument(_Control6);
                tabbedView.ActivateDocument(_Control6);
            }
            if (e.Element.Text == laymatkhaumoi)
            {
                tabbedView.AddDocument(_Control7);
                tabbedView.ActivateDocument(_Control7);
            }
            if (e.Element.Text == khuvucbaove)
            {
                tabbedView.AddDocument(_Control8);
                tabbedView.ActivateDocument(_Control8);
            }
            if (e.Element.Text == xoaPPAsieuthi)
            {
                tabbedView.AddDocument(_Control9);
                tabbedView.ActivateDocument(_Control9);
            }
            if (e.Element.Text == thoigianlamviec)
            {
                tabbedView.AddDocument(_Control10);
                tabbedView.ActivateDocument(_Control10);
            }
            if (e.Element.Text == thietlapquyenhan)
            {
                tabbedView.AddDocument(_Control11);
                tabbedView.ActivateDocument(_Control11);
            }
            if (e.Element.Text == xoainputchuyenmay)
            {
                tabbedView.AddDocument(_Control12);
                tabbedView.ActivateDocument(_Control12);
            }
            if (e.Element.Text == khovai)
            {
                tabbedView.AddDocument(_Control13);
                tabbedView.ActivateDocument(_Control13);
            }
            if (e.Element.Text == khophulieu)
            {
                tabbedView.AddDocument(_Control14);
                tabbedView.ActivateDocument(_Control14);
            }
            if (e.Element.Text == khothanhpham)
            {
                tabbedView.AddDocument(_Control15);
                tabbedView.ActivateDocument(_Control15);
            }
            if (e.Element.Text == catsieuthi)
            {
                tabbedView.AddDocument(_Control16);
                tabbedView.ActivateDocument(_Control16);
            }
        }

        private void tabbedView_DocumentClosed(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            if (e.Document.Caption == suadonkyduyet) _Control1 = OpenControl1(suadonkyduyet);
            if (e.Document.Caption == kiemtraluutrinh) _Control2 = OpenControl2(kiemtraluutrinh);
            if (e.Document.Caption == capnhatmavattu) _Control3 = OpenControl3(capnhatmavattu);
            if (e.Document.Caption == capnhatQCMPQ) _Control4 = OpenControl4(capnhatQCMPQ);
            if (e.Document.Caption == dongmodonhang) _Control5 = OpenControl5(dongmodonhang);
            if (e.Document.Caption == dangxuatITS) _Control6 = OpenControl6(dangxuatITS);
            if (e.Document.Caption == laymatkhaumoi) _Control7 = OpenControl7(laymatkhaumoi);
            if (e.Document.Caption == khuvucbaove) _Control8 = OpenControl8(khuvucbaove);
            if (e.Document.Caption == xoaPPAsieuthi) _Control9 = OpenControl9(xoaPPAsieuthi);
            if (e.Document.Caption == thoigianlamviec) _Control10 = OpenControl10(thoigianlamviec);
            if (e.Document.Caption == thietlapquyenhan) _Control11 = OpenControl11(thietlapquyenhan);
            if (e.Document.Caption == xoainputchuyenmay) _Control12 = OpenControl12(xoainputchuyenmay);
            if (e.Document.Caption == khovai) _Control13 = OpenControl13(khovai);
            if (e.Document.Caption == khophulieu) _Control14 = OpenControl14(khophulieu);
            if (e.Document.Caption == khothanhpham) _Control15 = OpenControl15(khothanhpham);
            if (e.Document.Caption == catsieuthi) _Control16 = OpenControl16(catsieuthi);


        }


    }
}
