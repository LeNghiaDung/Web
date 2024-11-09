using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class SPGHXoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> idTrung = (List<string>)Application["idTrung"];
            List<Class.SanPhamGioHang> listGH = (List<Class.SanPhamGioHang>)Application["listCart"];

            //get id from gioHang
            string id = Request.QueryString["id"];
            int soluong = 0;
            foreach (Class.SanPhamGioHang sp in listGH)
            {
                if (sp.id == id)
                {
                    soluong++;
                }
            }

            //remove item
            //ids.RemoveAll(i => i == id);
            listGH.RemoveAll(item => item.id == id);

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