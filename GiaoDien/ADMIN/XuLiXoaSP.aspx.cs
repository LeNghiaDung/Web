using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.ADMIN
{
    public partial class XuLiXoaSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy ra ID cần xóa
            string id = Request.QueryString.Get("id");
            List<Class.SanPham> listSanPham = (List<Class.SanPham>)Application["DSSanPham"];

            // Duyệt qua danh sách bằng vòng lặp for
            for (int i = 0; i < listSanPham.Count; i++)
            {
                if (id.Equals(listSanPham[i].Id.ToString()))
                {
                    // Xóa sản phẩm theo ID đã lấy ra
                    listSanPham.RemoveAt(i);
                    break;
                }
            }
            // Cập nhật lại danh sách trong Application
            Application["DSSanPham"] = listSanPham;
            // Chuyển hướng về trang Admin để làm mới danh sách
            Response.Redirect("Admin.aspx");
        }
    }
}