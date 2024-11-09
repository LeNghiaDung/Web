using BTLWEB;
using BTLWEB.GiaoDien.ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KiemtraDangNhapTrangChu();
            //gọi lại danh sách sản phẩm
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];
            User user = (User)Session["User"];
            
            //hiển thị sản phẩm mới
            int count = 0;
            string html1 = "";
            html1 += "<h1> SẢN PHẨM<strong> MỚI</strong></h1> <p> Tận hưởng cảm giác nghe nhạc đỉnh cao </p>";
            html1 += "<div class='big_container'>";

            foreach (Class.SanPham sp in sanPhams)
            {
                // Kiểm tra danh mục và số lượng sản phẩm đã thêm
                if (count >= 6)
                    break;

                if (sp.TenDanhMuc == "#EarBuds" || sp.TenDanhMuc == "#HeadPhones")
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

            // hiển thị tai nghe cao cấp
            int count2 = 0;
            string html2 = "";
            html2 += "<h1> BỘ SƯU TẬP <strong>TAI NGHE CAO CẤP</ strong ></h1> <p> Các thương hiệu nổi tiếng đi cùng với chất lượng cao cấp </p>";
            html2 += "<div class='big_container'>";
            foreach (Class.SanPham sp in sanPhams)
            {
                if (count2 >= 4)
                    break;
                if ((sp.TenDanhMuc == "#EarBuds" || sp.TenDanhMuc == "#HeadPhones") && sp.Gia > 3000000)
                {
                    html2 += "<div class='sp_box'>";
                    html2 += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><img src='" + sp.HinhAnh + "' alt=''></a>";
                    html2 += "<div class='sp_content'>";
                    html2 += "<span>" + sp.TenDanhMuc + "</span>";
                    html2 += "<h4><a href='ChiTietSanPham.aspx?id=" + sp.Id + "'>" + sp.Ten + "</a></h4>";
                    html2 += "<h3>" + sp.Gia.ToString("#,### VNĐ") + "</h3>";
                    html2 += "</div>";
                    html2 += "<div class='cart'>";
                    html2 += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><svg style='height: 20px; width: 20px' " +
                            "xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>" +
                            "<path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>";
                    html2 += "</div>";
                    html2 += "</div>";
                    count2++;
                }
            }
            html2 += "</div>";
            product2.InnerHtml = html2;

            // hiển thị sản phẩm phụ kiện cho tai nghe
            int count3 = 0;
            string html3 = "";
            html3 += "<h1> PHỤ KIỆN CHO <strong>TAI NGHE</strong></h1><p> Phụ kiện thường dùng cho tai nghe</p>";
            html3 += "<div class='big_container'>";
            foreach (Class.SanPham sp in sanPhams)
            {
                if (count3 >= 4)
                    break;
                if (sp.TenDanhMuc == "#Accessory")
                {
                    html3 += "<div class='sp_box'>";
                    html3 += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><img src='" + sp.HinhAnh + "' alt=''></a>";
                    html3 += "<div class='sp_content'>";
                    html3 += "<span>" + sp.TenDanhMuc + "</span>";
                    html3 += "<h4><a href='ChiTietSanPham.aspx?id=" + sp.Id + "'>" + sp.Ten + "</a></h4>";
                    html3 += "<h3>" + sp.Gia.ToString("#,### VNĐ") + "</h3>";
                    html3 += "</div>";
                    html3 += "<div class='cart'>";
                    html3 += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><svg style='height: 20px; width: 20px' " +
                            "xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>" +
                            "<path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>";
                    html3 += "</div>";
                    html3 += "</div>";
                    count3++;
                }
            }
            html3 += "</div>";
            product3.InnerHtml = html3;
        }
        
        protected void btnSearch_click(object sender, EventArgs e)
        {
            string html = "";
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];

            if (search.Value.Trim() == "")
            {
                //string al = "alert('Nhập dữ liệu để tìm kiếm !!');";
                //ClientScript.RegisterClientScriptBlock(this.GetType(), "AlertMessage", al, true);
                html += "<div class='big_container'>";
                foreach (Class.SanPham sp in sanPhams)
                {
                    html += "<div class='sp_box'>";
                    html += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><img src='" + sp.HinhAnh + "' alt=''></a>";
                    html += "<div class='sp_content'>";
                    html += "<span>" + sp.TenDanhMuc + "</span>";
                    html += "<h4><a href='ChiTietSanPham.aspx?id=" + sp.Id + "'>" + sp.Ten + "</a></h4>";
                    html += "<h3>" + sp.Gia.ToString("#,### VNĐ") + "</h3>";
                    html += "</div>";
                    html += "<div class='cart'>";
                    html += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><svg style='height: 20px; width: 20px' " +
                            "xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>" +
                            "<path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>";
                    html += "</div>";
                    html += "</div>";
                }
                html += "</div>";
                product1.InnerHtml = html;
            }
            else
            {
                html += "<div class='big_container'>";
                foreach (Class.SanPham sp in sanPhams)
                {
                    if (search.Value.Trim() != sp.Ten) continue;

                    html += "<div class='sp_box'>";
                    html += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><img src='" + sp.HinhAnh + "' alt=''></a>";
                    html += "<div class='sp_content'>";
                    html += "<span>" + sp.TenDanhMuc + "</span>";
                    html += "<h4><a href='ChiTietSanPham.aspx?id=" + sp.Id + "'>" + sp.Ten + "</a></h4>";
                    html += "<h3>" + sp.Gia.ToString("#,### VNĐ") + "</h3>";
                    html += "</div>";
                    html += "<div class='cart'>";
                    html += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><svg style='height: 20px; width: 20px' " +
                            "xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>" +
                            "<path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>";
                    html += "</div>";
                    html += "</div>";
                }

                if (html.Trim() == "")
                {
                    string al = "alert('Không tìm thấy sản phẩm !!');";
                    //ClientScript.RegisterClientScriptBlock(this.GetType(), "AlertMessage", al, true);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "AlertMessage", al, true);
                    html += "<div class='big_container'>";
                    foreach (Class.SanPham sp in sanPhams)
                    {
                        html += "<div class='sp_box'>";
                        html += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><img src='" + sp.HinhAnh + "' alt=''></a>";
                        html += "<div class='sp_content'>";
                        html += "<span>" + sp.TenDanhMuc + "</span>";
                        html += "<h4><a href='ChiTietSanPham.aspx?id=" + sp.Id + "'>" + sp.Ten + "</a></h4>";
                        html += "<h3>" + sp.Gia.ToString("##,## VNĐ") + "</h3>";
                        html += "</div>";
                        html += "<div class='cart'>";
                        html += "<a href='ChiTietSanPham.aspx?id=" + sp.Id + "'><svg style='height: 20px; width: 20px' " +
                                "xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>" +
                                "<path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>";
                        html += "</div>";
                        html += "</div>";
                    }
                    html += "</div>";
                    product1.InnerHtml = html;
                }
                html += "</div>";
                product1.InnerHtml = html;
            }
        }
        public void KiemtraDangNhapTrangChu()
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