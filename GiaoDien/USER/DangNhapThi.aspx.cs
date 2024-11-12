using BTLWEB.Class;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWEB.GiaoDien.USER
{
    public partial class DangNhapThi : System.Web.UI.Page
    {
        private string inputHoTen;
        private string inputNS;
        private string inputGioiTinh;
        private string inputST;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    inputHoTen = Request.Form["fullname"];
            //    inputNS = Request.Form["dob"];
            //    inputGioiTinh = Request.Form["gender"];
            //    inputST = Request.Form["hobby"];

            //    SoThich[] dshobby = Application["danhsach"] as SoThich[];
            //    if (dshobby == null)
            //    {
            //        dshobby = new SoThich[1];
            //    }
            //    else
            //    {
            //        Array.Resize(ref dshobby, dshobby.Length + 1);
            //    }

            //    //dshobby[dshobby.Length - 1] = new soThich(inputHoTen, inputNS, inputGioiTinh, in );
            //    Application["danhsach"] = dshobby;

            //    //Session["render"] = render();
            //    Response.Write("Danh sách");
            //    form1.InnerHtml = Session["render"].ToString();
            //}
            //public string render()
            //{
            //    string res = "";

            //    SoThich[] dshobby = Application["danhsach"] as SoThich[];

            //    res += "<table border='1'>";
            //    for (int i = 0; i < dshobby.Length; i++)
            //    {
            //        if (dshobby[i] != null)
            //        {
            //            res += "<tr>";
            //            res += "<th>" + "Mã NV" + "</th>";
            //            res += "<th>" + "Họ Tên" + "</th>";
            //            res += "<th>" + "Năm Sinh" + "</th>";
            //            res += "<th>" + "Giới Tính" + "</th>";
            //            res += "<th>" + "Địa Chỉ" + "</th>";
            //            res += "</tr>";
            //            res += "<tr>";
            //            res += "<th>" + dshobby[i].HOTEN + "</th>";
            //            res += "<th>" + dshobby[i].NgaySinh + "</th>";
            //            res += "<th>" + dshobby[i].GioiTinh + "</th>";
            //            res += "</tr>";
            //        }

            //    }
            //    res += "</table>";

            //    return res;
            //}
        }
    }
}