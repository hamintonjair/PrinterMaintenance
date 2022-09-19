
var datatable;

$(document).ready(function(){
    loadDataTable();
 
})
// function loadDataTable(){
//     datatable = $('#customerDatatable').DataTable({       
//     });
// }

//  $(document).on('click','.btnEdit', function (e){
//      e.preventDefault();
//      //el padre de la columna y de la fila parent
//      var id = $(this).attr("rl");  

//      if(id == "")
//      {
//        alert("Id rol required")
//      }
//      else
//      {
//          $.ajax({
//           url:  "/Impresion3D/GestionImpresion3D?handler=Update" +id,
//           contentType: "application/json; charset=utf-8",
//           dataType: "html",
//           headers: {
//             "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
//         },
//          data: JSON.stringify(impresion3d),
//             })
//             .done(function (result) {
//                 alert(result);
//                 console.log(result);
//                 location.reload();
//             })
//             .fail(function (error) {
//                 console.log(result);
//                 alert(error);
//             });
     
//        }
 
//     //  $(this).parent().parent().find('td').each(function(index){
//     //     switch(index){
//     //         case 0:
//     //             $('#id').val($(this).text());

      
//     //             break;
//     //         case 1:
//     //             $('#cliente').val($(this).text());
//     //             break;
//     //         case 2:
//     //             $('#impresion3d').val($(this).text());
//     //             break;
//     //         case 3:
//     //             $('#cantidad').val($(this).text());
//     //             break;
//     //         case 4:
//     //             $('#precio').val($(this).text());
//     //             break;
           
//     //     }

//     //  }),

//      $('#FormModalEditar'). modal('show');
//  });

// $(document).on('fnActualizar')

// $(document).on('FormModal1', function (e){
//     e.preventDefaul();

//     var estudio = { "Id": $("#Id").val(), "NivelEstudio": $("#nivelEstudio").val() }
   
//     $.ajax({   

//         type: 'POST',
//         url: "/Personas/GestionPersona?handler=CreateStudios",
//         contentType: "application/json; charset=utf-8",
//         dataType: "html",
//         headers: {
//             "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
//         },
//         data: JSON.stringify(estudio),
//     })
//     . done(function (result) {
//         alert(result);
//         location. reload();
//     })
//     . fail(function (error) {
//         alert(error);
//     });

//  });

//  $().ready(function(){
    
//     $("#FormModal1").validate({

//         reglas : {
//             nivelEstudio : {
//                 requerido: true,
//                 minlength: 7,
//                 maxlenght: 30,
//             },
//         },
//         mensajes : {
//             nivelEstudio: {
//                 requerido: "El nivel de estudio es requerido",
//                 minlength: "El nivel de estudio tener mínimo 7 caracteres",
//                 maxlength: "El  nivel de estudio debe tener máximo 30 caracteres",
//             },
//         }
//     });

//  });

// $(). ready(función() {

//     $("#form-registro"). on(enviar, función(e)){
//         e.preventDefault(); 
//     });

//     $("#form-registro"). validar({
//         errorClass: "invalid",
//         validClass: "éxito",
//         reglas: {
//             nombre : {
//                 requerido: true,
//                 minlength: 3,
//                 maxlenght: 50,
//             },
//             apellido : {
//                 requerido: true,
//                 minlength: 3,
//                 maxlenght: 50,
//             },
//             telefono: {
//                 requerido: true,
//                 número: verdadero,
//                 mín.: 3000000000,
//                 máx.: 3999999999,
//             },
//             genero: {
//                 requerido: true,
//             },
//             discriminador: {
//                 requerido: true,
//             },
//         },
//         mensajes : {
//             nombre: {
//                 requerido: "El nombre es requerido",
//                 minlength: "El nombre debe tener mínimo 3 caracteres",
//                 maxlength: "El nombre debe tener máximo 50 caracteres",,
//             },
//             apellido: {
//                 requerido: "El apellido es requerido",
//                 minlength: "El apellido debe tener mínimo 3 caracteres",
//                 maxlength: "El apellido debe tener máximo 50 caracteres",,
//             },
//             telefono: {
//                 requerido: "El número de teléfono es requerido",,
//                 número: "Debe ingresar solo números",
//                 min: "El número teléfonico debe ser mayor a 3000000000",
//                 max: "El número teléfonico debe ser menor a 3999999999",
//             },
//             genero: {
//                 requerido: "El genero es requerido",,
//             },
//             discriminador: {
//                 requerido: "El discriminador es requerido",
//             },
//         },
//         /*submitHandler: function(form) {
//             form.submit();
//         }*/
//     });

// });