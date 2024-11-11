<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhapThi.aspx.cs" Inherits="BTLWEB.GiaoDien.USER.DangNhapThi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thi</title>
    <link rel="stylesheet" href="../../Asset/CSS/style.css">
    <script src="../../Asset/js/XuliThi.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Họ tên <input type="text" name="fullname" id="fullname"><br>
        Ngày sinh <input type="date" name="dob" id="dob"><br>
        Giới tính 
        <input type="radio" name="gender" value="male" id="male"> Nam
        <input type="radio" name="gender" value="female" id="female"> Nữ<br>
        Sở thích<br>
        <input type="checkbox" name="hobby" value="DocSach" class="hobby"> Đọc Sách<br>
        <input type="checkbox" name="hobby" value="NgheNhac" class="hobby"> Nghe Nhạc<br>
        <input type="checkbox" name="hobby" value="DiDuLich" class="hobby"> Đi Du Lịch<br>
        <input type="checkbox" name="hobby" value="XemPhim" class="hobby"> Xem Phim<br>
        <input type="checkbox" name="hobby" value="Choi" class="hobby"> Chơi<br>
        Mật khẩu <input type="password" name="password" id="password"><br>
        <input type="submit" value="Đăng Nhập" name="register" onclick="return validateForm()"/>
    </div>
</form>
</body>
</html>
