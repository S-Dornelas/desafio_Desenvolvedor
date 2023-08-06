$(document).ready(function () {

    $('.glyphicon-calendar').closest("div.date").datepicker({
        todayBtn: "linked",
        keyboardNavigation: false,
        forceParse: false,
        calendarWeeks: false,
        format: 'dd/mm/yyyy',
        autoclose: true,
        language: 'pt-BR'
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

        let departamento = SerielizeForm($('#form'));
        let url = $('#form').attr('action');
        //debugger;

        $.ajax({
            type: "POST",
            url: url,
            data: departamento,
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

    $('#descricaoInput').on('keydown keyup change', function () {
        var minLength = 5;
        var maxLength = 20;
        var char = $(this).val();
        var charLength = $(this).val().length;
        if (charLength < minLength) {
            $('#descricaoMessage').text('Minimo de caracteres: ' + minLength);
        } else if (charLength > maxLength) {
            $('#descricaoMessage').text('Máximo de caracteres: ' + maxLength);
            $(this).val(char.substring(0, maxLength));
        } else {
            $('#descricaoMessage').text('');
        }
    });
});
