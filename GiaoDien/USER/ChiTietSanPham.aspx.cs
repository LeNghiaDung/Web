namespace BTLWEB.GiaoDien
{
    using BTLWEB;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ChiTietSanPham" />
    /// </summary>
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        /// <summary>
        /// Defines the idSPHienTai
        /// </summary>
        internal string idSPHienTai = "";

        /// <summary>
        /// Defines the spHT
        /// </summary>
        internal Class.SanPhamGioHang spHT = new Class.SanPhamGioHang();

        /// <summary>
        /// Defines the detailProduct
        /// </summary>
        internal Class.SanPham detailProduct = new Class.SanPham();

        /// <summary>
        /// The Page_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];
            KiemtraDangNhapChiTietSP();
            // lấy id
            string id = Request.QueryString.Get("id");

            foreach (Class.SanPham spchk in sanPhams)
            {
                if (spchk.Id == id)
                {
                    spHT.id = spchk.Id;
                    spHT.hinhAnh = spchk.HinhAnh;
                    spHT.ten = spchk.Ten;
                    spHT.gia = spchk.Gia;
                    detailProduct = spchk;
                    break;
                }
            }
            if (int.Parse(soluong.Value) < 0)
            {
                spHT.soLuong = 0;
            }
            else
            {
                spHT.soLuong = int.Parse(soluong.Value);
            }
            string tenDanhMuc = "";
            // lấy sản phầm cần tìm 
            foreach (Class.SanPham sp in sanPhams)
            {
                if (id.Equals(sp.Id.ToString()))
                {
                    // gán giá trị cho các control
                    tensp.InnerHtml = sp.Ten;
                    giasp.InnerHtml = sp.Gia.ToString("#,### VNĐ");
                    gioithieu.InnerHtml = sp.MoTa;
                    tenDanhMuc += sp.TenDanhMuc;
                    idSPHienTai += sp.Id;
                    MainImg.Attributes["src"] = sp.HinhAnh;  // Thiết lập thuộc tính src

                }
            }

            string outputHTML = "";
            int count = 0;
            // lấy ra các sản phẩm liên quan 
            foreach (Class.SanPham sp in sanPhams)
            {

                if (tenDanhMuc.Trim().Equals(sp.TenDanhMuc.ToString().Trim()) && !idSPHienTai.Equals(sp.Id.ToString()))
                {
                    outputHTML += $@"
                    <div class='sp_box'' id='sp1'>
                    <input type = 'hidden' value='pr01' />
                    <img src = {sp.HinhAnh} alt='sp1'>
                    <div class='sp_content'>
                        <span>{sp.TenDanhMuc}</span>
                        <h4>{sp.Ten}</h4>
                        <h3>{sp.Gia.ToString("#,### VNĐ")}</h3>
                    </div>
                    <div class='cart'>
                        <a href ='ChiTietSanPham.aspx?id='{sp.Id}' ><svg style='height: 20px; width: 20px'
                                xmlns='http://www.w3.org/2000/svg'
                                viewBox='0 0 576 512'><!--!Font Awesome Free 6.6.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.--><path
                                    d='M340.2 1c-3.9 2.1-5.3 7-3.2 10.8L434.6 192l-293.1 0L239 11.8c2.1-3.9 .7-8.7-3.2-10.8s-8.7-.7-10.8 3.2L123.2 192l-74.7 0L32 192 8 192c-4.4 0-8 3.6-8 8s3.6 8 8 8l28 0L99.9 463.5C107 492 132.6 512 162 512L414 512c29.4 0 55-20 62.1-48.5L540 208l28 0c4.4 0 8-3.6 8-8s-3.6-8-8-8l-24 0-16.5 0-74.7 0L351 4.2c-2.1-3.9-7-5.3-10.8-3.2zM52.5 208l471 0L460.6 459.6C455.3 481 436.1 496 414 496L162 496c-22 0-41.2-15-46.6-36.4L52.5 208zM208 296c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112zm80-8c-4.4 0-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112c0-4.4-3.6-8-8-8zm96 8c0-4.4-3.6-8-8-8s-8 3.6-8 8l0 112c0 4.4 3.6 8 8 8s8-3.6 8-8l0-112z' /></svg></a>
                    </div>
                </div>";
                    count++;
                    if (count >= 4) break;
                }
            }
            SanPhamLienQuan.InnerHtml = outputHTML;
        }

        /// <summary>
        /// The btnSearch_click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void btnSearch_click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Add_SP
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Add_SP(object sender, EventArgs e)
        {
            int slSP = 0;
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];
            User userTrongSession = (User)Session["user"];
            if (userTrongSession != null)
            {
                //Thêm sản phẩm vào danh sách giỏ hàng
                List<Class.SanPhamGioHang> listGH = (List<Class.SanPhamGioHang>)Application["listCart"];
                for (int i = 0; i < spHT.soLuong; ++i)
                {
                    listGH.Add(spHT);
                    Application["listCart"] = listGH;
                }
                List<Class.SanPham> listSanPham = new List<Class.SanPham>();
                listSanPham = (List<Class.SanPham>)Application["DsSanPham"];
                string id1 = Request.QueryString["id"];

                foreach (Class.SanPham spchk in listSanPham)
                {
                    if (spchk.Id == id1)
                    {
                        slSP = spchk.SoLuong;
                        break;
                    }
                }
                Response.Redirect("GioHang.aspx");
            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }
        }

        /// <summary>
        /// The KiemtraDangNhapChiTietSP
        /// </summary>
        public void KiemtraDangNhapChiTietSP()
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
