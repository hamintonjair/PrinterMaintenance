
var datatable;

$(document).ready(function () {
    loadDataTable();
})
function loadDataTable() {
    datatable = $('#customerDatatable').DataTable({
    });
}

//editar imoresiones 3d
$(document).on('click', '#btnEdit', function (e) {
    e.preventDefault();
    //  $(this).parent().parent().find('td').each(function(index){

    //  }),

    $(this).parent().parent().find('td').each(function (index) {


        switch (index) {
            case 0:
                $('#id').val($(this).text());
                break;
            case 1:
                $('#cliente').val($(this).text());
                break;
            case 2:
                $('#impresion3d').val($(this).text());
                break;
            case 3:
                $('#cantidad').val($(this).text());
                break;
            case 4:
                $('#_precio').val($(this).text());
                break;
            case 5:
                $('#impresora').val($(this).text());
                break;
        }

    }),

        $('#FormModalEditar').modal('show');
});

//actualizar
$(document).on('click', '#btnActualizar', function (e) {
    e.preventDefault();

    var impresion3d = {
        "Id": $("#id").val(),
        "Cliente": $("#cliente").val(),
        "Impresion3D": $("#impresion3d").val(),
        "Cantidad": $("#cantidad").val(),
        "Precio": $("#_precio").val(),
    };

    $.ajax({

        type: "POST",
        url: "/Impresion3D/Edit?handler=UpdateJson",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        headers: {
            "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
        },
        data: JSON.stringify(impresion3d),

    })
        .done(function (result) {
            Console.WriteLine(result);
            $('#FormModalEditar').modal('hide');
        })
        .fail(function (error) {
            alert(error);
        });

});
//eliminar
$(document).on("click", ".btnEliminar", function (e) {
    e.preventDefault();

    $(this).parent().parent().find('td').each(function (index) {

        switch (index) {
            case 0:
                $('#idImpresion3dEliminar').val($(this).text());
                break;
            case 1:
                $('#idNombreEliminar').val($(this).text());
                break;
        }

    });

    $('#modalEliminar').modal('show');

});

$("#btnEliminar").click(function () {

    $.ajax({
        type: "POST",
        url: "/Impresion3D/Edit?handler=Delete",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        dataType: "html",
        headers: {
            "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
        },
        data: { "Id": $("#idImpresion3dEliminar").val() },

    })
    .done(function (result) {

        eliminado();

    })
    .fail(function (error) {
        _Error();
    });
});



//alert 
function _Error() {
    Swal.fire({
        icon: 'error',
        title: 'Error',
        text: 'Se produjo un Error en el sistema',
    }),

        location.reload();
}

function eliminado() {
    Swal.fire({
        icon: 'success',
        title: 'Atencion',
        text: 'Se elimino el registro',
    }),

        location.reload();
}

//ver
$(document).on("click", ".btnVer", function (e) {
    e.preventDefault();

    $(this).parent().parent().find('td').each(function (index) {

        switch (index) {

            case 1:
                $('#VerCliente').val($(this).text());
                break;
            case 2:
                $('#verImpresion').val($(this).text());
                break;
            case 3:
                $('#verCantidad').val($(this).text());
                break;
            case 4:
                $('#verPrecio').val($(this).text());
                break;

        }
    }),
        $('#modalViewCliente').modal('show');
});


