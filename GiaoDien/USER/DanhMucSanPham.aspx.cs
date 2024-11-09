using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class DanhMucSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiểm tra xem có truyền tên danh mục qua get không
            //nếu không thì mặc định là tai nghe có dây
            string tenDanhMuc = Request.QueryString.Get("danh-muc");
            if (tenDanhMuc == null) tenDanhMuc = "EarBuds";
            DanhDauDanhMucDangChon(tenDanhMuc);
            HienDSSPTheoDanhMuc(tenDanhMuc);
            KiemtraDangNhap();
        }

        //hiển thị danh sách sản phẩm theo danh mục
        public void HienDSSPTheoDanhMuc(string tenDanhMuc)
        {
            List<SanPham> listSanPhamTrongApplication = (List<SanPham>)Application["DsSanPham"];
            //duyệt vòng for để lấy ra những sản phẩm theo danh mục 
            string htmlOutput = "";
            foreach (SanPham sp in listSanPhamTrongApplication)
            {
                if (sp.TenDanhMuc.Equals("#" + tenDanhMuc))
                {
                    htmlOutput += $@"
                        <div class='sp_box' id='sp1'>
                          <a href='ChiTietSanPham.aspx?id={sp.Id}'>
                            <img class='sp_img' src='{sp.HinhAnh}' alt='sp1' />
                            <div class='sp_content'>
                                <span>{sp.TenDanhMuc}</span>
                                <h4>{sp.Ten}</h4>
                                <h3>{sp.Gia} VNĐ</h3>
                            </div>
                            </a>
                            <div class='cart'>
                                    <svg style='height: 20px; width: 20px' xmlns='http://www.w3.org/2000/svg' viewBox='0 0 576 512'>
                                        <path d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s-3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' />
                                    </svg>
                            </div>
                        </div>";
                }
            }
            //gán html vào div danh sách sản phẩm
            listsanPhamTheoDanhMuc.InnerHtml = htmlOutput;
        }
        //đánh dấu danh mục đang chọn
        public void DanhDauDanhMucDangChon(string tenDanhMuc)
        {
            if (tenDanhMuc.Equals("EarBuds"))
            {
                //add class active cho danhMucTaiNgheCoDay
                danhMucTaiNgheCoDay.Attributes["class"] += " active";
                //chỉnh lại tiêu đè và mô tả của danh mục đang chọn
                danhMucDangChon.InnerHtml = "Tai nghe có dây";
                moTaDanhMucDangChon.InnerHtml = " Mang lại cảm giác nghe nhạc tuyệt vời, âm thanh sống động";
                return;
            }
            else if (tenDanhMuc.Equals("HeadPhones"))
            {
                //add class active cho danhMucTaiNgheKhongDay
                danhMucTaiNgheKhongDay.Attributes["class"] += " active";
                danhMucDangChon.InnerHtml = "Tai nghe không dây";
                moTaDanhMucDangChon.InnerHtml = "Mang lại trải nghiệm âm thah sống động mà không lo vướng víu";
                return;
            }
            else if (tenDanhMuc.Equals("Accessory"))
            {
                //add class active cho danhMucTaiNgheChongOn
                phuKienTaiNghe.Attributes["class"] += " active";
                danhMucDangChon.InnerHtml = "Phụ kiện tai nghe";
                moTaDanhMucDangChon.InnerHtml = "Tận hưởng không gian yên tĩnh với những chiếc tai nghe chống ồn";
                return;
            }
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