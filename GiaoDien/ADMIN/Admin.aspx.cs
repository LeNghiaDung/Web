using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.ADMIN
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lấy sản phẩm từ application
            List<SanPham> listSanPham = (List<SanPham>)Application["DSSanPham"];
            string outputHtml = @"
                <table>
                    <thead>
                        <tr>
                            <th>Ảnh</th>
                            <th>Tên SP</th>
                            <th>Mô tả</th>
                            <th>Danh mục</th>
                            <th>Giá bán</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>";
            // Dùng vòng lặp foreach để hiển thị từng sản phẩm
            foreach (SanPham sp in listSanPham)
            {
                outputHtml += $@"
                        <tr>
                            <td><img src='{sp.HinhAnh}' alt='{sp.Ten}' /></td>
                            <td>{sp.Ten}</td>
                            <td>{sp.MoTa}</td>
                            <td>{sp.TenDanhMuc}</td>
                            <td>{sp.Gia}</td>
<td><a href='CapNhatSp.aspx?id={sp.Id}' class='td_btnUpdate'>Sửa</a> <a href='XuLyXoaSanPham.aspx?id={sp.Id.ToString()}' class='td_btnDelete'>Xóa</a></td>
                        </tr>";
            }
            // Kết thúc HTML cho bảng
            outputHtml += @"
                    </tbody>
                </table>";
            tableSanPham.InnerHtml = outputHtml;
        }
    }
 }
