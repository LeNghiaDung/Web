using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DangNhapTK();
        }
        public void DangNhapTK()
        {
            if (IsPostBack)
            {
                //lấy ra thông tin đăng nhập từ form
                string sdt = Request.Form.Get("txtSDT");
                string matKhau = Request.Form.Get("txtmatkhau");
                List<User> dsUserTrongApplication = (List<User>)Application["listUsers"];
                //so sánh xem tài khoản đăng nhập có giống với 1 trong số các user lưu trong application không
                foreach (User user in dsUserTrongApplication)
                {
                    if (user.Sdt == sdt && user.MatKhau == matKhau)
                    {
                        Session["user"] = user;//gán user đã đăgn nhập thành công vào session
                        Response.Redirect("TrangChu.aspx");
                        return;
                    }
                }
                //nếu không có tài khoản nào đăng nhập thành công thì thông báo sai tài khoản hoặc mật khẩu
                alertmk.InnerHtml = "Tài khoản hoặc mật khẩu không chính xác";
            }
        }
    }
}