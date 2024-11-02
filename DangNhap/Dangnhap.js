function check() {
  var taikhoan = document.getElementById("txttaikhoan");
  var matkhau = document.getElementById("txtmatkhau");
  var alttk = document.getElementById("alertk");
  var altmk = document.getElementById("alertmk");
  var err = 0;
  if (taikhoan.value == "") {
    alttk.innerHTML = "Bạn chưa nhập tên đăng nhập hoặc email!";
    taikhoan.focus();
  } else {
    alttk.innerHTML = "";
  }
  if (matkhau.value == "") {
    altmk.innerHTML = "Bạn chưa nhập mật khẩu!";
    matkhau.focus();
  } else {
    altmk.innerHTML = "";
  }
  if (taikhoan.value == "" || matkhau.value == "") {
    return false;
  }
}
