using DevExpress.XtraBars.Docking2010.Views;
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
        XtraUserControl _Control1, _Control2, _Control3, _Control4, _Control5, 
            _Control6, _Control7, _Control8, _Control9, _Control10, _Control11, 
            _Control12,_Control13, _Control14, _Control15, _Control16, _Control17, 
            _Control18, _Control19, _Control20;
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
        string tachbundleticket = "Tách bundle ticket";
        string themdautickgp = "Thêm dấu tick GP";
        string suathongtindondieudong = "Sửa thông tin đơn điều động";
        string taotaikhoanAGP = "Tạo tài khoản AGP";
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
            _Control17 = OpenControl17(tachbundleticket);
            _Control18 = OpenControl18(themdautickgp);
            _Control19 = OpenControl19(suathongtindondieudong);
            _Control20 = OpenControl20(taotaikhoanAGP);
        }
        XtraUserControl OpenControl1(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            SuaDonKyDuyet xtra = new SuaDonKyDuyet();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl2(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            KiemTraLuuTrinh xtra = new KiemTraLuuTrinh();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl3(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            CapNhatMaVatTu xtra = new CapNhatMaVatTu();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl4(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            CapNhatQCMPQ xtra = new CapNhatQCMPQ();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }

        XtraUserControl OpenControl5(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            DongMoDonHang xtra = new DongMoDonHang();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl6(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            DangXuatITS xtra = new DangXuatITS();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl7(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            LayMatKhauMoi xtra = new LayMatKhauMoi();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl8(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            KhuVucBaoVe xtra = new KhuVucBaoVe();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl9(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XoaPPASieuThi xtra = new XoaPPASieuThi();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl10(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            ThoiGianLamViec xtra = new ThoiGianLamViec();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl11(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            ThietLapQuyenHan xtra = new ThietLapQuyenHan();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl12(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            XoaInputChuyenMay xtra = new XoaInputChuyenMay();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl13(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            KhoVai xtra = new KhoVai();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl14(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            KhoPhuLieu xtra = new KhoPhuLieu();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl15(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            KhoThanhPham xtra = new KhoThanhPham();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl16(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            CatSieuThi xtra = new CatSieuThi();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl17(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            TachBundleTicket xtra = new TachBundleTicket();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl18(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            ThemTickGP xtra = new ThemTickGP();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }

        XtraUserControl OpenControl19(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            SuaThongTinDonDieuDong xtra = new SuaThongTinDonDieuDong();
            xtra.Dock = System.Windows.Forms.DockStyle.Fill;
            xtra.Parent = result;
            return result;
        }
        XtraUserControl OpenControl20(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            TaoTaiKhoanAGP xtra = new TaoTaiKhoanAGP();
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
            if (e.Element.Text == tachbundleticket)
            {
                tabbedView.AddDocument(_Control17);
                tabbedView.ActivateDocument(_Control17);
            }
            if (e.Element.Text == themdautickgp)
            {
                tabbedView.AddDocument(_Control18);
                tabbedView.ActivateDocument(_Control18);
            }
            if (e.Element.Text == suathongtindondieudong)
            {
                tabbedView.AddDocument(_Control19);
                tabbedView.ActivateDocument(_Control19);
            }
            if (e.Element.Text == taotaikhoanAGP)
            {
                tabbedView.AddDocument(_Control20);
                tabbedView.ActivateDocument(_Control20);
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
            if (e.Document.Caption == tachbundleticket) _Control17 = OpenControl17(tachbundleticket);
            if (e.Document.Caption == themdautickgp) _Control18 = OpenControl18(themdautickgp);
            if (e.Document.Caption == suathongtindondieudong) _Control19 = OpenControl19(suathongtindondieudong);
            if (e.Document.Caption == taotaikhoanAGP) _Control20 = OpenControl20(taotaikhoanAGP);
        }


    }
}
