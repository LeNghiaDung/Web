<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemSP.aspx.cs" Inherits="BTLWEB.GiaoDien.ADMIN.ThemSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thêm Sản Phẩm</title>
    <link rel="stylesheet" href="../../Asset/CSS/ThemVaCapNhatSanPham.css">
</head>
<body>
    <div class="formThemSanPham">
    <h1>Thêm sản phẩm</h1>
    <form runat="server" method="post">
        <div>
            <label for="tenSanPhamInput">Tên</label>
            <input placeholder="Tên sản phẩm" id="tenSanPhamInput" name="tenSanPhamInput" type="text"required/>
        </div>
        <div>
            <label for="moTaSanPhamInput">Mô tả</label>
            <input placeholder="Mô tả sản phẩm" id="moTaSanPhamInput" name="moTaSanPhamInput" type="text" required/>
        </div>
        <div>
            <label for="giaSanPhamInput">Giá</label>
            <input placeholder="Giá sản phẩm" id="giaSanPhamInput" name="giaSanPhamInput" type="number" value="0" required/>
        </div>
        <div>
            <label for="hinhAnhSanPhamInput">Hình ảnh</label>
             <asp:FileUpload runat="server" type="file" ID="hinhAnhSanPhamInput" name="hinhAnhSanPhamInput" required/>
        </div>
    <div>
       <label for="danhMucSanPhamSelect">Danh mục</label>
       <select name="danhMucSanPhamSelect" id="danhMucSanPhamSelect">
    <option value="Tai nghe có dây">Tai nghe có dây</option>
    <option value="Tai nghe không dây">Tai nghe không dây</option>
    <option value="Tai nghe chống ồn">Tai nghe chống ồn</option>
</select>
    </div>
    <button type="submit" class="buttonSubmitForm">Thêm ngay</button>
    </form>
</div>
</body>
</html>
