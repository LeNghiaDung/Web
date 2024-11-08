<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="BTLWEB.GiaoDien.USER.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ĐĂNG KÍ</title>
    <link rel="stylesheet" href="../../Asset/CSS/DangNhap_Dangki.css">
</head>
<body>
    <script>
        function check() {
            var hoVaTen = document.getElementById("txtHoVaTen").value;
            var sdt = document.getElementById("sdt").value;
            var matkhau = document.getElementById("txtmatkhau").value;
            var rmatkhau = document.getElementById("txtrmatkhau").value;
            var errorHoVaTen = document.getElementById("errorHoVaTen");
            var errornumber = document.getElementById("errornumber");
            var errormatkhau = document.getElementById("errormatkhau");
            var errormatkhauNhapLai = document.getElementById("errormatkhauNhapLai");
            var check = true;
            if (hoVaTen == "") {
                errorHoVaTen.innerHTML = "Họ và tên không được để trống!";
                check = false;
            }
            else {
                errorHoVaTen.innerHTML = "";
            }
            if (sdt == "") {
                errornumber.innerHTML = "Số điện thoại không được để trống!";
                check = false;
            }
            else {
                errornumber.innerHTML = "";
            }
            if (matkhau == "") {
                errormatkhau.innerHTML = "Mật khẩu không được để trống!";
                check = false;
            }
            else {
                errormatkhau.innerHTML = "";
            }
            if (rmatkhau == "") {
                errormatkhauNhapLai.innerHTML = "Mật khẩu không được để trống!";
                check = false;
            }
            else {
                errormatkhauNhapLai.innerHTML = "";
            }
            if (matkhau != rmatkhau) {
                errormatkhauNhapLai.innerHTML = "Mật khẩu không trùng khớp!";
                check = false;
            }
            return check;
        }
    </script>
   <form runat="server" id="formdangky" class="form" method="post" onsubmit="return check()">
        <div class="form-title">
            <!-- <a href="SignIn.html"><i class="uil uil-arrow-left"></i></a> -->
            <p><span class="Dangkitaikhoan">Đăng ký</span> tài khoản!</p>
        </div>
        <div class="input-container">
            <p class="input-title">Họ và tên</p>
            <input type="text" placeholder="Nhập họ và tên" id="txtHoVaTen" name="txtHoVaTen" />
            <div id="errorHoVaTen" name="errorHoVaTen" class="alert"></div>
        </div>
        <div class="input-container">
            <p class="input-title">Số điện thoại</p>
            <input type="tel" placeholder="Nhập số điện thoại" id="sdt" name="sdt" maxlength="11" title="Ten digits code" "/>
            <div id="errornumber" name="errornumber" class="alert"></div>
        </div>
    
        <div class="input-container">
            <p class="input-title">Mật khẩu</p>
            <input type="password" placeholder="Nhập mật khẩu" id="txtmatkhau" name="txtmatkhau" />
            <div id="errormatkhau" name="errormatkhau" class="alert"></div>
        </div>
        <div class="input-container">
            <p class="input-title">Xác nhận mật khẩu</p>
            <input type="password" placeholder="Nhập mật khẩu" id="txtrmatkhau" name="txtrmatkhau" />
            <div id="errormatkhauNhapLai" name="errormatkhauNhapLai" class="alert"></div>
        </div>
        <button type="submit" id="register">
            Đăng ký
        </button>
        <p id="signin-link">
            Đã có tài khoản?
            <a href="DangNhap.aspx">Đăng nhập ngay!</a>
        </p>
    </form>
</body>
</html>
