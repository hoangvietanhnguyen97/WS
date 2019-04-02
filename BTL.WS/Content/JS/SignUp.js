$(document).ready(function () {
    btn_signup.Signup();
});

var btn_signup = {
    Signup: function () {
        $('#btn-signup').click(function () {
            var acc = {};
            acc.firstName = $('#firstname').val();
            acc.lasrName = $('#lastname').val();
            acc.email = $('#email').val();
            acc.password = $('#password').val();
            acc.confirmPassword = $('#confirm_password').val();
            $('input[type="radio"]').click(function () {
                if ($(this).is(':checked')) {
                    var result = $(this).val();
                    if (result == 'M') {
                        acc.gender = 1;
                    } else {
                        acc.gender = 0;
                    }
                }
            });
            $.ajax({
                url: "http://localhost:53113/Account/post",
                type: "POST",
                async: false,
                data: JSON.stringify(acc),
                dataType:"json",
                success: function (data) {
                    alert("ok");
                },
                error: function (data) {
                    alert(data.status);
                }
            });
        });
    }
}