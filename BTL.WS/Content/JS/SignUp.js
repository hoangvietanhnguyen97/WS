$(document).ready(function () {
    btn_signup.Signup();
});

function Acc() {
    this.firstName = '';
    this.lastName = '';
    this.email = '';
    this.password = '';
    this.confirmPassword = '';
    this.gender = '';
    this.birthday = '';

    this.setInfor = function (firstName, lastName, email, password, confirmPassword, gender, birthday) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.password = password;
        this.confirmPassword = confirmPassword;
        this.gender = gender;
        this.birthday = birthday;
    }
}

var btn_signup = {
    Signup: function () {
        $('#btn-signup').click(function () {
            var acc = new Acc();            
            var firstname = $('#firstname').val();
            var lastname = $('#lastname').val();
            var email = $('#email').val();
            var password = $('#password').val();
            var confirm = $('#confirm_password').val();
            var birthday = new Date();
            birthday.setDate($('#day').val());
            birthday.setMonth($('#month').val());
            birthday.setFullYear($('#year').val());
            var gender = new Int32Array();
            $('input:radio[name="gender"]').change(function () {
                debugger
                if ($(this).val() == 'Female') {
                    gender = 0;
                    
                }
                else {
                    gender = 1;
                }
            });
            
            alert(gender);
            acc.setInfor();
            //$.ajax({
            //    url: "http://localhost:53113/Account/post",
            //    type: "POST",
            //    async: false,
            //    data: JSON.stringify(acc),
            //    dataType:"json",
            //    success: function (data) {
            //        alert("ok");
            //    },
            //    error: function (data) {
            //        alert(data.status);
            //    }
            //});
        });
    }
}