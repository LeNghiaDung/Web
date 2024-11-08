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
            string input = "<table>\r\n<thead>\r\n<td>Hủy</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Số lượng</td>\r\n<td>Giá</td>\r\n<td>Thành tiền</td>\r\n</thead>\r\n<tbody>\r\n";
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
                                    input += "<tr>\r\n<td><button value=\"" + spGH.id + "\" onclick=\"huysp_click(this.value)\"><img src=\"Assets/Icons/close.svg\" alt=\"huy\" class=\"huy\"/></button></td>\r\n<td><img src=\"" + spGH.hinhAnh + "\" alt=\"anh-sp\"></td>\r\n<td>" + spGH.ten + "</td>\r\n<td><input type=\"number\" value=\"" + spGH.soLuong + "\" id=\"soluong\" name=\"soluong\" value=\"1\" onchange=\"nhapsoluong(this.value)\"></td>\r\n<td>" + spGH.gia.ToString("#,### VNĐ") + "</td>\r\n<td>" + tiensp.ToString("#,### VNĐ") + "</td>\r\n</tr>\r\n";
                                }
                                input += "</tbody>\r\n</table>";
                                if (listGH == null || listGH.Count == 0)
                                {
                                    // Hiển thị thông báo hoặc xử lý khi không có sản phẩm trong danh sách
                                    Cart.InnerHtml = "<p>Không có sản phẩm nào trong danh sách.</p>";
                                    return;
                                }
                                else
                                    Cart.InnerHtml = input;
                                    totalSoLuong += spGH.soLuong;
                                    tongtienhang.InnerHtml = TongTien.ToString("#,### VNĐ");
                            }
                        }
                    }
                }
            }
        }
    }
}
