using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace BTLWEB.GiaoDien.USER
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KiemtraDangNhapGioHang();
        }
        public void KiemtraDangNhapGioHang()
        {
            //lấy user từ trong session
            User userTrongSession = (User)Session["user"];
            //nếu user null thì hiện nút đăng nhập, nếu có user thì hiện tên user
            if (userTrongSession != null)
            {
                btnDangnhap.Attributes["class"] += " hidden";//thêm class hidden để ẩn nút đăng nhập vì đã đăng nhập thành công
                tenNguoiDungDangNhap.InnerText = userTrongSession.HoVaTen;
            }
            else
            {
                tenNguoiDungDangNhap.Attributes["class"] += " hidden";
                nutDangXuat.Attributes["class"] += " hidden";
            }
        }
        public void HienSP(string cookie_value)
        {
            string input = "<table>\r\n<thead>\r\n<td>Hủy</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Số lượng</td>\r\n<td>Giá</td>\r\n<td>Thành tiền</td>\r\n</thead>\r\n<tbody>\r\n";
            string coo = cookie_value;
            string[] arr = coo.Split('_');
            double tongtien = 0;
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];
            foreach (string arr1 in arr)
            {
                string[] sp = arr1.Split('-');
                foreach (Class.SanPham sanpham in sanPhams)
                {
                    if (sp[0] == sanpham.Id.ToString())
                    {
                        double tiensp = int.Parse(sp[1]) * sanpham.Gia;
                        tongtien += tiensp;
                        input += "<tr>\r\n<td><button value=\"" + sp[0] + "\" onclick=\"huysp_click(this.value)\"><img src=\"Assets/Icons/close.svg\" alt=\"huy\" class=\"huy\"/></button></td>\r\n<td><img src=\"" + sanpham.HinhAnh + "\" alt=\"anh-sp\"></td>\r\n<td>" + sanpham.Ten + "</td>\r\n<td><input type=\"number\" value=\"" + sp[1] + "\" id=\"soluong\" name=\"soluong\" value=\"1\" onchange=\"nhapsoluong(this.value)\"></td>\r\n<td>" + sanpham.Gia + " VNĐ</td>\r\n<td>" + tiensp + " VNĐ</td>\r\n</tr>\r\n";
                    }
                }
            }
            input += "</tbody>\r\n</table>";
            cart.InnerHtml = input;
            tongtienhang.InnerHtml = tongtien.ToString();
            tongthanhtoan.InnerHtml = tongtien.ToString();
        }

    }
}