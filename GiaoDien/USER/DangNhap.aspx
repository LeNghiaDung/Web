<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BTLWEB.GiaoDien.USER.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link rel="stylesheet" href="../../Asset/CSS/DangNhap_Dangki.css">
</head>
<body>
    <form runat="server" id="formdangnhap" class="form" method="post" onsubmit="return check()">
        <div class="form-title">
            <!-- <a href="TrangChu.html"><i class="uil uil-arrow-left"></i></a> -->
            <p><span class="Dangkitaikhoan">Ae FITHOU</span> chào mừng bạn!</p>
        </div>
        <div class="input-container">
            <p class="input-title">Số điện thoại</p>
            <input type="text" id="txtSDT" name="txtSDT" value="" placeholder="Nhập số điện thoại đăng nhập"/>
            <div id="alertk" class="alert" name="alerttk"></div>
        </div>
        <div class="input-container">
            <p class="input-title">Mật khẩu</p>
            <input type="password" id="txtmatkhau" name="txtmatkhau" placeholder="Nhập mật khẩu"/>
            <div id="alertmk" class="alert" name="alertmk" runat="server"></div>
        </div>
        <button type="submit" id="login">
            Đăng nhập
        </button>
        <p id="signup-link">
            Chưa có tài khoản?
            <a href="DangKy.aspx">Đăng ký ngay!</a>
        </p>
    </form>
</body>
    <script>
        function check() {
            var taikhoan = document.getElementById("txtSDT").value;
            var matkhau = document.getElementById("txtmatkhau").value;
            var alerttk = document.getElementById("alertk");
            var alertmk = document.getElementById("alertmk");
            var check = true;
            if (taikhoan == "") {
                alerttk.innerHTML = "Tên đăng nhập không được để trống!";
                check = false;
            }
            else {
                alerttk.innerHTML = "";
            }
            if (matkhau == "") {
                alertmk.innerHTML = "Mật khẩu không được để trống!";
                check = false;
            }
            else {
                alertmk.innerHTML = "";
            }
            return check;
        }
    </script>
</html>
