using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.ADMIN
{
    public partial class CapNhatSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lấy giá trị id từ url
            string id = Request.QueryString.Get("id");
            //lấy ra list sản phẩm ở trong application
            List<SanPham> dsSanPhamTrongApplication = (List<SanPham>)Application["listSanPham"];
            //duyet forech để lấy ra sản phẩm cần cập nhật
            foreach (SanPham sp in dsSanPhamTrongApplication)
            {
                if (id.Equals(sp.Id.ToString()))
                {
                    //gán giá trị cho các control
                    tenSanPhamInput.Value = sp.Ten;
                    moTaSanPhamInput.Value = sp.MoTa;
                    giaSanPhamInput.Value = Convert.ToInt32(sp.Gia).ToString();
                    if (sp.TenDanhMuc.Equals("Tai nghe có dây"))
                    {
                        danhMucSanPhamSelect.SelectedIndex = 0;
                    }
                    else if (sp.TenDanhMuc.Equals("Tai nghe không dây"))
                    {
                        danhMucSanPhamSelect.SelectedIndex = 1;
                    }
                    if (sp.TenDanhMuc.Equals("Tai nghe chống ồn"))
                    {
                        danhMucSanPhamSelect.SelectedIndex = 2;
                    }
                    //gán đường dẫn hình ảnh
                    urlAnhUpLoad.InnerHtml = sp.HinhAnh;
                    break;
                }
            }
        }
    }
}