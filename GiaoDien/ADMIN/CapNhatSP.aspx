<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CapNhatSP.aspx.cs" Inherits="BTLWEB.GiaoDien.ADMIN.CapNhatSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cập nhật sản phẩm</title>
    <link rel="stylesheet" href="../../Asset/CSS/ThemVaCapNhatSanPham.css">
</head>
<body>
    <div class="formThemSanPham">
    <h1>Thêm sản phẩm</h1>
    <form runat="server" method="post" action="XuLyThemSanPham.aspx">
        <div>
            <label for="tenSanPhamInput">Tên</label>
            <input runat="server" placeholder="Tên sản phẩm" id="tenSanPhamInput" type="text"/>
        </div>
        <div>
            <label for="moTaSanPhamInput">Mô tả</label>
            <input runat="server" placeholder="Mô tả sản phẩm" id="moTaSanPhamInput" type="text"/>
        </div>
        <div>
            <label for="giaSanPhamInput">Giá</label>
            <input runat="server"  placeholder="Giá sản phẩm" id="giaSanPhamInput" type="number"/>
        </div>
        <div>
            <label for="hinhAnhSanPhamInput">Hình ảnh<svg height="10" width="10" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512"><!--!Font Awesome Free 6.6.0 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.--><path d="M256 80c0-17.7-14.3-32-32-32s-32 14.3-32 32l0 144L48 224c-17.7 0-32 14.3-32 32s14.3 32 32 32l144 0 0 144c0 17.7 14.3 32 32 32s32-14.3 32-32l0-144 144 0c17.7 0 32-14.3 32-32s-14.3-32-32-32l-144 0 0-144z"/></svg></label>
            <asp:FileUpload runat="server" type="file" Width="0" Height="0" ID="hinhAnhSanPhamInput" name="hinhAnhSanPhamInput" />
            <span runat="server" class="urlAnhUpLoad" id="urlAnhUpLoad" name="urlAnhUpLoad"></span>
        </div>
    <div>
        <label for="danhMucSanPhamSelect">Danh mục</label>
        <select runat="server" id="danhMucSanPhamSelect">
        <option value="danhMuc1">Tai nghe có dây</option>
        <option value="danhMuc2">Tai nghe không dây</option>
        <option value="danhMuc3">Tai nghe chống ồn</option>
        </select>
    </div>
    <button class="buttonSubmitForm">Cập nhật</button>
    </form>
</div>
</body>
</html>
