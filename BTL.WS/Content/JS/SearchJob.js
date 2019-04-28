$(document).ready(function () {
    btn_arrowdown.show_menu($('.insert-arrowdown'));
    btn_arrowdown.show_menu($('.address-arrow'));
    select_value.change_value($('.select-time-update div'));
    select_value.change_value($('.select-salary div'));
    select_value.change_value($('.select-career div'));
    select_value.change_value($('.select-city div'));
})

var btn_arrowdown = {
    show_menu: function (a) {
        $(a).click(function () {
            $(this).siblings('div').toggle();
        });
    }
}

var select_value = {
    change_value: function (a) {
        $(a).click(function () {
            $(this).parent('div').siblings('input').val($(this).text());
            $(this).parent('div').hide();
        })
    }
}