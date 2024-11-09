using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.ADMIN
{
    public partial class ThemSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)//,iểm tra trang được load lại
            {
                string ten = Request.Form.Get("tenSanPhamInput");
                string moTa = Request.Form.Get("moTaSanPhamInput");
                double gia = Convert.ToDouble(Request.Form.Get("giaSanPhamInput"));
                string hinhAnh = "";
                if (hinhAnhSanPhamInput.HasFile)
                {
                    //guid để tao 1 chuỗi random giúp tránh trùng lặp tên file
                    string fileName = "../../Assets/HinhAnh/" + Guid.NewGuid().ToString() + hinhAnhSanPhamInput.FileName;
                    string filePath = MapPath(fileName);
                    hinhAnhSanPhamInput.SaveAs(filePath);
                    hinhAnh = fileName;
                }
                string danhMuc = Request.Form.Get("danhMucSanPhamSelect");
                int SoLuong = Convert.ToInt32(Request.Form.Get("soLuongSanPhamInput"));
                List<Class.SanPham> dsSanPhamTrongApplication = (List<SanPham>)Application["DsSanPham"];
                SanPham sp = new SanPham(dsSanPhamTrongApplication.Count + "1", ten, moTa, gia, hinhAnh, danhMuc, SoLuong);
                dsSanPhamTrongApplication.Add(sp);
                Response.Redirect("Admin.aspx");
            }
        }
    }
}