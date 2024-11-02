function formatsdt(format) {
  var sdt = "";
  sdt =
    format.slice(0, 4) + " " + format.slice(4, 7) + " " + format.slice(7, 10);
  return sdt;
}

function check() {
  //var cccd = document.getElementById("txtcccd");
  var gmail = document.getElementById("txtgmail");
  var pnumber = document.getElementById("sdt");
  var taikhoan = document.getElementById("txttaikhoan");
  var matkhau = document.getElementById("txtmatkhau");
  var rmatkhau = document.getElementById("txtrmatkhau");
  var diachi = document.getElementById("txtdiachi");

  //var alcccd = document.getElementById("alertcccd");
  var algmail = document.getElementById("alertgmail");
  var alnumber = document.getElementById("alertnumber");
  var altaikhoan = document.getElementById("alerttaikhoan");
  var almatkhau = document.getElementById("alertmatkhau");
  var alrmatkhau = document.getElementById("alertrmatkhau");
  var aldiachi = document.getElementById("alertdiachi");

  var err = 1;
  if (gmail.value == "") {
    algmail.innerHTML = "Hãy điền thông tin gmail!";
    gmail.focus();
    err = 0;
  } else {
    algmail.innerHTML = "";
  }

  if (pnumber.value == "") {
    alnumber.innerHTML = "Hãy điền thông tin số điện thoại!";
    pnumber.focus();
    err = 0;
  } else if (pnumber.value.length != 12 && isNaN(pnumber.value)) {
    alnumber.innerHTML = "Số điện thoại không hợp lệ xin hãy điền lại";
    pnumber.focus();
    err = 0;
  } else {
    alnumber.innerHTML = "";
  }

  if (taikhoan.value == "") {
    altaikhoan.innerHTML = "Hãy điền tên tài khoản!";
    taikhoan.focus();
    err = 0;
  } else {
    altaikhoan.innerHTML = "";
  }

  if (matkhau.value == "") {
    almatkhau.innerHTML = "Hãy điền mật khẩu!";
    matkhau.focus();
    err = 0;
  } else {
    almatkhau.innerHTML = "";
  }

  if (rmatkhau.value == "" || matkhau.value != rmatkhau.value) {
    alrmatkhau.innerHTML = "hãy điền lại mật khẩu!";
    rmatkhau.focus();
    err = 0;
  } else {
    alrmatkhau.innerHTML = "";
  }

  if (diachi.value == "") {
    aldiachi.innerHTML = "Hãy điền địa chỉ!";
    diachi.focus();
    err = 0;
  } else {
    aldiachi.innerHTML = "";
  }

  if (err == 0) {
    return false;
  }
}
