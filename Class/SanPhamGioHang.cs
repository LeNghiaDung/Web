using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLWEB.Class
{
    public class SanPhamGioHang
    {
        private string Id;
        private string HinhAnh;
        private string Ten;
        private double Gia;
        private int SoLuong;
        private double ThanhTien;

        public SanPhamGioHang() { }

        public SanPhamGioHang(string Id, string HinhAnh, string Ten, double Gia, int SoLuong, double ThanhTien)
        {
            this.Id = Id;
            this.HinhAnh = HinhAnh;
            this.Ten = Ten;
            this.Gia = Gia;
            this.SoLuong = SoLuong;
            this.ThanhTien = ThanhTien;
        }

        public string id { get => Id; set => Id = value; }
        public string hinhAnh { get => HinhAnh; set => HinhAnh = value; }
        public string ten { get => Ten; set => Ten = value; }
        public double gia { get => Gia; set => Gia = value; }
        public int soLuong { get => SoLuong; set => SoLuong = value; }
        public double thanhTien { get => ThanhTien; set => ThanhTien = value; }

    }
}