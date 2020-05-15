
(function ($) {
    "use strict";


    /*==================================================================
    [ Focus input ]*/
    $('.input100').each(function () {
        $(this).on('blur', function () {
            if ($(this).val().trim() != "") {
                $(this).addClass('has-val');
            }
            else {
                $(this).removeClass('has-val');
            }
        })
    })


    /*==================================================================
    [ Validate ]*/
    var input = $('.validate-input .input100');

    $('.validate-form').on('submit', function () {
        var check = true;

        for (var i = 0; i < input.length; i++) {
            var message = validate(input[i]);

            if (message != '') {
                showValidate(input[i], message);
                check = false;
            }
        }

        return check;
    });


    $('.validate-form .input100').each(function () {
        $(this).focus(function () {
            hideValidate(this);
        });
    });

    function validate(input) {
        if ($(input).attr('type') == 'email' || $(input).attr('name') == 'email') {
            if ($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                return 'Email no contiene el formato correcto';
            }
        }
        else {
            if ($(input).val().trim() == '') {
                if ($(input).attr('name') == 'username') {
                    return 'Usuario es requerido';
                }

                if ($(input).attr('name') == 'password') {
                    return 'Contraseña es requerida';
                }

                return '';
            }

            if ($(input).attr('type') == 'password' || $(input).attr('name') == 'password') {
                if ($(input).val().trim().length < 7) {
                    return 'Contraseña requiere de 6 caracteres minimo';
                }
            }

            return '';
        }
    }

    function showValidate(input, message) {
        var thisAlert = $(input).parent();

        $(thisAlert).attr('data-validate', message);
        $(thisAlert).addClass('alert-validate');
    }

    function hideValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).attr('data-validate', '');
        $(thisAlert).removeClass('alert-validate');
    }

    /*==================================================================
    [ Show pass ]*/
    var showPass = 0;
    $('.btn-show-pass').on('click', function () {
        if (showPass == 0) {
            $(this).next('input').attr('type', 'text');
            $(this).addClass('active');
            showPass = 1;
        }
        else {
            $(this).next('input').attr('type', 'password');
            $(this).removeClass('active');
            showPass = 0;
        }

    });


})(jQuery);