using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class SPGHGiam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //list id current
            List<string> idTrung = (List<string>)Application["idTrung"];
            List<Class.SanPhamGioHang> listGH = (List<Class.SanPhamGioHang>)Application["listCart"];
            Class.SanPhamGioHang spHT = new Class.SanPhamGioHang();

            //get id from gioHang
            string id = Request.QueryString["id"];
            string sdt = Request.QueryString["sđt"];
            idTrung.Remove(id);

            foreach (Class.SanPhamGioHang sp in listGH)
            {
                if (sp.id == id && sp.sĐT == sdt)
                {
                    listGH.Remove(sp);
                    break;
                }
            }

            List<Class.SanPham> listSanPham = new List<Class.SanPham>();
            listSanPham = (List<Class.SanPham>)Application["DsSanPham"];
            foreach (Class.SanPham spchk in listSanPham)
            {
                if (spchk.Id == id)
                {
                    spchk.SoLuong = (spchk.SoLuong + 1);
                    break;
                }
            }

            Session["id"] = "";
            Response.Redirect("gioHang.aspx");
        }
    }
}