using BTLWEB.GiaoDien.ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLWEB.Class
{
    public class SoThich
    {
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string SOTHICH;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string soThich { get => SOTHICH; set => SOTHICH = value; }
        public SoThich() { }
        public SoThich(string HoTen, string NgaySinh, string GioiTinh, bool soThich)
        {
            this.hoTen = HoTen;
            this.ngaySinh = NgaySinh;
            this.gioiTinh = GioiTinh;
            this.soThich = SOTHICH;
        }

        public string HOTEN
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }
        public string NGAYSINH
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public string GIOITINH
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public string sothich
        {
            get { return this.SOTHICH; }
            set { this.SOTHICH = value; }
        }
    }
}