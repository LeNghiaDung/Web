
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTLWEB
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Application sản phẩm
            Application["DsSanPham"] = new List<Class.SanPham>();
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];

            Class.SanPham sp1 = new Class.SanPham();
            sp1.Id = "1";
            sp1.Ten = "Meizu True Wireless 3";
            sp1.MoTa = "Tai nghe không dây Meizu True Wireless 3 với chất lượng âm thanh tuyệt vời và thời lượng pin lâu dài.";
            sp1.Gia = 2000000;
            sp1.HinhAnh = "/Asset/TAINGUYENSANPHAM/sp1.jpg";
            sp1.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp1);

            Class.SanPham sp2 = new Class.SanPham();
            sp2.Id = "2";
            sp2.Ten = "Sony WF-1000XM4";
            sp2.MoTa = "Tai nghe không dây Sony WF-1000XM4 với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp2.Gia = 3000000;
            sp2.HinhAnh = "Asset/TAINGUYENSANPHAM/sp2.jpg";
            sp2.TenDanhMuc = "#HeadPhones";
            sanPhams.Add(sp2);

            Class.SanPham sp3 = new Class.SanPham();
            sp3.Id = "3";
            sp3.Ten = "JBL QuanTum 600";
            sp3.MoTa = "Tai nghe không dây JBL QuanTum 600 với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp3.Gia = 1500000;
            sp3.HinhAnh = "Asset/TAINGUYENSANPHAM/sp3.jpg";
            sp3.TenDanhMuc = "#HeadPhones";
            sanPhams.Add(sp3);

            Class.SanPham sp4 = new Class.SanPham();
            sp4.Id = "4";
            sp4.Ten = "Sony WH-1000XM4";
            sp4.MoTa = "Tai nghe không dây Sony WH-1000XM4 với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp4.Gia = 5500000;
            sp4.HinhAnh = "Asset/TAINGUYENSANPHAM/sp4.jpg";
            sp4.TenDanhMuc = "#HeadPhones";
            sanPhams.Add(sp4);

            Class.SanPham sp5 = new Class.SanPham();
            sp5.Id = "5";
            sp5.Ten = "Bose Quite Comfor";
            sp5.MoTa = "Tai nghe không dây Bose Quite Comfor với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp5.Gia = 3500000;
            sp5.HinhAnh = "Asset/TAINGUYENSANPHAM/sp5.jpg";
            sp5.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp5);

            Class.SanPham sp6 = new Class.SanPham();
            sp6.Id = "6";
            sp6.Ten = "Samsung Galaxy Buds 3 Pro";
            sp6.MoTa = "Tai nghe không dây Samsung Galaxy Buds 3 Pro với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp6.Gia = 6500000;
            sp6.HinhAnh = "Asset/TAINGUYENSANPHAM/sp6.jpg";
            sp6.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp6);

            Class.SanPham sp7 = new Class.SanPham();
            sp7.Id = "7";
            sp7.Ten = "Jabra Engage 65";
            sp7.MoTa = "Tai nghe không dây Jabra Engage 65 với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp7.Gia = 2000000;
            sp7.HinhAnh = "Asset/TAINGUYENSANPHAM/sp7.jpg";
            sp7.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp7);

            Class.SanPham sp8 = new Class.SanPham();
            sp8.Id = "8";
            sp8.Ten = "Marshall Earbuds";
            sp8.MoTa = "Tai nghe không dây Marshall Earbuds với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp8.Gia = 1500000;
            sp8.HinhAnh = "Asset/TAINGUYENSANPHAM/sp8.jpg";
            sp8.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp8);

            Class.SanPham sp9 = new Class.SanPham();
            sp9.Id = "9";
            sp9.Ten = "Marshall Major IV";
            sp9.MoTa = "Tai nghe không dây Marshall Major IV với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp9.Gia = 3000000;
            sp9.HinhAnh = "Asset/TAINGUYENSANPHAM/sp9.jpg";
            sp9.TenDanhMuc = "#HeadPhones";
            sanPhams.Add(sp9);

            Class.SanPham sp10 = new Class.SanPham();
            sp10.Id = "10";
            sp10.Ten = "Xiaomi Air 2";
            sp10.MoTa = "Tai nghe không dây Xiaomi Air 2 với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp10.Gia = 2000000;
            sp10.HinhAnh = "Asset/TAINGUYENSANPHAM/sp10.jpg";
            sp10.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp10);

            Class.SanPham sp11 = new Class.SanPham();
            sp11.Id = "11";
            sp11.Ten = "Xiaomi Redmi Buds 3 Pro";
            sp11.MoTa = "Tai nghe không dây Xiaomi Redmi Buds 3 Pro với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp11.Gia = 1500000;
            sp11.HinhAnh = "Asset/TAINGUYENSANPHAM/sp11.jpg";
            sp11.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp11);

            Class.SanPham sp12 = new Class.SanPham();
            sp12.Id = "12";
            sp12.Ten = "AirPod Pro 2";
            sp12.MoTa = "Tai nghe không dây AirPod Pro 2 với chất lượng âm thanh tuyệt vời và chống ồn tốt.";
            sp12.Gia = 3500000;
            sp12.HinhAnh = "Asset/TAINGUYENSANPHAM/sp12.jpg";
            sp12.TenDanhMuc = "#EarBuds";
            sanPhams.Add(sp12);

            Class.SanPham sp13 = new Class.SanPham();
            sp13.Id = "13";
            sp13.Ten = "Vỏ đựng ốp Case Robot";
            sp13.MoTa = "Vỏ đựng ốp Case Robot cho tai nghe AirPods Pro 2.";
            sp13.Gia = 500000;
            sp13.HinhAnh = "Asset/TAINGUYENSANPHAM/sp13.jpg";
            sp13.TenDanhMuc = "#HeadPhones";
            sanPhams.Add(sp13);

            Class.SanPham sp14 = new Class.SanPham();
            sp14.Id = "14";
            sp14.Ten = "Miếng đệm tai Silicone cho tai nghe";
            sp14.MoTa = "Miếng đệm tai Silicone cho tai nghe AirPods Pro 2.";
            sp14.Gia = 200000;
            sp14.HinhAnh = "Asset/TAINGUYENSANPHAM/sp14.jpg";
            sp14.TenDanhMuc = "#HeadPhones";
            sanPhams.Add(sp14);

            Class.SanPham sp15 = new Class.SanPham();
            sp15.Id = "15";
            sp15.Ten = "Vỏ đựng ốp Case Robot";
            sp15.MoTa = "Vỏ đựng ốp Case Robot cho tai nghe AirPods Pro 2.";
            sp15.Gia = 500000;
            sp15.HinhAnh = "/Asset/TAINGUYENSANPHAM/pk4.jpg";
            sp15.TenDanhMuc = "#Accessory";
            sanPhams.Add(sp15);

            Class.SanPham sp16 = new Class.SanPham();
            sp16.Id = "16";
            sp16.Ten = "Miếng đệm tai Silicone cho tai nghe";
            sp16.MoTa = "Miếng đệm tai Silicone cho tai nghe AirPods Pro 2.";
            sp16.Gia = 200000;
            sp16.HinhAnh = "/Asset/TAINGUYENSANPHAM/pk2.png";
            sp16.TenDanhMuc = "#Accessory";
            sanPhams.Add(sp16);

            Class.SanPham sp17 = new Class.SanPham();
            sp17.Id = "17";
            sp17.Ten = "Hộp đựng tai nghe cao cấp";
            sp17.MoTa = "Hộp đựng tai nghe cao cấp cho tai nghe AirPods Pro 2.";
            sp17.Gia = 500000;
            sp17.HinhAnh = "/Asset/TAINGUYENSANPHAM/pk3.jpg";
            sp17.TenDanhMuc = "#Accessory";
            sanPhams.Add(sp17);

            Class.SanPham sp18 = new Class.SanPham();
            sp18.Id = "18";
            sp18.Ten = "Vỏ đựng ốp case Robot đẹp mắt";
            sp18.MoTa = "Vỏ đựng ốp case Robot đẹp mắt cho tai nghe AirPods Pro 2.";
            sp18.Gia = 500000;
            sp18.HinhAnh = "/Asset/TAINGUYENSANPHAM/pk1.jpg";
            sp18.TenDanhMuc = "#Accessory";
            sanPhams.Add(sp18);


            // Danh sách sản phẩm trong giỏ hàng ==============
            Application["listCart"] = new List<Class.SanPhamGioHang>();
            Application["listCart1"] = new List<Class.SanPhamGioHang>();
            Application["idSPHT"] = new List<string>();
            Application["idTrung"] = new List<string>();
            //list user
            List<User> listUser = new List<User>();
            //them sẵn 1 tk user 1 tk admin
            listUser.Add(new User("admin", "1234567890", "admin", true));
            listUser.Add(new User("Trần Minh Hiếu", "0348921209", "tranminhhieu", false));
            Application["listUsers"] = listUser;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["SanPham"] = new Class.SanPham();
            //tạo session lưu trữ  user đang đăng nhập
            Session["user"] = null;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}