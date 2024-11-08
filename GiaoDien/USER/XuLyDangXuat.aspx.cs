using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class XuLyDangXuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //xóa usser trong session và chuyển về tragn đăng nhập
            Session["user"] = null;
            Response.Redirect("DangNhap.aspx");
        }
    }
}