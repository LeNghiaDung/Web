using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class TimKiemSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KiemtraDangNhap();
            HienDSSanPhamTimKiem();
        }
        //hàm hiện ds snar phẩm theo từ khóa tìm kiếm
        public void HienDSSanPhamTimKiem()
        {
            //lấy ra tên sản phẩm từ input tìm kiếm ( phương thức get)
            string tuKhoaTimKiem = Request.QueryString.Get("search");
            if (tuKhoaTimKiem == null)
            {
                tuKhoaTimKiem = "";
            }
            //gán lai từ khóa vào ô input
            search.Value = tuKhoaTimKiem;

            //lấy ra thông tin sản phẩm từ application
            List<SanPham> listSPTrongApplication = (List<SanPham>)Application["DsSanPham"];
            //hiển thị sản phẩm mới
            int count = 0;
            string html1 = "";
            html1 += "<h1> SẢN PHẨM<strong> TÌM KIẾM</strong></h1>";
            html1 += "<div class='big_container'>";
            foreach (SanPham sp in listSPTrongApplication)
            {
                // Kiểm tra danh mục và số lượng sản phẩm đã thêm
                if (count >= 8)
                    break;
                //hiện ra những sản phẩm có tên giống với từ khóa tìm kiếm
                if (sp.Ten.ToLower().Contains(tuKhoaTimKiem.ToLower()))
                {
                    html1 += "<div class='sp_box'>";
                    html1 += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><img src='" + sp.HinhAnh + "' alt=''></a>";
                    html1 += "<div class='sp_content'>";
                    html1 += "<span>" + sp.TenDanhMuc + "</span>";
                    html1 += "<h4><a href='ChiTietSanPham.aspx?id=" + sp.Id + "'>" + sp.Ten + "</a></h4>";
                    html1 += "<h3>" + sp.Gia.ToString("#,### VNĐ") + "</h3>";
                    html1 += "</div>";
                    html1 += "<div class='cart'>";
                    html1 += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><svg style='height: 20px; width: 20px' " +
                            "xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>" +
                            "<path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>";
                    html1 += "</div>";
                    html1 += "</div>";
                    count++;
                }
            }
            html1 += "</div>";
            product1.InnerHtml = html1;
        }
        public void KiemtraDangNhap()
        {
            //lấy user từ trong session
            User userTrongSession = (User)Session["user"];
            //nếu user null thì hiện nút đăng nhập, nếu có user thì hiện tên user
            if (userTrongSession != null)
            {
                btnDangNhap.Attributes["class"] += " hidden";//thêm class hidden để ẩn nút đăng nhập vì đã đăng nhập thành công
                tenNguoiDungDangNhap.InnerText = userTrongSession.HoVaTen;
            }
            else
            {
                tenNguoiDungDangNhap.Attributes["class"] += " hidden";
                nutDangXuat.Attributes["class"] += " hidden";
            }
        }
    }
}