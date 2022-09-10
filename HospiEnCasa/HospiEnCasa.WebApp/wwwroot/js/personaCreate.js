$().ready(function(){
    
    $("#form-estudio").validate({

        reglas : {
            nombre : {
                nivelEstudio: true,
                minlength: 7,
                maxlenght: 30,
            },
        },
        mensajes : {
            nombre: {
                requerido: "El nivel de estudio es requerido",
                minlength: "El nivel de estudio tener mínimo 7 caracteres",
                maxlength: "El  nivel de estudio debe tener máximo 30 caracteres",
            },
        }
    });

 });

// $(). ready(función() {

//     $(".FormModal"). on(enviar, función(e)){
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