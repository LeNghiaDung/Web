using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLWEB
{
    public class User
    {
        //tendangnhap, email, sdt, matkhau, quyen
        private string hoVaTen;
        private string sdt;
        private string matKhau;
        private bool isAdmin;
        //getter setter, constructor
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public User() { }
        public User(string hoVaTen, string sdt, string matKhau, bool isAdmin)
        {
            this.hoVaTen = hoVaTen;
            this.sdt = sdt;
            this.matKhau = matKhau;
            this.isAdmin = isAdmin;
        }
       
    }
}