namespace BTLWEB.GiaoDien.USER
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="GioHang" />
    /// </summary>
    public partial class GioHang : System.Web.UI.Page
    {
        /// <summary>
        /// The Page_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            KiemtraDangNhapGioHang();
            HienSP();
        }

        /// <summary>
        /// The KiemtraDangNhapGioHang
        /// </summary>
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

        /// <summary>
        /// The HienSP
        /// </summary>
        public void HienSP()
        {
            //Danh sách các sản phảm đã thêm vào giỏ hàng
            List<string> idTrung = (List<string>)Application["idTrung"];
            List<Class.SanPhamGioHang> listGH = (List<Class.SanPhamGioHang>)Application["listCart"];
            List<Class.SanPham> sanPhams = (List<Class.SanPham>)Application["DsSanPham"];
            //Ghi nhớ những đối tượng đã được duyệt qua 
            List<string> ListIdChecked = new List<string>();
            List<string> listSizeCheck = new List<string>();
            List<Class.SanPhamGioHang> ghim = new List<Class.SanPhamGioHang>();
            // tạo bảng
            string input = "";
            int TongTien = 0;
            long totalSoLuong = 0;
            for (int i = 0; i < listGH.Count; i++)
            {
                string idCount = listGH[i].id;

                if (ListIdChecked.Contains(idCount))
                {
                    continue;
                }
                else
                {
                    //Đếm số lượng sp trùng = cách lấy hết id trùng chuyển về mảng và đếm só lượng mảng đó
                    //Phương thức LINQ trong C#
                    int soLuongId = idTrung.Where((idCheck) => idCheck == idCount).ToArray().Length;
                    int soLuongSP = listGH.Where((spCheck) => spCheck.id == idCount).ToArray().Length;
                    ListIdChecked.Add(idCount);
                    foreach (Class.SanPhamGioHang spGH in listGH)
                    {
                        //if (ghim.Contains(spGH))
                        //{  dù giống nhau nhưng so sánh đối tượng không được chính xác
                        if (ghim.Any((item) => item.id == spGH.id))
                        {
                            continue;
                        }
                        else
                        {
                            if (spGH.id == idCount)
                            {
                                ghim.Add(spGH);
                                // set số lượng cho sản phẩm giỏ hàng
                                spGH.soLuong = soLuongSP;
                                {
                                    int tiensp = (int)(spGH.soLuong * spGH.gia);
                                    TongTien += tiensp;
                                    input +=
                                        "<tr>\r\n <td> " 
                                        + $"<a href='SPGHXoa.aspx?id={spGH.id}'>"
                                        + "<svg width=\"20%\" height=\"20%\" xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 384 512\"><!--!Font Awesome Free 6.6.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.--><path d=\"M342.6 150.6c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0L192 210.7 86.6 105.4c-12.5-12.5-32.8-12.5-45.3 0s-12.5 32.8 0 45.3L146.7 256 41.4 361.4c-12.5 12.5-12.5 32.8 0 45.3s32.8 12.5 45.3 0L192 301.3 297.4 406.6c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L237.3 256 342.6 150.6z\"/></svg>'"
                                        + "</a></td>\r\n"
                                        +"<td><img src=\"" 
                                        + spGH.hinhAnh + "\" alt=\"anh-sp\"></td>\r\n<td>" 
                                        + spGH.ten 
                                        + "</td>\r\n"
                                        + " <td class='change-quantity space'>"
                                         + $" <a href = 'SPGHGiam.aspx?id={spGH.id}'>"
                                         + " <svg width=\"15%\" height=\"15%\" xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 448 512\"><!--!Font Awesome Free 6.6.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.--><path d=\"M432 256c0 17.7-14.3 32-32 32L48 288c-17.7 0-32-14.3-32-32s14.3-32 32-32l352 0c17.7 0 32 14.3 32 32z\"/></svg> "
                                         + " </a>"

                                         + $" <span id = 'text_quantity' > {spGH.soLuong} </span> "
                                         + $" <a href = 'SPGHTangaspx.aspx?id={spGH.id}'>"
                                         + " <svg width=\"15%\" height=\"15%\" xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 448 512\"><!--!Font Awesome Free 6.6.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.--><path d=\"M256 80c0-17.7-14.3-32-32-32s-32 14.3-32 32l0 144L48 224c-17.7 0-32 14.3-32 32s14.3 32 32 32l144 0 0 144c0 17.7 14.3 32 32 32s32-14.3 32-32l0-144 144 0c17.7 0 32-14.3 32-32s-14.3-32-32-32l-144 0 0-144z\"/></svg>"
                                         + " </a>"
                                         + " </td>" 
                                        + "<td>" 
                                        + spGH.gia.ToString("#,### VNĐ") 
                                        + "</td>\r\n" 
                                        +"<td>" 
                                        + tiensp.ToString("#,### VNĐ") 
                                        + "</td>\r\n</tr>\r\n";
                                }
                                if (listGH == null || listGH.Count == 0)
                                {
                                    // Hiển thị thông báo hoặc xử lý khi không có sản phẩm trong danh sách
                                    Cart.InnerHtml = "<p>Không có sản phẩm nào trong danh sách.</p>";
                                    return;
                                }
                                else
                                    //Cart.InnerHtml += input;
                                    bodySanPham.InnerHtml = input;      
                                    totalSoLuong += spGH.soLuong;
                                    tongtienhang.InnerHtml = TongTien.ToString("#,### VNĐ");
                                    tongthanhtoan.InnerHtml = TongTien.ToString("#,### VNĐ");
                            }
                        }
                    }
                }
            }
        }
        public void Huy_SP()
        {
            List<string> idTrung = (List<string>)Application["idTrung"];
            List<Class.SanPhamGioHang> listGH = (List<Class.SanPhamGioHang>)Application["listCart"];

            //get id from gioHang
            string id = Request.QueryString["id"];
            int soluong = 0;
            foreach (Class.SanPhamGioHang sp in listGH)
            {
                if (sp.id == id )
                {
                    soluong++;
                }
            }

            //remove item
            //ids.RemoveAll(i => i == id);
            listGH.RemoveAll(item => item.id == id );

            List<Class.SanPham> listSanPham = new List<Class.SanPham>();
            listSanPham = (List<Class.SanPham>)Application["DsSanPham"];
            foreach (Class.SanPham spchk in listSanPham)
            {
                if (spchk.Id == id)
                {
                    spchk.SoLuong = (spchk.SoLuong + soluong);
                    break;
                }
            }

            Session["id"] = "";
            Response.Redirect("GioHang.aspx");
        }
    }
}
