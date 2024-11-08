using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLWEB.Class
{
    public class SanPham
    {
        //id, ten, mota, gia, hinhanh, tendanhmuc
        private string id;
        private string ten;
        private string moTa;
        private double gia;
        private string hinhAnh;
        private string tenDanhMuc;

        //getter setter, constructor
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public double Gia { get => gia; set => gia = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }

        public SanPham()
        {
        }
        public SanPham(string id, string ten, string moTa, double gia, string hinhAnh, string tenDanhMuc)
        {
            this.id = id;
            this.ten = ten;
            this.moTa = moTa;
            this.gia = gia;
            this.hinhAnh = hinhAnh;
            this.tenDanhMuc = tenDanhMuc;
        }
    }
}