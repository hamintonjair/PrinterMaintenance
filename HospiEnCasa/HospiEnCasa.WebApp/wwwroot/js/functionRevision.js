
//editar imoresiones 3d
$(document).on('click','#btnEdit', function (e){
    e.preventDefault();
   //  $(this).parent().parent().find('td').each(function(index){

   //  }),
   
    $(this).parent().parent().find('td').each(function(index){

       switch(index){
           case 0:
               $('#id').val($(this).text());      
               break;
           case 1:
               $('#tecnico').val($(this).text());
               break;
           case 2:
               $('#impresora').val($(this).text());
               break;
           case 3:
               $('#estado').val($(this).text());
               break;
           case 4:
               $('#revision').val($(this).text());
               break;
           case 5:
               $('#repuesto').val($(this).text());
               break;  
            case 6:
                $('#precio').val($(this).text());
                break;
            case 7:
                $('#email').val($(this).text());
                break;  
            case 8:
                 $('#actualizacion').val($(this).text());
                 break;  
            case 9:
                 $('#detalle').val($(this).text());
                  break;
            case 10:
               $('#fecha').val($(this).text());
                  break;         
       }
     
     }),

    $('#FormModalEditarRevision'). modal('show');
});

// //actualizar
// $(document).on('click','#btnActualizar', function (e){
//    e.preventDefault();


//       var impresion3d = {
//        "Id": $("#id").val(),
//        "Cliente": $("#cliente").val(), 
//        "Impresion3D": $("#impresion3d").val(),     
//        "Cantidad": $("#cantidad").val(), 
//        "Precio": $("#precio").val(),
//        "Impresora": $("#impresora").val() 
//       };

//    $.ajax({   

//        type: "POST",
//        url: "/Impresion3D/Edit?handler=UpdateJson",
//        contentType: "application/json; charset=utf-8",
//        dataType: "html",
//        headers: {
//            "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
//        },
//         data: JSON.stringify(impresion3d),

//    })
//    . done(function (result) {
//        Console.WriteLine(result);
//        $('#FormModalEditar'). modal('hide');
//    })
//    . fail(function (error) {
//        alert(error);
//    });

// });
//eliminar
$(document).on("click",".btnEliminar", function(e){
   e.preventDefault();
   
   $(this).parent().parent().find('td').each(function(index){
       
       switch(index){
           case 0:
               $('#idTecnicoEliminar').val($(this).text());
               break;  
           case 1:
               $('#idNombreEliminar').val($(this).text());
               break;                
       } 

   });

   $('#modalEliminarRevision').modal('show');
   
});

$("#btnEliminarRevision").click(function(){
      
   $.ajax({
       type: "POST",
       url: "/Revisiones/EditRevision?handler=Delete",
       contentType: "application/x-www-form-urlencoded; charset=utf-8",
       dataType: "html",
       headers: {
           "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
       },
       data: { "Id" : $("#idTecnicoEliminar").val()},
       
   })
   .done(function (result) {
      
       eliminado();
     
   })
   .fail(function (error) {       
       _Error();
   });
});

//alert 
function _Error(){
   Swal.fire({
       icon: 'error',
       title: 'Error',
       text: 'Se produjo un Error en el sistema',      
     }),

    location.reload();
}

function eliminado(){
   Swal.fire({
       icon: 'success',
       title: 'Atencion',
       text: 'Se elimino la revisión',      
     }),

     location.reload();
}

//ver
$(document).on("click",".btnVer", function(e){
   e.preventDefault();
  
   $(this).parent().parent().find('td').each(function(index){

    switch(index){
       
        case 1:
            $('#Vertecnico').val($(this).text());
            break;
        case 2:
            $('#Verimpresora').val($(this).text());
            break;
        case 3:
            $('#Verrepuesto').val($(this).text());
            break;
        case 4:
            $('#Verprecio').val($(this).text());
            break;
        case 5:
            $('#Verfecha').val($(this).text());
            break;  
         case 6:
             $('#detalle').val($(this).text());
             break;
               
    }
    // $.ajax({
    //     type: "POST",
    //     url: "/Revisiones/Edit?handler=Delete",
    //     contentType: "application/x-www-form-urlencoded; charset=utf-8",
    //     dataType: "html",
    //     headers: {
    //         "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
    //     },
    //     data: { "Id" : $("#idTecnicoEliminar").val()},
        
    // })
  
  }),
      $('#modalViewRevisiones').modal('show');
});
