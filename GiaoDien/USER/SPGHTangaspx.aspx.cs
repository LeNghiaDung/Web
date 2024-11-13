using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class SPGHTangaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string sdt = Request.QueryString["sđt"];
            List<Class.SanPhamGioHang> listGH = (List<Class.SanPhamGioHang>)Application["listCart"];
            Class.SanPhamGioHang spHT = new Class.SanPhamGioHang();

            foreach (Class.SanPhamGioHang sp in listGH)
            {
                if (sp.id == id && sp.sĐT == sdt)
                {
                    spHT.id = id;
                    spHT.hinhAnh = sp.hinhAnh;
                    spHT.ten = sp.ten;
                    spHT.gia = sp.gia;
                    spHT.soLuong = 1;
                    spHT.sĐT = sdt;
                    break;
                }
            }

            List<Class.SanPham> listSanPham = new List<Class.SanPham>();
            listSanPham = (List<Class.SanPham>)Application["DsSanPham"];
            string id1 = Request.QueryString["id"];

            

            //Thêm sản phẩm vào danh sách giỏ hàng
            //listGH.Add(new classOJ.spGioHang(spHT.ID, spHT.IMG, spHT.TenSP, spHT.PhanLoai, spHT.MoTa, spHT.GiaSP, spHT.SoLuong, spHT.SizeSP, Session["current_email"].ToString()));

                listGH.Add(spHT);
                Application["listCart"] = listGH;

            Session["id"] = id;
            Response.Redirect("GioHang.aspx");
        }
    }
}