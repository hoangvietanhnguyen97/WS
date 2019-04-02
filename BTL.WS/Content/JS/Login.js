$(document).ready(function () {
    btn_login.login();
})

var btn_login = {
    login: function () {
        $('#btn-login').click(function () {
            //alert($("#password").val());
            //debugger
            $.ajax({
                method: "GET",
                url: "http://localhost:53113/Account/get?email=" + $("#email").val(),
                async: false,
                success: function (data) {
                    
                    data.password;
                    //alert( typeof (data.password)); 
                    if (data[0].password == $("#password").val()) {
                        alert("Đăng nhập thành công");
                    }
                    else {
                        alert("Sai tên đăng nhập hoặc mật khẩu");
                    }
                },
                error: function (textStatus) {
                    alert(textStatus);
                }
            });
        })
        
    }
}