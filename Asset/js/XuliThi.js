const hobbies = document.querySelectorAll('.hobby');
hobbies.forEach(hobby => {
    hobby.addEventListener('change', function () {
        const selectedHobbies = document.querySelectorAll('.hobby:checked').length;
    });
});

function validateForm() {
    const selectedHobbies = document.querySelectorAll('.hobby:checked').length;
    if (selectedHobbies < 1 || selectedHobbies > 3) {
        alert("vui lòng chọn ít nhất 1 sở thích (Tối thiểu 1 và tối đa 3).");
        return false;
    }
    let fullname = document.getElementById("fullname").value.trim();
    if (fullname === "") {
        alert("vui lòng nhập họ tên.");
        return false;
    }
    let dob = document.getElementById("dob").value;
    if (dob === "") {
        alert("vui lòng chọn ngày sinh.");
        return false;
    }
    let gender = document.querySelector('input[name="gender"]:checked');
    if (!gender) {
        alert("vui lòng chọn giới tính.");
        return false;
    }
    let password = document.getElementById("password").value;
    if (password === "") {
        alert("vui lòng nhập mật khẩu.");
        return false;
    }
    return true;
}