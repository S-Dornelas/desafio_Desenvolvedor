$(document).ready(function () {
    var date = new Date();
    date.setDate(date.getDate());
    $('.glyphicon-calendar').closest("div.date").datepicker({
        todayBtn: "linked",
        keyboardNavigation: false,
        forceParse: false,
        calendarWeeks: false,
        format: 'dd/mm/yyyy',
        autoclose: true,
        language: 'pt-BR',
        startDate: date
    });

    $('#btnCancelar').click(function () {
        Swal.fire({
            html: "Deseja cancelar essa operação? O registro não será salvo.",
            type: "warning",
            showCancelButton: true,
        }).then(function (result) {
            if (result.value) {
                history.back();
            } else {
                console.log("Cancelou a inclusão.");
            }
        });
    });

    $('#btnSalvar').click(function () {

        if ($('#form').valid() != true) {
            FormularioInvalidoAlert();
            return;
        }

        let chamado = SerielizeForm($('#form'));
        let url = $('#form').attr('action');
        //debugger;

        $.ajax({
            type: "POST",
            url: url,
            data: chamado,
            success: function (result) {

                Swal.fire({
                    type: result.Type,
                    title: result.Title,
                    text: result.Message,
                }).then(function () {
                    window.location.href = config.contextPath + result.Controller + '/' + result.Action;
                });

            },
            error: function (result) {

                Swal.fire({
                    text: result,
                    confirmButtonText: 'OK',
                    icon: 'error'
                });

            },
        });
    });

    $('#assuntoInput').on('keydown keyup change', function () {
        var minLength = 10;
        var maxLength = 80;
        var char = $(this).val();
        var charLength = $(this).val().length;
        if (charLength < minLength) {
            $('#assuntoMessage').text('Minimo de caracteres: ' + minLength);
        } else if (charLength > maxLength) {
            $('#assuntoMessage').text('Máximo de caracteres: ' + maxLength);
            $(this).val(char.substring(0, maxLength));
        } else {
            $('#assuntoMessage').text('');
        }
    });

    $('#solicitanteInput').on('keydown keyup change', function () {
        var minLength = 10;
        var maxLength = 30;
        var char = $(this).val();
        var charLength = $(this).val().length;
        if (charLength < minLength) {
            $('#solicitanteMessage').text('Minimo de caracteres: ' + minLength);
        } else if (charLength > maxLength) {
            $('#solicitanteMessage').text('Máximo de caracteres: ' + maxLength);
            $(this).val(char.substring(0, maxLength));
        } else {
            $('#solicitanteMessage').text('');
        }
    });
});
